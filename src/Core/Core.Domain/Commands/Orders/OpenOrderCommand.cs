using System;

namespace eCorp.KeyTrade.Core.Domain.Commands.Orders
{
    public class OpenOrderCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
