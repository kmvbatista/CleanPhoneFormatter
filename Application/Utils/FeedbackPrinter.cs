using System;

namespace CleanPhoneFormatter.Implementacao2
{
  public class FeedBackPrinter
  {
    public static void PrintHeader(string phrase)
    {
      Console.WriteLine();
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("--" + phrase);
      Console.WriteLine("-------------------------------------------");
      Console.WriteLine();
      // Console.ReadKey();
    }

    public static void PrintOutputPhone(string phoneNumber)
    {
      Console.Write(string.Format("Saída: \t\t {0}", phoneNumber));
    }
    public static void PrintInputPhone(string phoneNumber, int phoneNumberIndexOnList)
    {
      Console.WriteLine();
      Console.WriteLine(
        string.Format("-- Teste #{0:00} ------------------------------", phoneNumberIndexOnList + 1));
      Console.WriteLine(string.Format("Entrada: \t{0}", phoneNumber));
    }


  }
}