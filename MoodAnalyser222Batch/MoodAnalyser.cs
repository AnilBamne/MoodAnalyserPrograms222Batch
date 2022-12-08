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
            }
        }
    }
}
