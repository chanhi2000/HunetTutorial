using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace E_Async
{
    public class AsyncTest
    {
        public static void Main(string[] args)
        {
            Task task = new Task(ProcessDataAsync);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        public static async void ProcessDataAsync() 
        {
            Task<int> task = HandleFileAsync("Task.txt");
            System.Console.WriteLine("기다리는 중입니다. ");
            int x = await task;
            System.Console.WriteLine("count : "+ x);
        }

        public static async Task<int> HandleFileAsync(string file)
        {
            System.Console.WriteLine("파일을 엽니다. ");
            int count = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();
                count += v.Length;
                for (int i=0; i < 10000; i++)
                {
                    int x = v.GetHashCode();
                    if (x ==0 )
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("파일을 닫습니다. ");
            return count;
        }
    }
}
