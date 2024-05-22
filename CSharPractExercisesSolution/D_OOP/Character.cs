using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    class Character
    {
        private int health = 100;
        public int Health { get; private set; } = 100;

        public void  Hit (int damege)
        {
            health-=damege;
        }
    }
}
