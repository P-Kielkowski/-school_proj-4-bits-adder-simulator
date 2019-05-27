using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator.Code
{
    public abstract class Gate
    {
        public bool input1 { get; set; }
        public bool input2 { get; set; }
        public bool output { get; set; }

        public abstract void GetOutput();

    }
}
