using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e = new Empleado(123, "Juan", 936163227, 5000);

            listado(e);
            e.Celular = 999888777;
            e.SuelSoles += 200;
            listado(e);
        }
        static void listado(Empleado e)
        {
            Console.WriteLine("Código : " + e.Codigo);
            Console.WriteLine("Nombre : " + e.Nombre);
            Console.WriteLine("Número : " + e.Celular);
            Console.WriteLine("Sueldo Soles : " + e.SuelSoles);
            Console.WriteLine("Estado : " + e.estaSuel());
            Console.ReadKey();
        }
    }
}
