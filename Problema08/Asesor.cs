using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema08
{
    internal class Asesor
    {
        private int codigo;
        private string nombre;
        private int horaTraba;
        private double tariHora;

        public Asesor(int codigo, string nombre, int horaTraba, double tariHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horaTraba = horaTraba;
            this.tariHora = tariHora;
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
        public int HoraTraba
        {
            get { return horaTraba; }
            set { horaTraba = value; }
        }
        public double TariHora
        {
            get { return TariHora; }
            set { TariHora = value; }
        }
        public double suelBruto()
        {
            return horaTraba * tariHora;
        }
        public double descuento()
        {
            return suelBruto() * 0.15;
        }
        public double suelNeto()
        {
            return suelBruto() - descuento(); 
        }
    }
}
