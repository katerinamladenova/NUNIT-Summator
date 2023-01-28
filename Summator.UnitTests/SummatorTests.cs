namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);
            var expected = -100;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }

        // [TestCase(new int[] {1, 2})]

        // public void Test_Summator_SumDDT
        //var actural = Summator.Sum(values);

        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void Empty_Array_Should_Throw_Argument_Exception()
        //{
           // var nums = new int[] {};
            //var actual = Summator.Sum(nums);
           // Assert.Throws<ArgumentException>(() => Summator.Sum(nums));
        //}



    }
}