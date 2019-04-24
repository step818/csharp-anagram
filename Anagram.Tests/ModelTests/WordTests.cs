using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetInputWord_ReturnInputWord_String()
    {
      //Arrange
      string inputWord = "bread";
      Word newWord = new Word(inputWord);
      //Act
      string result = newWord.GetInputWord();
      //Assert
      Assert.AreEqual(inputWord, result);
    }

    [TestMethod]
    public void SetInputWord_SetInputWord_String()
    {
      string inputWord = "bread";
      Word newWord = new Word(inputWord);
      string inputWordList = "bared";
      newWord.SetInputWord(inputWordList);
      string result = newWord.GetInputWord();
      Assert.AreEqual(inputWordList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_WordList()
    {
      List<Word> newList = new List<Word> { };
      List<Word> result = Word.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void IsAnagram_ReturnsTrue_True()
    {
      //Arrange
      string tempInputWord = "bread";
      string tempInputWordList = "beard";

      //Act
      CalculateAnagram myAnagram = new CalculateAnagram(tempInputWordList);

      //Assert
      Assert.AreEqual(true, myAnagram.IsAnagram(tempInputWord, tempInputWordList));
    }
  }
}
