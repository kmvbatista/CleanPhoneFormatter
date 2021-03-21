using Xunit;
using CleanPhoneFormatter.Formatter.Utils;

namespace CleanPhoneFormatter.UnitTests
{
  public class PublicServicePhoneFormatterTests
  {
    [Fact]
    public static void ShouldGetPublicServicePhoneFormatted()
    {
      string result = PublicServicePhoneFormatter.GetFormattedPhone("190");
      Assert.Equal("SUP: 190", result);
    }
  }
}