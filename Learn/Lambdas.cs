using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger.Learn
{
    internal class Lambdas
    {
        public static void Main()
        {
            learnLambdas();
        }
        internal static void learnLambdas()
        {
            var hello = () => Console.WriteLine("Hello");
            var add = (int x, int y) => x + y;
            var sub = (int x, int y) => x - y;
            int res1 = add(5, 6);
            Console.WriteLine(res1);
            add += sub;
            int res2 = add(5, 6);
            Console.WriteLine(res2);

            OperationVoid sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");
            sum(1, 2);       // 1 + 2 = 3
            sum(22, 14);    // 22 + 14 = 36

            Message message1 = word => Console.WriteLine(word);
            Message message2 = (word) => Console.WriteLine(word);
            Message message3 = word => { Console.WriteLine("First " + word); Console.WriteLine("Second " + word); };

            message3(res1.ToString());
            message3(res2.ToString());

        }
        delegate void OperationVoid(int x, int y);
        delegate void Message(string Name);
    }
}
