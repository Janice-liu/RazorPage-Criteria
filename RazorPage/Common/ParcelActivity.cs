using Zebra;
using Zebra.Archetypes;

namespace RazorPage
{
	using M = ParcelActivity;

	public class ParcelActivity : Pentad<M, long, string, int, int, string>
	{
		public ParcelActivity() : this(0, string.Empty, 0, 0, string.Empty) { }

		private ParcelActivity(long id, string operators, int action, int stage, string tailledOn)
			: base(id, operators, action, stage, tailledOn) { }

		protected override M OnNew(IPentad<string, string, string, string, string> tvp)
			=> new M(tvp.V1.Over(at.Int64.Of),
			 tvp.V2,
			 at.Int32.Of(tvp.V3),
			 tvp.V4.Over(at.Int32.Of),
			 tvp.V5);

		public long ID => f1;

		public string Operators => f2;

		public int Action => f3;

		public int Stage => f4;

		public string TailledOn => f5;


	}
}
