using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericMath.Calculators
{
	using numberType = System.Int64;
	public struct LongCalculator : INumberCalculator<numberType>
	{
		public numberType Sum(numberType a, numberType b) => a + b;
		public numberType Add(numberType a, numberType b) => a + b;
		public numberType Divide(numberType a, numberType b) => a / b;
		public numberType Multiply(numberType a, numberType b) => a * b;
		public numberType Subtract(numberType a, numberType b) => a - b;
		public numberType Power(numberType a, numberType b) => (numberType)Math.Pow(a, b);

		public numberType Sum(numberType a, double b) => (numberType)(a + b);
		public numberType Add(numberType a, double b) => (numberType)(a + b);
		public numberType Divide(numberType a, double b) => (numberType)(a / b);
		public numberType Multiply(numberType a, double b) => (numberType)(a * b);
		public numberType Subtract(numberType a, double b) => (numberType)(a - b);
		public numberType Power(numberType a, double b) => (numberType)Math.Pow(a, b);
	}
}
