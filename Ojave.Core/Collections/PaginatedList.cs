using Microsoft.EntityFrameworkCore;
using Ojave.Core.Extensions;

namespace Ojave.Core.Collections;
public class PaginatedList<T>
{
    public List<T> Items { get; }
    public int PageIndex { get; }
    public int TotalPages { get; }
    public int TotalCount { get; }
    public bool HasPreviousPage => PageIndex > 1;
    public bool HasNextPage => PageIndex < TotalPages;

    public PaginatedList()
    {
        Items = new List<T>();
    }

    public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        TotalCount = count;
        Items = items;
    }

    public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int qtyPerPage)
    {
        var count = await source.CountAsync();
        var items = await source.SkipWithPagination(pageIndex, qtyPerPage).Take(qtyPerPage).ToListAsync();

        return new PaginatedList<T>(items, count, pageIndex, qtyPerPage);
    }
}

