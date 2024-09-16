namespace CalendarTest
{
    [TestFixture]
    public class CalendarTests
    {
        private Calendar.Calendar _calendar;

        [SetUp]
        public void Setup()
        {
            _calendar = new Calendar.Calendar();
        }

        [Test]
        public void GetCurrentDate_ShouldReturnCurrentDate()
        {
            DateTime result = _calendar.GetCurrentDate();
            Assert.That(result.Date, Is.EqualTo(DateTime.Now.Date));
        }

        [Test]
        public void GetDayOfWeek_ShouldReturnCorrectDayOfWeek()
        {
            DateTime date = new DateTime(2023, 10, 1);
            string result = _calendar.GetDayOfWeek(date);
            Assert.That(result, Is.EqualTo("Sunday"));
        }

        [Test]
        public void GetDaysInMonth_ShouldReturnCorrectDays()
        {
            int result = _calendar.GetDaysInMonth(2023, 10);
            Assert.That(result, Is.EqualTo(31));
        }

        [Test]
        public void AddDaysToDate_ShouldReturnCorrectDate()
        {
            DateTime date = new DateTime(2023, 10, 1);
            DateTime result = _calendar.AddDaysToDate(date, 10);
            Assert.That(result, Is.EqualTo(new DateTime(2023, 10, 11)));
        }

        [Test]
        public void IsLeapYear_ShouldReturnTrueForLeapYear()
        {
            bool result = _calendar.IsLeapYear(2024);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsLeapYear_ShouldReturnFalseForNonLeapYear()
        {
            bool result = _calendar.IsLeapYear(2023);
            Assert.IsFalse(result);
        }
    }
}