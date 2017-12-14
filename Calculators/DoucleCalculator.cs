using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericMath.Calculators
{
	using numberType = System.Double;
	public struct DoubleCalculator : INumberCalculator<numberType>
	{
		public numberType Sum(numberType a, numberType b) => a + b;
		public numberType Add(numberType a, numberType b) => a + b;
		public numberType Divide(numberType a, numberType b) => a / b;
		public numberType Multiply(numberType a, numberType b) => a * b;
		public numberType Subtract(numberType a, numberType b) => a - b;
		public numberType Power(numberType a, numberType b) => (numberType)Math.Pow(a, b);
	}
}
