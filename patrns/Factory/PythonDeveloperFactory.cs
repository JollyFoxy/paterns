using patrns.Developers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns.Factory
{
    class PythonDeveloperFactory : IDeveloperFactory
    {
        public IDeveloper CreateDeveloper()
        {
            return new PythonDeveloper();
        }
    }
}
