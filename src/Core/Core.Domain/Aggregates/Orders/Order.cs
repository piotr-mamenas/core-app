using eCorp.KeyTrade.Core.Domain.Interfaces;

namespace eCorp.KeyTrade.Core.Domain.Aggregates.Orders
{
    public class Order : Entity, IAggregateRoot
    {
        public OrderType Type { get; set; }
    }
}
