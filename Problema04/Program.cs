using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero o = new Obrero(123, "Max", 10, 15.50);

            listado(o);

            o.HorTra += 8;
            o.TarHora *= 0.015;

            listado(o);
        }
        static void listado(Obrero o)
        {
            Console.WriteLine("Código : " + o.Codigo);
            Console.WriteLine("Nombre : " + o.Nombre);
            Console.WriteLine("Horas trabajadas : " + o.HorTra);
            Console.WriteLine("Tarifa : " + o.TarHora);
            Console.WriteLine("Sueldo Bruto : " + o.suelBruto());
            Console.WriteLine("Descuento AFP : " + o.descAfp());
            Console.WriteLine("Descuento EPS : " + o.desEps());
            Console.WriteLine("Sueldo Neto : " + o.suelNeto());


            Console.ReadKey();
        }

    }
}
