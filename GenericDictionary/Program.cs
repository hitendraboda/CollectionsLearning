using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Tiger", 3);
            dictionary.Add("Lion", 2);
            dictionary.Add("Panda", 1);

            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }

            Console.ReadLine();
        }
    }
}
