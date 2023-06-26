using System.ComponentModel.DataAnnotations;
using Types.Extensions;

namespace Tests;

public class PhoneNumberTests
{
    [Theory]
    [InlineData("(800) 555-0137")]
    [InlineData("1-800-555-0137")]
    [InlineData("+1 (800) 555-0137")]
    [InlineData("1 800 555 0137")]
    [InlineData("18005550137")]
    [InlineData("+1 (800) JKL-01DS")]
    [InlineData("1800-THRIFTY")]
    [InlineData("1-800-94-JENNY")]
    [InlineData("03-3224-9999")]
    [InlineData("+1 03-3224-9999")]
    [InlineData("011-81-3-3224-9999")]
    [InlineData("+49 89 23548362")]
    [InlineData("+30 21 0687 0099")]
    [InlineData("+91 22 2630 4808")]
    [InlineData("")]
    [InlineData("1")]
    [InlineData("1234")]
    [InlineData("1234567")]
    public void ValidNumbersAreValid(string number)
    {
        // Arrange
        var attr = new PhoneAttribute();

        // Act
        var isValid = attr.IsValid(number);

        // Assert
        Assert.True(isValid);
    }

    [Theory]
    [InlineData("(800) 555-0137", "8005550137")]
    [InlineData("1-800-555-0137", "18005550137")]
    [InlineData("+1 (800) 555-0137", "18005550137")]
    [InlineData("1 800 555 0137", "18005550137")]
    [InlineData("18005550137", "18005550137")]
    [InlineData("+1 (800) JKL-01DS", "18005550137")]
    [InlineData("1800-THRIFTY", "18008474389")]
    [InlineData("1-800-94-JENNY", "18009453669")]
    [InlineData("03-3224-9999", "0332249999")]
    [InlineData("+1 03-3224-9999", "10332249999")]
    [InlineData("011-81-3-3224-9999", "01181332249999")]
    [InlineData("+49 89 23548362", "498923548362")]
    [InlineData("+30 21 0687 0099", "302106870099")]
    [InlineData("+91 22 2630 4808", "912226304808")]
    [InlineData("", "")]
    [InlineData("1", "1")]
    [InlineData("1234", "1234")]
    [InlineData("1234567", "1234567")]
    public void ConvertToNumberString(string number, string result)
    {
        // Arrange

        // Act
        var test = number.AlphaToNumber();

        // Assert
        Assert.Equal(result, test);
    }
}