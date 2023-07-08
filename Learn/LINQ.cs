using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger.Learn
{
    public class LINQ
    {
        public static void Main()
        {
           learnLINQ();
        }

        public static void learnLINQ()
        {
            int[] nums = { 5, 7, -6, 0, 5, 0, 9, 58, -51, 6001 };
            var ln = nums.Skip(1).Take(9).Where(el => el % 2 != 0 && el >= 0);
            List<int> list = ln.ToList();
            foreach (int num in list)
            {
                Console.WriteLine(num.ToString());
            };
            nums = ln.ToArray();
            foreach (int num in nums)
            {
                Console.WriteLine(num.ToString());
            };
            Console.WriteLine("Count is " + ln.Count());
            Console.WriteLine("Sum is " + ln.Sum());
            Console.WriteLine("Average is " + ln.Average());
            Console.WriteLine("Max is " + ln.Max());
            Console.WriteLine("Min is " + ln.Min());

            int[] nums_new = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var ln_new1 = nums_new.Select(i => i).ToList();
            var ln_new2 = nums_new.Select(i => i * 2).Where(i => i > 9).OrderBy(i => -i).ToList();
            foreach (int num in ln_new1)
            {
                Console.WriteLine(num.ToString());
            };
            foreach (int num in ln_new2)
            {
                Console.WriteLine(num.ToString());
            };

            List<int> list_new = (from el in nums_new where el % 2 == 0 select el + 1).ToList();
            foreach (int num in list_new)
            {
                Console.WriteLine(num.ToString());
            };

            string[] cars = { "Audi", "Skoda", "BMW", "Porsche" };
            string[] cars_new = { "Audi", "Chevrolet", "BMW" };

            string[] carsList = cars.Where(i => i.ToLower().StartsWith("po")).ToArray();

            foreach (string name in carsList)
            {
                Console.WriteLine(name);
            };

            var result1 = cars.Except(cars_new).ToArray();
            var result2 = cars.Intersect(cars_new).ToArray();
            var result3 = cars.Union(cars_new).ToArray();
            var result4 = cars.Zip(cars_new, (x, y) => x + " - " + y).ToArray();
            var result5 = cars.All(i => i == "Audi");
            var result6 = cars.Any(i => i == "Audi");

            Console.WriteLine("Except");
            foreach (string name in result1)
            {
                Console.WriteLine(name);
            };
            Console.WriteLine("Intersect");
            foreach (string name in result2)
            {
                Console.WriteLine(name);
            };
            Console.WriteLine("Union");
            foreach (string name in result3)
            {
                Console.WriteLine(name);
            };
            Console.WriteLine("Zip");
            foreach (string name in result4)
            {
                Console.WriteLine(name);
            };
            Console.WriteLine("All");
            Console.WriteLine(result4);
            Console.WriteLine("Any");
            Console.WriteLine(result5);

        }

    }
}
