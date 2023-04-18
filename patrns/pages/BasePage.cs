using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns.pages
{
    abstract class BasePage
    {
        public void ShowPage()
        {
            Console.WriteLine("Header");
            ShowContent();
            Console.WriteLine("Footer");
        }

        protected abstract void ShowContent();
    }
}
