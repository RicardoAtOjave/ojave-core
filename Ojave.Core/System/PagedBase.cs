namespace Ojave.Core.System;

public class PagedBase
{
    public PagedBase() {}

    public PagedBase(int pageNumber, int qtyPerPage)
    {
        PageNumber = pageNumber;
        QtyPerPage = qtyPerPage;
    }

    public int PageNumber { get; set; } = 1;
    public int QtyPerPage { get; set; } = 30;
}
