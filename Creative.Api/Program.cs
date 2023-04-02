using System.Collections.Generic;
using System.Reflection;
using Creative.Core.Events;
using Creative.Domain.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnections"));
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IEventPublisher, EventPublisher>();


//var consumerTypes = Assembly.GetExecutingAssembly().GetTypes()
//    .Where(t => !t.IsAbstract && t.GetInterfaces()
//        .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IConsumer<>)))
//    .ToList();

//foreach (var consumerType in consumerTypes)
//{
//    var interfaces = consumerType.GetInterfaces()
//        .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IConsumer<>));

//    foreach (var @interface in interfaces)
//    {
//        builder.Services.AddTransient(@interface, consumerType);
//    }
//}



var types = Assembly.GetExecutingAssembly().GetTypes();
var consumerTypes = new HashSet<Type>();

foreach (var type in types)
{
    if (type.IsClass && !type.IsAbstract)
    {
        var interfaces = type.GetInterfaces();
        var consumerInterface = interfaces.FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IConsumer<>));
        if (consumerInterface != null)
        {
            var eventType = consumerInterface.GetGenericArguments()[0];
            var handleEventMethod = consumerInterface.GetMethod("HandleEventAsync");
            var methodDelegate = Delegate.CreateDelegate(typeof(Func<,>).MakeGenericType(eventType, typeof(Task)), null, handleEventMethod);

            // Only register the consumer if it hasn't been registered before
            if (consumerTypes.Add(type))
            {
                builder.Services.AddTransient(type);
                builder.Services.AddSingleton(typeof(Func<,>).MakeGenericType(eventType, typeof(Task)), methodDelegate);
            }
        }
    }
}



//builder.Services.AddHttpClient<>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

