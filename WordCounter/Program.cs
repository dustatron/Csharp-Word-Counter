using System;
using System.Threading;
using System.Threading.Tasks;
using Word.Models;
using Word.Views;

namespace Word
{
  public class Program
  {
    public static void Main()
    {
      string inputSentence;
      string inputWord;

      Copy.FirstRun(out inputSentence, out inputWord);

      //run program

      int result = 0;
      try
      {
        result = Counter.ReturnCount(inputSentence, inputWord);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.Source);
        Console.WriteLine(ex.StackTrace);
      }

      Copy.Readout(result, inputSentence, inputWord);
      string endMenu = Console.ReadLine();

      if (endMenu.ToLower() == "q")
      {
        Copy.isStaying(false);
      }
      else
      {
        Copy.isStaying(true);
        Main();

      }


    }



  }

}