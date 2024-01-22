using AutoMapper;
using AutoMapper.QueryableExtensions;
using Ojave.Core.Data;

namespace Ojave.Core.Extensions.Iterable;
public static class PaginatedListExtensions
{
    public static Task<PaginatedList<TDestination>> ToPaginatedListAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int qtyPerPage)
           => PaginatedList<TDestination>.CreateAsync(queryable, pageNumber, qtyPerPage);

    public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, IConfigurationProvider configuration)
        => queryable.ProjectTo<TDestination>(configuration).ToListAsync();

    public static Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable, IConfigurationProvider configuration, CancellationToken cancellationToken = new CancellationToken())
        => queryable.ProjectTo<TDestination>(configuration).ToArrayAsync(cancellationToken);
}
