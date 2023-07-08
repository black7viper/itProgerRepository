namespace itProger
{
    public class Threads
    {
        public static void Main()
        {
            learnThreads();
        }
        public static void learnThreads()
        {
            Task task1 = new Task(Print);
            task1.Start();
            //or
            Task task2 = Task.Factory.StartNew(Print);
            //or
            Task task3 = Task.Run(Print);

            Thread.Sleep(1);
            //or
            task1.Wait();

            Task[] taskArr = {
            new Task(Print), new Task(()=>{
            Console.WriteLine("Task 2");
            Task task4 = Task.Run(() =>
            {
                Console.WriteLine("Task 3");
            });
            })
        };

            foreach (Task task in taskArr)
            {
                task.Start();
                task.Wait();
            }

            Thread.Sleep(3000);
            Task.WaitAll(taskArr);


            Parallel.Invoke(Print, () => { Console.WriteLine("Data"); }, () =>
            {
                Console.WriteLine("No Data");
                Thread.Sleep(2000);
            });
        }

        public static void Print()
        {
            Console.WriteLine("Task 1 running");
        }

    }
}
