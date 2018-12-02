using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111},
           new Student {First="Claire", Last="O'Donnell", ID=112},
           new Student {First="Sven", Last="Mortensen", ID=113},
           new Student {First="Cesar", Last="Garcia", ID=114},
           new Student {First="Debra", Last="Garcia", ID=115}
        };

            // string[] fruits = { "cherry", "apple", "blueberry" };

            // IEnumerable<string> sortedAcending = from fruit in fruits
            //                                      orderby fruit
            //                                      select fruit;

            // Console.WriteLine("Ascending:");
            // foreach (string s in sortedAcending)
            // {
            //     Console.WriteLine(s);
            // }

            // Console.WriteLine("Sorted:");

            // var groupedStudents = from stud in students
            //                       group stud by stud.First[0] into modifiedGroup
            //                       orderby modifiedGroup.Key
            //                       select modifiedGroup;

            // foreach (var item in groupedStudents)
            // {
            //     Console.WriteLine(item.Key);
            //     foreach (var innerItem in item)
            //     {
            //         Console.WriteLine(innerItem.First);
            //     }
            // }


            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet bluemoon = new Pet { Name = "Blue Moon", Owner = rui };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            // Create two lists.
            List<Person> people = new List<Person> { magnus, terry, charlotte, arlene, rui };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            var joined = from person in people
                         join pet in pets on person equals pet.Owner
                         select new { person.FirstName, pet.Name };

            var leftJoined = from person in people
                             join pet in pets on person equals pet.Owner into gj
                             from sub in gj.DefaultIfEmpty()
                             select new { person.FirstName, PetName = sub?.Name ?? String.Empty };

            foreach (var item in leftJoined)
            {
                Console.WriteLine($"{item.PetName} {item.FirstName}");

            }

        }
    }

    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Pet
    {
        public string Name { get; set; }
        public Person Owner { get; set; }
    }
}
