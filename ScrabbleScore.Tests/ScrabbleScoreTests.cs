using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleScoreTest
  {
    [TestMethod]
    public void GetWord_ReturnWord()
    {
      //Arrange
      string word = "pig";
      ScrabbleScore wordScore = new ScrabbleScore(word);
      //Act
      string expectedResult = wordScore.GetWord();
      //Assert
      Assert.AreEqual(word, expectedResult);
    }
    [TestMethod]
    public void ScoreCalculator_ReturnScore()
    {
      //Arrange
      string word = "pig";
      int score = 6;
      ScrabbleScore wordScore = new ScrabbleScore(word);
      //Act
      int expectedResult = wordScore.ScoreCalculator();
      //Assert
      Assert.AreEqual(score, expectedResult);
    }
  }


}
