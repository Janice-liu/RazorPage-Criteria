namespace RazorPage
{
	public class Ramp
	{
		public enum ID
		{
			Nil = 0,
			EX = 1,
			HR = 2,
			OP = 3,
			CD = 4
		}

		public enum Code : short
		{
			//EX
			NotFound = 10,
			UndefinedEX = 99,
			//HR
			HasConcern = 110,
			ShouldRackIn = 111,
			UndefinedHR = 199,
			//OP
			HasChallenge = 220,
			HasAddOnSvc = 221,
			HasOverthrehold = 230,
			HasFlaggedForReturn = 231,
			HasMeasured = 232,
			HasShippingPlan = 233,
			HasOutgated = 250,
			HasOutboundLocked = 251,
			UndefinedOP = 299,
			//CD
			ShouldOutbound = 310,
			UndefinedCD = 399
		}
	}

	partial class extRazorPage
	{
		public static Ramp.ID ToRamp(this Ramp.Code me)
		{
			if (me <= Ramp.Code.UndefinedEX)
				return Ramp.ID.EX;
			if (me <= Ramp.Code.UndefinedHR)
				return Ramp.ID.HR;
			if (me <= Ramp.Code.UndefinedOP)
				return Ramp.ID.OP;
			if (me <= Ramp.Code.UndefinedCD)
				return Ramp.ID.CD;
			return Ramp.ID.Nil;
		}
	}
}