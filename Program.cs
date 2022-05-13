using System;
using System.Threading;

namespace timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(new ThreadStart(timer));

                myThread.Start();
        }
        public static void timer()
        {
            System.DateTime date1 = new DateTime(2022, 2, 16, 20, 0, 0);
            while (true)
            {
                System.DateTime date2 = DateTime.Now;
                Console.WriteLine("Текущее дата-время: " + date2 + "\r\n");
                Console.WriteLine("Обнова будет: " + date1 + "\r\n");
                System.TimeSpan diff1 = date1.Subtract(date2);
                Console.WriteLine("Осталось ждать: " + diff1 + "\r\n");
                Thread.Sleep(950);
                Console.Clear();
            }
        }
    }
}
