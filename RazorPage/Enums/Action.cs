﻿namespace RazorPage
{
	public static class Actions
	{
		public enum ID
		{
			Nil = 0,
			InitMatter = 10010,
			HubCheckIn = 11100,
			HubMeasure = 11200,
			HubMeasureToRackIn = 11201,
			HubMeasureMPS = 11202,
			HubMeasureCPSWithLoop = 11203,
			HubMeasureCPS = 11213,
			ImportAsn = 11220,
			CfmAsnHubVerified = 11230,
			CfmAsnRacked = 11240,
			VoidAsn = 11245,
			ToRackIn = 11310,
			Cart = 11320,
			RackIn = 11330,
			ToRackOut = 11340,
			RackOut = 11350,
			MarkAsNotOnRack = 11355,
			TearOff = 11400,
			Unify = 11410,
			HubVerifyWithTappingGreen = 11510,
			ComplyWithShippingPlan = 11560,
			RetiredCloseSack = 11860,
			VoidSack = 11865,
			AddParcelToSack = 11866,
			RemoveParcelFromSack = 11867,
			AssignSackMft = 11868,
			RemoveFromSackMft = 11869,
			AddToSackLoad = 11872,
			RemoveFromSackLoad = 11873,
			VoidSackLoad = 11875,
			OpenSackMft = 11880,
			CloseSackMft = 11899,
			HubManifest = 11900,
			CfmTransloaded = 11950,
			ImportOutgateManifest = 11951,
			EndOfDay = 11952,
			InitParcel = 17000,
			VoidParcel = 17005,
			FlagForReturn = 17015,
			FlagAsFailedDelivery = 17016,
			QueueForReturnByHubDriver = 17032,
			ConfirmIDInfo = 17098,
			CompleteParcelInfo = 17099,
			UpdateParcelInfo = 17100,
			RequestIDNumber = 17101,
			UpdateIDNumber = 17102,
			RequestIDPicture = 17103,
			UpdateIDPicture = 17104,
			AssignCmdy = 17105,
			TranslateForBrokerage = 17106,
			CfmLabelGeneration = 17107,
			CfmLabelGenerationFailure = 17108,
			RequestBrkgTranslation = 17111,
			RequestOverlabel = 17120,
			Overlabel = 17121,
			ReportOverThreshold = 17155,
			PromoteToShippingPlan = 17170,
			ComposeShippingPlan = 17176,
			RouteToUSPS = 17180,
			CfmRoute = 17200,
			ReportSvcRateNotFound = 17203,
			ReportCreditLimitExceeded = 17204,
			OverrideCreditLimit = 17205,
			CfmPayment = 17206,
			ImportSvcRate = 17207,
			SourceRelease = 17210,
			SourceConcur = 17211,
			ShipperRelease = 17212,
			ReceiveBrkgAcceptance = 17220,
			RequeueBrkgApi = 17221,
			ReceiveBrkgRejection = 17225,
			VoidPickup = 17270,
			CallOffDriver = 17275,
			DriverStartOff = 17276,
			CancelStartOff = 17277,
			Dispatch = 17284,
			CfmPickedup = 17299,
			ICManifest = 17300,
			SurrenderByImport = 17360,
			FallbackShipping = 17500,
			Bounce = 17605,
			CancelFlight = 18835,
			CfmFlightOnboarded = 18840,
			CfmFlightDepartureDelayed = 18845,
			CfmFlightDeparted = 18850,
			CfmFlightArrivalDelayed = 18855,
			CfmFlightArrived = 18860,
			CfmCustomsHeld = 18865,
			CfmCustomsCleared = 18870,
			CfmCustomsSeized = 18895,
			CfmSurrenderByImport = 18897,
			CfmDoorDelivered = 19990,
			WMSProvideOutgoingWeight = 58540
		}

		public enum HasAction
		{
			HD = 100,
			EX = 200,
			OP = 300,
			CD = 400
		}
	}
}