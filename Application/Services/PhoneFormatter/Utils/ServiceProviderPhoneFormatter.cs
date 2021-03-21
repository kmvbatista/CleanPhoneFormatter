namespace CleanPhoneFormatter.Formatter.Utils
{
  public class ServiceProviderPhoneFormatter
  {
    public static string FormatCableTvServiceProvider(string phoneNumber) =>
      string.Format("ETV: {0}", phoneNumber);
    public static string FormatMobileServiceProvider(string phoneNumber) =>
      string.Format("ETM: {0}", phoneNumber);
    public static string FormatResidentialServiceProvider(string phoneNumber) =>
      string.Format("ETF: {0}+{1}", phoneNumber.Substring(0, 3), phoneNumber.Substring(3, 2));
  }
}