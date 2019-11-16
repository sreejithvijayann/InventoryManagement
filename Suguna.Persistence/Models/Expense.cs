using System;
using System.Collections.Generic;

namespace Suguna.Persistence.Models
{
    public partial class Expense
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public short Type { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }

        public virtual ExpenseCategory TypeNavigation { get; set; }
    }
}
