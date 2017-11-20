using eCorp.KeyTrade.Core.Domain.Interfaces;

namespace eCorp.KeyTrade.Core.Domain.Aggregates.Currencies
{
    public class Currency : Entity, IAggregateRoot
    {
        public string Code { get; set; }

        public string Description { get; set; }
    }
}
