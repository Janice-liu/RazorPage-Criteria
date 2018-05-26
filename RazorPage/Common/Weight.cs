using System;
using Zebra;

namespace RazorPage
{
	using M = Weight;
	using D = Decimal;
	public sealed class Weight
	{
		private const D lb2G = 453.59237m;
		private const D kg2G = 1000m;
		private const D oz2G = 28.3495m;

		private const D g2Lb = 0.00220462m;
		private const D g2Kg = 0.001m;
		private const D g2Oz = 0.035274m;

		public static M Empty => Of(0, Units.G);
		public static M Of(int value, Units unit) => Of(Convert.ToDecimal(value), unit);
		public static M Of(double value, Units unit) => Of(Convert.ToDecimal(value), unit);
		public static M Of(D value, Units unit) => new M(value, unit);

		private Weight(D value, Units unit)
		{
			if (value.IsFalsy()) value = 0;

			Unit = Units.G;
			switch (unit)
			{
				case Units.Kg:
					Value = value * kg2G;
					break;
				case Units.Lb:
					Value = value * lb2G;
					break;
				case Units.Oz:
					Value = value * oz2G;
					break;
				case Units.G:
				default:
					Value = value;
					break;
			}
		}

		public D Value { get; }
		public Units Unit { get; }

		public D G() => Value;
		public D Kg() => Value * g2Kg;
		public D Lb() => Value * g2Lb;
		public D Oz() => Value * g2Oz;

		public D G(int decimals) => D.Round(Value, decimals);
		public D Kg(int decimals) => D.Round(Value * g2Kg, decimals);
		public D Lb(int decimals) => D.Round(Value * g2Lb, decimals);
		public D Oz(int decimals) => D.Round(Value * g2Oz, decimals);

		public enum Units
		{
			G = 0,
			Kg = 1,
			Lb = 2,
			Oz = 3
		}
	}
}