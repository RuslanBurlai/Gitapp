using Newtonsoft.Json;
using System;
using System.IO;

namespace GitConsoleApp
{
    class Program
    {
        static private void DeleteFile(string path)
        {
            File.Delete(path);
        }
        static void Main(string[] args)
        {
            string s = null;
            
            Console.WriteLine(s);
            if (s != null)
                Console.WriteLine(s.Length);

            Console.WriteLine(File.ReadAllText(@"D:\111.txt"));
            Program product = new Program();
            string json = JsonConvert.SerializeObject(product);

            Console.WriteLine(json);
        }
    }
}
