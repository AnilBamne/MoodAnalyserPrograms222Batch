using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser222Batch
{
    public class MoodAnalyser
    {
        /// <summary>
        /// Taking Method with parameter.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string AnalyseMood(string message)
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
    }
}
