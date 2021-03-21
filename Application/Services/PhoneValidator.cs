using System.Text.RegularExpressions;
using System.Linq;

namespace CleanPhoneFormatter.Validator
{
  public class PhoneValidator
  {

    public static bool IsServiceProvider(string phoneNumber)
    {
      string pattern = @"^10(3|5|6)\d{1,2}$";
      return Regex.IsMatch(input: phoneNumber, pattern: pattern);
    }

    public static bool IsPublicService(string phoneNumber)
    {
      return phoneNumber.Length == 3;
    }

    public static bool IsNotGeophicNumber(string phoneNumber)
    {
      string pattern = @"^0(3|5|8)00(\d{7})$";
      return Regex.IsMatch(input: phoneNumber, pattern: pattern);
    }


    public static bool IsMobileNumber(string phoneNumber)
    {
      string pattern = @"^((5{2})?|(0)?)(\d{2})?9?(7|8|9){1}\d{7}$";
      bool IsMatch = Regex.IsMatch(input: phoneNumber, pattern: pattern);
      if (IsMatch && phoneNumber[0] == '0' && !IsPhoneStartingWithZeroValid(phoneNumber))
        return false;
      return IsMatch;
    }


    public static bool IsResidentialNumber(string phoneNumber)
    {
      string pattern = @"^([5]{2})?(([1-9]{2})|[0][1-9]{2})?(2|3|4|5)\d{3}\d{4}$$";
      return Regex.IsMatch(input: phoneNumber, pattern: pattern);
    }

    //Evitar os casos em que 0 não é seguido pelo código local, visto que não é possível fazer isso com string
    //exemplo que não deveria passar e não vai graças a essa validação: 0988888888 
    private static bool IsPhoneStartingWithZeroValid(string phoneNumber)
    {
      return phoneNumber.Length != 12 || IsPhoneStartingWithZeroWhichLengthIsNot12Valid(phoneNumber);
      //garantir que números que começam com 0 e têm tamanho diferente de 12 passem, como 04788888888
    }

    private static bool IsPhoneStartingWithZeroWhichLengthIsNot12Valid(string phoneNumber)
    {
      char[] permittedLeadingDigitsOnMobile = { '7', '8', '9' };
      return permittedLeadingDigitsOnMobile.Contains(phoneNumber[3]);
    }

  }

}