using MSTestMoodAnalyser;
using MSTestMoodAnalyser237;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        [TestMethod]
        [DataRow("I am in Sad Mood", "SAD")]     //TC 1.1    Given "I am in Sad Mood" should return "SAD" .
        public void Return_Sad_Mood_ByMethod(string message, string expected)
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            //Act
            string actualOutput = moodAnalyser.AnalyseMood(message);

            //Assert
            Assert.AreEqual(actualOutput, expected);
        }
        [TestMethod]
        [DataRow("I am in Any Mood", "HAPPY")]     //TC 1.2    Given "I am in Any Mood" should return "HAPPY" .
        public void Return_Happy_Mood_ByMethod(string message, string expected)
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            //Act
            string actualOutput = moodAnalyser.AnalyseMood(message);

            //Assert
            Assert.AreEqual(actualOutput, expected);
        }
        [TestMethod]
        [DataRow("I am in Sad Mood", "SAD")] //After Refactor Repeating TC 1.1, Given "I am in Sad Mood" should return "SAD" .
        public void ViaConstructor_ReturnSad(string message, string expected)
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);//message passed via constructor

            //Act
            string actualOutput = moodAnalyser.AnalyseMood();//message not passed via parameterised method.

            //Assert
            Assert.AreEqual(actualOutput, expected);
        }
        [TestMethod]
        [DataRow("I am in Any Mood", "HAPPY")] //After Refactor Repeating TC 1.2, Given "I am in Any Mood" should return "HAPPY" .
        public void ViaConstructor_ReturnHappy(string message, string expected)
        {
            //Arrange
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);//message passed via constructor

            //Act
            string actualOutput = moodAnalyser.AnalyseMood();//message not passed via parameterised method.

            //Assert
            Assert.AreEqual(actualOutput, expected);
        }
    }
}