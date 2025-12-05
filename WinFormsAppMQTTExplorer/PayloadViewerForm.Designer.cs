namespace WinFormsAppMQTTExplorer
{
    partial class PayloadViewerForm
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
            label1 = new Label();
            richTextBoxPayload = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 1;
            label1.Text = "Payload";
            // 
            // richTextBoxPayload
            // 
            richTextBoxPayload.Location = new Point(26, 69);
            richTextBoxPayload.Name = "richTextBoxPayload";
            richTextBoxPayload.ReadOnly = true;
            richTextBoxPayload.Size = new Size(609, 626);
            richTextBoxPayload.TabIndex = 2;
            richTextBoxPayload.Text = "";
            richTextBoxPayload.WordWrap = false;
            // 
            // PayloadViewerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 733);
            Controls.Add(richTextBoxPayload);
            Controls.Add(label1);
            Name = "PayloadViewerForm";
            Text = "PayloadViewerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private RichTextBox richTextBoxPayload;
    }
}