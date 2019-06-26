using Sumator.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator
{
	public static class AdderExtension
	{

		public static void SwitchOutput(this Adder adder)
		{
			adder.cOut = !adder.cOut;
		}
	}
}
