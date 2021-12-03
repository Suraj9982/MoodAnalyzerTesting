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
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_NULL,"Message ssshould not be null");
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_EMPTY, "Message ssshould not be empty");
            }
        }
    }
}
