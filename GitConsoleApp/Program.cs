using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace GitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string shutdown = Console.ReadLine();
            bool equalTime = true;
            while (equalTime)
            {
                TimeSpan time = DateTime.Parse(shutdown) - DateTime.Now;
                Console.WriteLine("Выключение будет в {0:t}", DateTime.Parse(shutdown));
                Console.WriteLine("До выключения осталось {0}:{1}", time.Minutes.ToString(), time.Seconds.ToString());
                Thread.Sleep(1000);
                Console.Clear();
                if (time < TimeSpan.Zero)
                {
                    Process.Start("shutdown.exe", "-h");
                    equalTime = false;
                }
            }
        }
    }
}
