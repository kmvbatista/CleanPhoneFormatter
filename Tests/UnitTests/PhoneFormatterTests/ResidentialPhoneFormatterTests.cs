using Xunit;
using CleanPhoneFormatter.Formatter.Utils;


namespace CleanPhoneFormatter.UnitTests
{
  public class ResidentialPhoneFormatterTests
  {
    [Fact]
    public static void ShouldGetCompleteResidentialPhoneFormated()
    {
      string result = ResidentialPhoneFormatter.FormatCompleteResidentialPhone("554733251368");
      Assert.Equal("RES: +55 (47) 3325-1368", result);
    }

    [Fact]
    public static void ShouldGetResidentialWithoutLeadingZeroFormated()
    {
      string result = ResidentialPhoneFormatter.FormatPhoneWithLeadingZero("04733251368");
      Assert.Equal("RES: (47) 3325-1368", result);
    }

    [Fact]
    public static void ShouldGetResidentialWithoutCountryCodeFormated()
    {
      string result = ResidentialPhoneFormatter.FormatWithoutCountryCode("4733251368");
      Assert.Equal("RES: (47) 3325-1368", result);
    }

    [Fact]
    public static void ShouldGetBasicResidentialPhoneFormatted()
    {
      string result = ResidentialPhoneFormatter.FormatBasicPhone("33251368");
      Assert.Equal("RES: 3325-1368", result);
    }
  }
}