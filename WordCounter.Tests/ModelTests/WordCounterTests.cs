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
      int notWords;
      Assert.AreEqual(goodResult, Counter.NormalizeSentence(testSentence, out notWords));
    }

    [TestMethod] //4
    public void NormalizeSentence_RemoveSpecialCharacters_ReturnObject()
    {
      string testSentence = "<>Thank you @for being a friend!?|";
      string goodResult = "thank you for being a friend";
      int notWords;
      Assert.AreEqual(goodResult, Counter.NormalizeSentence(testSentence, out notWords));
    }
    [TestMethod] //4
    public void NormalizeSentence_ReturnsHowManyNonWordsFound_ReturnObject()
    {
      string testSentence = "Thank you for being a WalMart SafeWay COVIDNinteen friend";
      int goodResult = 3;
      int notWords;
      string Sentence = Counter.NormalizeSentence(testSentence, out notWords);
      Assert.AreEqual(goodResult, notWords);
    }
    //--------------   Validate is english word  --------------- \\
    [TestMethod] //5
    public void ValidateWord_CheckWordInDictionary_True()
    {
      string testWord = "cat";
      Assert.IsTrue(Counter.ValidateWord(testWord), "Validate word returned False");
    }
    [TestMethod] //5
    public void ValidateWord_CheckWordAMAZINGInDictionary_True()
    {
      string testWord = "AMAZING";
      Assert.IsTrue(Counter.ValidateWord(testWord), "Validate word AMAZING returned False");
    }

    //--------------   Return Count  --------------- \\
    [TestMethod]
    public void ReturnCount_ReturnNumberOfTimesWordFoundInSentence_Int()
    {
      string word = "you";
      string testSentence = @"Thank you for being a friend. 
                              Thank you for being a friend.
                              Traveled down a road and back again
                              Your heart is true, you're a pal and a confidant
                              I'm not ashamed to say
                              I hope it always will stay this way
                              My hat is off, won't you stand up and take a bow
                              And if you threw a party
                              Invited everyone you knew
                              Well, you would see the biggest gift would be from me
                              And the card attached would say
                              Thank you for being a friend
                              Thank you for being a friend
                              Thank you for being a friend
                              Thank you for being a friend";

      int goodCount = 10;
      int result = Counter.ReturnCount(testSentence, word);

      Assert.AreEqual(goodCount, result);

    }

    [TestMethod]
    public void ReturnCount_ReturnNumberOfTimesWordFoundInSentenceWithOtherWordOption_Int()
    {
      string word = "Walmart";
      string testSentence = @"If it's a car you lack
                              I'd surely buy you a Cadillac
                              Whatever you need any time of the day or night
                              I'm not ashamed to say
                              I hope it always will stay this way
                              My hat is off, won't you stand up and take a bow
                              And when we both get older
                              With walking canes and hair of gray
                              Have no fear even… Walmart";

      int goodCount = 1;
      int result = Counter.ReturnCount(testSentence, word);

      Assert.AreEqual(goodCount, result);

    }
  }
}