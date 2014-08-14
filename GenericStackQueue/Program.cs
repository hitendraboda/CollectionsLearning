using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // =============================== Stack ===============================//
            
            Stack<int> stackNum = new Stack<int>();
            
            for (int i = 1 ; i < 7; i++)
            {
                stackNum.Push(i);
            }
            
            foreach (int numbers in stackNum)
            {
                Console.WriteLine("Stack Numbers {0}",numbers);
            }
            
            stackNum.Pop(); //It will remove last element/recent added element from the collections i.e. 6
            
            Console.WriteLine("\n-------------------------------------------\n");

            //Declaring Stack
            Stack<string> stacknames = new Stack<string>();
            stacknames.Push("Pradeep Dhuri");
            stacknames.Push("Shiv Prasad");
            stacknames.Push("Khadak");
            stacknames.Push("Shaam");

            foreach (string strnames in stacknames)
            {
                Console.WriteLine("Stack Names {0}", strnames);
            }

            stacknames.Pop(); //It will remove last element/recent added element from the collections i.e. Shaam

            Console.WriteLine("\n-------------------------------------------\n");

            // ===================================================================//


            // =============================== Queue ===============================//
            Queue<int> Queuenum = new Queue<int>();
            Queuenum.Enqueue(1);
            Queuenum.Enqueue(2);
            Queuenum.Enqueue(3);
            Queuenum.Enqueue(5);
            Queuenum.Enqueue(6);



            foreach (int numbers in Queuenum)
            {
                Console.WriteLine("Queue Numbers {0}", numbers);
            }

            Queuenum.Dequeue(); //It will remove first element from the collections i.e (1)


            Console.WriteLine("\n-------------------------------------------\n");


            //Declaring Queues
            Queue<string> Queuenames = new Queue<string>();
            Queuenames.Enqueue("Mohan Aiyer");
            Queuenames.Enqueue("Shiv Prasad");
            Queuenames.Enqueue("Khadak");
            Queuenames.Enqueue("Shaam");


            foreach (string strnames in Queuenames)
            {
                Console.WriteLine("Queue Names {0}", strnames);
            }

            Queuenum.Dequeue(); //It will remove first added element from the collections i.e Mohan Aiyer

            Console.WriteLine("\n-------------------------------------------\n");

            Console.ReadLine();
        }
    }
}
