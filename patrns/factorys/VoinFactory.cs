using paterns.factorys;
using paterns.movments;
using paterns.wepons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns.factorys
{
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovment()
        {
            return new RunMovement();
        }

        public override Wepon CreateWepon()
        {
            return new Sword();
        }
    }
}
