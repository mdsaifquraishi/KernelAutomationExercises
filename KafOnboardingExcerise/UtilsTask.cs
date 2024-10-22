using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises
{
    public static class UtilsTask
    {

        public static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
        public static void Wait(Func<bool> condition, TimeSpan timeout)
        {
            DateTime endTime = DateTime.Now.Add(timeout);
            
                while (DateTime.Now < endTime)
                {
               
                    if (condition())
                    {
                        Console.WriteLine("Exception is not thrown");
                        return;
                    }                   
                }
            throw new TimeoutException("Timeout exception is thrown explicitly");
        }
    }
}
