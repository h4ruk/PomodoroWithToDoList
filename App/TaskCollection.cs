using System;
using System.IO;
using System.Collections.Generic;

namespace App
{
    public class TaskCollection
    {
        private Task current;
        private List<Task> list;
        public event EventHandler CurrentTaskChanged;

        public int Count
        {
            get => list.Count;
        }

        public Task this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public TaskCollection()
        {
            current = new Task();
            list = new List<Task>();
        }

        public void Add(Task task)
        {
            list.Add(task);        
        }

        public void Complete(int index)
        {
            if (IsValidIndex(index))
            {
                list.RemoveAt(index);
                current = new Task();
                CurrentTaskChanged?.Invoke(null, null);
            }
        }

        public void Change(int index, string content)
        {
            if (IsValidIndex(index))
            { 
                list[index].Content = content;
                CurrentTaskChanged?.Invoke(null, null);
            }
        }

        public void WorkOn(int index)
        {
            if (IsValidIndex(index))
            {
                current.IsWorkOn = false;
                current = list[index];
                current.IsWorkOn = true;
                CurrentTaskChanged?.Invoke(null, null);
            }
        }

        public Task CurrentTask()
        {
            return current;        
        }

        public void Clear()
        {
            list.Clear();
        }

        private bool IsValidIndex(int index)
        {
            return !(index < 0 || index >= list.Count);
        }

        public void Load(string path)
        {
            string[] contents = File.ReadAllLines(path);
            foreach (string content in contents)
                Add(new Task(content));
        }

        public void Save(string path)
        {
            string[] contents = new string[Count];
            for (int i = 0; i < Count; i++)
                contents[i] = this[i].Content;
            File.WriteAllLines(path, contents);
        }
    }
    
}