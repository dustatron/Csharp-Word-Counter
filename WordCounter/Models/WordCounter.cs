using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word.Models
{
  //change name of class.
  public class Counter
  {
    private static char[] _specialChar = new Char[] { '!', '@', '#', '$', '^', '&', '*', '(', ')', '_', '-', '=', '+', ',', '.', '\\', '/', '`', '~', ':', ';', '{', '}', '[', ']', '|', '?', '<', '>' };

    private static char[] _numbers = new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

    public static string NormalizeWord(string word)
    {
      //Remove special Characters
      string resultChar = word.Trim(_specialChar);
      //Remove Numbers
      string result = resultChar.Trim(_numbers);
      return result.ToLower();
    }
    public static string NormalizeSentence(string sentence, out int notWord)
    {
      string[] wordsArr = sentence.Split(' ');
      notWord = 0;
      List<string> resultList = new List<string>(5);

      foreach (var word in wordsArr)
      {
        string normalizedWord = NormalizeWord(word).ToLower();
        if (ValidateWord(normalizedWord))
        {
          resultList.Add(normalizedWord);
        }
        else
        {
          resultList.Add(normalizedWord);
          notWord++;
        }
      }

      return String.Join(" ", resultList.ToArray());
    }

    public static bool ValidateWord(string word)
    {
      string[] WordListPath = Directory.GetFiles("../../../../WordCounter/Models", "*.txt");
      IEnumerable<String> wordList = File.ReadLines(WordListPath[0]);

      foreach (var item in wordList)
      {
        if (item.ToLower() == word)
        {
          return true;
        }
      }

      return false;

    }
  }

}