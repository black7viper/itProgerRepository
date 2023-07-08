using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    internal class HomeworkPasswordChecker
    {
        public static void Main()
        {

            PasswordChecker passwordChecker = new PasswordChecker();

            string inputString;
            int inputInt;

            Console.Write("Введите мин. длину пароля: ");
            inputString = Console.ReadLine();
            if (Int32.TryParse(inputString, out inputInt))
            {
                passwordChecker.MinLength = inputInt;
            }
            else
            {
                throw new ArgumentException("Введите число!");
            }

            Console.Write("Введите макс. допустимое количество повторений символа подряд: ");
            inputString = Console.ReadLine();
            if (Int32.TryParse(inputString, out inputInt))
            {
                passwordChecker.MaxRepeats = inputInt;
            }
            else
            {
                throw new ArgumentException("Введите число!");
            }

            while (true)
            {
                Console.Write("Введите пароль или end: ");
                inputString = Console.ReadLine();
                if (inputString == "end")
                {
                    break;
                }
                else
                {
                    if (passwordChecker.verify(inputString))
                    {
                        Console.WriteLine("Подходит, справился!");
                    }
                    else
                    {
                        Console.WriteLine("Хлебушек, кто тебя пароли учил вводить?");
                    }
                }
            }

        }

        class PasswordChecker
        {
            public delegate void PasswordPropertiesHandler();
            public event PasswordPropertiesHandler? Notify;

            int? minLength;
            int? maxRepeats;

            public int? MinLength { set { if (value < 0) { throw new ArgumentException("Введите корректное число"); } else { minLength = value; } } }
            public int? MaxRepeats { get => maxRepeats; set => maxRepeats = value; }

            public bool verify(string password)
            {
                if (minLength == null || maxRepeats == null)
                {
                    throw new InvalidOperationException("Не заполнен один из параметров");
                }
                else
                {
                    if (checkLength() && checkRepeats())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                bool checkLength()
                {
                    if (password.Length >= this.minLength)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    };
                }
                bool checkRepeats()
                {
                    char[] arr = password.ToCharArray();

                    int repeats = 1;
                    for (int i = 1; i < arr.Length; i++)
                    {
                        if (arr[i] == arr[i - 1])
                        {
                            repeats++;
                        }
                        else
                        {
                            repeats = 1;
                        }

                        if (repeats > this.maxRepeats)
                        {
                            return false;
                        }

                    }
                    return true;

                }

            }


        }

    }
}
