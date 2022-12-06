using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser222Batch;

namespace MoodAnalyserTest
{
    /// <summary>
    /// Creating a test class
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test method
        /// Refactor 1 : Taking mood message in constructor
        /// TC 1.1 :when - Iam in sad mood , then - retunr SAD
        /// </summary>
        [TestMethod]                                            //Refactor 1 -TC1.1
        public void Given_WhenSadMood_ThenReturn_SAD()
        {
            //AAA- Arrange-Act-Assert
            MoodAnalyser moodAnalyser = new MoodAnalyser("Iam in Sad mood");
            //Arrange
            string expected = "SAD";
            //Act
            string actual=moodAnalyser.AnalyseMood();
            //Assert
            //Using Assert class for testing
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 1.1 : When - Iam in Any mood Then - return Happy
        /// </summary>
        [TestMethod]                                            //Refactor 1-TC1.2
        public void Given_WhenAnyMood_ThenReturn_HAPPY()
        {
            //AAA- Arrange-Act-Assert
            MoodAnalyser moodAnalyser = new MoodAnalyser("Iam in Happy mood");
            //Arrange
            string expected = "HAPPY";
            //Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            //Using Assert class for testing
            Assert.AreEqual(expected, actual);
        }
    }
}
