using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_S_and_D
{
    class Task
    {
        public String Title { get; set; }
        private DateTime time;
        private DateTime start;
        private DateTime end;
        private int interval;
        public bool IsRepeated { get; private set; }
        public bool IsActive { get; set; } = true;

        public Task(string title, DateTime time)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            this.time = DateCorrector(time);
            IsRepeated = false;     
        }

        public Task(string title, DateTime start, DateTime end, int interval)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            this.start = DateCorrector(start);
            this.end = DateCorrector(end);
            this.interval = interval;
            IsRepeated = true;
        }

        public void SetTime(DateTime time)
        {
            IsRepeated = false;
            this.time = DateCorrector(time);
        }
        public void SetTime(DateTime start, DateTime end, int interval)
        {
            IsRepeated = true;
            this.start = DateCorrector(start);
            this.end = DateCorrector(end);
            this.interval = interval;
        }

        public DateTime GetTime()
        {
            if (IsRepeated)
            {
                return start;
            }
            else
            {
                return time;
            }
        }

        public DateTime GetStartTime()
        {
            return GetTime();
        }
        public DateTime GetEndTime()
        {
            if (IsRepeated)
            {
                return end;
            }
            else
            {
                return time;
            }
        }
        public int GetRepeatInterval()
        {
            if (IsRepeated)
            {
                return interval;
            }
            else
            {
                return 0;
            }
        }
        public DateTime? nextTimeAfter(DateTime current)
        {
            if (IsRepeated)
            {
                DateTime tempDate = start;
                while(tempDate <= current)
                {
                    tempDate = tempDate.AddMinutes(interval);
                }
                if(tempDate <= end)
                {
                    return tempDate;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if(time <= current)
                {
                    return null;
                }
                else
                {
                    return time;

                }
            }
        }

        public override string ToString()
        {
            String str = String.Empty;
            if (IsRepeated)
            {
                str += "'" + Title + "'" + " З: " + start.ToString("dd.MM.yyyy HH:mm") + " До: " + end.ToString("dd.MM.yyyy HH:mm") + " з інтервалом: " + interval + " хвилин";
                if (IsActive)
                {
                    str += ", активна";
                }
                else
                {
                    str += ", не активна";
                }
            }
            else
            {
                str = "'" + Title + "'" + " На час: " + time.ToString("dd.MM.yyyy HH:mm");
                if (IsActive)
                {
                    str += ", активна";
                }
                else
                {
                    str += ", не активна";
                }
            }
            return str;

        }

        private DateTime DateCorrector(DateTime input)
        {
            return new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0);
        }

        public override int GetHashCode()
        {
            var hashCode = -1678590704;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + time.GetHashCode();
            hashCode = hashCode * -1521134295 + start.GetHashCode();
            hashCode = hashCode * -1521134295 + end.GetHashCode();
            hashCode = hashCode * -1521134295 + interval.GetHashCode();
            hashCode = hashCode * -1521134295 + IsRepeated.GetHashCode();
            hashCode = hashCode * -1521134295 + IsActive.GetHashCode();
            return hashCode;
        }
    }
}
