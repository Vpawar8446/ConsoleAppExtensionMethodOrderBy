using System;
using System.Linq;

namespace ConsoleAppExtensionMethodOrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => g);
            Console.WriteLine("Element of array in ascending order : ");
            foreach(var i in result)
            {
                System.Console.Write(i + " ");
            }
            
        }
    }
}
