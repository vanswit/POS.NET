using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public abstract class POSEntity
    {
        public bool IsValid { get; set; }
        public bool IsNew { get; set; }
        public bool IsChanged { get; set; }

        public abstract bool Validate();
    }
}
