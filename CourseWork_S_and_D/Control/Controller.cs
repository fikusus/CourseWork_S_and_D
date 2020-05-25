using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork_S_and_D
{
    /// <summary>
    /// The class that is responsible for processing user actions 
    /// performed on View objects and entering the corresponding 
    /// ones for Model objects. Saves and downloads data from a file.
    /// The generating Singleton programming pattern is used for this class.
    /// </summary>
    class Controller
    {
        /// <summary>
        /// A static field that refers to itself gives access to a singletone object.
        /// </summary>
        public static Controller controller = new Controller();

        /// <summary>
        /// List of tasks with which work is performed.
        /// </summary>
        private TaskList tasks = new TaskList();

        /// <summary>
        /// The path to the file with the saved tasks.
        /// </summary>
        private String saveFileName = "tasks.txt";

        /// <summary>
        /// Controller class constructor. 
        /// Carries out basic initialization and reads task data from a file.
        /// </summary>
        private Controller()
        {
            TaskIO.ReadTasks(tasks, saveFileName);
        }

        /// <summary>
        /// Method is responsible for adding a new recurring task to the list.
        /// </summary>
        /// <param name="title">The name of the new task</param>
        /// <param name="start">Start date of the new task</param>
        /// <param name="end">End date of the new task</param>
        /// <param name="interval">Interval for repeating a new task</param>
        public void AddTask(string title, DateTime start, DateTime end, int interval)
        {
            tasks.AddTask(new Task(title, start, end, interval));
            SaveData();
        }
        /// <summary>
        /// Method is responsible for adding a new non-recurring task in the list.
        /// </summary>
        /// <param name="title">The name of the new task.</param>
        /// <param name="time">Date to execute a new task</param>
        public void AddTask(string title, DateTime time)
        {
            tasks.AddTask(new Task(title, time));
            SaveData();
        }

        /// <summary>
        /// A method that allows you to get tasks from the collection on the index.
        /// </summary>
        /// <param name="index">Index of the required task</param>
        /// <returns>Returns a task from an array by index</returns>
        public Task GetTaskFromTaskList(int index)
        {
            return tasks.GetTask(index);
        }

        /// <summary>
        /// A method that allows you to delete tasks from the collection by index.
        /// </summary>
        /// <param name="index">The index of the task to delete</param>
        /// <returns>Returns the success of deletion from the collection</returns>
        public bool RemoveTaskFromTaskList(int index)
        {
            bool result = tasks.RemoveTask(tasks.GetTask(index));
            SaveData();
            return result;
        }

        /// <summary>
        /// A method that allows you to find out the number of tasks in the collection.
        /// </summary>
        /// <returns>Returns the number of tasks in the collection</returns>
        public int GetCountOfTasks()
        {
            return tasks.Size();
        }

        /// <summary>
        /// The method allows you to change an existing task to a non-recurring one with the specified parameters.
        /// </summary>
        /// <param name="index">The index of the task to change</param>
        /// <param name="title">The new name of the task</param>
        /// <param name="time">New task execution date</param>
        /// <param name="activity">Activity parameter of the task</param>
        public void ChangeDateInTaskList(int index, String title, DateTime time, bool activity)
        {
            Task task = tasks.GetTask(index);
            task.Title = title;
            task.SetTime(time);
            task.IsActive = activity;
            SaveData();
        }

        /// <summary>
        /// The method allows you to change an existing task to a repetitive one with the specified parameters.
        /// </summary>
        /// <param name="index">The index of the task to change</param>
        /// <param name="title">The new name of the task</param>
        /// <param name="start">New task start date</param>
        /// <param name="end">New task end date</param>
        /// <param name="interval">New task interval for repeating</param>
        /// <param name="activity">Activity parameter of the task</param>
        public void ChangeDateInTaskList(int index, String title, DateTime start, DateTime end, int interval, bool activity)
        {
            Task task = tasks.GetTask(index);
            task.Title = title;
            task.SetTime(start, end, interval);
            task.IsActive = activity;
            SaveData();
        }

        /// <summary>
        /// The method provides information in a structured form about the tasks that fall into the interval.
        /// </summary>
        /// <param name="start">The initial boundary of the interval</param>
        /// <param name="end">The final boundary of the interval</param>
        /// <returns>Returns information about tasks on the interval</returns>
        public String TasksCalendarText(DateTime start, DateTime end)
        {
            SortedDictionary<DateTime?, HashSet<Task>> currCalendarTasks = tasks.Calendar(start, end);
            if (currCalendarTasks.Count == 0)
            {
                return "Завдання відсутні";
            }
            int day = -1;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in currCalendarTasks.Keys)
            {
                HashSet<Task> temp;
                currCalendarTasks.TryGetValue(item, out temp);
                if (item.Value.Day != day)
                {
                    if (day != -1)
                    {
                        stringBuilder.Append(Environment.NewLine);
                    }
                    day = item.Value.Day;
                    stringBuilder.Append("На дату ").Append(item.Value.ToShortDateString());
                }
                foreach (var item2 in temp)
                {
                    stringBuilder.Append(Environment.NewLine).Append("         Завдання ").Append(item2.Title).Append(" ").Append(item.Value.ToShortTimeString());
                }
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// The method provides information in the form of an array of strings for all tasks.
        /// </summary>
        /// <returns>Returns an array of strings with task information</returns>
        public String[] GetTaskListInfo()
        {
            List<String> outList = new List<String>();
            for (int i = 0; i < tasks.Size(); i++)
            {
                outList.Add(tasks.GetTask(i).ToString());
            }
            return outList.ToArray();
        }

        /// <summary>
        /// The method saves the list of tasks to a file.
        /// </summary>
        private void SaveData()
        {
            TaskIO.WriteTasks(tasks, saveFileName);
        }
    }
}
