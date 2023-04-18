using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns
{
    interface IObserver
    {
        void handleEvent(List<String> vacancies);
    }
}
