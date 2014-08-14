using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * List collection are strong type index based collection and dynamically resizable and at a same time we can pass any data type to a list object. 
               It provides many inbuilt methods to manipulate list object. List generic collections is a generic concept applied over Arrays and Arraylist.
             
             * Syntax
                List obj = new List();
                Where "T" generic parameter you can pass any data-type or custom class object to this parameter.            
             */

            List<int> list = new List<int>();

            for (int i = 1; i < 10; i++)
            {
                list.Add(i);
            }

            foreach (int numbers in list)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine("Count -> {0}",list.Count);
            Console.WriteLine("\n-------------------------------------------\n");


            List<bool> list1 = new List<bool>();

            for (int j = 1; j <= 5; j++)
            {
                if (j % 2 == 0)
                {
                    list1.Add(true);
                }
                else
                {
                    list1.Add(false);
                }
            }

            foreach (bool booleans  in list1)
            {
                Console.WriteLine(booleans);
            }

            Console.WriteLine("Total Count -> {0}", list1.Count);
            Console.WriteLine("True Count -> {0}", list1.Count(m => m.Equals(true)));
            Console.WriteLine("False Count -> {0}", list1.Count(m => m.Equals(false)));
            Console.WriteLine("\n-------------------------------------------\n");
            Console.ReadLine();
        }
    }
}
