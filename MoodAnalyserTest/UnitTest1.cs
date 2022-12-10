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
        /// <summary>
        /// UC2 --> TC2.1 : Given Null Mood should return Happy
        /// Handling null refrence exception
        /// </summary>
        [TestMethod]
        [DataRow(null)]
        public void Given_WhenNullMood_ThenReturn_HAPPY(string message)
        {
            //AAA- Arrange-Act-Assert
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Arrange
            string expected = "HAPPY";
            //Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            //Using Assert class for testing
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC3 - TC 3.1 when givem null input , inform user with exception
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow(null)]     
        public void Given_WhenNullMood_ThenReturn_InformUser(string message)
        {
            //AAA- Arrange-Act-Assert
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Arrange
            string expected = "HAPPY";
            //Act
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            //Using Assert class for testing
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC3 - TC 3.2 when givem empty input , throw exception , show exception message
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        [DataRow("")]
        public void Given_WhenEmptyMood_ThenReturn_ThrowExceptionMessage(string message)
        {
            //AAA- Arrange-Act-Assert
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
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
