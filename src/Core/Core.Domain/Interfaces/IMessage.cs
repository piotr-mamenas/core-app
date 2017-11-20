using System;

namespace eCorp.KeyTrade.Core.Domain.Interfaces
{
    public interface IMessage
    {
        Guid Id { get; set; }
    }
}