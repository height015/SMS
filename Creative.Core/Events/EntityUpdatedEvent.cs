﻿using System;
namespace Creative.Core.Events
{
	public class EntityUpdatedEvent<T> where T : class
	{
		public EntityUpdatedEvent(T entity)
		{
			Entity = entity;

        }

		public T Entity { get; }
	}
}

