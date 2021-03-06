﻿using System;
using System.IO;
using System.Windows.Forms;

namespace CourseWork_S_and_D
{/// <summary>
/// A class that provides the ability to 
/// save and read created tasks.
/// </summary>
    static class TaskIO
    {
        /// <summary>
        /// Method for saving data about tasks 
        /// to a special saving file in binary format.
        /// </summary>
        /// <param name="tasks">An array of tasks to save</param>
        /// <param name="fileName">The path to the save file</param>
        public static void WriteTasks(TaskList tasks, String fileName)
        {
            try
            {
                using (BinaryWriter binary = new BinaryWriter(File.Open(fileName, FileMode.Create)))
                {
                    if (tasks.Size() == 0)
                    {
                        return;
                    }
                    binary.Write(tasks.Size());
                    for (int i = 0; i < tasks.Size(); i++)
                    {
                        Task temp = tasks.GetTask(i);
                        binary.Write(temp.Title);
                        binary.Write(temp.IsActive);
                        binary.Write(temp.IsRepeated);
                        if (temp.IsRepeated)
                        {
                            binary.Write(temp.GetStartTime().ToBinary());
                            binary.Write(temp.GetEndTime().ToBinary());
                            binary.Write(temp.GetRepeatInterval());
                        }
                        else
                        {
                            binary.Write(temp.GetTime().ToBinary());
                        }
                    }
                }
            }catch (Exception)
            {
                MessageBox.Show("Файл збереження відсутній або пошкоджений. Створення нового файлу збереження", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                File.Create(fileName).Close();
            }
        }

        /// <summary>
        /// Method for reading binary task data from a file to an array.
        /// </summary>
        /// <param name="tasks">An array in which to read the data</param>
        /// <param name="fileName">The path to the save file</param>
        public static void ReadTasks(TaskList tasks, String fileName)
        {
            try
            {
                FileInfo file = new FileInfo(fileName);

                if (file.Length == 0)
                {
                    return;
                }
                using (BinaryReader binary = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    int size = binary.ReadInt32();
                    if(size <= 0)
                    {
                        throw new ArgumentException();
                    }
                    for (int i = 0; i < size; i++)
                    {
                        String title = binary.ReadString();
                        bool active = binary.ReadBoolean();
                        bool repeated = binary.ReadBoolean();
                        if (!repeated)
                        {
                            tasks.AddTask(new Task(title, DateTime.FromBinary(binary.ReadInt64())));
                            tasks.GetTask(i).IsActive = active;
                        }
                        else
                        {
                            tasks.AddTask(new Task(title, DateTime.FromBinary(binary.ReadInt64()), DateTime.FromBinary(binary.ReadInt64()), binary.ReadInt32()));
                            tasks.GetTask(i).IsActive = active;
                        }
                    }
                }
            }catch(Exception)
            {
                MessageBox.Show("Файл збереження відсутній або пошкоджений. Створення нового файлу збереження", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                File.Create(fileName).Close();
            }
        }
    }
}
