using RazorPage.Archetypes;

namespace RazorPage
{
	public interface ITvpRepoContext
	{
		Tenancy Tenancy { get; }
		string TenancyTvp { get; }
	}
}
