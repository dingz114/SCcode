using System;
namespace Alarm_clock
{
    public class AlarmClock
    {
        public event Action Tick;
        public event Action Alarm;

        public void Start(int time)
        {
            for (int i = 0; i < time; i++)
            {
                System.Threading.Thread.Sleep(1000); // 每秒触发一次
                Tick?.Invoke();
            }
            Alarm?.Invoke();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 6;
            AlarmClock clock = new AlarmClock();
            clock.Tick += () => Console.WriteLine("Tick!");
            clock.Alarm += () => Console.WriteLine("Alarm!");
            clock.Start(time);
        }
    }
}
