using Zebra;

namespace RazorPage
{
	public class State
	{
		public enum ID
		{
			Nil = 0,
			RackingTobeRackedIn = 11310,
			Carted = 11320,
			ToBeRackedOut = 11340,
			CreditLimitExceeded = 17150,
			MissingSvcRate = 17170,
			Bounced = 17605,
			LoopAwaitingIDPicture = 17250,
			SackMftCreated = 18800,
			SackMftTransloaded = 18830,
			SackMftOnboarded = 18840,
			SackMftDepartDelayed = 18845,
			SackMftDeparted = 18850,
			SackMftArriveDelayed = 18855,
			SackMftArrived = 18860,
			SackMftCustomsCleared = 18870,
			SackMftSurrendered = 18899,
			FlightCancelled = 18700,
			FlightBooked = 18710,
			FlightDepartDelayed = 18715,
			FlightDeparted = 18720,
			FlightArriveDelayed = 18725,
			FlightArrived = 18750,
			SackOpened = 18785,
			SackTransloaded = 18789,

			ExceptionUnshippable = 38005,
			CustomsSeized = 38010,
			FlaggedForReturn = 38040,
			BrkgAPIRejected_eShip = 38025,
			InfoPictureReceived = 38070,
			ParcelCreated = 38100,
			HubCheckedIn = 38200,
			OverThreshold = 38205,
			HubMeasured = 38260,
			HubVerified = 38300,
			AwaitingIDNumber = 38335,
			AwaitingIDPicture = 38336,
			RouteAssigned = 38370,
			AwaitingBrkgAPICfm = 38380,
			RouteCfmed = 38400,
			ICManifested = 38600,
			HubManifested = 38650,
			Outgated = 38700,
			CustomsHeld = 38855,
			Surrendered = 38950,
			DoorDelivered = 38990,

			AwaitingRouteCfm = 38300,
			AwaitingFlightDepature = 38860,
			CustomCleared = 38870,
			AwaitingCustomsClearance = 38880,
			AwaitingDoorDelivery = 39950,

			CDAwaitingBrkgAPICfmFor = 48100,
			CDParcelCreated = 48060,
			CDHubCheckedIn = 48200,

			BrkgAPIRejected_VMI = 58105,
			BrkgAPIRejected_VMI_NEW = 58385,

			SackManifested = 18773,
			SackLoaded = 18776
		}
	}

	partial class extRazorPage
    {
		public static bool Equals(this State.ID me, int stateId)
				=> me.ToInt32() == stateId;
	}
}
