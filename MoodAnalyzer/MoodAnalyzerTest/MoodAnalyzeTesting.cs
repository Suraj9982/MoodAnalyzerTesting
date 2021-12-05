using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in a Sad mood";
            AnalyzeMood mood = new AnalyzeMood(message);
            string result = mood.MoodAnalyzer();
            Assert.AreEqual(result, "SAD");
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in Happy mood";
            AnalyzeMood mood = new AnalyzeMood(message);
            string result = mood.MoodAnalyzer();
            Assert.AreEqual(result, "HAPPY");
        }
        [Test]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnInvalidMoodException()
        {
            try
            {
                string expected = "mood should not be null";
                string message = null;
                AnalyzeMood mood = new AnalyzeMood(message);
                string result = mood.MoodAnalyzer();
                Assert.AreEqual(expected, result);
            }
            catch(MoodAnalysisException e) 
            { 
                Assert.AreEqual("mood should not be null",e.Message);
            }
        }
        [Test]
        public void GivenEmptyMoodMessage_WhenAnalyze_ShouldReturnInvalidMoodException()
        {
            try
            {
                string expect = "mood should not be Empty";
                string message = "Empty Mood";
                AnalyzeMood mood = new AnalyzeMood(message);
                string result = mood.MoodAnalyzer();
                Assert.AreEqual(expect, result);
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual("mood should not be Empty", e.Message);
            }
        }
    }
}