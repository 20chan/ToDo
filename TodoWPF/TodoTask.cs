using System;

namespace TodoWPF
{
    [Serializable]
    public class TodoTask
    {
        public DateTime When { get; set; }
        public string What { get; set; }
        public string Description { get; set; }

        public bool Done { get; set; }

        public TodoTask(DateTime when, string what)
        {
            Done = false;
            When = when;
            What = what;
        }
    }
}
