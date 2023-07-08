using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    public class Collections
    {
        public static void Main()
        {
            learnCollections();
        }

        public static void learnCollections()
        {
            //list
            Console.WriteLine("Работа с коллекциями");
            List<string> list = new List<string>();
            list.Add("Первый элемент");
            list.Add("Второй элемент");
            list.Insert(1, "Вставленный элемент");
            list[0] = "Это мы вставили вместо первого элемента";
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }

            List<dynamic> listDynamic = new List<dynamic>(list);
            listDynamic.Add(57);
            foreach (var el in listDynamic)
            {
                Console.WriteLine(el);
            }

            //linkedList
            LinkedList<string> linkedList = new LinkedList<string>();
            LinkedListNode<string> node1 = linkedList.AddFirst("Skoda");
            linkedList.AddAfter(node1, "Audi");
            linkedList.AddBefore(node1, "BMW");

            foreach (var el in linkedList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine(linkedList.Last?.Previous?.Value);

            LinkedList<string> people = new LinkedList<string>(new[] { "Tom", "Sam", "Bob" });

            // от начала до конца списка
            var currentNode = people.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            // с конца до начала списка
            currentNode = people.Last;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }

            //arrayList
            ArrayList arrList = new ArrayList();
            arrList.Add(5);
            arrList.Add("Hi!");
            arrList.Add(new List<int>() { 1, 3, 3 });

            //dictionary
            Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            { "key1", "value1" }, { "key2", "value2" }
        };
            dic.Add("key3", "value3");
            Console.WriteLine(dic["key2"]);

            foreach (string el in dic.Keys)
            {
                Console.WriteLine($"Key: {el}, {dic[el]}");
            }
            foreach (KeyValuePair<string, string> el in dic)
            {
                Console.WriteLine(el.Key);
                Console.WriteLine(el.Value);
            }
            bool containsKey = dic.ContainsKey("key99");
            bool containsValue = dic.ContainsValue("value99");

            //queue
            Queue<string> que = new Queue<string>();
            que.Enqueue("Alex");
            que.Enqueue("John");
            que.Enqueue("Bob");

            Console.WriteLine(que.Dequeue());
            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Dequeue());

            //stack
            Stack<string> stack = new Stack<string>();
            stack.Push("David");
            stack.Push("Emil");
            stack.Push("Danny");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
        }

    }
}
