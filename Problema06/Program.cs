using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente p = new Paciente("Max", "Lopez", 16, 168.4, 53.5);

            listado(p);

            p.Edad = 17;

            listado(p);
        }

        static void listado(Paciente p)
        {

            Console.WriteLine("Nombre : " + p.Nombre);
            Console.WriteLine("Apellido : " + p.Apellido);
            Console.WriteLine("Edad : " + p.Edad);
            Console.WriteLine("Talla : " + p.Talla);
            Console.WriteLine("Peso : " + p.Peso);
            Console.WriteLine("Determinar  : " + p.mayorEdad());
            Console.ReadKey();
        }
    }
}
