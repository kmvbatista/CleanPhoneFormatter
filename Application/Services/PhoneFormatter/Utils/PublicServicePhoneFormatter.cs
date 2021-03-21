namespace CleanPhoneFormatter.Formatter.Utils
{
  public class PublicServicePhoneFormatter
  {
    public static string GetFormattedPhone(string phoneNumber)
    {
      return string.Format("SUP: {0}", phoneNumber);
    }
  }
}