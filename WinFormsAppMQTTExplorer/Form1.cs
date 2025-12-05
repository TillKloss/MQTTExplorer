using System.Windows.Forms;
using WinFormsAppMQTTExplorer.Classes;

namespace WinFormsAppMQTTExplorer
{
    public partial class Form1 : Form
    {
        Handler handler;
        private bool isInitializing = true;


        public Form1()
        {
            InitializeComponent();

            handler = new Handler();

            handler.OnPayloadReceived += Handler_OnPayloadReceived;

            listBoxTopics.DataSource = handler.Topics;
            listBoxConns.DataSource = handler.Connections;
            listBoxConns.SelectedIndex = -1;

            buttonDisconnect.Enabled = false;
            buttonConnect.Enabled = true;

            isInitializing = false;
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

        private void clearConnectionTextBox()
        {
            textBoxBroker.Text = string.Empty;
            textBoxConnName.Text = string.Empty;
        }

        private void clearTopicTextBox()
        {
            textBoxTopicName.Text = string.Empty;
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
            clearConnectionTextBox();
        }

        //RemoveConnection - sicher
        private void buttonRemoveConn_Click(object sender, EventArgs e)
        {
            if (listBoxConns.SelectedItem is Connection connection)
            {
                handler.RemoveConnection(connection);
                return;
            }
            MessageBox.Show("Keine Verbindung ausgewählt!");
        }

        //Connection - sicher
        private async void buttonConnect_Click(object sender, EventArgs e)
        {
            if (listBoxConns.SelectedItem is not Connection connection)
            {
                MessageBox.Show("Keine Verbindung gewählt!");
                return;
            }

            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = false;

            try
            {
                await handler.Connect(connection);
                buttonDisconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verbindung nicht möglich.");
                buttonConnect.Enabled = true;
            }
            
        }

        private void listBoxConns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing)
            {
                return;
            }

            if (listBoxConns.SelectedItem is Connection connection)
            {
                textBoxConnName.Text = connection.Name;
                textBoxBroker.Text = connection.Broker;
                textBoxPort.Text = connection.Port.ToString();
            }
        }

        //Disconnect - sicher
        private async void buttonDisconnect_Click(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = false;

            await handler.Disconnect();

            buttonConnect.Enabled = true;
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
            clearTopicTextBox();
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

        private void buttonClearPayloads_Click(object sender, EventArgs e)
        {
            listBoxPayloads.Items.Clear();
        }

        private void listBoxPayloads_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPayloads.SelectedItem is Payload payload)
            {
                var viewer = new PayloadViewerForm(payload);
                viewer.Show();
            }
        }
    }
}
