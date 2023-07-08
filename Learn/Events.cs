using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger.Learn
{
    public  class Events
    {
        static void Main()
        {
            learnEvents();
        }
        public static void learnEvents()
        {
            Player player1 = new Player();
            player1.ActionHealth += DisplayMessage;
            player1.Damage(50);
            player1.Heal(20);
            Console.WriteLine();
        }

        public static void DisplayMessage(int health)
        {
            Console.WriteLine($"Жизнь игрока: {health}");
        }

    }
}
