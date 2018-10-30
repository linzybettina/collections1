using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace collection2
{
    class Program
    {
               static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", "1234");
            ht.Add("Ename","sajan");
                ht.Add("job","software Developer");
                    ht.Add("Salary","4320");
                        ht.Add("sdrid","78");
                            ht.Add("phone","3434343");
                            ht.Add("email", "vethakumarsajan@gmail.com");
            Console.WriteLine(ht["email"]);
            foreach (object key in ht.Keys) //to display key
            Console.WriteLine(key);
            foreach (object k in ht.Values)//to display values
                Console.WriteLine(k);
            Console.WriteLine("keys".GetHashCode());//to get hashcode
            foreach (object k in ht.Keys)
                Console.WriteLine(k+":"+ht[k]);//to display key and hashcodevalue
                          Console.ReadLine();






        }
    }
}
