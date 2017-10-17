using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralSortingFunction
{
    class Person
    {
        private string name;
        private int age;
        public Person()
        {
            Name = "Noname";
            Age = 0;

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(string name)
        {
            this.Name = name;
            this.Age = 0;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public static bool Compare(object obj1, object obj2)
        {
            if (string.Compare( ((Person)obj1).Name, ((Person)obj2).Name ) < 0)
                return true;
            return false;
        }

        public static bool Compare_Age(object obj1, object obj2)
        {
            if (((Person)obj1).Age < ((Person)obj2).Age)
                return false;
            return true;
        }

        public override string ToString()
        {
            return name + " " + age;
        }
    }
}
