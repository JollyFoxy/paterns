using patrns.pages;
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
            HomePage homePage = new HomePage();
            NewsPage newsPage = new NewsPage();

            homePage.ShowPage();
            Console.WriteLine("\n==================================================\n");
            newsPage.ShowPage();

            Console.ReadKey();
        }
    }
}
