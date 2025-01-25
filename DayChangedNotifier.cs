using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhaleTrack
{
    // lifted more or less verbatim from https://stackoverflow.com/a/3053754, thanks
    public static class DayChangedNotifier
    {
        private static Timer timer;

        static DayChangedNotifier()
        {
            timer = new Timer();
            timer.Interval = GetSleepTime();
            timer.Tick += (o, e) =>
            {
                OnDayChanged(DateTime.Now.DayOfWeek);
                timer.Interval = GetSleepTime();
            };
            timer.Start();

            SystemEvents.TimeChanged += new EventHandler(SystemEvents_TimeChanged);
        }

        private static void SystemEvents_TimeChanged(object sender, EventArgs e)
        {
            timer.Interval = GetSleepTime();
        }

        private static int GetSleepTime()
        {
            var midnightTonight = DateTime.Today.AddDays(1);
            var differenceInMilliseconds = (int)(midnightTonight - DateTime.Now).TotalMilliseconds;
            return differenceInMilliseconds;
        }

        private static void OnDayChanged(DayOfWeek day)
        {
            var handler = DayChanged;
            if (handler != null)
            {
                handler(null, new DayChangedEventArgs(day));
            }
        }

        public static event EventHandler<DayChangedEventArgs> DayChanged;
    }

    public class DayChangedEventArgs : EventArgs
    {
        public DayChangedEventArgs(DayOfWeek day)
        {
            DayOfWeek = day;
        }

        public DayOfWeek DayOfWeek { get; private set; }
    }
}
