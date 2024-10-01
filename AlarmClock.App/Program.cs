using System.Timers;
using Timer = System.Timers.Timer;

namespace AlarmClock.App;

public class AlarmClock
{
    private readonly Timer _timer;
    private readonly DateTime _alarmTime;
    private readonly Action _alarmAction;

    public AlarmClock(DateTime alarmTime, Action alarmAction)
    {
        _alarmTime = alarmTime;
        _alarmAction = alarmAction;
        _timer = new Timer(1000);
        _timer.Elapsed += CheckAlarm;
        _timer.Start();
    }

    private void CheckAlarm(object sender, ElapsedEventArgs e)
    {
        if (DateTime.Now < _alarmTime) return;
        _timer.Stop();
        _alarmAction.Invoke();
    }
}