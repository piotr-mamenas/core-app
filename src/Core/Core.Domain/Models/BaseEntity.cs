using System;

namespace eCorp.KeyTrade.Core.Domain.Models
{
    public class BaseEntity
    {
        public Guid Guid { get; set; }

        public DateTime CreatedTimestamp { get; set; }

        public DateTime ModifiedTimestamp { get; set; }

        public bool IsDeleted { get; set; }
    }
}
