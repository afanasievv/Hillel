using Lesson25;
using Xunit;

public class StringManipulatorTests
{
    private StringManipulator _stringManipulator;

    public StringManipulatorTests()
    {
        _stringManipulator = new StringManipulator();
    }

    [Fact]
    public void ConcatenateStrings_ShouldReturnConcatenatedString()
    {
        // Arrange
        string str1 = "Hello, ";
        string str2 = "world!";

        // Act
        string result = _stringManipulator.ConcatenateStrings(str1, str2);

        // Assert
        Assert.Equal("Hello, world!", result);
    }

    [Fact]
    public void GetStringLength_ShouldReturnStringLength()
    {
        // Arrange
        string str = "Hello";

        // Act
        int result = _stringManipulator.GetStringLength(str);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void ReverseString_ShouldReturnReversedString()
    {
        // Arrange
        string str = "Hello";

        // Act
        string result = _stringManipulator.ReverseString(str);

        // Assert
        Assert.Equal("olleH", result);
    }

    [Theory]
    [InlineData("racecar")]
    [InlineData("Madam")]
    public void IsPalindrome_WhenPalindromeString_ShouldReturnTrue(string palindrome)
    {
        // Act
        bool result = _stringManipulator.IsPalindrome(palindrome);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("hello")]
    [InlineData("world")]
    public void IsPalindrome_WhenNonPalindromeString_ShouldReturnFalse(string nonPalindrome)
    {
        // Act
        bool result = _stringManipulator.IsPalindrome(nonPalindrome);

        // Assert
        Assert.False(result);
    }
}