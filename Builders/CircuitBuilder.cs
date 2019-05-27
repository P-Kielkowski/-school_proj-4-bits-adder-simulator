using Sumator.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator.Builders
{
	class CircuitBuilder
	{
		private Circuit circuit;

		public CircuitBuilder(string inputA, string inputB)
		{
			circuit = new Circuit(inputA, inputB);
		}

		public CircuitBuilder AddAdder( Action<AdderBuilder> builder )
		{
			int inputLength = this.circuit.fullInputA.Length;
			int addersLength = this.circuit.adders.Count;

			bool inpA = circuit.fullInputA[ inputLength - ( 1 + addersLength ) ] == '1' ? true : false;
			bool inpB = circuit.fullInputB[ inputLength - ( 1 + addersLength ) ] == '1' ? true : false;
			bool cin = addersLength != 0 ? circuit.adders[ addersLength - 1 ].cOut : false;
	
			var adderBuilder = new AdderBuilder( inpA, inpB, cin );
			builder( adderBuilder );
			this.circuit.adders.Add( adderBuilder.Build() );

			return this;
		}

		public CircuitBuilder SetResult()
		{
			for ( int i = 0; i < this.circuit.adders.Count; i++ )
			{
				circuit.result = this.circuit.adders[ i ].si.ToBinString() + this.circuit.result;
			}

			if ( this.circuit.adders[ 3 ].cOut == true )
				this.circuit.result = "1" + this.circuit.result;

			return this;
		}

		public Circuit Build()
		{
			return circuit;
		}

	}
}
