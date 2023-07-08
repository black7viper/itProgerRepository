using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    public class BasicTypesFilesExceptions
    {
        public static void Main()
        {
            learnDate();
            learnStrings();
            learnDirectories();
            learnFiles();
            learnExceptions();
        }
        public static void learnDate()
        {
            Console.WriteLine("Работа с датами");
            DateTime t = new DateTime();
            t = DateTime.Now;
            Console.WriteLine(t.ToString("Сегодня: dd.MMMM.yyyy"));
        }

        public static void learnStrings()
        {
            Console.WriteLine("Работа со сторками");
            string s = " Skoda.Fabia. TSI";
            Console.WriteLine(s.Trim().ToUpper().ToLower());
            string[] sm = s.Split(".");
            foreach (string name in sm)
            {
                Console.WriteLine(name.Trim());
            }
            Console.WriteLine(String.Join(", ", sm));
        }

        public static void learnDirectories()
        {
            Console.WriteLine("Работа с директориями");
            DirectoryInfo di = new DirectoryInfo("Info");
            if (!di.Exists)
            {
                Console.WriteLine("Не существует");
                di.Create();
            }
            else
            {
                string[] filesList = Directory.GetFiles("obj");
                foreach (var el in filesList)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public static void learnFiles()
        {
            Console.WriteLine("Работа с файлами");
            FileStream fs = new FileStream("Info/info.txt", FileMode.OpenOrCreate);
            byte[] arr = System.Text.Encoding.Default.GetBytes("some");
            fs.Write(arr);
            fs.Close();

            // Console.WriteLine("Введите текст:"); 
            // string? user_input = Console.ReadLine() ?? "Грустно, потому что ты ничего не ввел";
            // Console.WriteLine(user_input);

            using (FileStream fss = new FileStream("Info/info.txt", FileMode.OpenOrCreate))
            {
                byte[] arrr = System.Text.Encoding.Default.GetBytes("some");
                fss.Write(arrr);
            }
        }

        public static void learnExceptions()
        {
            Console.WriteLine("Работа с исключениями");
            try
            {
                Console.WriteLine("Введите число:");
                int num = Int32.Parse("5");
                int div = 1 / num;

                throw new Exception("Ошибка это ты, пёс");

            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Вы ввели ноль!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Непонятная ошибка: {e.Message}");

            }
            finally
            {
                Console.WriteLine("Сюда мы попадем в любом случае");
            }
        }

    }
}
