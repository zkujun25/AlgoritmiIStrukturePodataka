using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Pro
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue("Ivo");
            queue.Enqueue("Ana");
            queue.Enqueue("Bob");
            queue.Enqueue("Iva");
            queue.Enqueue("Leo");


            queue.Display();

            try
            {
                for (int i = 0; i < 6; i++)
                {
                    queue.Dequeue();
                    queue.Display();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            queue.Display();
        }
    }
}
