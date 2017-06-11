using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace TODO
{
    [Serializable]
    public class TaskTable
    {
        public List<Task> Tasks { get; }

        public TaskTable()
        {
            Tasks = new List<Task>();
        }

        public void SaveToFile(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(TaskTable));
            using (StreamWriter sw = new StreamWriter(path))
                xml.Serialize(sw, this);
        }

        public static TaskTable LoadFromFile(string path)
        {
            TaskTable t;
            XmlSerializer xml = new XmlSerializer(typeof(TaskTable));
            using (StreamReader sr = new StreamReader(path))
                t = xml.Deserialize(sr) as TaskTable;
            return t;
        }
    }
}
