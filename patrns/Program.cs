using patrns;
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
            JobSite jobSite = new JobSite();

            jobSite.addVacacies("Уборщик");
            jobSite.addVacacies("Гущик");

            IObserver observer1 = new Subscriber("Viktor");
            IObserver observer2 = new Subscriber("Eremei");

            jobSite.addObserver(observer1);
            jobSite.addObserver(observer2);

            Console.WriteLine("\n--------------------------\n");

            jobSite.addVacacies("Садовник");

            Console.WriteLine("\n--------------------------\n");

            jobSite.removeVacacies("Уборщик");
            jobSite.removeObserver(observer2);

            Console.WriteLine("\n--------------------------\n");

            jobSite.addVacacies("Уборщик");

            Console.ReadKey();
        }
    }
}