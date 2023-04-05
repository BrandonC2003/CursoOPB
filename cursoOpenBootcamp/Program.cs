using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoOpenBootcamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine(nombre);

            string hora = DateTime.Now.ToString("hh:mmm");
            Console.WriteLine(hora);
            Console.Read();
        }
    }
}
