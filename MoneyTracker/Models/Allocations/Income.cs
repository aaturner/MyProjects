﻿using System.Collections.Generic;
using System.ComponentModel;

namespace MoneyTracker.Models.Allocations
{
    public class Income: Allocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Income()
        {
        }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }


        public int IncomeSourceId { get; set; }
        public virtual IncomeSource IncomeSource { get; set; }

    }
}