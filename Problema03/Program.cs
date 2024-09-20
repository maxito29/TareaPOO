using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edificio e = new Edificio(123, 15, 6, 10000);

            listado(e);

            e.PreDolares *= 20.0;

            listado(e);
        }
        static void listado(Edificio e)
        {
            Console.WriteLine("Código : " + e.Codigo);
            Console.WriteLine("Número de Departamentos : " + e.NumDepar);
            Console.WriteLine("Cantidad de pisos : " + e.CanPisos);
            Console.WriteLine("Precio Departamento : " + e.PreDolares);
            Console.WriteLine("Precio Edificio : " + e.preEdificio());


            Console.ReadKey();
        }
    }
}
