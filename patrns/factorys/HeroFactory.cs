using paterns.movments;
using paterns.wepons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paterns.factorys
{
    abstract class HeroFactory
    {
        public abstract Movement CreateMovment();
        public abstract Wepon CreateWepon();

    }
}
