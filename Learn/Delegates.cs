using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    internal class Delegates
    {
        public static void Main()
        {
            learnDelegates();
        }
        public static void learnDelegates()
        {
            //ex1
            MessageDayOrNight messageDayOrNight;

            if (DateTime.Now.Hour > 12)
            {
                messageDayOrNight = GoodDay;
                GoodDay();
            }
            else
            {
                messageDayOrNight = GoodNight;
                GoodNight();
            }

            messageDayOrNight += Hello;
            messageDayOrNight += Hello;
            messageDayOrNight -= Hello;

            messageDayOrNight();

            //ex2
            Calculate(5, 7, Add);
            Calculate(5, 7, Subtract);
            Calculate(5, 7, Multiply);

            //ex3
            Operation operation = SelectOperation(OperationType.Add);
            Console.WriteLine(operation(10, 4));    // 14

            operation = SelectOperation(OperationType.Subtract);
            Console.WriteLine(operation(10, 4));    // 6

            operation = SelectOperation(OperationType.Multiply);
            Console.WriteLine(operation(10, 4));    // 40
        }

        delegate void MessageDayOrNight();
        public delegate int Action(int x1, int x2);
        public delegate int Operation(int x, int y);
        static void GoodDay()
        {
            Console.WriteLine("Good Day!");
        }
        static void GoodNight()
        {
            Console.WriteLine("Good Night!");
        }
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
        static void Calculate(int x, int y, Action action)
        {
            Console.WriteLine(action(x, y));
        }
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;
        public static Operation SelectOperation(OperationType opType)
        {
            switch (opType)
            {
                case OperationType.Add: return Add;
                case OperationType.Subtract: return Subtract;
                default: return Multiply;
            }
        }
        public enum OperationType
        {
            Add, Subtract, Multiply
        }

    }
}
