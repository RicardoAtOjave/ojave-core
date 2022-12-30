namespace Ojave.Core.Extensions;

public static class DictionaryExtensions
{
    public static int GetValueOrDefault(this Dictionary<int, int> dict, int key)
    {
        return dict.ContainsKey(key) 
               ? dict[key] 
               : 0;
    }
}
