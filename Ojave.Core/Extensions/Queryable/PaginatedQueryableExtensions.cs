namespace Ojave.Core.Extensions;

public static class PaginatedQueryableExtensions
{
    public static IQueryable<T> SkipWithPagination<T>(this IQueryable<T> query, int pageNumber, int qtyPerPage)
        => query.Skip((pageNumber - 1) * qtyPerPage);

    public static IQueryable<T> SkipWithPagination<T>(this IOrderedQueryable<T> query, int pageNumber, int qtyPerPage)
        => query.Skip((pageNumber - 1) * qtyPerPage);
}
