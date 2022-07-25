using Ojave.Core.System;

namespace Ojave.Core.Extensions;

public static class StringExtensions
{
    /// <summary>
    /// Will return all numbers found within a string, removing all other characters
    /// </summary>
    /// <param name="str"></param>
    /// <returns>string of numbers</returns>
    public static string OnlyNumbers(this string str)
    {
        char[] numbers = Character.RemoveLetters(str);
        return new string(numbers);
    }

    /// <summary>
    /// Will return all numbers before the first instance of the splitter provided is found, removing all other characters
    /// </summary>
    /// <param name="str"></param>
    /// <param name="splitter"></param>
    /// <returns>string of numbers</returns>
    public static string OnlyNumbers(this string str, char splitter)
    {
        var indexed = str.IndexOf(splitter);

        if (indexed < 0 || indexed > str.Length) return string.Empty;

        var indexedSpan = str[..indexed];

        char[] numbers = Character.RemoveLetters(indexedSpan);

        return new string(numbers);
    }

    /// <summary>
    /// Will return all numbers from a string removing all other characters while skipping the number of instances of a splitter determined by the skip parameter provided. 
    /// </summary>
    /// <param name="str"></param>
    /// <param name="skip"></param>
    /// <param name="splitter"></param>
    /// <returns>string of numbers</returns>
    public static string OnlyNumbers(this string str, int skip, char splitter)
    {
        int splitterIndex = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == splitter)
            {
                splitterIndex++;

                if (splitterIndex == skip)
                {
                    startIndex = i + 1;
                }

                if (splitterIndex > skip)
                {
                    endIndex = i;
                    break;
                }
            }
        }

        var selection = str[startIndex..endIndex];

        char[] numbers = Character.RemoveLetters(selection);

        return new string(numbers);
    }

    /// <summary>
    /// Will return all letters found within a string, removing all other characters
    /// </summary>
    /// <param name="str"></param>
    /// <returns>string of letters</returns>
    public static string OnlyLetters(this string str)
    {
        char[] letters = Character.RemoveNumbers(str);
        return new string(letters);
    }
}
