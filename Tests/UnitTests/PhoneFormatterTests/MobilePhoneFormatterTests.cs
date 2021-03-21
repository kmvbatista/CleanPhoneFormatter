using Xunit;
using CleanPhoneFormatter.Formatter.Utils;

namespace CleanPhoneFormatter.UnitTests
{
  public class MobilePhoneFormatterTests
  {
    [Fact]
    public static void ShouldGetMobileNumberWithTwelveDigits()
    {
      string result = MobilePhoneFormatter.FormatCompletePhone("5533996207702");
      Assert.Equal("MOB: +55 (33) 9 9620-7702", result);
    }

    [Fact]
    public static void ShouldGetMobileNumberWithoutNinethDigit()
    {
      string result = MobilePhoneFormatter.FormatWithoutNineth("553386207702");
      Assert.Equal("MOB: +55 (33) 8620-7702", result);
    }

    [Fact]
    public static void ShouldGetMobileNumberWithLeadingZero()
    {
      string result = MobilePhoneFormatter.FormatPhoneWithLeadingZero("033986207702");
      Assert.Equal("MOB: (33) 9 8620-7702", result);
    }

    [Fact]
    public static void ShouldGetMobileWithLeadingZeroWithoutNineth()
    {
      string result = MobilePhoneFormatter.FormatPhoneLeadingZeroWithoutNineth("03386207702");
      Assert.Equal("MOB: (33) 8620-7702", result);
    }

    [Fact]
    public static void ShouldGetMobileWithoutCountryCodeAndLocalCode()
    {
      string result = MobilePhoneFormatter.FormatWithoutCountryCodeAndLocalCode("986207702");
      Assert.Equal("MOB: 9 8620-7702", result);
    }

    [Fact]
    public static void ShouldGetMobileWithBasicDigits()
    {
      string result = MobilePhoneFormatter.FormatBasicPhone("86207702");
      Assert.Equal("MOB: 8620-7702", result);
    }
  }
}