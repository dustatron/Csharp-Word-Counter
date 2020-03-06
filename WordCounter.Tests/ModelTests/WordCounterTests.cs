using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word.Models;
using System;

namespace Word.Tests
{
  
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void Validate_ReturnNormalizedWord_ReturnObject()
    {
      string testWord = "Friend!";
      string goodResult = "friend";
      Assert.AreEqual(goodResult, Counter.Validate(testWord));
    }

  }
}