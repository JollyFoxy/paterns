using patrns;
using patrns.Activitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();

            developer.setActivity(new Coding());
            developer.executeActivity();

            developer.setActivity(new Reading());
            developer.executeActivity();

            developer.setActivity(new Sleeping());
            developer.executeActivity();

            Console.ReadKey();
        }
    }
}
