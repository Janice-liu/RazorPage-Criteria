using System;
using System.Collections.Generic;
using System.Linq;

namespace RazorPage
{
    using M = RefNbr;
    public partial class RefNbr : Archetypes.TvpInfo
    {
        public static readonly M Empty = Of(string.Empty);
        public static M Of(string tvp) => new M(tvp);

        public RefNbr() : this(string.Empty) { }
        private RefNbr(string tvp) : base(tvp) { }
    }

    partial class extRazorPage
    {
        public static string ValOf(this M me, Enum key) => me.InfoOf(key);

        public static string MIC(this M me) => me.ValOf(M.Types.MIT);
        public static string MawbNbr(this M me) => me.ValOf(M.Types.MawbNbr);
        public static string BookingNbr(this M me) => me.ValOf(M.Types.BookingNbr);
        public static string ClientRefNbr(this M me) => me.ValOf(M.Types.ClientRef);
        public static string LastMilerNbr(this M me) => me.ValOf(M.Types.PostCourier);
        public static string FirstMilerNbr(this M me) => me.ValOf(M.Types.PreCourier);
        public static IList<string> RefNbrs(this M me) => me.Infos.Select(x => x.Value).ToList();
    }
}

