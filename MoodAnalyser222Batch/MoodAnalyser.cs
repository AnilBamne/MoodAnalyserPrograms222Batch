using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser222Batch
{
    public class MoodAnalyser
    {
        public string message;
        /// <summary>
        /// Taking mood message in constructor as parameter
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Taking Method with parameter.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string AnalyseMood()
        {
            if (message.ToLower().Contains("sad"))      //comparing
            {
                return "SAD";
            }
            else if (message.ToLower().Contains("Happy"))
            {
                return "HAPPY";
            }
            else
            {
                return "wrongInput";
            }
        }
    }
}
