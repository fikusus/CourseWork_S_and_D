using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseWork_S_and_D
{/// <summary>
/// A class that creates an array of tasks 
/// and contains methods for working with that array.
/// </summary>
    class TaskList
    {
        /// <summary>
        /// A collection of tasks on which operations are performed.
        /// </summary>
        List<Task> tasks = new List<Task>();

        /// <summary>
        /// Method is responsible for adding a new non-recurring task in the list
        /// </summary>
        /// <param name="task">The task to be added to the array</param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        /// <summary>
        /// A method that allows you to delete tasks from the collection.
        /// </summary>
        /// <param name="task">The task to be removed from the array.</param>
        /// <returns>Returns the success of deletion from the collection</returns>
        public bool RemoveTask(Task task)
        {
            return tasks.Remove(task);
        }

        /// <summary>
        ///  A method that allows you to find out the number of tasks in the collection.
        /// </summary>
        /// <returns>Returns the number of tasks in the collection</returns>
        public int Size()
        {
            return tasks.Count;
        }

        /// <summary>
        /// A method that allows you to get tasks from the collection on the index.
        /// </summary>
        /// <param name="index">Index of the required task</param>
        /// <returns>Returns a task from an array by index</returns>
        public Task GetTask(int index)
        {
            return tasks.ElementAt(index);
        }

        /// <summary>
        /// A method that creates a collection of tasks structured by execution date at a certain interval.
        /// </summary>
        /// <param name="start">The initial boundary of the interval</param>
        /// <param name="end">he final boundary of the interval</param>
        /// <returns>Returns an array of tasks structured by execution date</returns>
        public SortedDictionary<DateTime?, HashSet<Task>> Calendar(DateTime start, DateTime end)
        {
            HashSet<Task> buffSet = new HashSet<Task>();
            SortedDictionary <DateTime?, HashSet <Task>> myMap = new SortedDictionary<DateTime?, HashSet<Task>>();
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

        /// <summary>
        /// An overloaded method for converting an object to a structured string.
        /// </summary>
        /// <returns>Returns a string with information about the tasks array</returns>
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
