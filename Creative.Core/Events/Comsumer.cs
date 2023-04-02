using System;

namespace Creative.Core.Events;

	public class Comsumer<T> : IConsumer<T>
	{
    private readonly Func<T, Task> _handler;

		public Comsumer(Func<T, Task> handler)
		{
        _handler = handler;

    }

    public async  Task HandleEventAsync(T eventMessage)
    {
        await _handler(eventMessage);
    }
}

