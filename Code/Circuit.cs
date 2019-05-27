using Sumator.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator.Code
{
	class Circuit
	{
		public string fullInputA { get; set; }
		public string fullInputB { get; set; }
		public List<Adder> adders { get; set; }
		public string result { get; set; }
		
		public Circuit(string inputA, string inputB)
		{
			adders = new List<Adder>();
			this.fullInputA = inputA;
			this.fullInputB = inputB;
		}

	}
}
