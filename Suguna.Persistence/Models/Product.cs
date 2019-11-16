using System;
using System.Collections.Generic;

namespace Suguna.Persistence.Models
{
    public partial class Product
    {
        public Product()
        {
            Price = new HashSet<Price>();
            Sale = new HashSet<Sale>();
        }

        public short Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }

        public virtual ICollection<Price> Price { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
