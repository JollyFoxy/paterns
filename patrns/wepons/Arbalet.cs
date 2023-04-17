using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.wepons
{
    class Arbalet : Wepon
    {
        public override void Hit()
        {
            Console.WriteLine("Выстрел из арбалета");
        }
    }
}
