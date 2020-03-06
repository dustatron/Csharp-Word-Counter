using System;

namespace Word.Models
{
  //change name of class.
  public class Counter
  {
    private static char[] _specialChar = new Char[] { '!', '@', '#', '$', '^', '&', '*', '(', ')', '_', '-', '=', '+', ',', '.', '\\', '/', '`', '~', ':', ';', '{', '}', '[', ']', '|', '?', '<', '>' };

    private static char[] _numbers = new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

    public static string Validate(string word)
    {
      //Remove special Characters
      string result = word.Trim(_specialChar);

      return result.ToLower();
    }
  }

}