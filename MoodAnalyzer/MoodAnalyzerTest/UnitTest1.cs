using MoodAnalyzer;
using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
       AnalyzeMood mood;
       [SetUp]
        public void Setup()
        {
            this.mood = new AnalyzeMood();
        }

        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnSad()
        {
            string message = "I am in a Sad mood";
            string result = mood.MoodAnalyzer(message);
            Assert.AreEqual(result, "SAD");
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyze_ShouldReturnHappy()
        {
            string message = "I am in Any mood";
            string result = mood.MoodAnalyzer(message);
            Assert.AreEqual(result, "HAPPY");
        }
    }
}