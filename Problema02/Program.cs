using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora c = new Computadora(123, "ASUS", "NEGRO", 1200);

            Listado(c);

            c.PreDolares *= 0.90;

            Listado(c);
        }
        static void Listado(Computadora c)
        {
            Console.WriteLine("Codigo : " + c.Codigo);
            Console.WriteLine("Marca : " + c.Marca);
            Console.WriteLine("Color : " + c.Color);
            Console.WriteLine("Precio en Dólares : " + c.PreDolares);
            Console.WriteLine("Precio en Soles : " + c.preSoles());
            Console.WriteLine("Precio en Euros : " + c.preEuros());

            Console.ReadKey();
        }
    }
}
