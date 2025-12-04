using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMQTTExplorer.Classes
{
    internal class Connection
    {
        private string name;
        private string broker;
        private int port;

        public Connection(string name, string broker, int port)
        {
            this.name = name;
            this.broker = broker;
            this.port = port;
        }

        public string Name { get => name; set => name = value; }
        public string Broker { get => broker; set => broker = value; }
        public int Port { get => port; set => port = value; }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
