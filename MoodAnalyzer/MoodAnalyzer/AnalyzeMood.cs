﻿using System;

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
                if (this.message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.ENTERED_NULL, "Message should not be null");
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
            catch(NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}
