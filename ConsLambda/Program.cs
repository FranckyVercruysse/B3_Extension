using LibStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsLambda
{
    class Program
    {
        public delegate string transform(string value);
        public delegate int count(string value);
        public delegate bool compare(string value1, string value2);
        public delegate string checkAge(int value1, int value2);

        static List<string> fruits = new List<string> { "apple", "pear", "banana", "strawberry", "lemon" };


        static void Main(string[] args)
        {
            StudentData sd = new StudentData();
            List<Student> students = sd.GetFilteredStudents();
            foreach(Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine();

            Console.WriteLine("Oefening 1");
            transform transform = x => x.ToUpper();
            
            foreach (string fruit in fruits)
            {
                Console.WriteLine(transform(fruit));
            }

            Console.WriteLine();
            Console.WriteLine("Oefening 2");
            count count = x => x.Length;
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"{fruit} telt {count(fruit)} tekens");
            }

            Console.WriteLine();
            Console.WriteLine("Oefening 3");
            compare compare = (x, y) => x.Length > y.Length;
            for (int i = 1; i < fruits.Count; i++)
            {
                Console.WriteLine($"{fruits[i - 1]} contains more characters  than {fruits[i]} : {compare(fruits[i - 1], fruits[i])}");
            }

            Console.WriteLine();
            Console.WriteLine("Oefening 4");
            //checkAge checkAge = (x, y) => { if (x < y) return "not"; else return ""; };
            checkAge checkAge = (x, y) =>  (x < y)? "NOT": ""; 

            foreach (Student s in sd.GetAllStudents())
            {
                Console.WriteLine($"{s.FirstName} {s.LastName} is {checkAge(s.Age,21)} old enough.");
            }

            Console.ReadKey();

        }
    }
}
