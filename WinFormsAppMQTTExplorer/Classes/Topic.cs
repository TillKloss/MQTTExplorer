using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMQTTExplorer.Classes
{
    public class Topic
    {
        private string name;

        public Topic(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
