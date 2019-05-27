using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator.Code
{
    public class Adder
    {
		public bool a { get; set; }
		public bool b { get; set; }
		public bool cIn { get; set; }
		public bool si { get; set; }
		public bool cOut { get; set; }

		public List<Gate> AdderGates { get; set; }

		public Adder( bool a, bool b, bool cin)
        {
            this.a = a;
            this.b = b;
            this.cIn = cin;
        }

	}
}
