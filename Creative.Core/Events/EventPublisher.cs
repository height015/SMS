using System;

namespace Creative.Core.Events
{
	public class EventPublisher : IEventPublisher
	{
		private readonly IEnumerable<IConsumer<object>> _subscribers;

		public EventPublisher(IEnumerable<IConsumer<object>> subscribers)
		{
			_subscribers = subscribers;

        }

        public async Task PublishAsync<T>(T eventMessage)
        {
			foreach (var subscriber in _subscribers.OfType<IConsumer<T>>())
			{
				await subscriber.HandleEventAsync(eventMessage);

            }
        }
    }
}

