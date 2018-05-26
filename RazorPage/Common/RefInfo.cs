using System.Collections.Generic;
using RazorPage.Archetypes;

namespace RazorPage
{
    using M = RefInfo;
	public partial class RefInfo : TvpInfo
	{
		public static readonly M Empty = Of(string.Empty);
		public static M Of(string tvp) => new M(tvp);

		public RefInfo() : this(string.Empty) { }
		private RefInfo(string tvp) : base(tvp) { }
	}

	partial class extRazorPage
	{
		public static IEnumerable<LineInfo> DeclaredInfo(this M me) 
			=> LineInfo.ManyFrom(me.InfoOf(M.Types.DeclaredInfo));
		public static IEnumerable<LineInfo> VerifiedInfo(this M me) 
			=> LineInfo.ManyFrom(me.InfoOf(M.Types.VerifiedInfo));
	}
}
