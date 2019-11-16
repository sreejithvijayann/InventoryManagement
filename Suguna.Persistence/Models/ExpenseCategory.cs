using System;
using System.Collections.Generic;

namespace Suguna.Persistence.Models
{
    public partial class ExpenseCategory
    {
        public ExpenseCategory()
        {
            Expense = new HashSet<Expense>();
        }

        public short Id { get; set; }
        public Guid Guid { get; set; }
        public string Type { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }

        public virtual ICollection<Expense> Expense { get; set; }
    }
}
