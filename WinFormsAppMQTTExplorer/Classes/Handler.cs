using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMQTTExplorer.Classes
{
    internal class Handler
    {
        private MQTTHandler mqttHandler;
        private BindingList<Topic> topics;
        private BindingList<Connection> connections;

        public event Action<Payload> OnPayloadReceived;

        public Handler()
        {
            mqttHandler = new MQTTHandler();
            topics = new BindingList<Topic>();
            connections = new BindingList<Connection>(JSONHandler.LoadConnections());

            mqttHandler.OnPayloadReceived += payload =>
            {
                OnPayloadReceived?.Invoke(payload);
            };
        }

        public void AddConnection(Connection connection)
        {
            connections.Add(connection);
            JSONHandler.SaveConnections(connections);
        }
        public void RemoveConnection(Connection connection)
        {
            connections.Remove(connection);
            JSONHandler.SaveConnections(connections);
        }
        public async Task Connect(Connection connection)
        {
            await mqttHandler.ConnectAsync(connection, topics);
        }
        public async Task Disconnect()
        {
            await mqttHandler.DisconnectAsync();
        }
        public async Task AddTopic(Topic topic)
        {
            topics.Add(topic);
            mqttHandler.SubscribeAsync(topic);
        }
        public async Task RemoveTopic(Topic topic)
        {
            topics.Remove(topic);
            mqttHandler.UnsubscribeAsync(topic);
        }

        public BindingList<Topic> Topics { get => topics; set => topics = value; }
        public BindingList<Connection> Connections { get => connections; set => connections = value; }
    }
}
