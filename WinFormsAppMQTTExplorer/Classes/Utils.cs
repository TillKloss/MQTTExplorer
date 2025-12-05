using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsAppMQTTExplorer.Classes
{
    public class Utils
    {
        public string PrettyPrintJson(string rawJson)
        {
            try
            {
                using var document = JsonDocument.Parse(rawJson);
                return JsonSerializer.Serialize(document, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            }
            catch
            {
                return rawJson;
            }
        }

        public void HighlightJson(RichTextBox box)
        {
            box.SuspendLayout();

            int cursorPos = box.SelectionStart;

            box.SelectAll();
            box.SelectionColor = Color.Black;

            string text = box.Text;

            //keys
            foreach (Match match in Regex.Matches(text, "\"(.*?)\"(?=\\s*:)"))
            {
                box.Select(match.Index, match.Length);
                box.SelectionColor = Color.Blue;
            }

            //values
            foreach (Match match in Regex.Matches(text, ":\\s*\"(.*?)\""))
            {
                box.Select(match.Index + 2, match.Length - 2);
                box.SelectionColor = Color.DarkGreen;
            }

            //nums
            foreach (Match match in Regex.Matches(text, @"\b\d+(\.\d+)?\b"))
            {
                box.Select(match.Index, match.Length);
                box.SelectionColor = Color.DarkOrange;
            }

            //bools
            foreach (Match match in Regex.Matches(text, @"\b(true|false|null)\b"))
            {
                box.Select(match.Index, match.Length);
                box.SelectionColor = Color.Purple;
            }

            box.SelectionStart = cursorPos;
            box.SelectionLength = 0;
            box.SelectionColor = Color.Black;

            box.ResumeLayout();
        }
    }
}
