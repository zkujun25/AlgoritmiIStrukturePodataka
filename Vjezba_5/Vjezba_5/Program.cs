using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push("Kim");
            stack.Push("Iva");
            stack.Push("Bob");
            stack.Push("Ana");
            stack.Push("Ivo");


            stack.Display();

            try
            {
                for(int i = 0; i < 6; i++)
                {
                    stack.Pop();
                    stack.Display();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            stack.Display();
        }
    }
}
