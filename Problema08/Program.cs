using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor a = new Asesor(123, "Alva", 12, 65.50);

            listado(a);
            a.HoraTraba *= 10;
            a.TariHora *= 0.15;
            listado (a);
        }
        static void  listado(Asesor a)
        {
            Console.WriteLine("Código : " + a.Codigo);
            Console.WriteLine("Nombre : " + a.Nombre);
            Console.WriteLine("Horas trabajadas : " + a.HoraTraba);
            Console.WriteLine("Tarifa Horario : " + a.TariHora);
            Console.WriteLine("Sueldo Bruto : " + a.suelBruto());
            Console.WriteLine("Descuento : " + a.descuento());
            Console.WriteLine("Sueldo Neto : " + a.suelNeto());
            Console.ReadKey();
        }
    }
}
