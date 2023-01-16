using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Player player = new Player(10, "FalseBacon");
            Enemy enemy = new Enemy(10, "Enemy");

            player.ShowStats();
            player.TakeDMG(5);
            player.ShowStats();

            enemy.ShowStats();
            enemy.TakeDMG(11);
            enemy.ShowStats();

            Console.ReadKey(true);

        }
    }
}
