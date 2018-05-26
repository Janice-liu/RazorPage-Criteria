using System;

namespace RazorPage
{
	using M = Dimension;
	using L = Length;
	public class Dimension
	{
		public static M Of(float length, float width, float height, L.Units unit)
			=> Of(Convert.ToDecimal(length), Convert.ToDecimal(width), Convert.ToDecimal(height), unit);
		public static M Of(decimal length, decimal width, decimal height, L.Units unit)
			=> new M(length, width, height, unit);

		private Dimension(decimal length, decimal width, decimal height, L.Units unit)
		{
			Unit = unit;
			Length = L.Of(length, unit);
			Width = L.Of(width, unit);
			Height = L.Of(height, unit);
		}

		public L Length { get; }
		public L Width { get; }
		public L Height { get; }
		public L.Units Unit { get; }
	}
}