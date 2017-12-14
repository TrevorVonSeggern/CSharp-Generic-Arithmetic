using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMath.Calculators
{
	public interface INumberCalculator<T>
	{
		T Sum(T a, T b);
		T Add(T a, T b);
		T Divide(T a, T b);
		T Multiply(T a, T b);
		T Subtract(T a, T b);
		T Power(T a, T b);

		T Sum(T a, double b);
		T Add(T a, double b);
		T Divide(T a, double b);
		T Multiply(T a, double b);
		T Subtract(T a, double b);
		T Power(T a, double b);
	}
}
