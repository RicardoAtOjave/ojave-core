using Ojave.Core.System.Collections;

namespace Ojave.Core.Extensions;

public static class PaginatedQueryableExtensions
{
    public static Task<PaginatedList<TDestination>> ToPaginatedListAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int qtyPerPage)
           => PaginatedList<TDestination>.CreateAsync(queryable, pageNumber, qtyPerPage);

    public static IQueryable<T> SkipWithPagination<T>(this IQueryable<T> query, int pageNumber, int qtyPerPage)
        => query.Skip((pageNumber - 1) * qtyPerPage);

    public static IQueryable<T> SkipWithPagination<T>(this IOrderedQueryable<T> query, int pageNumber, int qtyPerPage)
        => query.Skip((pageNumber - 1) * qtyPerPage);
}
