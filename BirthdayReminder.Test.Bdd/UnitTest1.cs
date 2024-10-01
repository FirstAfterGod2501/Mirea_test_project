using BirthdayReminder.App;

namespace BirthdayReminder.Test.Bdd;

[TestFixture]
public class BirthdayReminderServiceBddTests
{
    private BirthdayReminderService _service = null!;
    private Friend _friendWithBirthdayToday = null!;
    private Friend _friendWithBirthdayTomorrow = null!;

    [SetUp]
    public void Setup()
    {
        _service = new BirthdayReminderService();
        _friendWithBirthdayToday = new Friend("John Doe", DateTime.Today);
        _friendWithBirthdayTomorrow = new Friend("Jane Doe", DateTime.Today.AddDays(1));
    }

    [Test]
    public void GivenAFriend_WhenAddedToService_ThenTheyShouldBeInTheList()
    {
        // Given
        var friend = new Friend("John Doe", new DateTime(1990, 1, 1));

        // When
        _service.AddFriend(friend);

        // Then
        var friends = _service.GetFriendsWithBirthdayToday();
        Assert.IsEmpty(friends);
    }

    [Test]
    public void GivenAFriendWithBirthdayToday_WhenChecked_ThenTheyShouldBeReturned()
    {
        // Given
        _service.AddFriend(_friendWithBirthdayToday);

        // When
        var friends = _service.GetFriendsWithBirthdayToday();

        // Then
        Assert.That(friends, Has.Count.EqualTo(1));
        Assert.That(friends[0].Name, Is.EqualTo(_friendWithBirthdayToday.Name));
    }

    [Test]
    public void GivenAFriendWithBirthdayTomorrow_WhenChecked_ThenTheyShouldNotBeReturned()
    {
        // Given
        _service.AddFriend(_friendWithBirthdayTomorrow);

        // When
        var friends = _service.GetFriendsWithBirthdayToday();

        // Then
        Assert.IsEmpty(friends);
    }

    [Test]
    public void GivenMultipleFriends_WhenChecked_ThenOnlyFriendsWithBirthdayTodayShouldBeReturned()
    {
        // Given
        _service.AddFriend(_friendWithBirthdayToday);
        _service.AddFriend(_friendWithBirthdayTomorrow);

        // When
        var friends = _service.GetFriendsWithBirthdayToday();

        // Then
        Assert.That(friends, Has.Count.EqualTo(1));
        Assert.That(friends[0].Name, Is.EqualTo(_friendWithBirthdayToday.Name));
    }
}