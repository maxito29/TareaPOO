using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04
{
    internal class Obrero
    {
        private int codigo;
        private string nombre;
        private int horTra;
        private double tarHora;

        public Obrero(int codigo, string nombre, int horTra, double tarHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horTra = horTra;
            this.tarHora = tarHora;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int HorTra
        {
            get { return horTra; }
            set { horTra = value; }
        }
        public double TarHora
        {
            get { return tarHora; }
            set { tarHora = value; }
        }

        public double suelBruto()
        {
            return horTra * tarHora;
        }
        public double descAfp()
        {
            return suelBruto() * 0.10;
        }
        public double desEps()
        {
            return suelBruto() * 0.05;
        }
        public double suelNeto()
        {
            return suelBruto() - descAfp() - desEps();
        }
    }


}
