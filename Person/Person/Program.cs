using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person yehuda = new Person(040196388, 38, 180, "Yehuda");
            Person sivan = new Person(039705074, 34, 162, "Sivan");
            Person lior = new Person(345007512, 1, 90, "Lior");
            Person aba = new Person(1111111, 62, 176, "Gershon");
            Person ima = new Person(22222222, 61, 175, "Gila");
            Person[] people = new Person[]
            {
                yehuda,sivan,lior,aba,ima
            };
            Array.Sort(people, Person.DefultComparer);
            PrintPersonArray(people);            
            Array.Sort(people, new PersonCompareByHeight());
            PrintPersonArray(people);            
            Array.Sort(people, Person.AgeComparer);
            PrintPersonArray(people);
            Array.Sort(people, Person.NameComparer);
            PrintPersonArray(people);
        }
        
        private static void PrintPersonArray(Person [] people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person);                
            }
            Console.WriteLine();
        }
        
    }
}
