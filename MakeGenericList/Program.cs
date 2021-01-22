using System;

namespace MakeGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
                Console.WriteLine("Added Numbers: "+i);

            }

            Console.WriteLine("\nHow many items in numbers array: "+numbers.Count);
            

        }
    }
}
