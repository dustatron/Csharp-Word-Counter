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

    public static void FirstRun(out string inputSentence, out string inputWord)
    {
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.Clear();
      Console.WriteLine(@"
                              ____    __    ____  ______   .______       _______                 
                              \   \  /  \  /   / /  __  \  |   _  \     |       \                
                               \   \/    \/   / |  |  |  | |  |_)  |    |  .--.  |               
                                \            /  |  |  |  | |      /     |  |  |  |               
                                 \    /\    /   |  `--'  | |  |\  \----.|  '--'  |               
                                  \__/  \__/     \______/  | _| `._____||_______/                
                                                                                                 
                       ______   ______    __    __  .__   __. .___________. _______ .______      
                      /      | /  __  \  |  |  |  | |  \ |  | |           ||   ____||   _  \     
                     |  ,----'|  |  |  | |  |  |  | |   \|  | `---|  |----`|  |__   |  |_)  |    
                     |  |     |  |  |  | |  |  |  | |  . `  |     |  |     |   __|  |      /     
                     |  `----.|  `--'  | |  `--'  | |  |\   |     |  |     |  |____ |  |\  \----.
                      \______| \______/   \______/  |__| \__|     |__|     |_______|| _| `._____|
                                                                                                                                   
      ");
      Type("Hello and welcome to the world famus word counter!", 35, true);
      Type("This program can tell you how many times a word shows up in a sentence.", 35, true);
      System.Console.WriteLine();

      Type("Enter your sentence...", 50, false);
      inputSentence = Console.ReadLine();
      System.Console.WriteLine();
      Type("Enter your word...", 50, false);
      inputWord = Console.ReadLine();
      System.Console.WriteLine();

      Console.WriteLine("we are now using your advanced algorithms to process your request");
      Type("Processing . ", 50, false);
      Type(". . .", 400, true);
      Type("Completed...", 50, true);
    }

    public static void Readout(int result, string sentence, string word)
    {
      string times = "times";
      if (result == 1)
      {
        times = "time";
      }
      Type($"Your sentence was {sentence.Length} character long.", 50, true);
      Type($"It included the word {word} {result} {times}.", 50, true);
      Type($"Would you like to try again?", 50, true);
      Type($"Press [Y] for yes or [Q] to quit.", 50, true);
    }

    public static void isStaying(bool staying)
    {
      if (staying)
      {
        Copy.Type("Great Lets do it again!!!        ", 50, true);
      }
      else
      {
        Copy.Type("It was good hanging out... See you next time     ", 50, true);
      }
    }

  }
}