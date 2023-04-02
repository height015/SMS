using System;
namespace Creative.Core.Events
{
	public class EntityDeletedEvent<T> where T : class
	{
		public EntityDeletedEvent(T entity)
		{
            Entity = entity;

        }

        public T Entity { get; }
    }
}

