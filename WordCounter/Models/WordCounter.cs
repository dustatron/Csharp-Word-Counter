using System;
using System.Collections.Generic;
using System.IO;

namespace Word.Models
{
  public class Counter
  {
    public static int MissSpelled { get; set; }
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
        string normalizedWord = NormalizeWord(word).ToLower();
        if (!ValidateWord(normalizedWord))
        {
          MissSpelled++;
        }
        resultList.Add(normalizedWord);
      }

      return String.Join(" ", resultList.ToArray());
    }

    //Checks if word is in wordlist.txt
    public static bool ValidateWord(string word)
    {
      string path = Path.Combine(Environment.CurrentDirectory);
      int debugInPath = path.IndexOf("Debug");
      string wordListPath = "../../../wordlist.txt";
      if (debugInPath == -1)
      {
        wordListPath = "wordlist.txt";
      }
      IEnumerable<String> wordList = File.ReadLines(wordListPath);

      foreach (var item in wordList)
      {
        if (item.ToLower() == word.ToLower())
        {
          return true;
        }
      }

      return false;

    }

    public static int ReturnCount(string sentence, string checkWord)
    {

      string cleanSentence = NormalizeSentence(sentence);
      string cleanWord = checkWord.ToLower();


      string[] sentenceArray = cleanSentence.Split(' ');
      int count = 0;
      foreach (string word in sentenceArray)
      {
        if (word == cleanWord)
        {
          count++;
        }
      }
      return count;
    }
  }

}