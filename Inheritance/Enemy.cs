using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Enemy : GameCharacter
    {
        public Enemy(int HP, string name) : base(HP, name)
        {

        }
    }
}
