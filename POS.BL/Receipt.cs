using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public class Receipt : POSEntity
    {
        public override bool Validate()
        {
            return IsValid;
        }
    }
}
