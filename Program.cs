using System;
using System.IO;
using System.Reflection;

namespace Lab3
{
    internal class Program
    {
        static void Main()
        {
            string path = "example.txt";

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("username: myUsername");
                    sw.WriteLine("password: myPassword");
                }
            }

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}