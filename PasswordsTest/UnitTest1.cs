using NUnit.Framework;
using Passwords;
using System;
using System.Linq;

namespace Passwords.Tests
{
    [TestFixture]
    public class PasswordGeneratorTests
    {
        private PasswordGenerator _passwordGenerator;

        [SetUp]
        public void Setup()
        {
            _passwordGenerator = new PasswordGenerator();
        }

        [Test]
        public void GenerateRandomPassword_ShouldReturnPasswordOfCorrectLength()
        {
            int length = 10;
            string password = _passwordGenerator.GenerateRandomPassword(length);
            Assert.That(password.Length, Is.EqualTo(length));
        }

        [Test]
        public void GeneratePasswordWithSpecialChars_ShouldReturnPasswordOfCorrectLength()
        {
            int length = 10;
            string password = _passwordGenerator.GeneratePasswordWithSpecialChars(length);
            Assert.That(password.Length, Is.EqualTo(length));
        }

        [Test]
        public void GenerateNumericPassword_ShouldReturnPasswordOfCorrectLength()
        {
            int length = 10;
            string password = _passwordGenerator.GenerateNumericPassword(length);
            Assert.That(password.Length, Is.EqualTo(length));
            Assert.IsTrue(password.All(char.IsDigit));
        }

        [Test]
        public void GenerateAlphabeticPassword_ShouldReturnPasswordOfCorrectLength()
        {
            int length = 10;
            string password = _passwordGenerator.GenerateAlphabeticPassword(length);
            Assert.That(password.Length, Is.EqualTo(length));
            Assert.IsTrue(password.All(char.IsLetter));
        }

        [Test]
        public void GenerateCustomPassword_ShouldReturnPasswordOfCorrectLength()
        {
            int length = 10;
            string customChars = "ABC123";
            string password = _passwordGenerator.GenerateCustomPassword(length, customChars);
            Assert.That(password.Length, Is.EqualTo(length));
            Assert.IsTrue(password.All(c => customChars.Contains(c)));
        }
    }
}