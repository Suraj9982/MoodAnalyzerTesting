using System;

namespace MoodAnalyzer
{
    public class AnalyzeMood
    {
        public string MoodAnalyzer(string message)
        {
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
