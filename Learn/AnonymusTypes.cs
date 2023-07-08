using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    public class AnonymusTypes
    {
        public static void Main()
        {
            learnAnonymusTypes();
        }
        public static void learnAnonymusTypes()
        {

            // Предположим, у нас есть база данных с таблицей "Users"
            // и у каждого пользователя есть поля "Name" и "Age"

            // Создаем объект контекста базы данных
            var dbContext = new MyDbContext();

            // Выполняем выборку пользователей из базы данных
            var users = dbContext.Users.Select(user => new
            {
                user.Name,
                user.Age
            });

            // Обрабатываем результаты выборки
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name}, Age: {user.Age}");
            }

        }

        class MyDbContext
        {
            // Методы и свойства для работы с базой данных
            // ...

            // Пример определения класса пользователя
            public class User
            {
                public string? Name { get; set; }
                public int Age { get; set; }
            }

            // Пример коллекции пользователей
            public IQueryable<User> Users { get; } = new[]
            {
                new User { Name = "John", Age = 25 },
                new User { Name = "Jane", Age = 30 },
                new User { Name = "Bob", Age = 35 }
            }.AsQueryable();
        }

    }
}
