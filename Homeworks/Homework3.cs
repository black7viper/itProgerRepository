using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    internal class Homework3
    {
        public static void Main()
        {
            rpcPlayer bot = new rpcPlayer();
            rpcPlayer alex = new rpcPlayer(VARIANTS.PAPER, "Alex");

            Console.WriteLine(bot.whoWins(bot, alex));
        }

        class rpcPlayer
        {
            string name;
            VARIANTS var;

            public rpcPlayer()
            {
                this.name = "bot";
                Random r = new Random();
                Array values = Enum.GetValues(typeof(VARIANTS));
                int n = r.Next(0, values.Length);
                this.var = (VARIANTS)values.GetValue(n);
            }

            public rpcPlayer(VARIANTS _var, string _name)
            {
                this.name = _name;
                this.var = _var;
            }

            public string whoWins(rpcPlayer p1, rpcPlayer p2)
            {
                int resultInt;
                if (p1.var == VARIANTS.PAPER && p2.var == VARIANTS.ROCK)
                {
                    resultInt = 1;
                }
                else if (p1.var == VARIANTS.PAPER && p2.var == VARIANTS.SCISSORS)
                {
                    resultInt = 2;
                }
                else if (p1.var == VARIANTS.ROCK && p2.var == VARIANTS.PAPER)
                {
                    resultInt = 2;
                }
                else if (p1.var == VARIANTS.ROCK && p2.var == VARIANTS.SCISSORS)
                {
                    resultInt = 1;
                }
                else if (p1.var == VARIANTS.SCISSORS && p2.var == VARIANTS.ROCK)
                {
                    resultInt = 2;
                }
                else if (p1.var == VARIANTS.SCISSORS && p2.var == VARIANTS.PAPER)
                {
                    resultInt = 1;
                }
                else
                {
                    resultInt = 0;
                }

                string winString = "Победил игрок: ";
                string resultString = (resultInt == 1) ? winString + p1.name : (resultInt == 2) ? winString + p2.name : "Ничья";

                return resultString;
            }

        }

        public enum VARIANTS
        {
            ROCK, PAPER, SCISSORS
        }
    }
}
