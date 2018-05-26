using System;
using Zebra;

namespace RazorPage
{
	using M = Length;
	using D = Decimal;
	public sealed class Length
	{
		private const D cm2Inch = 0.393701m;
		private const D cm2Foot = 0.0328084m;
		private const D cm2Meter = 0.01m;

		private const D inch2Cm = 2.54m;
		private const D foot2Cm = 30.48m;
		private const D meter2Cm = 100m;

		public static M Empty => Of(0, Units.Cm);
		public static M Of(int value, Units unit) => Of(Convert.ToDecimal(value), unit);
		public static M Of(double value, Units unit) => Of(Convert.ToDecimal(value), unit);
		public static M Of(D value, Units unit) => new M(value, unit);

		private Length(D value, Units unit)
		{
			if (value.IsFalsy()) value = 0;

			Unit = Units.Cm;
			switch (unit)
			{
				case Units.Inch:
					Value = value * inch2Cm;
					break;
				case Units.Feet:
					Value = value * foot2Cm;
					break;
				case Units.Meter:
					Value = value * meter2Cm;
					break;
				case Units.Cm:
				default:
					Value = value;
					break;
			}
		}

		public Units Unit { get; }
		public D Value { get; }
			   
		public D Cm() => Value;
		public D Inch() => Value * cm2Inch;
		public D Foot() => Value * cm2Foot;
		public D Meter() => Value * cm2Meter;
			   
		public D Cm(int decimals) => D.Round(Value, decimals);
		public D Inch(int decimals) => D.Round(Value * cm2Inch, decimals);
		public D Foot(int decimals) => D.Round(Value * cm2Foot, decimals);
		public D Meter(int decimals) => D.Round(Value * cm2Meter, decimals);

		public enum Units
		{
			nil = 0,
			Cm = 1,
			Meter = 2,
			Inch = 3,
			Feet = 4
		}
	}
}
