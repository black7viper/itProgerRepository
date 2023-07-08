namespace Learn
{
    internal class References
    {
        public static void Main()
        {
            int a = 5;
            int b = 8;
            ref int pointer = ref Max(ref a, ref b);
            pointer = 34;   // меняем значением максимального числа
            Console.WriteLine($"a: {a}  b: {b}"); // a: 5   b: 34

            ref int Max(ref int n1, ref int n2)
            {
                if (n1 > n2)
                    return ref n1;

                else
                    return ref n2;
            }
        }
    }
}
