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
        /// when given sad mood , retunr SAD
        /// </summary>
        [TestMethod]
        public void Given_WhenSadMood_ThenReturn_SAD()
        {
            //AAA- Arrange-Act-Assert
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            //Arrange
            string message = "Iam in Sad mood";
            string expected = "SAD";
            //Act
            string actual=moodAnalyser.AnalyseMood(message);
            //Assert
            //Using Assert class for testing
            Assert.AreEqual(expected, actual);
        }
    }
}
