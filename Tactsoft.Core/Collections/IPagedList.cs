namespace Tactsoft.Common.Collections
{
    public interface IPagedList<T>
    {
        IList<T> Items { get; set; }
        int Total { get; set; }
    }
}
