namespace CleanPhoneFormatter.Formatter.Utils
{
  public class ResidentialPhoneFormatter
  {


    public static string FormatCompleteResidentialPhone(string telphoneNumber)
    {
      return string.Format("RES: +{0} ({1}) {2}-{3}",
                telphoneNumber.Substring(0, 2),
                telphoneNumber.Substring(2, 2),
                telphoneNumber.Substring(4, 4),
                telphoneNumber.Substring(8, 4)
            );
    }

    public static string FormatPhoneWithLeadingZero(string telphoneNumber)
    {
      return string.Format("RES: ({0}) {1}-{2}",
                telphoneNumber.Substring(1, 2),
                telphoneNumber.Substring(3, 4),
                telphoneNumber.Substring(7, 4)
            );
    }

    public static string FormatWithoutCountryCode(string telphoneNumber)
    {
      return string.Format("RES: ({0}) {1}-{2}",
                  telphoneNumber.Substring(0, 2),
                  telphoneNumber.Substring(2, 4),
                  telphoneNumber.Substring(6, 4)
              );
    }

    public static string FormatBasicPhone(string telphoneNumber)
    {
      return string.Format("RES: {0}-{1}",
                      telphoneNumber.Substring(0, 4),
                      telphoneNumber.Substring(4, 4)
                  );
    }
  }
}