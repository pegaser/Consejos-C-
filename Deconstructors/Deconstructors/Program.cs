using System;

namespace Deconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Id = 1;
            person.FirstName = "Sergio";
            person.LastName = "Pérez";
            person.Age = 40;
            person.Email = "sperezgabriel@gmail.com";

            (string lastName, string firstName) = person;
            Console.WriteLine($"Nombre: {firstName} {lastName}");
            Console.ReadKey();

            int age;
            (firstName, lastName, age) = person;
            Console.WriteLine($"{firstName} {lastName} tiene {age} años");
            Console.Read();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }
    }
}
