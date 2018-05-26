using System;
using System.Collections.Generic;
using System.Linq;
using Zebra;

namespace RazorPage
{
	public interface ITenancy
	{
		int ID { get; }
		int PID { get; }
		int AID { get; }
		string Alias { get; }
		IReadOnlyCollection<int> Roles { get; }
	}

	partial class extRazorPage
    {
		public static string TvpFor(this ITenancy me, Enum role) => TvpFor(me, role.ToInt32());
		public static string TvpFor(this ITenancy me, int tobeRoleID)
		{
			return me?.To(x => at.Tvp.Quad.Join(x.PID, x.AID, x.ID, rectify(tobeRoleID))).Ensure();

			int rectify(int roleID) => me.Roles.Contains(roleID) ? roleID : -1;
		}
	}
}
