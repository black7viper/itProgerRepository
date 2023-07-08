using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace itProger
{
    internal class Homework4
    {
        public static void Main()
        {
            User user = new User();
            Console.Write("Введите имя: ");
            user.name = Console.ReadLine();

            Console.Write("Введите логин: ");
            user.login = Console.ReadLine();

            Console.Write("Введите возраст: ");
            user.age = Console.ReadLine();

            Console.Write("Введите хобби: ");
            string? hobbie = Console.ReadLine();

            user.hobbie = hobbie.Split(",");

            XmlSerializer xml = new XmlSerializer(typeof(User));
            string path = "D:\\Projects_C#\\itProgerGit\\User.xml";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, user);
            }
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {

                User user_new = xml.Deserialize(fs) as User;
                Console.WriteLine($"Пользователь: {user_new.name} с логином {user_new.login}. Его возраст: {user_new.age}. Хобби:");
                foreach (string s in user_new.hobbie)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("Десериализация прошла успешно");
            }

        }

        [Serializable]
        public class User
        {
            public User() { }

            public string name;
            public string login;
            public string age;
            public string[] hobbie;
        }
    }
}
