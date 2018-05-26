using System.Collections.Generic;
using Zebra;
using Zebra.Archetypes;

namespace RazorPage
{
	using M = LineInfo;

	public class LineInfo : Quad<M, GoodsInfo, int, Money, int>
	{
		public static IEnumerable<M> ManyFrom(string tvp) 
			=> tvp.Over(at.Tvp.Mucho.Of).AsEnumerable(From);
		public static M Of(GoodsInfo goodsInfo, int quantity, Money lineTotal, int cmdyID)
			=> new M(goodsInfo, quantity, lineTotal, cmdyID);

		public LineInfo() : this(GoodsInfo.Empty, 0, Money.Empty, 0) { }
		private LineInfo(GoodsInfo goodsInfo, int quantity, Money lineTotal, int cmdyID)
			: base(goodsInfo, quantity, lineTotal, cmdyID) { }

		protected override M OnNew(IQuad<string, string, string, string> tvp)
			=> new M(tvp.V1.Over(GoodsInfo.From),
					 tvp.V2.Over(at.Int32.Of),
					 tvp.V3.Over(Money.From),
					 tvp.V4.Over(at.Int32.Of));

		public GoodsInfo GoodsInfo => f1;
		public Money LineTotal => f3;
		public int Quantity => f2;
		public int CmdyID => f4;

		public override string ToString() => ToTvp();
	}
}
