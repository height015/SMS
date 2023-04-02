using System;
namespace Creative.Core.Events
{
	public static class EventPublisherExtensions
	{
        public static void EntityInserted<T>(this IEventPublisher eventPublisher, T entity) where T : class
        {
            eventPublisher.PublishAsync(new EntityInsertedEvent<T>(entity));
        }

        public static void EntityUpdated<T>(this IEventPublisher eventPublisher, T entity) where T : class
        {
            eventPublisher.PublishAsync(new EntityUpdatedEvent<T>(entity));
        }

        public static void EntityDeleted<T>(this IEventPublisher eventPublisher, T entity) where T : class
        {
            eventPublisher.PublishAsync(new EntityDeletedEvent<T>(entity));
        }
    }
}

