using System;

namespace Word.Models
{
  //change name of class.
  public class Counter
  {
    private static char[] _specialChar = new Char[] { '!', '@', '#', '$', '^', '&', '*', '(', ')', '_', '-', '=', '+', ',', '.', '\\', '/', '`', '~', ':', ';', '{', '}', '[', ']', '|', '?', '<', '>' };

    private static char[] _numbers = new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

    public static string Normalize(string word)
    {
      //Remove special Characters
      string resultChar = word.Trim(_specialChar);
      //Remove Numbers
      string result = resultChar.Trim(_numbers);
      return result.ToLower();
    }
  }

}