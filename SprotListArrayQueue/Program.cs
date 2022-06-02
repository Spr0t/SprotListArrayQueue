using SprotListArrayQueue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotListArrayQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EasyQueue<int> easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine();

            ArrayQueue<int> arrayQueue = new ArrayQueue<int>(10);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.ReadLine();




        }
    }
}
