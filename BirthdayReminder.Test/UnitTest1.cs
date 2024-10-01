using BirthdayReminder.App;

namespace BirthdayReminder.Test
{
    public class BirthdayReminderServiceTests
    {
        private BirthdayReminderService _service = null!;

        [SetUp]
        public void Setup()
        {
            _service = new BirthdayReminderService();
        }

        [Test]
        public void AddFriend_ShouldAddFriendToList()
        {
            var friend = new Friend("John Doe", new DateTime(1990, 1, 1));
            _service.AddFriend(friend);

            var friends = _service.GetFriendsWithBirthdayToday();
            Assert.IsEmpty(friends);
        }

        [Test]
        public void GetFriendsWithBirthdayToday_ShouldReturnFriendsWithTodayBirthday()
        {
            var today = DateTime.Today;
            var friend1 = new Friend("John Doe", today);
            var friend2 = new Friend("Jane Doe", today.AddDays(-1));

            _service.AddFriend(friend1);
            _service.AddFriend(friend2);

            var friends = _service.GetFriendsWithBirthdayToday();
            Assert.That(friends, Has.Count.EqualTo(1));
            Assert.That(friends[0].Name, Is.EqualTo("John Doe"));
        }
    }
}