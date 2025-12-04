using System.Windows.Forms;
using WinFormsAppMQTTExplorer.Classes;

namespace WinFormsAppMQTTExplorer
{
    public partial class Form1 : Form
    {
        Handler handler;

        public Form1()
        {
            InitializeComponent();

            handler = new Handler();

            handler.OnPayloadReceived += Handler_OnPayloadReceived;

            listBoxTopics.DataSource = handler.Topics;
            listBoxConns.DataSource = handler.Connections;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            handler.Disconnect();
            handler.OnPayloadReceived -= Handler_OnPayloadReceived;
            base.OnFormClosing(e);
        }

        private void Handler_OnPayloadReceived(Payload payload)
        {
            if (IsDisposed || !IsHandleCreated)
            {
                return;
            }

            if (InvokeRequired)
            {
                Invoke(new Action(() => Handler_OnPayloadReceived(payload)));
                return;
            }

            listBoxPayloads.Items.Add(payload);
            listBoxPayloads.TopIndex = listBoxPayloads.Items.Count - 1;
        }

        //AddConnection - sicher
        private void buttonAddConn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBroker.Text))
            {
                MessageBox.Show("Broker ungültig!");
                return;
            }

            if (!int.TryParse(textBoxPort.Text, out int port) || port < 1 || port > 65535)
            {
                MessageBox.Show("Port ungültig!");
                return;
            }

            if (string.IsNullOrEmpty(textBoxConnName.Text))
            {
                MessageBox.Show("Name ungültig!");
                return;
            }

            Connection connection = new Connection
                (
                textBoxConnName.Text,
                textBoxBroker.Text,
                port
                );

            handler.AddConnection(connection);
        }

        //Connection - sicher
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (listBoxConns.SelectedItem is Connection connection)
            {
                handler.Connect(connection);
                return;
            }
            MessageBox.Show("Keine Verbindung gewählt!");
        }

        //Disconnect - sicher
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            handler.Disconnect();
        }

        //AddTopic - sicher
        private void buttonAddTopic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTopicName.Text))
            {
                MessageBox.Show("Topic-Name ungültig!");
                return;
            }

            Topic topic = new Topic
                (
                textBoxTopicName.Text
                );

            handler.AddTopic(topic);
        }

        //RemoveTopic - sicher
        private void buttonRemoveTopic_Click(object sender, EventArgs e)
        {
            if (listBoxTopics.SelectedItem is Topic topic)
            {
                handler.RemoveTopic(topic);
                return;
            }
            MessageBox.Show("Kein Topic gewählt!");
        }
    }
}
