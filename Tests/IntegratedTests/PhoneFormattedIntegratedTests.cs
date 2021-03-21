using Xunit;
using CleanPhoneFormatter.Formatter;

namespace CleanPhoneFormatter.UnitTests
{
  public class PhoneFormattedIntegratedTests
  {
    private static string GetNotFoundString(string phone) => "Número de telefone não identificado: " + phone;

    [Theory]
    [InlineData("554733251368", "RES: +55 (47) 3325-1368")]
    [InlineData("04733251368", "RES: (47) 3325-1368")]
    [InlineData("4733251368", "RES: (47) 3325-1368")]
    [InlineData("33251368", "RES: 3325-1368")]
    public static void ShouldFormatResidentialNumbers(string input, string output)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(output, result);
    }

    [Theory]
    [InlineData("454733251368")]
    [InlineData("14733251368")]
    [InlineData("4713251368")]
    [InlineData("3251368")]
    public static void ShouldNotFormatResidentialNumbers(string phoneNumber)
    {
      string result = PhoneFormatter.GetFormattedPhone(phoneNumber);
      Assert.Equal(GetNotFoundString(phoneNumber), result);
    }

    [Theory]
    [InlineData("5547984461240", "MOB: +55 (47) 9 8446-1240")]
    [InlineData("554784461240", "MOB: +55 (47) 8446-1240")]
    [InlineData("047984461240", "MOB: (47) 9 8446-1240")]
    [InlineData("04784461240", "MOB: (47) 8446-1240")]
    [InlineData("47984461240", "MOB: (47) 9 8446-1240")]
    [InlineData("4784461240", "MOB: (47) 8446-1240")]
    [InlineData("984461240", "MOB: 9 8446-1240")]
    [InlineData("84461240", "MOB: 8446-1240")]
    public static void ShouldFormatMobileNumbers(string input, string output)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(output, result);
    }

    [Theory]
    [InlineData("5447984461240")]
    [InlineData("5504784461240")]
    [InlineData("047284461240")]
    [InlineData("24784461240")]
    [InlineData("47924461240")]
    [InlineData("0984461240")]
    [InlineData("14461240")]
    public static void ShouldNotFormatMobileNumbers(string input)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(GetNotFoundString(input), result);
    }

    [Theory]
    [InlineData("10321", "ETF: 103+21")]
    [InlineData("1051", "ETM: 1051")]
    [InlineData("10698", "ETV: 10698")]
    public static void ShouldFormatServiceProviders(string input, string output)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(result, output);
    }

    [Theory]
    [InlineData("10221")]
    [InlineData("1011")]
    [InlineData("10998")]
    public static void ShouldNotFormatServiceProviders(string input)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(GetNotFoundString(input), result);
    }

    [Theory]
    [InlineData("08007294568", "NNG: 0800 729 4568")]
    [InlineData("03007294568", "NNG: 0300 729 4568")]
    [InlineData("05007294568", "NNG: 0500 729 4568")]
    public static void ShouldFormatNotGeographicPhone(string input, string output)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(result, output);
    }

    [Theory]
    [InlineData("01007294568")]
    [InlineData("23007294568")]
    [InlineData("07007294568")]
    public static void ShouldNotFormatNotGeographicPhone(string input)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(GetNotFoundString(input), result);
    }

    [Theory]
    [InlineData("180", "NNG: 0800 729 4568")]
    [InlineData("198", "NNG: 0300 729 4568")]
    public static void ShouldFormatPublicPhone(string input, string output)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(result, output);
    }

    [Theory]
    [InlineData("1900")]
    [InlineData("13")]
    public static void ShouldNotFormatPublicPhone(string input)
    {
      string result = PhoneFormatter.GetFormattedPhone(input);
      Assert.Equal(GetNotFoundString(input), result);
    }

  }
}