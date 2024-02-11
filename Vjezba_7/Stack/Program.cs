using System;

namespace Vjezba_7
{
    class Program
    {
        static void Main() 
        {
            Hash_Table HashTable = new Hash_Table(9);

            HashTable.Insert("Ana", 1);
            HashTable.Insert("Iva", 2);
            HashTable.Insert("Kim", 3);
            HashTable.Insert("Bob", 4);
            HashTable.Insert("Ivo", 5);
            HashTable.Insert("Lea", 6);
            HashTable.Insert("Joe", 7);
            HashTable.Insert("Ena", 8);
            HashTable.Insert("Tea", 9);

            HashTable.Display();

            Console.WriteLine();
            Console.WriteLine("Searching for Bob...");
            try
            {
                Console.WriteLine("Found. Bob, " + HashTable.Search("Bob"));
                Console.WriteLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            
            Console.WriteLine("Searching for Zvone...");
            try
            {
                Console.WriteLine("Found. Zvone, " + HashTable.Search("Zvone"));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            Console.WriteLine("Deleting Bob...");

            HashTable.Delete("Bob");

            HashTable.Display();

        }
    }
}