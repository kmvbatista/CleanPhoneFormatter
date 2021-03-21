using CleanPhoneFormatter.Formatter.Utils;
using CleanPhoneFormatter.Validator;

namespace CleanPhoneFormatter.Formatter
{
  public class PhoneFormatter
  {
    //Não vi outro modo de resolver sem ser com ifs. 
    // State pattern, polimorfismo ou matching pattern do c# 9 não fazem sentido aqui
    public static string GetFormattedPhone(string phoneNumber)
    {
      if (PhoneValidator.IsPublicService(phoneNumber))
        return PublicServicePhoneFormatter.GetFormattedPhone(phoneNumber);
      if (PhoneValidator.IsServiceProvider(phoneNumber))
        return PhoneFormatter.GetFormattedServiceProviderNumber(phoneNumber);
      if (PhoneValidator.IsNotGeophicNumber(phoneNumber))
        return GetNotGeographicFormattedNumber(phoneNumber);
      if (PhoneValidator.IsResidentialNumber(phoneNumber))
        return GetResidentialFormattedNumber(phoneNumber);
      if (PhoneValidator.IsMobileNumber(phoneNumber))
        return GetMobileFormattedNumber(phoneNumber);
      return "Número de telefone não identificado: " + phoneNumber;
    }

    private static string GetMobileFormattedNumber(string phoneNumber) => phoneNumber.Length switch
    {
      13 => MobilePhoneFormatter.FormatCompletePhone(phoneNumber),
      12 when phoneNumber[0] == '0' => MobilePhoneFormatter.FormatPhoneWithLeadingZero(phoneNumber),
      12 => MobilePhoneFormatter.FormatWithoutNineth(phoneNumber),
      11 when phoneNumber[0] == '0' => MobilePhoneFormatter.FormatPhoneLeadingZeroWithoutNineth(phoneNumber),
      11 => MobilePhoneFormatter.FormatWithoutCountryCode(phoneNumber),
      10 => MobilePhoneFormatter.FormatWithoutCountryCodeAndNineth(phoneNumber),
      9 => MobilePhoneFormatter.FormatWithoutCountryCodeAndLocalCode(phoneNumber),
      _ => MobilePhoneFormatter.FormatBasicPhone(phoneNumber)
    };

    private static string GetResidentialFormattedNumber(string phoneNumber) => phoneNumber.Length switch
    {
      8 => ResidentialPhoneFormatter.FormatBasicPhone(phoneNumber),
      10 => ResidentialPhoneFormatter.FormatWithoutCountryCode(phoneNumber),
      11 => ResidentialPhoneFormatter.FormatPhoneWithLeadingZero(phoneNumber),
      _ => ResidentialPhoneFormatter.FormatCompleteResidentialPhone(phoneNumber)
    };

    private static string GetNotGeographicFormattedNumber(string phoneNumber)
    {
      return NotGeographicPhoneFormatter.GetFormattedPhone(phoneNumber);
    }

    private static string GetFormattedServiceProviderNumber(string phoneNumber) => phoneNumber.Substring(0, 3) switch
    {
      "103" => ServiceProviderPhoneFormatter.FormatResidentialServiceProvider(phoneNumber),
      "105" => ServiceProviderPhoneFormatter.FormatMobileServiceProvider(phoneNumber),
      _ => ServiceProviderPhoneFormatter.FormatCableTvServiceProvider(phoneNumber)
    };

  }

}