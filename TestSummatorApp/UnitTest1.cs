using ConsoleAppSummator;

namespace TestSummatorApp
{
    public class SummatorTests
    {
   
        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2, };
            var actual = Summator.Sum (nums);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
       
        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -50, };
            var actual = Summator.Sum(nums);
            var expected = -51;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumOnePositiveNumber()
        {
            var nums = new int[] { 15, };
            var actual = Summator.Sum(nums);
            var expected = 15;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumOnePositiveAndOneNegativeNumber()
        {
            var nums = new int[] {-10,10 };
            var actual = Summator.Sum(nums);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_SumOneNegativeNumber()
        {
            var nums = new int[] { -10 };
            var actual = Summator.Sum(nums);
            var expected = -10;

            Assert.AreEqual(expected, actual);
        }
    }
}

