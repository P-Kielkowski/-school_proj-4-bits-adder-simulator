using Sumator.Builders;
using Sumator.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SumatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
			Regex regex = new Regex( "^([0-1]){4}$" );

			

			Console.WriteLine( "Set four-bits binary number adder inputs eg. 1011" );
			//initialize input 1 
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine( "Input a: ");
			string res1;  

			while ( !regex.IsMatch( res1 = Console.ReadLine()) )
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine( "bad input. Please set four-bits binary number adder inputs eg. 1011 " );
				Console.ForegroundColor = ConsoleColor.DarkBlue;
			}
			Console.WriteLine();

			//initialize input 2
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine( "Input b: " );
			string res2;

			while ( !regex.IsMatch( res2 = Console.ReadLine() ) )
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine( "bad input. Please set four-bits binary number adder inputs eg. 1011 " );
				Console.ForegroundColor = ConsoleColor.DarkMagenta;
			}

			Console.WriteLine();

			//creat delegate to invoke proper methods on adderBuilder
			Action<AdderBuilder> adderBuilder = x => x.InitializeGates()
				.CountGates().SetOutputs();

			//initialize CircuitBuilder
			var circuitBuilder = new CircuitBuilder(res1,res2);

			Circuit circuit = circuitBuilder
				.AddAdder( adderBuilder )
				.AddAdder( adderBuilder )
				.AddAdder( adderBuilder )
				.AddAdder( adderBuilder )
				.SetResult()
				.Build();

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("wynik to : " + circuit.result );

			Console.ReadKey();
        }
    }
}
