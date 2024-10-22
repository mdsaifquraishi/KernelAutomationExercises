using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises
{
    public static class StringExtension
    {
        public static int CountNumberOfLinesInString(this string str)
        {
            return str.Split(Environment.NewLine).Length;
        }
    }
}
