using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFruit
{
    class Program
    {
        public delegate string transform(string value);
        public delegate int count(string value);
        public delegate bool compare(string value1, string value2);

        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "apple", "pear", "banana", "strawberry", "lemon" };

            transform transform = x => x.ToUpper();

            Console.WriteLine("Oefening 1");
            foreach(string fruit in fruits)
            {
                Console.WriteLine(transform(fruit));
            }
            
            Console.WriteLine("Oefening 2");

            count count = x => x.Length;
            foreach(string fruit in fruits)
            {
                Console.WriteLine($"{fruit} telt {count(fruit)} tekens");
            }
            Console.WriteLine("Oefening 3");
            compare compare = (x, y) => x.Length > y.Length;
            for (int i = 1; i < fruits.Count;i++)
            {
                Console.WriteLine($"{fruits[i-1]} contains more characters  than {fruits[i]} : {compare(fruits[i-1],fruits[i])}");
            }

            Console.ReadKey();
        }
    }
}
