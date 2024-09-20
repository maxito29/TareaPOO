using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01
{
    internal class Celular
    {
        private int numero;
        private string usuario;
        private int segCons;
        private double preSeg;

        public Celular(int numero, string usuario, int segCons, double preSeg)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segCons = segCons;
            this.preSeg = preSeg;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public int SegConsu
        {
            get { return segCons; }
            set { segCons = value; }
        }
        public double PreSeg
        {
            get { return preSeg; }
            set { preSeg = value; }
        }


        public double costConsu()
        {
            return segCons * preSeg;
        }

        public double igv()
        {
            return costConsu() * 0.18;
        }
        public double monPagar()
        {
            return costConsu() + igv();
        }
    }
}
