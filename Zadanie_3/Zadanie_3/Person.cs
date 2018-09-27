using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person (string n1, int a1)
        {
            Name = n1;
            Age = a1;
        }

        public override string ToString()
        {
            return "{" + Name + "}" + "-" + "{" + Age.ToString() + "}";
        }

        public int CompareTo(Person obj)
        {
            return Age.CompareTo(obj.Age);
        }

    }
}
