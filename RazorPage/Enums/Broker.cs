using System;
using System.ComponentModel;
using System.Reflection;
using Zebra;

namespace RazorPage
{
	public enum Broker
	{
		[Description("")]
		Nil = 0,
		[Description("跨境易")]
		KuaJingYi = 7001,
		[Description("新境界")]
		NewRealm = 7002,
		[Description("EMS-C")]
		EMS_C = 7003,
		USPS = 7004,
		[Description("威时沛运")]
		WTD = 7005,
		[Description("百通")]
		Buytong = 7006,
		[Description("AAE全球速递香港分公司")]
		AAE_HK = 7007,
		[Description("聨締國際有限公司")]
		TW = 7008,
		[Description("汇富通")]
		HuiFuTong = 7009,
		[Description("鸿丰")]
		HongFeng_TAO = 7010,
		[Description("海谷")]
		HaiGu = 7011,
		[Description("宏丰")]
		HongFeng_PVG = 7012,
		[Description("易云仓")]
		YiyunCang = 7013,
		[Description("LineHaul")]
		LineHaul = 7014,
		[Description("COE")]
		COE = 7015,
		[Description("Aircity")]
		Aircity = 7016,
		[Description("Micom")]
		Micom = 7017,
		[Description("GTS")]
		GTS = 7018,
	}

	partial class extRazorPage
    {
		public static string EnumName<TEnum>(this int me) where TEnum : struct
			=> me == 0 ? string.Empty : Enum.GetName(typeof(TEnum), me).FallbackOnVacant(me.ToString());
		public static string EnumAlias<TEnum>(this int me) where TEnum : struct
		{
			if (me == 0) return string.Empty;
			var name = me.EnumName<TEnum>();
			FieldInfo fi = typeof(TEnum).GetField(name);

			DescriptionAttribute[] attributes = (DescriptionAttribute[])
				fi?.GetCustomAttributes(typeof(DescriptionAttribute), false);

			return (attributes != null && attributes.Length > 0)
					? attributes[0].Description : name;
		}
	}
}
