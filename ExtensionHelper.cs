using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator
{
	public static class ExtensionHelper
	{
		public static string ToBinString(this bool value)
		{
			return value ? "1" : "0";
		}
	}
}
