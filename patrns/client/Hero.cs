using paterns.factorys;
using paterns.movments;
using paterns.wepons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns.client
{
    class Hero
    {
        private Wepon wepon;
        private Movement movement;

        public Hero(HeroFactory factory)
        {
            wepon = factory.CreateWepon();
            movement = factory.CreateMovment();
        }

        public void Run()
        {
            movement.Move();
        }

        public void Hit()
        {
            wepon.Hit();
        }
    }
}
