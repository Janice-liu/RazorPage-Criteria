using System;
using System.Collections.Generic;
using System.Linq;
using Zebra;

namespace RazorPage
{
	public sealed class Tenancy : ITenancy
	{
		public static readonly Tenancy Empty = Of(string.Empty);

		public static Tenancy Of(Func<string> tvpFactory) => Of(tvpFactory());
		public static Tenancy Of(string tvp) => new Tenancy(tvp);

		private Tenancy(string tvp)
		{
			var pair = at.Tvp.Duad.Of(tvp);
			var ids = pair.ValAt(0, at.Tvp.Quad.Of);

			ID = ids.ValAt(0, at.Int32.Of);
			PID = ids.ValAt(1, at.Int32.Of);
			AID = ids.ValAt(2, at.Int32.Of);
			Alias = ids.ValAt(3);
			Roles = pair.ValAt(1, at.Tvp.Comma.Of).AsEnumerable(at.Int32.Of).Over(x => new HashSet<int>(x));
		}

		public int ID { get; }
		public int PID { get; }
		public int AID { get; }
		public string Alias { get; }
		public IReadOnlyCollection<int> Roles { get; }
	}

	public static partial class extRazorPage
	{
		public static bool IsEmpty(this Tenancy me)
			=> me == null || me.ID == 0 || me.AID == 0 || me.PID == 0 || me.Roles == null || !me.Roles.Any();

		public static bool IsTrangible(this Tenancy me) => !me.IsEmpty();

		public static string ToTvpFull(this Tenancy me)
			=> at.Tvp.Duad.Join(at.Tvp.Quad.Join(me.ID, me.PID, me.AID, me.Alias), string.Join(",", me.Roles));

		public static int TenantID(this Tenancy me) => me.AID;
		public static int SiteID(this Tenancy me) => me.PID;

		public static int AcctID(this Tenancy me) => me.AID;
		public static int HubID(this Tenancy me) => me.PID;
	}

}
