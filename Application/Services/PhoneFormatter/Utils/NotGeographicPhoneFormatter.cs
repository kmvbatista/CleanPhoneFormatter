namespace CleanPhoneFormatter.Formatter.Utils
{
  public class NotGeographicPhoneFormatter
  {
    public static string GetFormattedPhone(string telphoneNumber)
    {
      return string.Format("NNG: {0} {1} {2}",
                    telphoneNumber.Substring(0, 4),
                    telphoneNumber.Substring(4, 3),
                    telphoneNumber.Substring(7, 4));
    }
  }
}