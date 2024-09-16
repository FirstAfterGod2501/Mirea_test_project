using Strings;

namespace StringsTest
{
    [TestFixture]
    public class StringOperationsTests
    {
        private StringOperations _stringOperations;

        [SetUp]
        public void Setup()
        {
            _stringOperations = new StringOperations();
        }

        [Test]
        public void ReverseString_InputIsHello_ReturnsOlleh()
        {
            string result = _stringOperations.ReverseString("Hello");
            Assert.That(result, Is.EqualTo("olleH"));
        }

        [Test]
        public void CountWords_InputIsHelloWorld_Returns2()
        {
            int result = _stringOperations.CountWords("Hello World");
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void ToUpperCase_InputIsHello_ReturnsHELLO()
        {
            string result = _stringOperations.ToUpperCase("Hello");
            Assert.That(result, Is.EqualTo("HELLO"));
        }

        [Test]
        public void ToLowerCase_InputIsHELLO_ReturnsHello()
        {
            string result = _stringOperations.ToLowerCase("HELLO");
            Assert.That(result, Is.EqualTo("hello"));
        }

        [Test]
        public void IsPalindrome_InputIsRacecar_ReturnsTrue()
        {
            bool result = _stringOperations.IsPalindrome("Racecar");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_InputIsHello_ReturnsFalse()
        {
            bool result = _stringOperations.IsPalindrome("Hello");
            Assert.IsFalse(result);
        }
    }
}