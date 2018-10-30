using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(4);
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(300);
            al.Add(400);
            al.Add(500);
            al.Add(600);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            al.Insert(3, 1000);
            foreach (object obj in al)
                Console.WriteLine(obj + "");
            Console.WriteLine();
            al.Remove(200);
            foreach (object obj in al)
                Console.WriteLine(obj + "");
            al.RemoveAt(1);
            Console.ReadLine();

        }
    }
}
