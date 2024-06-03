using System;
using System.Reflection;
using System.Linq;

namespace AlgorithmCoding
{
    public abstract class KataBase
    {
        public abstract void Example();
    }

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("실행하고자 하는 문제의 Class Name을 적어주세요:");
            Console.Write("Q_");
            string problemClassName = Console.ReadLine();
            problemClassName = "Q_" + problemClassName;

            var testType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.IsSubclassOf(typeof(KataBase)) && t.Name == problemClassName);

            if (testType != null)
            {
                var instance = Activator.CreateInstance(testType) as KataBase;
                instance?.Example();
            }
            else
            {
                Console.WriteLine($"Problem class '{problemClassName}' not found.");
            }
        }
    }
}
