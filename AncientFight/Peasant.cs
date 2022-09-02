using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncientFight
{
    internal class Peasant : Unit
    {
        public Peasant() : base(500, 100 , 3)
        {
            health = 500;
            moveSpeed = 100;
            Damage = 3;
        }
    }
}
