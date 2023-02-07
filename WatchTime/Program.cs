using System;
using System.Threading;

namespace WatchTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread thread1 = new Thread();
            //Thread thread2 = new Thread();
            //Thread thread3 = new Thread();


            //thread1.Start();
            //thread2.Start();
            //thread3.Start();
            Clock();
        }


        static void Clock()
        {
            DateTime now;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                now = DateTime.Now;
                Console.Write($"{now.Hour.ToString("00")}:{now.Minute.ToString("00")}:{now.Second.ToString("00")}");
                Thread.Sleep(1000);
            }
        }
      
    }
}
