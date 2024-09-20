using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular c = new Celular(936163227, "Max Lopez", 300, 0.50);

            Listado(c);

            c.SegConsu += 20;
            c.PreSeg *= 0.95;

            Listado(c);
        }

        static void Listado(Celular c)
        {
            Console.WriteLine("El número : " + c.Numero);
            Console.WriteLine("Usuario : " + c.Usuario);
            Console.WriteLine("Segundos Consumidos : " + c.SegConsu);
            Console.WriteLine("Precio por segundo : " + c.PreSeg);
            Console.WriteLine("Costo por consumo : " + c.costConsu());
            Console.WriteLine("Impuesto : " + c.igv());
            Console.WriteLine("Total a pagar : " + c.monPagar());

            Console.ReadKey();

        }
    }
    
}
