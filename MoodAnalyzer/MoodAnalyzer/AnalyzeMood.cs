using System;

namespace MoodAnalyzer
{
    public class AnalyzeMood
    {
        string message;
        public AnalyzeMood()
        {

        }
        public AnalyzeMood(string message)
        {
            this.message = message;
        }
        public string MoodAnalyzer()
        {
            try
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
            catch
            {
                return "HAPPY";
            }
        }
    }
}
