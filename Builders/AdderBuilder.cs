using Sumator.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator.Builders
{
	class AdderBuilder
	{
		private Adder adder;

		public AdderBuilder(bool a, bool b, bool cin)
		{
			this.adder = new Adder( a, b, cin );
		}

		public AdderBuilder CountGates()
		{
			//count AND Gates outputs
			this.adder.AdderGates[ (int)Gates.And1 ].GetOutput();
			this.adder.AdderGates[ (int)Gates.And2 ].GetOutput();
			this.adder.AdderGates[ (int)Gates.And3 ].GetOutput();

			//fill Or1 gate fields
			this.adder.AdderGates.Add( new Or
			{
				input1 = this.adder.AdderGates[ (int)Gates.And1 ].output,
				input2 = this.adder.AdderGates[ (int)Gates.And2 ].output,
				input3 = this.adder.AdderGates[ (int)Gates.And3 ].output
			} );
			//count Or1 Gate ouptut
			this.adder.AdderGates[ (int)Gates.Or1 ].GetOutput();

			//count XOr1 Gate ouptut
			this.adder.AdderGates[ (int)Gates.XoR1 ].GetOutput();

			//fill XOr2 gate fields
			this.adder.AdderGates[ (int)Gates.XoR2 ].input2 = this.adder.AdderGates[ (int)Gates.XoR1 ].output;
			//count XOr2 Gate ouptut
			this.adder.AdderGates[ (int)Gates.XoR2 ].GetOutput();

			return this;
		}

		public AdderBuilder InitializeGates()
		{	
			//initialize gates as on topology 1 
			this.adder.AdderGates = new List<Gate>();

			this.adder.AdderGates.Add( new XoR { input1 = this.adder.cIn, input2 = this.adder.b } );
			this.adder.AdderGates.Add( new XoR { input1 = this.adder.a } );
			this.adder.AdderGates.Add( new And { input1 = this.adder.a, input2 = this.adder.b } );
			this.adder.AdderGates.Add( new And { input1 = this.adder.b, input2 = this.adder.cIn } );
			this.adder.AdderGates.Add( new And { input1 = this.adder.a, input2 = this.adder.cIn } );
	
			return this;
		}

		public AdderBuilder SetOutputs()
		{
			this.adder.si = this.adder.AdderGates[ (int)Gates.XoR2 ].output;
			this.adder.cOut = this.adder.AdderGates[ (int)Gates.Or1 ].output;

			return this;
		}

		public Adder Build()
		{
			return this.adder;
		}
	}
}
