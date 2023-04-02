using System;
namespace Creative.Core.Events
{
	public interface IConsumer<T>
	{
		Task HandleEventAsync(T eventMessage);
	}
}

