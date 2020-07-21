using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDiscards
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ValidateMyClass(null);
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine($"Error en la aplicación: '{ ex.Message}'");
            }
            Console.Read();
        }
        private static void ValidateMyClass(MyClass myClass)
        {
            //if(myClass == null)
            //{
            //    throw new ApplicationException("No se recibió el objeto esperado");
            //}
            _ = myClass ?? throw new ApplicationException("No se recibió el objeto esperado");
        }
    }
    
    public class MyClass
    {
        public string NameClass { get; set; }
    }
}
