using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMQTTExplorer.Classes
{
    public class Payload
    {
        private Topic topic;
        private DateTime timestamp;
        private string value;

        public Payload(Topic topic, DateTime timestamp, string value)
        {
            this.topic = topic;
            this.timestamp = timestamp;
            this.value = value;
        }

        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        public string Value { get => value; set => this.value = value; }
        internal Topic Topic { get => topic; set => topic = value; }

        public override string ToString()
        {
            return $"[{timestamp.ToString("HH:mm:ss")}] {topic}";
        }
    }
}
