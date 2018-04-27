using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public abstract class POSEntity
    {
        [NotMapped]
        public bool IsValid { get; set; }
        [NotMapped]
        public bool IsNew { get; set; }
        [NotMapped]
        public bool IsChanged { get; set; }

        public abstract bool Validate();
    }
}
