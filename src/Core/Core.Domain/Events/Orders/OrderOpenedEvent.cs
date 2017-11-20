using System;

namespace eCorp.KeyTrade.Core.Domain.Events.Orders
{
    public class OrderOpenedEvent : IEvent
    {
        public Guid Id { get; set; }
    }
}
