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
                if (message.Contains("Empty Mood"))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_EMPTY, "mood should not be Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalysisException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_EMPTY, "mood should not be Empty");
            }
        }
    }
}
