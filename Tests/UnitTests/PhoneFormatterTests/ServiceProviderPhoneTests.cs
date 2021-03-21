using Xunit;
using CleanPhoneFormatter.Formatter.Utils;

namespace CleanPhoneFormatter.UnitTests
{
  public class ServiceProviderPhoneFormatterTests
  {
    [Fact]
    public static void ShouldFormatResidentialServiceProvider()
    {
      string result = ServiceProviderPhoneFormatter.FormatResidentialServiceProvider("10321");
      Assert.Equal("ETF: 103+21", result);
    }

    [Fact]
    public static void ShouldFormatMobileServiceProvider()
    {
      string result = ServiceProviderPhoneFormatter.FormatMobileServiceProvider("1052");
      Assert.Equal("ETM: 1052", result);
    }

    [Fact]
    public static void ShouldFormatCableTvServiceProvider()
    {
      string result = ServiceProviderPhoneFormatter.FormatCableTvServiceProvider("10625");
      Assert.Equal("ETV: 10625", result);
    }
  }
}