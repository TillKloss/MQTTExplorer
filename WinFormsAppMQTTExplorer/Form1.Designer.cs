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
            listBoxPayloads = new ListBox();
            buttonClearPayloads = new Button();
            label7 = new Label();
            groupBoxConnect.SuspendLayout();
            groupBoxTopics.SuspendLayout();
            groupBoxPayloads.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Enabled = false;
            buttonDisconnect.Location = new Point(26, 867);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(343, 57);
            buttonDisconnect.TabIndex = 7;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(26, 804);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(343, 57);
            buttonConnect.TabIndex = 6;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(21, 161);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 2;
            label1.Text = "Broker";
            // 
            // textBoxBroker
            // 
            textBoxBroker.Location = new Point(116, 196);
            textBoxBroker.Name = "textBoxBroker";
            textBoxBroker.Size = new Size(327, 39);
            textBoxBroker.TabIndex = 2;
            // 
            // textBoxProtocol
            // 
            textBoxProtocol.Enabled = false;
            textBoxProtocol.Location = new Point(27, 196);
            textBoxProtocol.Name = "textBoxProtocol";
            textBoxProtocol.Size = new Size(83, 39);
            textBoxProtocol.TabIndex = 4;
            textBoxProtocol.Text = "mqtt://";
            // 
            // textBoxConnName
            // 
            textBoxConnName.Location = new Point(27, 104);
            textBoxConnName.Name = "textBoxConnName";
            textBoxConnName.Size = new Size(416, 39);
            textBoxConnName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(267, 32);
            label2.TabIndex = 5;
            label2.Text = "Name der Verbindung";
            // 
            // groupBoxConnect
            // 
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
            groupBoxConnect.Location = new Point(87, 74);
            groupBoxConnect.Name = "groupBoxConnect";
            groupBoxConnect.Size = new Size(539, 944);
            groupBoxConnect.TabIndex = 7;
            groupBoxConnect.TabStop = false;
            groupBoxConnect.Text = "Verbindung aufbauen";
            // 
            // buttonAddConn
            // 
            buttonAddConn.Location = new Point(27, 363);
            buttonAddConn.Name = "buttonAddConn";
            buttonAddConn.Size = new Size(411, 72);
            buttonAddConn.TabIndex = 4;
            buttonAddConn.Text = "Verbindung hinzufügen";
            buttonAddConn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(21, 473);
            label4.Name = "label4";
            label4.Size = new Size(176, 32);
            label4.TabIndex = 10;
            label4.Text = "Verbindungen";
            // 
            // listBoxConns
            // 
            listBoxConns.FormattingEnabled = true;
            listBoxConns.Location = new Point(27, 508);
            listBoxConns.Name = "listBoxConns";
            listBoxConns.Size = new Size(416, 260);
            listBoxConns.TabIndex = 5;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(26, 294);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(84, 39);
            textBoxPort.TabIndex = 3;
            textBoxPort.Text = "1883";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(21, 259);
            label3.Name = "label3";
            label3.Size = new Size(63, 32);
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
            groupBoxTopics.Location = new Point(649, 74);
            groupBoxTopics.Name = "groupBoxTopics";
            groupBoxTopics.Size = new Size(539, 944);
            groupBoxTopics.TabIndex = 8;
            groupBoxTopics.TabStop = false;
            groupBoxTopics.Text = "MQTT Topics";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(22, 256);
            label6.Name = "label6";
            label6.Size = new Size(86, 32);
            label6.TabIndex = 16;
            label6.Text = "Topics";
            // 
            // buttonRemoveTopic
            // 
            buttonRemoveTopic.Location = new Point(27, 860);
            buttonRemoveTopic.Name = "buttonRemoveTopic";
            buttonRemoveTopic.Size = new Size(342, 64);
            buttonRemoveTopic.TabIndex = 15;
            buttonRemoveTopic.Text = "Topic entfernen";
            buttonRemoveTopic.UseVisualStyleBackColor = true;
            // 
            // listBoxTopics
            // 
            listBoxTopics.FormattingEnabled = true;
            listBoxTopics.Items.AddRange(new object[] { "default" });
            listBoxTopics.Location = new Point(27, 291);
            listBoxTopics.Name = "listBoxTopics";
            listBoxTopics.Size = new Size(416, 548);
            listBoxTopics.TabIndex = 14;
            // 
            // buttonAddTopic
            // 
            buttonAddTopic.Location = new Point(27, 171);
            buttonAddTopic.Name = "buttonAddTopic";
            buttonAddTopic.Size = new Size(342, 64);
            buttonAddTopic.TabIndex = 13;
            buttonAddTopic.Text = "Topic hinzufügen";
            buttonAddTopic.UseVisualStyleBackColor = true;
            // 
            // textBoxTopicName
            // 
            textBoxTopicName.Location = new Point(27, 104);
            textBoxTopicName.Name = "textBoxTopicName";
            textBoxTopicName.Size = new Size(416, 39);
            textBoxTopicName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(22, 69);
            label5.Name = "label5";
            label5.Size = new Size(195, 32);
            label5.TabIndex = 12;
            label5.Text = "Name des Topic";
            // 
            // groupBoxPayloads
            // 
            groupBoxPayloads.Controls.Add(label7);
            groupBoxPayloads.Controls.Add(buttonClearPayloads);
            groupBoxPayloads.Controls.Add(listBoxPayloads);
            groupBoxPayloads.Location = new Point(1211, 74);
            groupBoxPayloads.Name = "groupBoxPayloads";
            groupBoxPayloads.Size = new Size(788, 944);
            groupBoxPayloads.TabIndex = 9;
            groupBoxPayloads.TabStop = false;
            groupBoxPayloads.Text = "MQTT Payloads";
            // 
            // listBoxPayloads
            // 
            listBoxPayloads.FormattingEnabled = true;
            listBoxPayloads.Location = new Point(27, 101);
            listBoxPayloads.Name = "listBoxPayloads";
            listBoxPayloads.Size = new Size(664, 740);
            listBoxPayloads.TabIndex = 0;
            // 
            // buttonClearPayloads
            // 
            buttonClearPayloads.Location = new Point(27, 860);
            buttonClearPayloads.Name = "buttonClearPayloads";
            buttonClearPayloads.Size = new Size(342, 64);
            buttonClearPayloads.TabIndex = 1;
            buttonClearPayloads.Text = "Payloads leeren";
            buttonClearPayloads.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(21, 66);
            label7.Name = "label7";
            label7.Size = new Size(115, 32);
            label7.TabIndex = 17;
            label7.Text = "Payloads";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2102, 1091);
            Controls.Add(groupBoxPayloads);
            Controls.Add(groupBoxTopics);
            Controls.Add(groupBoxConnect);
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
    }
}
