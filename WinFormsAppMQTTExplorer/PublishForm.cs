using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppMQTTExplorer.Classes;

namespace WinFormsAppMQTTExplorer
{
    public partial class PublishForm : Form
    {
        Handler handler;
        public PublishForm(Handler handler)
        {
            InitializeComponent();
            this.handler = handler;
        }

        private async void buttonPublish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPublishTopic.Text))
            {
                MessageBox.Show("Topic-Name ungültig!");
                return;
            }
            if (string.IsNullOrEmpty(richTextBoxPublishContent.Text))
            {
                MessageBox.Show("Payload ungültig!");
                return;
            }

            Publish publish = new Publish(
                                  new Topic(textBoxPublishTopic.Text), 
                                  richTextBoxPublishContent.Text
                                  );

            await handler.NewPublish(publish);
        }
    }
}
