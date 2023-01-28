using NuGet.Frameworks;

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
            var nums = new int[] {};
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
        
       //[Test]
       // public void Empty_Array_Should_Throw_Argument_Exception()
      // {
          //  var nums = new int[] {};
          //  var actual = Summator.Sum(nums);
           // Assert.Throws<ArgumentException>(() => Summator.Sum(nums));
       //}

        [Test]
        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 20000000, 20000000, 20000000 };
            var actual = Summator.Sum(nums);
            var expected = 60000000;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Summator_SumThreePositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 1, 2, 3 };
            var expected = 6;

            //Act
            var actual = Summator.Sum(nums);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Assertion_Examples()
        {
            Assert.That(9 == 9);
            Assert.That(9, Is.GreaterThan(8));
            double percentage = 11.11;
            Assert.That(percentage, Is.InRange(11, 11.13));
            Assert.That("This is test", Does.Contain ("test"));

            Assert.That(() => "test"[45], Throws.TypeOf<IndexOutOfRangeException>());
            Assert.That(() => "test"[45], Throws.InstanceOf<Exception>());

            var percentages = new int[] { 10, 20, 30, 40 };
            Assert.That(percentages, Is.All.InRange(9, 41));


        }

    }
}