using RazorPage.Archetypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Zebra;
using Zebra.Tuplets;

namespace RazorPage
{
    namespace Archetypes
	{
		public interface ITvpInfo { string InfoOf(Enum key); }

		public abstract class TvpInfo : ITvpInfo
		{
			public TvpInfo(string tvp) => _info = at.Tvp.Many.Of(tvp.Decode())
				.AsEnumerable(x => x.ToDuad(at.Int32.Of, Extension.Echo))
				.ToDictionary(x => x.V1, x => x.V2);
			private readonly Dictionary<int, string> _info;
			public IDictionary<int, string> Infos => _info;
			string ITvpInfo.InfoOf(Enum key) => _info.Peek(key.ToInt32()).Ensure();
		}
	}

	partial class extRazorPage
	{
		public static string Decode(this string me)
			=> me.Over(WebUtility.HtmlDecode).Ensure(x => x.Equals(me) ? x : Decode(x));

		public static string InfoOf(this ITvpInfo me, Enum key)
			=> me.Ensure(x => x.InfoOf(key));

		public static IEnumerable<string> SeqOf(this ITvpInfo me, params Enum[] keys)
			=> keys.EachTo(me.InfoOf);

		public static IEnumerable<KeyValuePair<Enum, string>> KvpOf(this ITvpInfo me, params Enum[] keys)
			=> keys.EachTo(x => x.ValMe(me.InfoOf(x)));

		public static IEnumerable<KeyValuePair<string, string>> KvpOf(this ITvpInfo me, Func<Enum, string> localizer, params Enum[] keys)
			=> keys.EachTo(x => localizer(x).ValMe(me.InfoOf(x)));
	}
}
