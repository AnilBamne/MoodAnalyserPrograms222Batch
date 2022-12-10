using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser222Batch
{
    public class MoodAnalyserFactory
    {
        //UC4 CreatingMoodAnalyserObject() to get Object of MoodAnalyser class .
        public object CreatingMoodAnalyserObject(string className, string constructorName)
        {
            string pattern = "." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executingAssembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = executingAssembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (Exception)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS,"No Such Class");
                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.CONSTRUCTOR_NOT_FOUND,"No Such Method");
            }
        }
        public static object CreateMoodAnalyzerUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructorInfo.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHODE, "Constructor is Not Found");
                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
    }
}
