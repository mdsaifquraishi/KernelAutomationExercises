using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafOnboardingExcerises
{
    [TestFixture]
    public class NunitExerciseTest
    {
        [TestCase(0, 0, 0)]
        public void Sum_TwoNumbers_ReturnsExpectedResult(int a, int b, int expected)
        {
            int result = 0;
            Assert.AreEqual(expected, result);
        }

    }
}
