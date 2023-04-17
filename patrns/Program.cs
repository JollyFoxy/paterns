using patrns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloperFactory developerFactory = CrateDeveloperBySpec("java");
            IDeveloper developer = developerFactory.CreateDeveloper();

            developer.WriteCode();
            Console.ReadKey();
           
        }

        static IDeveloperFactory CrateDeveloperBySpec(string spec)
        {
            if (spec.Equals("c#"))
            {
                return new CsDeveloperFactory();
            } else if (spec.Equals("java"))
            {
                return new JavaDeveloperFactory();
            } else if (spec.Equals("python"))
            {
                return new PythonDeveloperFactory();
            }
            else
            {
                throw new Exception(spec + " is unknow spec");
            }

        }
    }
    
}
