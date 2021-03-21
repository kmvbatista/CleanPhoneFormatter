using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using ExtensionMethods;
using CleanPhoneFormatter.Formatter;

/*
[CleanPhoneFormatter] Prova Implementação
*/

namespace CleanPhoneFormatter.Implementacao2
{
  internal class Program
  {
    private static Stopwatch stopwatch = new Stopwatch();
    private static void Main(string[] args)
    {
      FeedBackPrinter.PrintHeader("-- Teste Kennedy Messias Vieira Batista");

      StartCountingTime();

      FormatPhoneNumbers();

      FinishCountingTime();

      FeedBackPrinter.PrintHeader(
        string.Format("-- PROGRAMA FINALIZADO EM {0}ms", stopwatch.ElapsedMilliseconds));
    }

    private static void StartCountingTime()
    {
      stopwatch.Start();
    }

    private static void FinishCountingTime()
    {
      stopwatch.Stop();
    }

    private static void FormatPhoneNumbers()
    {
      IEnumerable<string> lines = File.ReadLines(@"InputData/input.4.in");
      foreach (var (line, index) in lines.WithIndex())
      {
        FeedBackPrinter.PrintInputPhone(phoneNumber: line, phoneNumberIndexOnList: index);
        string formattedPhone = PhoneFormatter.GetFormattedPhone(line);
        FeedBackPrinter.PrintOutputPhone(formattedPhone);
      }
    }
  }
}