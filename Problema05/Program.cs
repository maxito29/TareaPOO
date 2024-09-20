using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video v = new Video(123, "GAA", 10.50, 3.50);

            listado(v);

            v.PreSoles += 5.50;

            listado(v);

        }
        static void listado(Video v)
        {
            Console.WriteLine("Código : " + v.Codigo);
            Console.WriteLine("Nombre Video : " + v.NomVideo);
            Console.WriteLine("Precio : " + v.PreSoles);
            Console.WriteLine("Tipo de cambio : " + v.TipoCambio);
            Console.WriteLine("Precio del video : " + v.preVideo());
            Console.ReadKey();
        }
    }
}
