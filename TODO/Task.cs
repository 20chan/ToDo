using System;

namespace TODO
{
    [Serializable]
    public class Task
    {
        public DateTime When { get; set; }
        public string What { get; set; }
        public string Description { get; set; }

        public bool Done { get; set; }
    }
}
