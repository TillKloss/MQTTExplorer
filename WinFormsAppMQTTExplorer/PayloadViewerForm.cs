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
    public partial class PayloadViewerForm : Form
    {
        Utils utils;
        public PayloadViewerForm(Payload payload)
        {
            InitializeComponent();

            utils = new Utils();

            Text = $"[{payload.Timestamp:HH:mm:ss}] {payload.Topic.Name}";
            richTextBoxPayload.Text = utils.PrettyPrintJson(payload.Value);
            utils.HighlightJson(richTextBoxPayload);
        }
    }
}
