using TechTalk.SpecFlow;

[Binding]
public class AlarmClockSteps
{
    private DateTime _currentTime;
    private DateTime _alarmTime;
    private bool _alarmTriggered;

    [Given(@"the current time is now")]
    public void GivenTheCurrentTimeIsNow()
    {
        _currentTime = DateTime.Now;
    }

    [When(@"I set the alarm to (.*) seconds from now")]
    public void WhenISetTheAlarmToSecondsFromNow(int seconds)
    {
        _alarmTime = _currentTime.AddSeconds(seconds);
        var alarmClock = new AlarmClock.App.AlarmClock(_alarmTime, () => _alarmTriggered = true);
    }

    [Then(@"the alarm should trigger")]
    public void ThenTheAlarmShouldTrigger()
    {
        Thread.Sleep(3000);
        Assert.That(_alarmTriggered, Is.True);
    }
}