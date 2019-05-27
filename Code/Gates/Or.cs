using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator.Code
{
   public class Or : Gate
    {
        public bool input3 { get; set; }

        public override void GetOutput()
        {
            output = (this.input1 | this.input2 | this.input3);

        }
    }
}
