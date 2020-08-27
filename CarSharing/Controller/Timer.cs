using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace CarSharing.Controller
{
    class Timer
    {
        DispatcherTimer dispatcherTimer;

        TextBlock time, date; 

        public Timer(TextBlock _time, TextBlock _date)
        {
            time = _time;
            date = _date;
            SetDateTime(); 
            CreateTimer();  
        }

        private void CreateTimer()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Tick += timerTick;
            dispatcherTimer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            SetDateTime(); 
        }

        public void SetDateTime()
        {
            time.Text = this.GetTime();
            date.Text = this.GetDate();
        }

        private string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }

        private string GetDate()
        {
            return DateTime.Now.ToShortDateString();
        }


    }
}
