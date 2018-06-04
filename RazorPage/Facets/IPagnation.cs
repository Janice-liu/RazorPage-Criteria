namespace RazorPage
{
    public interface IPagnation
    {
        int PageIndex { get; }
        int PageSize { get; }
        int AvailCnt { get; }
    }
}