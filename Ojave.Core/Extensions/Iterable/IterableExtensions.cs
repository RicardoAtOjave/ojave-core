using System.Text;

namespace Ojave.Core.Extensions.Iterable;

public static class IterableExtensions
{
    public static string CombineCollection(this int[] collection)
    {
        StringBuilder builder = new();

        if (collection.Length == 0) return string.Empty;

        builder.Append(collection[0]);

        var span = collection.AsSpan()[1..];

        foreach (var item in span)
        {
            builder.Append($" {item}");
        }

        return builder.ToString();
    }

    public static string CombineCollection(this int[] collection, char separator)
    {
        StringBuilder builder = new();

        if (collection.Length == 0) return string.Empty;

        builder.Append(collection[0]);

        var span = collection.AsSpan()[1..];

        foreach (var item in span)
        {
            builder.Append($"{separator} {item}");
        }

        return builder.ToString();
    }
}
