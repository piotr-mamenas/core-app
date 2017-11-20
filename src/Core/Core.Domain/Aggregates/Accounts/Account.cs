using eCorp.KeyTrade.Core.Domain.Interfaces;

namespace eCorp.KeyTrade.Core.Domain.Aggregates.Accounts
{
    public class Account : Entity, IAggregateRoot
    {
        public string Number { get; set; }

        public string Description { get; set; }
    }
}
