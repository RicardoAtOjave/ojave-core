namespace Ojave.Core.Extensions.Iterable;

public static class IterableQueryableExtensions
{
    public static IQueryable<T> SkipWithPagination<T>(this IQueryable<T> query, int pageNumber, int quantityPerPage)
        => query.Skip((pageNumber - 1) * quantityPerPage);

    public static IQueryable<T> SkipWithPagination<T>(this IOrderedQueryable<T> query, int pageNumber, int quantityPerPage)
        => query.Skip((pageNumber - 1) * quantityPerPage);
}
