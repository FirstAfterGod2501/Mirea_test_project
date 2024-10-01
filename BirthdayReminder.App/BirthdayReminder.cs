// File: BirthdayReminder/BirthdayReminderService.cs
namespace BirthdayReminder.App;


public class Friend
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }

    public Friend(string name, DateTime birthday)
    {
        Name = name;
        Birthday = birthday;
    }
}

public class BirthdayReminderService
{
    private readonly List<Friend> _friends = new List<Friend>();

    public void AddFriend(Friend friend)
    {
        _friends.Add(friend);
    }

    public List<Friend> GetFriendsWithBirthdayToday()
    {
        return _friends.Where(f => f.Birthday.Date == DateTime.Today).ToList();
    }
}