using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns
{
    class Subscriber : IObserver
    {
        private String name;
        public Subscriber(String name)
        {
            this.name = name;
        }
        public void handleEvent(List<string> vacancies)
        {
            Console.WriteLine(name + " Для вас есть обновлённый список вакансий \n");
            foreach (String i in vacancies)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n================================\n");
        }
    }
}
