using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word.Models;
using System;

namespace Word.Tests
{

  [TestClass]
  public class CounterTests
  {
    //--------------   Normalize word --------------- \\

    [TestMethod] //1
    public void NormalizeWord_ReturnNormalizedWord_ReturnObject()
    {
      string testWord = "Friend!";
      string goodResult = "friend";
      Assert.AreEqual(goodResult, Counter.NormalizeWord(testWord));
    }

    [TestMethod] //2
    public void NormalizeWord_ReturStringWithoutNumbers_ReturnObject()
    {
      string testWord = "Friend8";
      string goodResult = "friend";
      Assert.AreEqual(goodResult, Counter.NormalizeWord(testWord));
    }

    //--------------   Normalize Sentence --------------- \\
    [TestMethod] //3
    public void NormalizeSentence_ReturnSentenceLowerCase_ReturnObject()
    {
      string testSentence = "Thank you for being a friend";
      string goodResult = "thank you for being a friend";
      Assert.AreEqual(goodResult, Counter.NormalizeSentence(testSentence));
    }

    [TestMethod] //4
    public void NormalizeSentence_RemoveSpecialCharacters_ReturnObject()
    {
      string testSentence = "<>Thank #you @for being a friend!?|";
      string goodResult = "thank you for being a friend";
      Assert.AreEqual(goodResult, Counter.NormalizeSentence(testSentence));
    }
    //--------------   Validate is english word  --------------- \\
    [TestMethod] //5
    public void ValidateWord_CheckWordInDictionary_True()
    {
      string testWord = "cat";
      Assert.IsTrue(Counter.ValidateWord(testWord), "Validate word returned False");
    }
  }
}