using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns
{
    class Os
    {
        private static Os instance;
        public string Name { get; private set; }
        private Os(string name)
        {
            this.Name = name;
        }
        public static Os getInstance(string name)
        {
            if (instance == null)
                instance = new Os(name);
            return instance;
        }
    }
}
