
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator.Code
{
    class And : Gate
    {
        public override void GetOutput( )
        {
            this.output = this.input1 & this.input2;
        }
    }
}
