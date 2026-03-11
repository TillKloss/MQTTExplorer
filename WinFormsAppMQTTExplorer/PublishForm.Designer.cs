namespace WinFormsAppMQTTExplorer
{
    partial class PublishForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxPublishRadioButtons = new GroupBox();
            radioButtonPublishJSON = new RadioButton();
            radioButtonPublishRaw = new RadioButton();
            labelPublishTopic = new Label();
            textBoxPublishTopic = new TextBox();
            labelPublishContent = new Label();
            richTextBoxPublishContent = new RichTextBox();
            buttonPublish = new Button();
            groupBoxPublishRadioButtons.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPublishRadioButtons
            // 
            groupBoxPublishRadioButtons.Controls.Add(radioButtonPublishJSON);
            groupBoxPublishRadioButtons.Controls.Add(radioButtonPublishRaw);
            groupBoxPublishRadioButtons.Location = new Point(6, 12);
            groupBoxPublishRadioButtons.Name = "groupBoxPublishRadioButtons";
            groupBoxPublishRadioButtons.Size = new Size(233, 68);
            groupBoxPublishRadioButtons.TabIndex = 0;
            groupBoxPublishRadioButtons.TabStop = false;
            groupBoxPublishRadioButtons.Text = "Typ";
            // 
            // radioButtonPublishJSON
            // 
            radioButtonPublishJSON.AutoSize = true;
            radioButtonPublishJSON.Location = new Point(154, 29);
            radioButtonPublishJSON.Name = "radioButtonPublishJSON";
            radioButtonPublishJSON.Size = new Size(65, 24);
            radioButtonPublishJSON.TabIndex = 1;
            radioButtonPublishJSON.TabStop = true;
            radioButtonPublishJSON.Text = "JSON";
            radioButtonPublishJSON.UseVisualStyleBackColor = true;
            // 
            // radioButtonPublishRaw
            // 
            radioButtonPublishRaw.AutoSize = true;
            radioButtonPublishRaw.Location = new Point(6, 29);
            radioButtonPublishRaw.Name = "radioButtonPublishRaw";
            radioButtonPublishRaw.Size = new Size(58, 24);
            radioButtonPublishRaw.TabIndex = 0;
            radioButtonPublishRaw.TabStop = true;
            radioButtonPublishRaw.Text = "Raw";
            radioButtonPublishRaw.UseVisualStyleBackColor = true;
            // 
            // labelPublishTopic
            // 
            labelPublishTopic.AutoSize = true;
            labelPublishTopic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPublishTopic.Location = new Point(6, 99);
            labelPublishTopic.Name = "labelPublishTopic";
            labelPublishTopic.Size = new Size(46, 20);
            labelPublishTopic.TabIndex = 1;
            labelPublishTopic.Text = "Topic";
            // 
            // textBoxPublishTopic
            // 
            textBoxPublishTopic.Location = new Point(6, 122);
            textBoxPublishTopic.Name = "textBoxPublishTopic";
            textBoxPublishTopic.Size = new Size(227, 27);
            textBoxPublishTopic.TabIndex = 2;
            // 
            // labelPublishContent
            // 
            labelPublishContent.AutoSize = true;
            labelPublishContent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPublishContent.Location = new Point(6, 171);
            labelPublishContent.Name = "labelPublishContent";
            labelPublishContent.Size = new Size(50, 20);
            labelPublishContent.TabIndex = 3;
            labelPublishContent.Text = "Inhalt";
            // 
            // richTextBoxPublishContent
            // 
            richTextBoxPublishContent.Location = new Point(6, 194);
            richTextBoxPublishContent.Name = "richTextBoxPublishContent";
            richTextBoxPublishContent.Size = new Size(354, 237);
            richTextBoxPublishContent.TabIndex = 4;
            richTextBoxPublishContent.Text = "";
            // 
            // buttonPublish
            // 
            buttonPublish.Location = new Point(6, 437);
            buttonPublish.Name = "buttonPublish";
            buttonPublish.Size = new Size(227, 29);
            buttonPublish.TabIndex = 5;
            buttonPublish.Text = "Publish";
            buttonPublish.UseVisualStyleBackColor = true;
            buttonPublish.Click += buttonPublish_Click;
            // 
            // PublishForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 480);
            Controls.Add(buttonPublish);
            Controls.Add(richTextBoxPublishContent);
            Controls.Add(labelPublishContent);
            Controls.Add(textBoxPublishTopic);
            Controls.Add(labelPublishTopic);
            Controls.Add(groupBoxPublishRadioButtons);
            Name = "PublishForm";
            Text = "PublishForm";
            groupBoxPublishRadioButtons.ResumeLayout(false);
            groupBoxPublishRadioButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPublishRadioButtons;
        private RadioButton radioButtonPublishJSON;
        private RadioButton radioButtonPublishRaw;
        private Label labelPublishTopic;
        private TextBox textBoxPublishTopic;
        private Label labelPublishContent;
        private RichTextBox richTextBoxPublishContent;
        private Button buttonPublish;
    }
}