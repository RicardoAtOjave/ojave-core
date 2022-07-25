using Ojave.Core.Extensions;

namespace Ojave.Core.Tests;

public class StringExtensionsTests
{
    private string lettersAndNumbers = "CE10090-F01-V02";
    private string lettersAndNumbersSemiColon = "CE10090;F01;V02";
    private string expected = "10090";

    [Fact]
    public void OnlyNumberExtTest()
    {
        var noLetters = lettersAndNumbers.OnlyNumbers();
        Assert.Equal("100900102", noLetters);
    }

    [Fact]
    public void OnlyNumberExtSplitterTest()
    {
        var noLetters = lettersAndNumbers.OnlyNumbers('-');
        var noLetters2 = lettersAndNumbers.OnlyNumbers('/');
        var noLetters3 = lettersAndNumbersSemiColon.OnlyNumbers(';');

        Assert.Equal(expected, noLetters);
        Assert.Equal(string.Empty, noLetters2);
        Assert.Equal(expected, noLetters3);
    }

    [Fact]
    public void OnlyNumbersExtSkipAndSplitterTest()
    {
        var noLetters1 = lettersAndNumbers.OnlyNumbers(0, '-');
        var noLetters2 = lettersAndNumbers.OnlyNumbers(1, '-');
        var noLettersNoSplitter = lettersAndNumbers.OnlyNumbers(1, '/');
        var noLettersSemiCol = lettersAndNumbers.OnlyNumbers(1, ';');

        Assert.Equal(expected, noLetters1);
        Assert.Equal("01", noLetters2);
        Assert.Equal(string.Empty, noLettersNoSplitter);
        Assert.Equal(string.Empty, noLettersSemiCol);
    }

    [Fact]
    public void OnlyLettersExtTest()
    {
        var noNumbers = lettersAndNumbers.OnlyLetters();
        Assert.Equal("CEFV", noNumbers);
    }
}
