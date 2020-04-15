using System;
using System.Collections.Generic;
using System.Text;

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
            Title = title;
            this.time = DateCorrector(time);
            IsRepeated = false;     
        }

        public Task(string title, DateTime start, DateTime end, int interval)
        {
            Title = title;
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
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("'").Append(Title).Append("'");
            if (IsRepeated)
            {
                stringBuilder.Append(" З: ").Append(start.ToString("dd.MM.yyyy HH:mm")).Append(" До: ").Append(end.ToString("dd.MM.yyyy HH:mm")).Append(" з інтервалом: ").Append(interval).Append(" хв");
            }
            else
            {
                stringBuilder.Append(" На час: ").Append(time.ToString("dd.MM.yyyy HH:mm"));

            }
            if (IsActive)
            {
                stringBuilder.Append(", активна");
            }
            else
            {
                stringBuilder.Append(", не активна");
            }
            return stringBuilder.ToString();

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
