using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator.Code
{
    class XoR:Gate
    {
        public override void GetOutput()
        {
            output = this.input1 ^ this.input2;
        }
    }
}
