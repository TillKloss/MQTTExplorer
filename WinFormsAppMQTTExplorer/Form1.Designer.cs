namespace WinFormsAppMQTTExplorer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDisconnect = new Button();
            buttonConnect = new Button();
            label1 = new Label();
            textBoxBroker = new TextBox();
            textBoxProtocol = new TextBox();
            textBoxConnName = new TextBox();
            label2 = new Label();
            groupBoxConnect = new GroupBox();
            buttonRemoveConn = new Button();
            buttonAddConn = new Button();
            label4 = new Label();
            listBoxConns = new ListBox();
            textBoxPort = new TextBox();
            label3 = new Label();
            groupBoxTopics = new GroupBox();
            label6 = new Label();
            buttonRemoveTopic = new Button();
            listBoxTopics = new ListBox();
            buttonAddTopic = new Button();
            textBoxTopicName = new TextBox();
            label5 = new Label();
            groupBoxPayloads = new GroupBox();
            buttonNewPublish = new Button();
            label7 = new Label();
            buttonClearPayloads = new Button();
            listBoxPayloads = new ListBox();
            groupBoxConnect.SuspendLayout();
            groupBoxTopics.SuspendLayout();
            groupBoxPayloads.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Enabled = false;
            buttonDisconnect.Location = new Point(16, 542);
            buttonDisconnect.Margin = new Padding(2);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(211, 36);
            buttonDisconnect.TabIndex = 7;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(16, 502);
            buttonConnect.Margin = new Padding(2);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(211, 36);
            buttonConnect.TabIndex = 6;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(13, 101);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Broker";
            // 
            // textBoxBroker
            // 
            textBoxBroker.Location = new Point(71, 122);
            textBoxBroker.Margin = new Padding(2);
            textBoxBroker.Name = "textBoxBroker";
            textBoxBroker.Size = new Size(203, 27);
            textBoxBroker.TabIndex = 2;
            // 
            // textBoxProtocol
            // 
            textBoxProtocol.Enabled = false;
            textBoxProtocol.Location = new Point(17, 122);
            textBoxProtocol.Margin = new Padding(2);
            textBoxProtocol.Name = "textBoxProtocol";
            textBoxProtocol.Size = new Size(53, 27);
            textBoxProtocol.TabIndex = 4;
            textBoxProtocol.Text = "mqtt://";
            // 
            // textBoxConnName
            // 
            textBoxConnName.Location = new Point(17, 65);
            textBoxConnName.Margin = new Padding(2);
            textBoxConnName.Name = "textBoxConnName";
            textBoxConnName.Size = new Size(258, 27);
            textBoxConnName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(14, 43);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 5;
            label2.Text = "Name der Verbindung";
            // 
            // groupBoxConnect
            // 
            groupBoxConnect.Controls.Add(buttonRemoveConn);
            groupBoxConnect.Controls.Add(buttonAddConn);
            groupBoxConnect.Controls.Add(label4);
            groupBoxConnect.Controls.Add(listBoxConns);
            groupBoxConnect.Controls.Add(textBoxPort);
            groupBoxConnect.Controls.Add(label3);
            groupBoxConnect.Controls.Add(buttonDisconnect);
            groupBoxConnect.Controls.Add(textBoxConnName);
            groupBoxConnect.Controls.Add(buttonConnect);
            groupBoxConnect.Controls.Add(label2);
            groupBoxConnect.Controls.Add(textBoxProtocol);
            groupBoxConnect.Controls.Add(label1);
            groupBoxConnect.Controls.Add(textBoxBroker);
            groupBoxConnect.Font = new Font("Segoe UI", 9F);
            groupBoxConnect.Location = new Point(54, 46);
            groupBoxConnect.Margin = new Padding(2);
            groupBoxConnect.Name = "groupBoxConnect";
            groupBoxConnect.Padding = new Padding(2);
            groupBoxConnect.Size = new Size(332, 590);
            groupBoxConnect.TabIndex = 7;
            groupBoxConnect.TabStop = false;
            groupBoxConnect.Text = "Verbindung aufbauen";
            // 
            // buttonRemoveConn
            // 
            buttonRemoveConn.Location = new Point(158, 227);
            buttonRemoveConn.Margin = new Padding(2);
            buttonRemoveConn.Name = "buttonRemoveConn";
            buttonRemoveConn.Size = new Size(114, 53);
            buttonRemoveConn.TabIndex = 11;
            buttonRemoveConn.Text = "Verbindung entfernen";
            buttonRemoveConn.UseVisualStyleBackColor = true;
            buttonRemoveConn.Click += buttonRemoveConn_Click;
            // 
            // buttonAddConn
            // 
            buttonAddConn.Location = new Point(17, 227);
            buttonAddConn.Margin = new Padding(2);
            buttonAddConn.Name = "buttonAddConn";
            buttonAddConn.Size = new Size(114, 53);
            buttonAddConn.TabIndex = 4;
            buttonAddConn.Text = "Verbindung hinzufügen";
            buttonAddConn.UseVisualStyleBackColor = true;
            buttonAddConn.Click += buttonAddConn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(13, 296);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 10;
            label4.Text = "Verbindungen";
            // 
            // listBoxConns
            // 
            listBoxConns.FormattingEnabled = true;
            listBoxConns.Location = new Point(17, 318);
            listBoxConns.Margin = new Padding(2);
            listBoxConns.Name = "listBoxConns";
            listBoxConns.Size = new Size(258, 164);
            listBoxConns.TabIndex = 5;
            listBoxConns.SelectedIndexChanged += listBoxConns_SelectedIndexChanged;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(16, 184);
            textBoxPort.Margin = new Padding(2);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(53, 27);
            textBoxPort.TabIndex = 3;
            textBoxPort.Text = "1883";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(13, 162);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "Port";
            // 
            // groupBoxTopics
            // 
            groupBoxTopics.Controls.Add(label6);
            groupBoxTopics.Controls.Add(buttonRemoveTopic);
            groupBoxTopics.Controls.Add(listBoxTopics);
            groupBoxTopics.Controls.Add(buttonAddTopic);
            groupBoxTopics.Controls.Add(textBoxTopicName);
            groupBoxTopics.Controls.Add(label5);
            groupBoxTopics.Location = new Point(399, 46);
            groupBoxTopics.Margin = new Padding(2);
            groupBoxTopics.Name = "groupBoxTopics";
            groupBoxTopics.Padding = new Padding(2);
            groupBoxTopics.Size = new Size(332, 590);
            groupBoxTopics.TabIndex = 8;
            groupBoxTopics.TabStop = false;
            groupBoxTopics.Text = "MQTT Topics";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(14, 160);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 16;
            label6.Text = "Topics";
            // 
            // buttonRemoveTopic
            // 
            buttonRemoveTopic.Location = new Point(17, 538);
            buttonRemoveTopic.Margin = new Padding(2);
            buttonRemoveTopic.Name = "buttonRemoveTopic";
            buttonRemoveTopic.Size = new Size(210, 40);
            buttonRemoveTopic.TabIndex = 15;
            buttonRemoveTopic.Text = "Topic entfernen";
            buttonRemoveTopic.UseVisualStyleBackColor = true;
            buttonRemoveTopic.Click += buttonRemoveTopic_Click;
            // 
            // listBoxTopics
            // 
            listBoxTopics.FormattingEnabled = true;
            listBoxTopics.Location = new Point(17, 182);
            listBoxTopics.Margin = new Padding(2);
            listBoxTopics.Name = "listBoxTopics";
            listBoxTopics.Size = new Size(258, 344);
            listBoxTopics.TabIndex = 14;
            // 
            // buttonAddTopic
            // 
            buttonAddTopic.Location = new Point(17, 107);
            buttonAddTopic.Margin = new Padding(2);
            buttonAddTopic.Name = "buttonAddTopic";
            buttonAddTopic.Size = new Size(210, 40);
            buttonAddTopic.TabIndex = 13;
            buttonAddTopic.Text = "Topic hinzufügen";
            buttonAddTopic.UseVisualStyleBackColor = true;
            buttonAddTopic.Click += buttonAddTopic_Click;
            // 
            // textBoxTopicName
            // 
            textBoxTopicName.Location = new Point(17, 65);
            textBoxTopicName.Margin = new Padding(2);
            textBoxTopicName.Name = "textBoxTopicName";
            textBoxTopicName.Size = new Size(258, 27);
            textBoxTopicName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(14, 43);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 12;
            label5.Text = "Name des Topic";
            // 
            // groupBoxPayloads
            // 
            groupBoxPayloads.Controls.Add(buttonNewPublish);
            groupBoxPayloads.Controls.Add(label7);
            groupBoxPayloads.Controls.Add(buttonClearPayloads);
            groupBoxPayloads.Controls.Add(listBoxPayloads);
            groupBoxPayloads.Location = new Point(745, 46);
            groupBoxPayloads.Margin = new Padding(2);
            groupBoxPayloads.Name = "groupBoxPayloads";
            groupBoxPayloads.Padding = new Padding(2);
            groupBoxPayloads.Size = new Size(485, 590);
            groupBoxPayloads.TabIndex = 9;
            groupBoxPayloads.TabStop = false;
            groupBoxPayloads.Text = "MQTT Payloads";
            // 
            // buttonNewPublish
            // 
            buttonNewPublish.Enabled = false;
            buttonNewPublish.Location = new Point(227, 538);
            buttonNewPublish.Name = "buttonNewPublish";
            buttonNewPublish.Size = new Size(200, 40);
            buttonNewPublish.TabIndex = 18;
            buttonNewPublish.Text = "Neuer Publish";
            buttonNewPublish.UseVisualStyleBackColor = true;
            buttonNewPublish.Click += buttonNewPublish_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(13, 41);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 17;
            label7.Text = "Payloads";
            // 
            // buttonClearPayloads
            // 
            buttonClearPayloads.Location = new Point(17, 538);
            buttonClearPayloads.Margin = new Padding(2);
            buttonClearPayloads.Name = "buttonClearPayloads";
            buttonClearPayloads.Size = new Size(200, 40);
            buttonClearPayloads.TabIndex = 1;
            buttonClearPayloads.Text = "Payloads leeren";
            buttonClearPayloads.UseVisualStyleBackColor = true;
            buttonClearPayloads.Click += buttonClearPayloads_Click;
            // 
            // listBoxPayloads
            // 
            listBoxPayloads.FormattingEnabled = true;
            listBoxPayloads.Location = new Point(17, 63);
            listBoxPayloads.Margin = new Padding(2);
            listBoxPayloads.Name = "listBoxPayloads";
            listBoxPayloads.Size = new Size(410, 464);
            listBoxPayloads.TabIndex = 0;
            listBoxPayloads.DoubleClick += listBoxPayloads_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 659);
            Controls.Add(groupBoxPayloads);
            Controls.Add(groupBoxTopics);
            Controls.Add(groupBoxConnect);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "MQTTExplorer";
            groupBoxConnect.ResumeLayout(false);
            groupBoxConnect.PerformLayout();
            groupBoxTopics.ResumeLayout(false);
            groupBoxTopics.PerformLayout();
            groupBoxPayloads.ResumeLayout(false);
            groupBoxPayloads.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDisconnect;
        private Button buttonConnect;
        private Label label1;
        private TextBox textBoxBroker;
        private TextBox textBoxProtocol;
        private TextBox textBoxConnName;
        private Label label2;
        private GroupBox groupBoxConnect;
        private TextBox textBoxPort;
        private Label label3;
        private Button buttonAddConn;
        private Label label4;
        private ListBox listBoxConns;
        private GroupBox groupBoxTopics;
        private Button buttonAddTopic;
        private TextBox textBoxTopicName;
        private Label label5;
        private Button buttonRemoveTopic;
        private ListBox listBoxTopics;
        private Label label6;
        private GroupBox groupBoxPayloads;
        private Label label7;
        private Button buttonClearPayloads;
        private ListBox listBoxPayloads;
        private Button buttonRemoveConn;
        private Button buttonNewPublish;
    }
}
