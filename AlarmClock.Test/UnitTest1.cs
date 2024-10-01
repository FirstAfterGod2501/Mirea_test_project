namespace AlarmClock.Test;

[TestFixture]
public class AlarmClockTests
{
    private bool _alarmTriggered;

    [SetUp]
    public void SetUp()
    {
        _alarmTriggered = false;
    }

    [Test]
    public void AlarmClock_ShouldTriggerAlarmAtSpecifiedTime()
    {
        var alarmTime = DateTime.Now.AddSeconds(2);

        var alarmClock = new App.AlarmClock(alarmTime, () => _alarmTriggered = true);

        Thread.Sleep(3000);

        Assert.That(_alarmTriggered, Is.True);
    }
}