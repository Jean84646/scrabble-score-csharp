using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class ScrabbleScore
  {
    private string inputWord;
    private Dictionary<int, char[]> dictionaryScrabble = new Dictionary<int,  char[]>() {
      {1, new char[] {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'}},
      {2, new char[] {'D', 'G'}},
      {3, new char[] {'B', 'C', 'M', 'P'}},
      {4, new char[] {'F', 'H', 'V', 'W', 'Y'}},
      {5, new char[] {'K'}},
      {8, new char[] {'J', 'X'}},
      {10, new char[] {'Q', 'Z'}} };

    public ScrabbleScore(string enterWord)
    {
      inputWord = enterWord;
    }
    public string GetWord()
    {
      return inputWord;
    }
    public int ScoreCalculator()
    {
      int score = 0;
      for(int i = 0; i < inputWord.Length; i++)
      {
        foreach(KeyValuePair<int, char[]> entry in dictionaryScrabble)
        {
          int position = Array.IndexOf(entry.Value, char.ToUpper(inputWord[i]));
          if(position > -1)
          {
            score += entry.Key;
          }
        }
      }
      return score;
    }
  }

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your scrabble word.");
      string scrabbleWord = Console.ReadLine();
      ScrabbleScore wordScore = new ScrabbleScore(scrabbleWord);
      int score = wordScore.ScoreCalculator();
      Console.WriteLine("Your scrabble word score is " + score);
    }
  }

}
