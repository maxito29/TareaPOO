using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Problema03
{
    internal class Edificio
    {
        private int codigo;
        private int numDepar;
        private int canPisos;
        private double preDolares;

        public Edificio(int codigo, int numDepar, int canPisos, double preDolares)
        {
            this.codigo = codigo;
            this.numDepar = numDepar;
            this.canPisos = canPisos;
            this.preDolares = preDolares;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int NumDepar
        {
            get { return numDepar; }
            set { numDepar = value; }
        }
        public int CanPisos
        {
            get { return canPisos; }
            set { canPisos = value; }
        }
        public double PreDolares
        {
            get { return preDolares; }
            set { preDolares = value; }
        }

        public double preEdificio()
        {
            return numDepar * preDolares;
        }
    }
}
