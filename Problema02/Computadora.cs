using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema02
{
    internal class Computadora
    {
        private int codigo;
        private string marca;
        private string color;
        private double preDolares;

        public Computadora(int codigo, string marca, string color, double preDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.preDolares = preDolares;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double PreDolares
        {
            get { return preDolares; }
            set { preDolares = value; }
        }
        public double preSoles()
        {
            return preDolares * 3.35;
        }
        public double preEuros()
        {
            return preDolares * 1.20;
        }
    }
}
