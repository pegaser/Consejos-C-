using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Person
    {
        private string _firstName;
        private string _lastName;

        public override string ToString() => $"{_firstName} {_lastName}".Trim();

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public Person(string firstName, string lastName) => (_firstName, _lastName) = (firstName, lastName);

        ~Person() => Console.WriteLine("El destructor se está ejecutando...");
    }
}
