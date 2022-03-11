using System;
using System.Threading;

namespace Homework04
{
    // 参数类型
    public class TAEvenArgs : EventArgs
    {
        public int Minute;
        public int Second;
        public int Hour;
        public string Message;
    } 
    
    public class TickEventArgs : TAEvenArgs
    {
        public TickEventArgs()
        {
            Message = "Tick";
        }
    }

    // 参数类型
    public class AlarmEventArgs : TAEvenArgs
    {
        public AlarmEventArgs()
        {
            Message = "Alarm!";
        }
    }

    // 委托
    public delegate void TickEventHandler(object sender, TickEventArgs args);

    // 委托
    public delegate void AlarmEventHandler(object sender, AlarmEventArgs args);

    public class Clock
    {
        // 事件
        public event TickEventHandler Tick;
        public event AlarmEventHandler Alarm;
        
        public int Second { get; }
        public int Minute { get; }
        public int Hour { get; }

        public Clock(int hour, int minute, int second)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
        }

        public void Start()
        {
            int second = 0;
            int minute = 0;
            int hour = 0;
            if (Second < 0 || Second >= 60 || Minute < 0 || Minute >= 60 || Hour < 0 || Hour >= 12)
            {
                throw new ArgumentException("参数错误");
            }
            else
            {
                while (true)
                {
                    // 为了效果减少时间
                    Thread.Sleep(1);
                    if (second == Second && minute == Minute && Hour == hour)
                    {
                         AlarmEventArgs alarm = new AlarmEventArgs();
                         alarm.Minute = Minute;
                         alarm.Second = Second;
                         alarm.Hour = Hour;
                         Alarm(this, alarm);
                    }
                    // 每30s一次tick
                    else if (second % 30 == 0)
                    {
                        TickEventArgs tick = new TickEventArgs();
                        tick.Minute = minute;
                        tick.Second = second;
                        tick.Hour = hour;
                        Tick(this, tick);
                    }

                    second++;
                    if (second == 60)
                    {
                        second = 0;
                        minute += 1;
                        if (minute == 60)
                        {
                            hour = (hour + 1) % 24;
                            minute = 0;
                        }
                    }
                    
                }

               
            }
        }
    }
}