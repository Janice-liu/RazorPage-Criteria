using System;
using Zebra;

namespace RazorPage
{
	using M = Money;
	using U = Currency;
	using S = String;

	public partial class Money : ISlip
	{
		public static M Empty => Of(0, U.NIL);
		public static M From(string xactAmt) => xactAmt.Over(at.Int64.Of).Over(Of);
		public static M Of(long xactAmt)
			=> xactAmt.To(x => Of(Math.Round(x / 100.0, 0) / 100.0D, (x % 100).Be<U>()));
		public static M Of(double amount, S currency) => Of(amount, currency.Be<U>());
		public static M Of(double amount, U currency) => new M(amount, currency);

		public Money() : this(0, U.NIL) { }
		private Money(double amount, U currency)
		{
			Amount = amount;
			Currency = currency;
		}

		public double Amount { get; }
		public U Currency { get; }

		public long ToXactAmt()
			=> Math.Sign(Amount) * (at.Fraction.Expand((decimal)Amount.Abs()) * 100 + Currency.ToByte());
		public string ToTvp() => ToXactAmt().ToString();
		public override string ToString() => ToTvp();
	}
}
