using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public int Id { get;private set; }
        public int Age { get;private set; }
        public float Height { get;private set; }
        public string Name { get;private set; }

        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }
        
        private static readonly IComparer<Person> comparerById = new PersonCompareById();
        private static readonly IComparer<Person> comparerByAge = new PersonCompareByAge();        
        private static readonly IComparer<Person> comparerByHeight = new PersonCompareByHeight();
        private static readonly IComparer<Person> comparerByName = new PersonCompareByName();

        public static IComparer<Person> DefultComparer
        {
            get { return comparerById; }
        }
        public static IComparer<Person> IdComparer
        {
            get { return comparerById; }
        }
        public static IComparer<Person> AgeComparer
        {
            get { return comparerByAge; }
        }
        public static IComparer<Person> HeightComparer
        {
            get { return comparerByHeight; }
        }
        public static IComparer<Person> NameComparer
        {
            get { return comparerByName; }
        }
           
        public override string ToString()
        {
            return $"Name: {Name,7} Age: {Age,2} Height: {Height,4} Id: {Id}";
        }
    }
}
