using Xunit;
using CleanPhoneFormatter.Validator;

namespace CleanPhoneFormatter.UnitTests.PhoneValidatorTests
{
  public class PhoneValidatorTests
  {
    [Theory]
    [InlineData("986207703")]
    [InlineData("4776207702")]
    [InlineData("554796207702")]
    [InlineData("5547986207702")]
    [InlineData("04786207702")]
    public static void ShouldBeMobileNumber(string phoneNumber)
    {
      var isMobileNumber = PhoneValidator.IsMobileNumber(phoneNumber);
      Assert.True(isMobileNumber);
    }

    [Theory]
    [InlineData("896207703")]
    [InlineData("4726207702")]
    [InlineData("54786207702")]
    [InlineData("5547946207702")]
    [InlineData("004786207702")]
    public static void ShouldNotBeMobileNumber(string phoneNumber)
    {
      var isMobileNumber = PhoneValidator.IsMobileNumber(phoneNumber);
      Assert.False(isMobileNumber);
    }

    [Theory]
    [InlineData("23070703")]
    [InlineData("4733251368")]
    [InlineData("04743251368")]
    [InlineData("554756207702")]
    public static void ShouldBeResidentialNumber(string phoneNumber)
    {
      var isResidentialNumber = PhoneValidator.IsResidentialNumber(phoneNumber);
      Assert.True(isResidentialNumber);
    }

    [Theory]
    [InlineData("13070703")]
    [InlineData("4763251368")]
    [InlineData("54743251368")]
    [InlineData("324746207702")]
    public static void ShouldNotBeResidentialNumber(string phoneNumber)
    {
      var isResidentialNumber = PhoneValidator.IsResidentialNumber(phoneNumber);
      Assert.False(isResidentialNumber);
    }

    [Theory]
    [InlineData("123")]
    [InlineData("789")]
    public static void ShouldBePublicServiceNumber(string phoneNumber)
    {
      var isPubService = PhoneValidator.IsPublicService(phoneNumber);
      Assert.True(isPubService);
    }

    [Theory]
    [InlineData("1230")]
    [InlineData("78")]
    public static void ShouldNotBePublicServiceNumber(string phoneNumber)
    {
      var isPubService = PhoneValidator.IsPublicService(phoneNumber);
      Assert.False(isPubService);
    }

    [Theory]
    [InlineData("10341")]
    [InlineData("1051")]
    [InlineData("10612")]
    [InlineData("10610")]
    public static void ShouldBeServiceProviderNumber(string phoneNumber)
    {
      var isServiceProvider = PhoneValidator.IsServiceProvider(phoneNumber);
      Assert.True(isServiceProvider);
    }

    [Theory]
    [InlineData("20341")]
    [InlineData("1081")]
    [InlineData("12414")]
    [InlineData("11612")]
    public static void ShouldNotBeServiceProviderNumber(string phoneNumber)
    {
      var isServiceProvider = PhoneValidator.IsServiceProvider(phoneNumber);
      Assert.False(isServiceProvider);
    }

    [Theory]
    [InlineData("08007294568")]
    [InlineData("05007294586")]
    [InlineData("03007291247")]
    public static void ShouldBeNotGeophicNumber(string phoneNumber)
    {
      var isNotGeophicNumber = PhoneValidator.IsNotGeophicNumber(phoneNumber);
      Assert.True(isNotGeophicNumber);
    }

    [Theory]
    [InlineData("0800729456")]
    [InlineData("0500729456")]
    [InlineData("01007294586")]
    [InlineData("02007291247")]
    [InlineData("04007291247")]
    [InlineData("07007291247")]
    [InlineData("09007291247")]
    public static void ShouldNOtBeNotGeophicNumber(string phoneNumber)
    {
      var isNotGeophicNumber = PhoneValidator.IsNotGeophicNumber(phoneNumber);
      Assert.False(isNotGeophicNumber);
    }
  }
}