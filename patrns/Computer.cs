using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns
{
    class Computer
    {
        public Os Os { get; set; }
        public void Launch(string osName)
        {
            Os = Os.getInstance(osName);
        }
    }
}
