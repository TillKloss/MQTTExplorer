using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsAppMQTTExplorer.Classes
{
    internal class JSONHandler
    {
        private static string filePath = "data/connections.json";

        public static void SaveConnections(IEnumerable<Connection> connections)
        {
            var json = JsonSerializer.Serialize(connections, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, json);
        }

        public static List<Connection> LoadConnections()
        {
            if (!File.Exists(filePath))
                return new List<Connection>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Connection>>(json) ?? new List<Connection>();
        }
    }
}
