using System;
using Zebra;

namespace RazorPage
{
	partial class extRazorPage
	{
		public static TEnum BeEnum<TEnum>(this string me) where TEnum : struct
		{
			Enum.TryParse(me.Ensure(), true, out TEnum units);
			return units;
		}
	}
}