using System;

namespace Word.Models
{
  //change name of class.
  public class Counter
  {
    private static char[] _specialChar = new Char[] {'!', '@', '#', '$', '^', '&', '*', '(', ')', '_', '-', '=', '+', ',', '.', '\\', '/', '`', '~', ':', ';', '{', '}', '[', ']', '|', '?', '<', '>' };
    //Change the name of the method.
    public static string Validate(string word)
    {
      //Remove special Characters
      string result = word.Trim(_specialChar);

      return result.ToLower();
    }
  }

}