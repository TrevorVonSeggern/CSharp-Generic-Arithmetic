using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericMath.Calculators
{
	using numberType = System.Decimal;
	public struct DecimalCalculator : INumberCalculator<numberType>
	{
		public numberType Sum(numberType a, numberType b) => a + b;
		public numberType Add(numberType a, numberType b) => a + b;
		public numberType Divide(numberType a, numberType b) => a / b;
		public numberType Multiply(numberType a, numberType b) => a * b;
		public numberType Subtract(numberType a, numberType b) => a - b;
		public numberType Power(numberType a, numberType b) => (numberType)Math.Pow(numberType.ToDouble(a), numberType.ToDouble(b));

		public numberType Sum(numberType a, double b) => (a + (numberType)(b));
		public numberType Add(numberType a, double b) => (a + new numberType(b));
		public numberType Divide(numberType a, double b) => (a / new numberType(b));
		public numberType Multiply(numberType a, double b) => (a * new numberType(b));
		public numberType Subtract(numberType a, double b) => (a - new numberType(b));
		public numberType Power(numberType a, double b) => (numberType)Math.Pow(numberType.ToDouble(a), b);
	}
}
