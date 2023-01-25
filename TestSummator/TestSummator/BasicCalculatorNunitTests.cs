using ConsoleAppSummator;

namespace SummatorTests
{
    public class BasicCalculatorNunitTests
    {
            [Test]
        public void Test_Calculator_SumTwoPositiveNumbers()
        {
            var nums = new int[] {2,3};
            var actual = Summator.Sum(nums);
            var expeted = 5;
            Assert.AreEqual(actual,expeted);
        }

        [Test]
        public void Test_Calculator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -10, -100 };
            var actual = Summator.Sum(nums);
            var expeted = -110;
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_SumOneNegativeAndOnePositiveNumber()
        {
            var nums = new int[] { -10, 10 };
            var actual = Summator.Sum(nums);
            var expeted = 0;
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_GetAverageFromTwoPositiveNumbers()
        {
            var nums = new int[] { 50, 100 };
            var actual = Summator.Average(nums);
            var expeted = 75;
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_GetAverageOneNegativeAndOnePositiveNumber()
        {
            var nums = new int[] { -50, 100 };
            var actual = Summator.Average(nums);
            var expeted = 25;
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_MultiplyTwoPositiveNumbers()
        {
            var nums = new int[] { 2, 100 };
            var actual = Summator.Multiply(nums);
            var expeted = 200;
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_MultiplyOnePositiveAndOneNegativeNumbers()
        {
            var nums = new int[] { 2, -10 };
            var actual = Summator.Multiply(nums);
            var expeted = -20;
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_devideOnePositiveAndOneNegativeNumbers()
        {
            var nums = new int[] { -100, 10 };
            var actual = Summator.Devide(nums);
            var expeted = -10;
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_DevideTwoPositiveNumbers()
        {
            var nums = new int[] { 1000, 10 };
            var actual = Summator.Devide(nums);
            var expeted = 100;
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_SubstrackTwoPositiveNumber()
        {
            var nums = new int[] { 15, 10 };
            var actual = Summator.susbtruction(nums);
            var expected = 5;
               Assert.AreEqual(actual,expected);
        }
        [Test]
        public void Test_Calculator_SubstrackTwoNegativeNumbers()
        {
            var nums =  new int[] { -15, -10 };
            var actual = Summator.susbtruction(nums);
            var expected = -5;
            Assert.AreEqual(actual,expected);

        }
    }
}
