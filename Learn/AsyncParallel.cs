using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger.Learn
{
    public class AsyncParallel
    {
        public static async Task Main()
        {
            await learnAsync();         
        }
        public static async Task learnAsync()
        {
            Console.WriteLine("Основной метод");
            await PrintAsync();
            Console.WriteLine("Финиш");

            string result = await Client.getData();
            Console.WriteLine("Ждем загрузку данных 1");
            Console.WriteLine("Ждем загрузку данных 2");
            Console.WriteLine("Ждем загрузку данных 3");
            Console.WriteLine("Ждем загрузку данных 4");
            Console.WriteLine("Ждем загрузку данных 5");
            //Task.Delay(1000);
            Console.WriteLine(result);

            int[] numbers = { 1, 9999, 3, 4999, 5 };
            int sum = 0;

            Parallel.ForEach(numbers, (number) =>
            {
                Console.WriteLine("Сумма: " + number);
                //Thread.Sleep(1000);
                sum += number;
            });

            Console.WriteLine("Сумма: " + sum);

            Console.WriteLine("Работа с JSON");
            string jsonData = await Client.getJSONData();
            Console.WriteLine(jsonData);
            try
            {
                Todo todo = JsonConvert.DeserializeObject<Todo>(jsonData) ?? throw new Exception("Не удалось обработать JSON");
                Console.WriteLine($"ID: {todo.id}. User ID: {todo.userId}. Title: {todo.completed}. Completed: {todo.completed}. ID which is not in JSON: {todo.id_notJson}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок Finally после обработки JSON");
            }

        }

        public static async Task PrintAsync()
        {
            Console.WriteLine("Дождались");
        }

        class Client
        {
            private static HttpClient http = new HttpClient();
            public static async Task<string> getData()
            {
                string result1 = await http.GetStringAsync("https://reqres.in/api/users/2");
                return result1;
            }
            public static async Task<string> getJSONData()
            {
                string result1 = await http.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");
                return result1;
            }
        }

        class Todo
        {
            public int userId;
            public int id;
            public string? id_notJson;
            public string title;
            public bool completed;
        }

    }
}
