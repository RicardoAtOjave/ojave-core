using Ojave.Core.Extensions.Iterable;

namespace Ojave.Core.Tests;

public class IterableCollectionTests
{
    private readonly int[] _array = new int[] { 1, 2, 3 };

    [Fact]
    public void CombineIntArrayNoSeparator()
    {
        var result = _array.CombineCollection();
        Assert.Equal("1 2 3", result);
    }

    [Fact]
    public void CombineInArrayWithSeparator()
    {
        var result = _array.CombineCollection(',');
        Assert.Equal("1, 2, 3", result);
    }

}
