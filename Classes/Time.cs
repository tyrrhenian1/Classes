using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Time
    { 
        public int hours;
        public int minutes;
        public int seconds;
        public void Add(int hour, int minute, int seconds)
        {
            this.hours = hour;
            this.minutes = minute;
            this.seconds = seconds;
        }
        public void Change()
        {
            this.hours += 1;
            this.minutes += 40;
            if (this.minutes >= 60)
            {
                this.hours += this.minutes / 60;
                this.minutes -= (this.minutes / 60 * 60);
            }
        }

        public void Print()
        {
            Console.WriteLine($"Время: {hours}.{minutes}.{seconds} До полуночи (24:00:00) - {24 * 60 - (hours * 60 + minutes)}.{seconds} минут");
        }
    }
}
