using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using Zebra;

namespace at.SvcTypes
{
	using E = RazorPage.SvcType;

	public static class BC
	{
		public static IEnumerable<E> ForLookup()
		{
			yield return E.BC_T;
			yield return E.BT_eFO;
			yield return E.VMI_BC_T;
			yield return E.VMI_BC_T_Legacy;
			yield return E.CD_BC_T;
		}
	}

	public static class CC
	{
		public static IEnumerable<E> ForLookup()
		{
			yield return E.CC_DDP;
			yield return E.CC_DDP_CAINIAO;
			yield return E.VMI_CC_DDP_W_Legacy;
			yield return E.CC_DDP_W;
			yield return E.CC_DDP_Y;
			yield return E.VMI_CC_DDP_Y_Legacy;
			yield return E.eExpress_DDP_G;
			yield return E.eExpress_DDP_GHK;
			yield return E.AAE_Business;
			yield return E.AAE_CC_DDP;
			yield return E.AAE_CC_DDP_PIX;
			yield return E.AAE_EMS;
			yield return E.AAE_EMS_LUX;
			yield return E.AAE_HK;
			yield return E.AAE_TW;
			yield return E.AAE_USPS_PMEI;
			yield return E.AAE_USPS_PMI;
			yield return E.HK_AAE;
			yield return E.eExpress_CN;
			yield return E.eExpress_DDP;
			yield return E.eExpress;
			yield return E.HK_Post_COE;
			yield return E.HKPost_COE_DDP;
			yield return E.HK_Post_eExpress;
			yield return E.HK_SF;
			yield return E.TW;
			yield return E.USPS_PMEI;
			yield return E.USPS_PMI;
			yield return E.XPD_CFS;
			yield return E.XPD_ECCF;
			yield return E.ZEB_CC_DDP;
			//yield return E.FEDEX_SP;
			yield return E.BT_eFO;
			yield return E.CD_HK;
			yield return E.eFO_CD_TMall;
			yield return E.eFO_CD_USPS;
			yield return E.Commercial_PVG;
			yield return E.Commercial_TAO;
			yield return E.eExpress_DDP_BT;
			yield return E.eExpress_DDU_BT;
			yield return E.EMS;
		}

		public static IEnumerable<E> CCGTS()
		{
			yield return E.eExpress_DDP_G;
			yield return E.eExpress_DDP_GHK;
		}
	}

	public static class Usd
	{
		public static IEnumerable<E> ForLookup()
		{
			yield return E.FEDEX_SP;
		}
	}
}

namespace RazorPage
{
	using E = SvcType;
	public enum SvcType
	{
		Nil = 0,

		[LabelCode("FEx")]
		[Description("FedEx-SP")]
		FEDEX_SP = 2010,

		[Description("ZEB CC-DDP")]
		ZEB_CC_DDP = 2810,

		[LabelCode("CC")]
		[Description("AMZ-CC-DDP-SKU")]
		AMZ_CC_DDP_SKU = 3801,

		[LabelCode("BC")]
		[Description("AMZ-BC-T")]
		AMZ_BC_T = 4801,

		[LabelCode("BC")]
		[Description("AMZ-BC-T-W")]
		AMZ_BC_T_W = 4802,

		[LabelCode("BC")]
		[Description("BC-T")]
		BC_T = 4806,

		[LabelCode("BC")]
		[Description("eFO-BC-T")]
		BT_eFO = 4811,

		[LabelCode("BC")]
		[Description("VMI-BC-T-Legacy")]
		VMI_BC_T_Legacy = 4812,

		[LabelCode("CC")]
		[Description("AMZ-CC-DDP")]
		AMZ_CC_DDP = 5801,

		[LabelCode("CC")]
		[Description("AMZ-CC-DDP-K")]
		AMZ_CC_DDP_K = 5802,

		[LabelCode("CC")]
		[Description("AMZ-CC-DDP-Y")]
		AMZ_CC_DDP_Y = 5803,

		[LabelCode("CC")]
		[Description("AMZ-CC-DDP-W")]
		AMZ_CC_DDP_W = 5804,

		[LabelCode("CC")]
		[Description("CC-DDP-CAINIAO")]
		CC_DDP_CAINIAO = 5805,

		[LabelCode("CC")]
		[Description("CC-DDP-Y")]
		CC_DDP_Y = 5806,

		[LabelCode("CC")]
		[Description("CC-DDP")]
		CC_DDP = 5807,

		[LabelCode("CC")]
		[Description("AAE-CC-DDP")]
		AAE_CC_DDP = 5809,

		[LabelCode("CC")]
		[Description("AAE-CC-DDP-PIX")]
		AAE_CC_DDP_PIX = 5810,

		[LabelCode("ETK")]
		[Description("AMZ-eExpress-DDP-BT")]
		AMZ_eExpress_DDP_BT = 5811,

		[LabelCode("ETK")]
		[Description("eExpress-DDP-BT")]
		eExpress_DDP_BT = 5812,

		[LabelCode("CC")]
		[Description("CC-DDP-W")]
		CC_DDP_W = 5813,

		[LabelCode("CC")]
		[Description("VMI-CC-DDP-Y-Legacy")]
		VMI_CC_DDP_Y_Legacy = 5853,

		[LabelCode("CC")]
		[Description("VMI-CC-DDP-W-Legacy")]
		VMI_CC_DDP_W_Legacy = 5854,

		[Description("VMI-CC-DDP-Y")]
		VMI_CC_DDP_Y = 5855,

		[Description("VMI-CC-DDP-W")]
		VMI_CC_DDP_W = 5856,

		[Description("VMI-ClientPickup")]
		VMI_ClientPickup = 5863,

		[LabelCode("BC")]
		[Description("VMI-BC-T")]
		VMI_BC_T = 5864,

		[LabelCode("ETK")]
		[Description("VMI-eExpress-DDP-BT")]
		VMI_eExpress_DDP_BT = 5865,

		[LabelCode("ETK")]
		[Description("VMI-eExpress-DDU-BT")]
		VMI_eExpress_DDU_BT = 5866,

		[LabelCode("ETK")]
		[Description("VMI-eExpress-DDP-GHK")]
		VMI_eExpress_DDP_GHK = 5867,

		[LabelCode("ETK")]
		[Description("VMI-eExpress-DDP-G")]
		VMI_eExpress_DDP_G = 5868,

		[LabelCode("ETK")]
		[Description("VMI-eExpress-DDP-LH")]
		VMI_eExpress_DDP_LH = 5869,

		[LabelCode("ETK")]
		[Description("VMI-eExpress-DDU-LH")]
		VMI_eExpress_DDU_LH = 5870,

		[LabelCode("ETK")]
		[Description("AMZ-eExpress-DDU-BT")]
		AMZ_eExpress_DDU_BT = 5911,

		[LabelCode("ETK")]
		[Description("eExpress-DDU-BT")]
		eExpress_DDU_BT = 5912,

		[LabelCode("EMS")]
		[Description("EMS")]
		EMS = 6801,

		[LabelCode("EMS")]
		[Description("AAE-EMS")]
		AAE_EMS = 6802,

		[LabelCode("EMS")]
		[Description("AAE-EMS-LUX")]
		AAE_EMS_LUX = 6803,

		[LabelCode("PMI")]
		[Description("AAE-USPS-PMI")]
		AAE_USPS_PMI = 7801,

		[LabelCode("PMEI")]
		[Description("AAE-USPS-PMEI")]
		AAE_USPS_PMEI = 7802,

		[LabelCode("PMI")]
		[Description("USPS-PMI")]
		USPS_PMI = 7803,

		[LabelCode("PMEI")]
		[Description("USPS-PMEI")]
		USPS_PMEI = 7804,

		[LabelCode("HK")]
		[Description("AMZ-HK-AAE")]
		AMZ_HK_AAE = 7805,

		[LabelCode("TW")]
		[Description("AMZ-TW")]
		AMZ_TW = 7806,

		[LabelCode("COM")]
		[Description("Commercial-TAO")]
		Commercial_TAO = 7807,

		[LabelCode("COM")]
		[Description("Commercial-PVG")]
		Commercial_PVG = 7808,

		[LabelCode("HK")]
		[Description("HK-AAE")]
		HK_AAE = 7809,

		[LabelCode("TW")]
		[Description("TW")]
		TW = 7810,

		[LabelCode("HK")]
		[Description("AAE-HK")]
		AAE_HK = 7811,

		[LabelCode("TW")]
		[Description("AAE-TW")]
		AAE_TW = 7812,

		[LabelCode("COM")]
		[Description("AAE-Business")]
		AAE_Business = 7813,

		[LabelCode("PMI")]
		[Description("AMZ-USPS-PMI")]
		AMZ_USPS_PMI = 7814,

		[LabelCode("PMEI")]
		[Description("AMZ-USPS-PMEI")]
		AMZ_USPS_PMEI = 7815,

		[LabelCode("ETK")]
		[Description("eExpress-CN")]
		eExpress_CN = 7821,

		[LabelCode("ETK")]
		[Description("eExpress-NCN")]
		HK_Post_eExpress = 7822,

		[LabelCode("ETK")]
		[Description("eExpress")]
		eExpress = 7823,

		[LabelCode("HKP")]
		[Description("HKPost-COE")]
		HK_Post_COE = 7824,

		[LabelCode("HKS")]
		[Description("AMZ-HK-SF")]
		AMZ_HK_SF = 7825,

		[LabelCode("HKS")]
		[Description("HK-SF")]
		HK_SF = 7826,

		[LabelCode("HKP")]
		[Description("HKPost-COE-DDP")]
		HKPost_COE_DDP = 7827,

		[LabelCode("ETK")]
		[Description("eExpress-DDP")]
		eExpress_DDP = 7828,

		[LabelCode("ETK")]
		[Description("eExpress-DDP-G")]
		eExpress_DDP_G = 7833,

		[LabelCode("ETK")]
		[Description("AMZ-eExpress-DDP-G")]
		AMZ_eExpress_DDP_G = 7834,

		[LabelCode("ETK")]
		[Description("eExpress-DDP-GHK")]
		eExpress_DDP_GHK = 7835,

		[LabelCode("EFU")]
		[Description("eFO-CD-USPS")]
		eFO_CD_USPS = 8001,

		[LabelCode("EFT")]
		[Description("eFO-CD-TMall")]
		eFO_CD_TMall = 8010,

		[LabelCode("HK")]
		[Description("CD-HK")]
		CD_HK = 8021,

		[LabelCode("BC")]
		[Description("CD-BC-T")]
		CD_BC_T = 8801,

		[LabelCode("CFS")]
		[Description("XPD-CFS")]
		XPD_CFS = 9001,

		[LabelCode("ECCF")]
		[Description("XPD-ECCF")]
		XPD_ECCF = 9011,

	}

	partial class extRazorPage
    {
		public static bool IsBC(this E me) => SvcTypes.BCTypes().Contains(me);
		public static bool IsCC(this E me) => SvcTypes.CCTypes().Contains(me);

		public static string ToDescription(this Enum value)
		{
			var info = value.GetType().GetField(value.ToString());
			if (info.IsFalsy()) return string.Empty;
			var attributes = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);

			if (attributes != null && attributes.Length > 0)
				return attributes[0].Description;
			else
				return value.ToString();
		}
	}

	public class SvcTypes
	{
		//public static SvcType Of(int rawSvcType) => (SvcType)((rawSvcType / 10000).Fallback(rawSvcType));
		private readonly E _svcType;
		private SvcTypes(int rawSvcType)
		{
			_svcType = (E)((rawSvcType / 10000).Fallback(rawSvcType));
		}
		public static implicit operator E(SvcTypes svcTypes) => svcTypes._svcType;
		public static explicit operator SvcTypes(int rawSvcType) => Of(rawSvcType);
		public static SvcTypes Of(int rawSvcType) => new SvcTypes(rawSvcType);
		public override string ToString() => _svcType.ToString();
		public override bool Equals(object obj) => _svcType.Equals(obj);
		public override int GetHashCode() => _svcType.GetHashCode();

		public static IEnumerable<E> CCTypes()
		{
			yield return E.FEDEX_SP;
			yield return E.AMZ_CC_DDP;
			yield return E.AMZ_CC_DDP_K;
			yield return E.AMZ_CC_DDP_Y;
			yield return E.AMZ_CC_DDP_W;
			yield return E.CC_DDP_CAINIAO;
			yield return E.CC_DDP_Y;
			yield return E.CC_DDP;
			yield return E.AAE_CC_DDP;
			yield return E.AAE_CC_DDP_PIX;
			yield return E.AMZ_eExpress_DDP_BT;
			yield return E.eExpress_DDP_BT;
			yield return E.VMI_CC_DDP_Y_Legacy;
			yield return E.VMI_CC_DDP_W_Legacy;
			yield return E.AMZ_eExpress_DDU_BT;
			yield return E.eExpress_DDU_BT;
			yield return E.EMS;
			yield return E.AAE_EMS;
			yield return E.AAE_EMS_LUX;
			yield return E.AAE_USPS_PMI;
			yield return E.AAE_USPS_PMEI;
			yield return E.USPS_PMI;
			yield return E.USPS_PMEI;
			yield return E.AMZ_HK_AAE;
			yield return E.AMZ_TW;
			yield return E.Commercial_TAO;
			yield return E.Commercial_PVG;
			yield return E.HK_AAE;
			yield return E.TW;
			yield return E.AAE_HK;
			yield return E.AAE_TW;
			yield return E.AAE_Business;
			yield return E.AMZ_USPS_PMI;
			yield return E.AMZ_USPS_PMEI;
			yield return E.AAE_Business;
			yield return E.eExpress_CN;
			yield return E.eExpress_DDP;
			yield return E.HK_Post_eExpress;
			yield return E.eExpress;
			yield return E.HK_Post_COE;
			yield return E.HKPost_COE_DDP;
			yield return E.AMZ_HK_SF;
			yield return E.HK_SF;
			yield return E.eFO_CD_USPS;
			yield return E.eFO_CD_TMall;
			yield return E.CD_HK;
			yield return E.AMZ_eExpress_DDP_G;
			yield return E.eExpress_DDP_G;
			yield return E.eExpress_DDP_GHK;
			yield return E.VMI_eExpress_DDP_BT;
			yield return E.VMI_eExpress_DDU_BT;
			yield return E.VMI_eExpress_DDP_GHK;
			yield return E.VMI_eExpress_DDP_G;
			yield return E.VMI_eExpress_DDP_LH;
			yield return E.VMI_eExpress_DDU_LH;
		}
		public static IEnumerable<E> BCTypes()
		{
			yield return E.AMZ_CC_DDP_SKU;
			yield return E.AMZ_BC_T;
			yield return E.AMZ_BC_T_W;
			yield return E.BC_T;
			yield return E.BT_eFO;
			yield return E.VMI_BC_T;
			yield return E.VMI_BC_T_Legacy;
		}
	}
}
