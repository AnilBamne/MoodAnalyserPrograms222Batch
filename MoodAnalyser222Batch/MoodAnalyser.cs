using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser222Batch
{
    public class MoodAnalyser
    {
        private string message;
        /// <summary>
        /// Taking mood message in constructor as parameter
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public MoodAnalyser()
        {

        }
        /// <summary>
        /// Taking Method with parameter.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string AnalyseMood()
        {
            try
            {
                //checking if msg passed is empty or not
                if (message.Equals(string.Empty))                       //UC3 - TC 3.2
                {
                    //thows Exception If Empty Value
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (message.ToLower().Contains("sad"))      //comparing
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch                 //UC2 : Handling exception when given Null Mood 
            {
                return "HAPPY";
                //thows Exception If Null Value
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood Should not be null");            //UC3 - TC 3.1
            }
        }
    }
}
