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
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in a Sad mood";
            AnalyzeMood mood = new AnalyzeMood(message);
            string result = mood.MoodAnalyzer();
            Assert.AreEqual(result, "SAD");
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in Happy mood";
            AnalyzeMood mood = new AnalyzeMood(message);
            string result = mood.MoodAnalyzer();
            Assert.AreEqual(result, "HAPPY");
        }
    }
}