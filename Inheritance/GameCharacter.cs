using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class GameCharacter
    {
        public int HP = 100;
        public string Name;

        public GameCharacter(int health, string name)
        {
            HP = health;
            Name = name;
        }

        public void TakeDMG(int DMG)
        {
            Console.WriteLine(Name + " is taking " + DMG + " damage");
            HP -= DMG;
            if(HP < 0)
            {
                HP = 0;
            }
        }

        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine(Name + "'s Stats");
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("----------------------");
            Console.WriteLine();
        }

    }
}
