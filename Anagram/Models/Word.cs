using System;
using System.Collections.Generic;


namespace Anagram.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello, please enter a WORD: ");
      string inputWord = Console.ReadLine();

      List<string> newList = new List<string> {};
      List<string> anagramList = new List<string> {};

      Console.WriteLine("Enter another word to see if it is an anagram: ");
      string inputWordList = Console.Readline();

  
      Console.WriteLine("Would you like to add another word: (Y/N)");
      string answer = Console.Readline();
      if (answer == "Y")
      {
        while (answer == "Y")
        {
          Console.WriteLine("Enter another word to see if it is an anagram: ");
          string inputWordList = Console.Readline();
          newList.Add(inputWordList);
          Console.WriteLine("Would you like to add another word: (Y/N)");
          string answer = Console.Readline();
        }
      }
      else if (answer == "N")
      {
        Console.WriteLine("The list is done adding your words");
      }



    }
  }

  public class CalculateAnagram
  {
    public bool IsAnagram()
    {

    }

  }









  public class Word
  {
    private string _inputWord;

    public Word (string inputWord)
    {
      _inputWord = inputWord;
    }
    public string GetInputWord()
    {
      return _inputWord;
    }

    public void SetInputWord(string newInputWord)
    {
      _inputWord = newInputWord;
    }
    public static List<Word> GetAll()
    {
      return new List<Word> {};
    }
  }
}
