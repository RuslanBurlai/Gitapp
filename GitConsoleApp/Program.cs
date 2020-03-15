using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;

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
                if (time < TimeSpan.Zero)
                {
                    Process.Start("shutdown.exe", "-h");
                    equalTime = false;
                    Console.WriteLine(time);
                }
            }
        }
    }
}
