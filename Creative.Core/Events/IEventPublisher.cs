using System;
namespace Creative.Core.Events
{
	public interface IEventPublisher
	{
		Task PublishAsync<T>(T eventMessage);
	}
}

