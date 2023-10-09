using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jacky";
            int age = 25;

            Console.WriteLine("There was a boy once called " + name);
            Console.WriteLine(name + " was " + age + "of age");
            Console.WriteLine(name + "really never liked his name.");

            name = "Tom";
            age = 20;

            Console.WriteLine("At age " + age + " he changed his name to " + name);
            Console.ReadLine();
           
        }
    }
}
