using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork_S_and_D
{
     class Controller
    {
        public static Controller controller = new Controller();
        private TaskList tasks = new TaskList();

        private Controller()
        {
            TaskIO.ReadTasks(tasks, "tasks.txt");
        }

        public void AddTask(Task task)
        {
            tasks.AddTask(task);
            SaveData();
        }

        public Task GetTaskFromTaskList(int index)
        {
            return tasks.GetTask(index);
        }

        public bool RemoveTaskFromTaskList(int index)
        {
            bool result = tasks.RemoveTask(tasks.GetTask(index));
            SaveData();
            return result;
        }

        public int GetCountOfTasks()
        {
            return tasks.Size();
        }

        public void ChangeDateInTaskList(int index, String title, DateTime time, bool activity)
        {
            Task task = tasks.GetTask(index);
            task.Title = title;
            task.SetTime(time);
            task.IsActive = activity;
            SaveData();
        }

        public void ChangeDateInTaskList(int index, String title, DateTime start,DateTime end, int interval, bool activity)
        {
            Task task = tasks.GetTask(index);
            task.Title = title;
            task.SetTime(start,end,interval);
            task.IsActive = activity;
            SaveData();
        }

        public String TasksCalendarText(DateTime start, DateTime end)
        {
            SortedDictionary<DateTime?, HashSet<Task>> currCalendarTasks = tasks.Calendar(start, end);
            if(currCalendarTasks.Count == 0)
            {
                return "Завдання відсутні";
            }
            int day = -1;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in currCalendarTasks.Keys)
            {
                HashSet<Task> temp;
                currCalendarTasks.TryGetValue(item, out temp);
                if(item.Value.Day != day)
                {
                    if(day != -1)
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

        public String[] GetTaskListInfo()
        {
            List<String> outList = new List<String>();
            for(int i = 0;i < tasks.Size(); i++)
            {
                outList.Add(tasks.GetTask(i).ToString());
            }
            return outList.ToArray();
       }

        private void SaveData()
        {
            TaskIO.WriteTasks(tasks, "tasks.txt");
        }
    }
}
