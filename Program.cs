using GenericMath.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMath
{
	class Program
	{
		static void Main(string[] args)
		{
			IntLengthConverter.ConvertType(1, 1);

			FloatLengthConverter.ConvertType(1, 1);
			FloatLengthConverter.ConvertType(1.1f, 1.1f);

			DoubleLengthConverter.ConvertType(1, 1);
			DoubleLengthConverter.ConvertType(1.1f, 1.1f);
			DoubleLengthConverter.ConvertType(1.1d, 1.1d);
		}
	}


	class FloatLengthConverter : DensityGeneric<float, FloatCalculator> { }
	class DoubleLengthConverter : DensityGeneric<double, DoubleCalculator> { }
	class IntLengthConverter : DensityGeneric<decimal, DecimalCalculator> { }

	class DensityGeneric<T, C>
		where T : new()
		where C : INumberCalculator<T>, new()
	{
		public static void WriteType(T t)
		{
			Console.WriteLine(typeof(T));
		}

		public static T ConvertType(Number<T, C> one, Number<T, C> two)
		{
			Console.WriteLine(one + two);
			return (one + two) / 1e-2d;
		}
	}
}
