using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MQTTnet;

namespace WinFormsAppMQTTExplorer.Classes
{
    internal class MQTTHandler
    {
        private IMqttClient client;
        public bool IsConnected => client != null && client.IsConnected;
        public event Action<Payload> OnPayloadReceived;

        public MQTTHandler()
        {
            var factory = new MqttClientFactory();
            client = factory.CreateMqttClient();

            client.ApplicationMessageReceivedAsync += e =>
            {
                string topic = e.ApplicationMessage.Topic;
                string payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);

                var msg = new Payload(new Topic(topic), DateTime.Now, payload);
                OnPayloadReceived?.Invoke(msg);

                return Task.CompletedTask;
            };
        }

        public async Task ConnectAsync(Connection connection, IEnumerable<Topic> topics)
        {
            if (connection == null) throw new Exception("Keine Verbindung ausgewählt.");
            if (client.IsConnected) return;

            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(connection.Broker, connection.Port)
                .WithClientId(Guid.NewGuid().ToString())
                .WithCleanSession()
                .Build();

            await client.ConnectAsync(options);

            foreach(var topic in topics)
            {
                await client.SubscribeAsync(topic.Name);
            }
            MessageBox.Show("Verbunden");
        }

        public async Task DisconnectAsync()
        {
            if (client.IsConnected)
            {
                await client.DisconnectAsync();
            }
        }

        public async Task SubscribeAsync(Topic topic)
        {
            if (client.IsConnected)
            {
                await client.SubscribeAsync(topic.Name);
            }
        }

        public async Task UnsubscribeAsync(Topic topic)
        {
            if (client.IsConnected)
            {
                await client.UnsubscribeAsync(topic.Name);
            }
        }
    }
}
