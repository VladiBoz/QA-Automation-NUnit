using ConsoleAppSummator;

namespace ConsoleAppCalculatorTests
{
    public class BasicCalculatorNunitTests
    {
            [Test]
        public void Test_Calculator_SumTwoPositiveNumbers()
        {
            //Arrange
            var nums = new int[] {2,3};
            //Act
            var actual = Summator.Sum(nums);
            var expeted = 5;
            //Assert
            Assert.AreEqual(actual,expeted);
        }

        [Test]
        public void Test_Calculator_SumTwoNegativeNumbers()
        {
            //Arrange
            var nums = new int[] { -10, -100 };
            //Act
            var actual = Summator.Sum(nums);
            var expeted = -110;
            //Assert
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_SumOneNegativeAndOnePositiveNumber()
        {
            //Arrange
            var nums = new int[] { -10, 10 };
            //Act
            var actual = Summator.Sum(nums);
            var expeted = 0;
            //Assert
            Assert.AreEqual(actual, expeted);
        }
      
        [Test]
        public void Test_Calculator_GetAverageFromTwoPositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 50, 100 };
            //Act
            var actual = Summator.Average(nums);
            var expeted = 75;
            //Assert
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_GetAverageOneNegativeAndOnePositiveNumber()
        {
            //Arrange
            var nums = new int[] { -50, 100 };
            //Act
            var actual = Summator.Average(nums);
            var expeted = 25;
            //Assert
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_MultiplyTwoPositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 2, 100 };
            //Act
            var actual = Summator.Multiply(nums);
            var expeted = 200;
            //Assert
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_MultiplyOnePositiveAndOneNegativeNumbers()
        {
            //Arrange
            var nums = new int[] { 2, -10 };
            //Act
            var actual = Summator.Multiply(nums);
            var expeted = -20;
            //Assert
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_devideOnePositiveAndOneNegativeNumbers()
        {
            //Arrange
            var nums = new int[] { -100, 10 };
            //Act
            var actual = Summator.Devide(nums);
            var expeted = -10;
            //Assert
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_DevideTwoPositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 1000, 10 };
            //Act
            var actual = Summator.Devide(nums);
            var expeted = 100;
            //Assert
            Assert.AreEqual(actual, expeted);
        }
        [Test]
        public void Test_Calculator_SubstrackTwoPositiveNumber()
        {
            //Arrange
            var nums = new int[] { 15, 10 };
            //Act
            var actual = Summator.susbtruction(nums);
            var expected = 5;
            //Assert
            Assert.AreEqual(actual,expected);
        }
        [Test]
        public void Test_Calculator_SubstrackTwoNegativeNumbers()
        {
            //Arrange
            var nums =  new int[] { -15, -10 };
            //Act
            var actual = Summator.susbtruction(nums);
            var expected = -5;
            //Assert
            Assert.AreEqual(actual,expected);

        }
    }
}
