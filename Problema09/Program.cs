using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota p = new Pelota("Adidas", 40, 55.5, 30, 40.50);

            listado(p);
            p.Precio *= 0.25;
            p.DiameCenti += 1;
            listado( p );
        }
        static void listado ( Pelota p)
        {
            Console.WriteLine("Marca : " + p.Marca);
            Console.WriteLine("Peso en gramos : " + p.PesoGramos);
            Console.WriteLine("Presion libras : " + p.PesionLibras);
            Console.WriteLine("Diametro centimetros : " + p.DiameCenti);
            Console.WriteLine("Precio : " + p.Precio);
            Console.WriteLine("Radio : " + p.Calcularradio());
            Console.WriteLine("Volumen : " + p.voluBalon());
            Console.WriteLine("Descuento : " + p.descuento());
            Console.WriteLine("Importe Pagar : " + p.impPagar());
            Console.ReadKey();
        }
    }
}
