namespace Ojave.Core.System;

public class Character
{
    public static char[] RemoveNumbers(ReadOnlySpan<char> chars)
    {
        char[] numbers = new char[chars.Length];

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLetter(chars[i]))
            {
                numbers[i] = chars[i];
            }
        }

        if (Contains(numbers, '\0'))
        {
            return RemoveNullCharacters(numbers);
        }

        return numbers;
    }

    public static char[] RemoveLetters(ReadOnlySpan<char> chars)
    {
        char[] numbers = new char[chars.Length];

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsDigit(chars[i]))
            {
                numbers[i] = chars[i];
            }
        }

        if (Contains(numbers, '\0'))
        {
            return RemoveNullCharacters(numbers);
        }

        return numbers;
    }

    public static char[] RemoveNullCharacters(ReadOnlySpan<char> chars)
    {
        int nullCounter = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '\0')
            {
                nullCounter++;
            }
        }

        char[] result = new char[chars.Length - nullCounter];
        int counter = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != '\0')
            {
                result[counter] = chars[i];
                counter++;
            }
        }

        return result;
    }

    public static bool Contains(ReadOnlySpan<char> chars, char lookUp)
    {
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == lookUp)
                return true;
        }

        return false;
    }
}
