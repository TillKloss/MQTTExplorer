using MQTTnet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMQTTExplorer.Classes
{
    public class Publish
    {
        private Topic topic;
        private string payload;
        private MqttQualityOfServiceLevel level = MqttQualityOfServiceLevel.AtMostOnce;

        public Publish(Topic topic, string payload)
        {
            this.topic = topic;
            this.payload = payload;
        }

        public Topic Topic { get => topic; set => topic = value; }
        public string Payload { get => payload; set => payload = value; }
        public MqttQualityOfServiceLevel Level { get => level; }
    }
}
