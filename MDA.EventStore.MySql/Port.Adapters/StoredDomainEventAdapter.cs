﻿using MDA.Event.Abstractions;

namespace MDA.EventStore.MySql.Port.Adapters
{
    public class StoredDomainEventAdapter
    {
        public static StoredDomainEvent ToStoredDomainEvent(
            IDomainEvent domainEvent,
            IEventSerializer serializer)
        {
            return new StoredDomainEvent()
            {
                EventId = domainEvent.Id,
                EventBody = serializer.Serialize(domainEvent),
                EventSequence = domainEvent.Sequence,
                AggregateRootId = domainEvent.AggregateRootId,
                AggregateRootTypeName = domainEvent.AggregateRootTypeName,
                CommandId = domainEvent.CommandId,
                OccurredOn = domainEvent.Timestamp
            };
        }
    }
}
