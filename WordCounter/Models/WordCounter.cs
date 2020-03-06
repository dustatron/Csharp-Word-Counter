using System;
using System.Collections.Generic;

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
    public static string NormalizeSentence(string sentence)
    {
      string[] wordsArr = sentence.Split(' ');
      List<string> resultList = new List<string>(5);

      foreach (var word in wordsArr)
      {
        string wordString = "";
        foreach (var letter in word)
        {
          if (Array.IndexOf(_specialChar, letter) == -1)
          {
            wordString += letter;
          }
        }
        resultList.Add(wordString.ToLower());
      }
      string result = String.Join(" ", resultList.ToArray());
      return result;
    }
  }

}