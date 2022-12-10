using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser222Batch;

namespace MoodAnalyserTest
{
    /// <summary>
    /// Creating a test class
    /// </summary>
    [TestClass]
    [TestCategory("MoodAnalyser")]
    public class UnitTest1
    {
        /// <summary>
        /// Test method
        /// Refactor 1 : Taking mood message in constructor
        /// TC 1.1 :when - Iam in sad mood , then - retunr SAD
        /// </summary>
        [TestMethod]
        [TestCategory("MoodAnalyser")]//Refactor 1 -TC1.1
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
        [TestCategory("MoodAnalyser")]
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
        [TestCategory("Exception")]
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
        [TestCategory("Exception")]
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
        [TestCategory("Exception")]
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
        ///<summary>
        ///Reflection
        ///creating an instance of MoodAnalyserFactory class
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
        /// <summary>
        /// Reflection
        /// UC4- TC4.1 : When passed class name,check class name equals to object of reflected class(mood analyser factory)
        /// if both are equals - PASS
        /// </summary>
        
        [TestMethod]
        [TestCategory("Reflection")]
        [DataRow("MoodAnalyser222Batch.MoodAnalyser", "MoodAnalyser")] //TC 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        public void When_GivenClassInfo_Then_ReturnDefaultConstructor(string className, string constructorName)
        {
            MoodAnalyser expectedObj = new MoodAnalyser();
            object actualObj = moodAnalyserFactory.CreatingMoodAnalyserObject(className, constructorName);
            actualObj.Equals(expectedObj);   //comparing two objects ,if found Equal than test will be passed .
        }

        /// <summary>
        /// UC4- TC4.2 : When passed class name,check class name equals to object of reflected class(mood analyser factory)
        /// If class not matches --> Show No such class Error message(Using exception).
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        [TestMethod]
        [TestCategory("Reflection")]
        [DataRow("MoodAnalyser222Batch.MoodAnalyser", "MoodAnalyser")] //TC 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        public void When_GivenClassName_Then_Return_NoSuchClassError(string className, string constructorName)
        {
            MoodAnalyser expectedObj = new MoodAnalyser();
            object actualObj = moodAnalyserFactory.CreatingMoodAnalyserObject(className, constructorName);
            actualObj.Equals(expectedObj);   //comparing two objects ,if found Equal than test will be passed .
        }

        /// <summary>
        /// UC4- TC4.3 : When passed class name,check class name equals to object of reflected class(mood analyser factory)
        /// If parameters not matches --> Show No such Method Error message(Using exception).
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        [TestMethod]
        [TestCategory("Reflection")]
        [DataRow("MoodAnalyser222Batch.MoodAnalyser", "MoodAnalyser")] //TC 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
        public void When_GivenClassName_Then_Return_NoSuchMethodError(string className, string constructorName)
        {
            MoodAnalyser expectedObj = new MoodAnalyser();
            object actualObj = moodAnalyserFactory.CreatingMoodAnalyserObject(className, constructorName);
            actualObj.Equals(expectedObj);   //comparing two objects ,if found Equal than test will be passed .
        }
    }
}
