using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork_S_and_D
{
    /// <summary>
    /// A class that represents each individual 
    /// task and the functionality to work with it.
    /// </summary>
    class Task
    {
        /// <summary>
        /// The title of the task.
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Time to complete a non-recurring task.
        /// </summary>
        private DateTime time;

        /// <summary>
        /// The start time of the recurring task.
        /// </summary>
        private DateTime start;

        /// <summary>
        /// The end time of the recurring task.
        /// </summary>
        private DateTime end;

        /// <summary>
        /// Interval of recurring task.
        /// </summary>
        private int interval;

        /// <summary>
        /// Field containing information about the recurrence of the task.
        /// </summary>
        public bool IsRepeated { get; private set; }

        /// <summary>
        /// Field containing information about the activity of the task
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Сonstructor for a not-repetitive task.
        /// </summary>
        /// <param name="title">The name of the new task</param>
        /// <param name="time">Date to execute a new task</param>
        public Task(string title, DateTime time)
        {
            Title = title;
            this.time = DateCorrector(time);
            IsRepeated = false;
        }

        /// <summary>
        /// Сonstructor for a repetitive task.
        /// </summary>
        /// <param name="title">The name of the new task</param>
        /// <param name="start">Start date of the new task</param>
        /// <param name="end">End date of the new task</param>
        /// <param name="interval">Interval for repeating a new task</param>
        public Task(string title, DateTime start, DateTime end, int interval)
        {
            Title = title;
            this.start = DateCorrector(start);
            this.end = DateCorrector(end);
            this.interval = interval;
            IsRepeated = true;
        }

        /// <summary>
        /// Method for setting a new execution date for a non-repeatable task.
        /// </summary>
        /// <param name="time">New task execution date</param>
        public void SetTime(DateTime time)
        {
            IsRepeated = false;
            this.time = DateCorrector(time);
        }

        /// <summary>
        /// Method for setting a new start and end date, 
        /// and interval for repeating for a repeatable task.
        /// </summary>
        /// <param name="start">New task start date</param>
        /// <param name="end">New task end date</param>
        /// <param name="interval">New task interval for repeating</param>
        public void SetTime(DateTime start, DateTime end, int interval)
        {
            IsRepeated = true;
            this.start = DateCorrector(start);
            this.end = DateCorrector(end);
            this.interval = interval;
        }

        /// <summary>
        /// Method for getting the date of execution.
        /// </summary>
        /// <returns>Returns the execution date of a non-repeatable task, 
        /// or the start date of a repeatable task.</returns>
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

        /// <summary>
        /// Method to get the start date of the task.
        /// </summary>
        /// <returns>Returns the start date of a repeatable task, 
        /// or the execution date of a non-repeatable task.</returns>
        public DateTime GetStartTime()
        {
            return GetTime();
        }

        /// <summary>
        /// Method to get the end date of the task.
        /// </summary>
        /// <returns>Returns the end date of a repeatable task, 
        /// or the execution date of a non-repeatable task.</returns>
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

        /// <summary>
        /// Method to get interval for repeating of the task.
        /// </summary>
        /// <returns>Returns the interval for repeating of a repeatable task, 
        /// or 0 for a non-repeatable task.</returns>
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

        /// <summary>
        /// A method that determines the time of the next task after a certain date.
        /// </summary>
        /// <param name="current">The date after which the task should be executed.</param>
        /// <returns>Returns the time of the next task execution after a certain date, if one exists.</returns>
        public DateTime? nextTimeAfter(DateTime current)
        {
            if (IsRepeated)
            {
                DateTime tempDate = start;
                while (tempDate <= current)
                {
                    tempDate = tempDate.AddMinutes(interval);
                }
                if (tempDate <= end)
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
                if (time <= current)
                {
                    return null;
                }
                else
                {
                    return time;

                }
            }
        }

        /// <summary>
        /// An overloaded method for converting an object to a structured string.
        /// </summary>
        /// <returns>Returns a string with information about the task</returns>
        public override string ToString()
        {
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

        /// <summary>
        /// Method for entering all dates in one format.
        /// Removes everything in less than a minute.
        /// </summary>
        /// <param name="input">Date for correction</param>
        /// <returns>Returns the corrected date</returns>
        private DateTime DateCorrector(DateTime input)
        {
            return new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0);
        }

        /// <summary>
        /// The method creates a unique hash code for the object.
        /// </summary>
        /// <returns>Returns the hash code of the object</returns>
        public override int GetHashCode()
        {
            int hashCode = -1678590704;
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
