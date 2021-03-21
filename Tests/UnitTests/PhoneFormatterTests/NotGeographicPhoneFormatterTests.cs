using Xunit;
using CleanPhoneFormatter.Formatter.Utils;

namespace CleanPhoneFormatter.UnitTests
{
  public class NotGeographicPhoneFormatterTests
  {
    [Fact]
    public static void ShouldGetNotGeographicPhoneFormatted()
    {
      string result = NotGeographicPhoneFormatter.GetFormattedPhone("08007294568");
      Assert.Equal("NNG: 0800 729 4568", result);
    }
  }
}