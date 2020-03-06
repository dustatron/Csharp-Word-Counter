using System;
using System.Threading;
using System.Threading.Tasks;
using Word.Models;

namespace Word.Views
{
  public class Copy
  {
    public static void Type(string line1, int speed, bool nextLine)
    {
      for (int i = 0; i < line1.Length; i++)
      {
        Task.Run(async delegate
        {
          await Task.Delay(speed);
          Console.Write(line1[i]);

        }
        ).Wait();
      }
      if (nextLine)
      {
        Console.WriteLine();
      }

    }

  }
}