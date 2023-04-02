//using Creative.Domain;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Options;

//public class CustomUserManager : UserManager<AppUserObj>
//{
//    public CustomUserManager(IUserStore<AppUserObj> store,
//                             IOptions<IdentityOptions> optionsAccessor,
//                             IPasswordHasher<AppUserObj> passwordHasher,
//                             IEnumerable<IUserValidator<AppUserObj>> userValidators,
//                             IEnumerable<IPasswordValidator<AppUserObj>> passwordValidators,
//                             ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors,
//                             IServiceProvider services, ILogger<UserManager<AppUserObj>> logger)
//        : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators,
//               keyNormalizer, errors, services, logger)
//    {
//    }

//    // Override the Register method
//    public override async Task<IdentityResult> CreateAsync(AppUserObj user, string password)
//    {
//        // Your custom registration logic here
//        return await base.CreateAsync(user, password);
//    }

//    // Override the Login method
//    public override async Task<AppUserObj> FindByEmailAsync(string email)
//    {
//        // Your custom login logic here
//        return await base.FindByEmailAsync(email);
//    }
//}

