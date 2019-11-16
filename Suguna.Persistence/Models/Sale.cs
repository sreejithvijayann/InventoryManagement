using System;
using System.Collections.Generic;

namespace Suguna.Persistence.Models
{
    public partial class Sale
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public short? Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }

        public virtual Product ProductNavigation { get; set; }
    }
}
