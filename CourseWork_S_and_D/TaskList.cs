using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_S_and_D
{
    class TaskList
    {
        List<Task> tasks = new List<Task>();
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public bool RemoveTask(Task task)
        {
            return tasks.Remove(task);
        }
        public int Size()
        {
            return tasks.Count;
        }
        public Task GetTask(int index)
        {
            return tasks.ElementAt(index);
        }
        public SortedDictionary<DateTime?, HashSet<Task>> Calendar(DateTime start, DateTime end)
        {
            HashSet<Task> buffSet = new HashSet<Task>();
            SortedDictionary < DateTime?, HashSet < Task >> myMap = new SortedDictionary<DateTime?, HashSet<Task>>();
            foreach (Task item in tasks)
            {
                if (item.IsActive)
                {
                    DateTime tmpDate = start;
                    while (item.nextTimeAfter(tmpDate).HasValue && item.nextTimeAfter(tmpDate) <= end)
                    {
                        if (myMap.TryGetValue(item.nextTimeAfter(tmpDate), out buffSet))
                        {
                            buffSet.Add(item);
                            myMap[item.nextTimeAfter(tmpDate)] = buffSet;
                        }
                        else
                        {
                            buffSet = new HashSet<Task>();
                            buffSet.Add(item);
                            myMap.Add(item.nextTimeAfter(tmpDate), buffSet);
                        }
                        tmpDate = item.nextTimeAfter(tmpDate).Value;

                    }
                }
            }       
            return myMap;
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in tasks)
            {
                stringBuilder.Append(item).Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
    
}
