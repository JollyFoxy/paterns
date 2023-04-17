using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns.Factory
{
    class CsDeveloperFactory : IDeveloperFactory
    {
        public IDeveloper CreateDeveloper()
        {
            return new CsDeveloder();
        }
    }
}
