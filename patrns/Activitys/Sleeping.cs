﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns.Activitys
{
    class Sleeping : IActivity
    {
        public void DoIt()
        {
            Console.WriteLine("В отрубе жеском...");
        }
    }
}
