namespace Learn
{
    public class Operators
    {
        public Operators()
        {
        }

        class Counter
        {
            public int Value { get; set; }
            public int Seconds { get; set; }

            public static Counter operator +(Counter counter1, Counter counter2)
            {
                return new Counter { Value = counter1.Value + counter2.Value };
            }
            public static bool operator >(Counter counter1, Counter counter2)
            {
                return counter1.Value > counter2.Value;
            }
            public static bool operator <(Counter counter1, Counter counter2)
            {
                return counter1.Value < counter2.Value;
            }
            public static Counter operator ++(Counter counter1)
            {
                return new Counter { Value = counter1.Value + 10 };
            }
            public static bool operator true(Counter counter1)
            {
                return counter1.Value != 0;
            }
            public static bool operator false(Counter counter1)
            {
                return counter1.Value == 0;
            }

            //Преобразования: int к типу Counter
            public static implicit operator Counter(int x)
            {
                return new Counter { Seconds = x };
            }
            //Преобразования: Counter к типу int
            public static explicit operator int(Counter counter)
            {
                return counter.Seconds;
            }

        }

        public static void Main()
        {
            Counter counter1 = new Counter { Value = 23 };
            Counter counter2 = new Counter { Value = 45 };

            bool result = counter1 > counter2;
            Counter c3 = counter1 + counter2;
        }

    }
}
