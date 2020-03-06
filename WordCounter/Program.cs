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
      Copy.Type("Hello and welcome to the world famus word counter!", 35, true);
      Copy.Type("This program can tell you how many times a word shows up in a sentence.", 35, true);
      System.Console.WriteLine();

      Copy.Type("Enter your sentence...", 50, false);
      string inputSentence = Console.ReadLine();
      System.Console.WriteLine();
      Copy.Type("Enter your word...", 50, false);
      string inputWord = Console.ReadLine();
      System.Console.WriteLine();

      Copy.Type("we are now using your advanced algorithms to process your request", 10, true);
      Copy.Type("Processing . ", 50, false);
      Copy.Type(". . . . . . .", 500, true);
      Copy.Type("Completed...", 50, true);
      string test = Console.ReadLine();



    }



  }

}