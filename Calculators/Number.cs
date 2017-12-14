namespace GenericMath.Calculators
{
	public struct Number<T, C>
		where T : new()
		where C : INumberCalculator<T>, new()
	{
		private T value;
		private static C calculator = new C(); // struct is 0 size. No overhead for a new.
		public Number(T value)
		{
			this.value = value;
		}

		public static implicit operator Number<T, C>(T a) => new Number<T, C>(a);
		public static implicit operator T(Number<T, C> a) => a.value;

		public static Number<T, C> operator +(Number<T, C> a, Number<T, C> b) => calculator.Add(a.value, b.value);
		public static Number<T, C> operator -(Number<T, C> a, Number<T, C> b) => calculator.Subtract(a.value, b.value);
		public static Number<T, C> operator *(Number<T, C> a, Number<T, C> b) => calculator.Multiply(a.value, b.value);
		public static Number<T, C> operator /(Number<T, C> a, Number<T, C> b) => calculator.Divide(a.value, b.value);
		public static Number<T, C> operator ^(Number<T, C> a, Number<T, C> b) => calculator.Power(a.value, b.value);

		public static Number<T, C> operator +(Number<T, C> a, double b) => calculator.Add(a.value, b);
		public static Number<T, C> operator -(Number<T, C> a, double b) => calculator.Subtract(a.value, b);
		public static Number<T, C> operator *(Number<T, C> a, double b) => calculator.Multiply(a.value, b);
		public static Number<T, C> operator /(Number<T, C> a, double b) => calculator.Divide(a.value, b);
		public static Number<T, C> operator ^(Number<T, C> a, double b) => calculator.Power(a.value, b);
	}
}
