using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static bool b;

        static void PrintAscending (List<Person> collection)
        {
            foreach(Person p in collection)
            {
                if(p.Age>=18)
                Console.WriteLine(p.ToString());
            }

        }

        static void PrintOccurenceOfGivenAge (List<Person> collection, int age)
        {
            foreach (Person p in collection)
            {
                if (p.Age == age)
                {
                    b = true;
                    break;
                }
                else
                    b = false;
            }

            Console.WriteLine(b);

        }


        static void Main(string[] args)
        {
            List<Person> collection = new List<Person>();

            collection.Add(new Person("John", 16));
            collection.Add(new Person("Gabi", 46));
            collection.Add(new Person("Michael", 22));
            collection.Add(new Person("Derek", 9));
            collection.Add(new Person("Julia", 37));
            collection.Add(new Person("Robert", 100));
            collection.Add(new Person("Ana", 10));
            collection.Add(new Person("Marcin", 53));
            collection.Add(new Person("Jimmy", 72));
            collection.Add(new Person("Maria", 18));
            collection.Add(new Person("Karol", 17));

            collection.Sort();

            PrintAscending(collection);

            PrintOccurenceOfGivenAge(collection, 18);

            PrintOccurenceOfGivenAge(collection, 108);

            Console.ReadKey();
        }


        
    }
}
