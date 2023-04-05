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
            Computer comp = new Computer();
            comp.Launch("Win8");
            Console.WriteLine(comp.Os.Name);

            //Невозможно изменить имя...
            comp.Os = Os.getInstance("Windows 10");
            Console.WriteLine(comp.Os.Name);

            Console.ReadLine();
        }
    }
    
}
