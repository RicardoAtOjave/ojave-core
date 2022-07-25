namespace Ojave.Core.Extensions;

public static class IterableStringExtensions
{
    public static IEnumerable<string> ToLower(this IEnumerable<string> collection)
    {
        var arr = collection.ToArray();
        string[] newCollection = new string[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            newCollection[i] = arr[i].ToLower();
        }

        return newCollection;
    }
}
