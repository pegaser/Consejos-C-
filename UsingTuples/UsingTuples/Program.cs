using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            string address;
            string city;
            int zipcode;
            (address, city, zipcode) = GetAddressInfo("Sergio");
            Console.WriteLine($"Address: {address}, City: {city}, ZipCode: {zipcode}");
            Console.Read();
        }
        private static (string, string, int) GetAddressInfo(string name)
        {
            if (name == "Sergio")
                return ("Azalea 77", "Ciudad de México", 14640);
            else if (name == "Alejandro")
                return ("Cedral 99", "Ciudad de México", 14650);
            else
                return (String.Empty, String.Empty, 0);
        }
    }

}
