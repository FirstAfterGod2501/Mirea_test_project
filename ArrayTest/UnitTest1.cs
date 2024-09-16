using Arrays;

namespace ArrayTest
{
    [TestFixture]
    public class ArrayOperationsTests
    {
        private ArrayOperations _arrayOps;

        [SetUp]
        public void Setup()
        {
            _arrayOps = new ArrayOperations();
        }

        [Test]
        public void ReverseArray_ShouldReverseArray()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 5, 4, 3, 2, 1 };

            int[] result = _arrayOps.ReverseArray(array);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FindMax_ShouldReturnMaxValue()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int expected = 5;

            int result = _arrayOps.FindMax(array);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FindMin_ShouldReturnMinValue()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int expected = 1;

            int result = _arrayOps.FindMin(array);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CalculateAverage_ShouldReturnAverageValue()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            double expected = 3.0;

            double result = _arrayOps.CalculateAverage(array);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SortArray_ShouldSortArray()
        {
            int[] array = { 5, 3, 1, 4, 2 };
            int[] expected = { 1, 2, 3, 4, 5 };

            int[] result = _arrayOps.SortArray(array);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}