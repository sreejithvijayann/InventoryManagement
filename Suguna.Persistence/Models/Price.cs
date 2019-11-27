using System;

namespace Suguna.Persistence.Models
{
    public partial class Price
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public short ProductId { get; set; }
        public decimal Amount { get; set; }
        public bool CurrentPrice { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }

        public virtual Product Product { get; set; }
    }
}
