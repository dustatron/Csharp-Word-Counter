using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word.Models;
using System;

namespace Word.Tests
{

  [TestClass]
  public class CounterTests
  {
    //--------------   Normalize
    [TestMethod]
    public void NormalizeWord_ReturnNormalizedWord_ReturnObject()
    {
      string testWord = "Friend!";
      string goodResult = "friend";
      Assert.AreEqual(goodResult, Counter.NormalizeWord(testWord));
    }
    [TestMethod]
    public void NormalizeWord_ReturStringWithoutNumbers_ReturnObject()
    {
      string testWord = "Friend8";
      string goodResult = "friend";
      Assert.AreEqual(goodResult, Counter.NormalizeWord(testWord));
    }
    [TestMethod]
    public void NormalizeSentence_ReturnSentenceLowerCase_ReturnObject()
    {
      string testSentence = "Thank you for being a friend";
      string goodResult = "thank you for being a friend";
      Assert.AreEqual(goodResult, Counter.NormalizeSentence(testSentence));
    }

  }
}