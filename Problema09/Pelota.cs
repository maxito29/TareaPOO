using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema09
{
    internal class Pelota
    {
        private string marca;
        private double pesoGramos;
        private double presionLibras;
        private double diameCenti;
        private double precio;

        public Pelota(string marca, double pesoGramos, double presionLibras, double diameCenti, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diameCenti = diameCenti;
            this.precio = precio;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public double PesoGramos
        {
            get { return pesoGramos; }
            set { pesoGramos = value; }
        }
        public double PesionLibras
        {
            get { return presionLibras; }
            set { presionLibras = value; }
        }
        public double DiameCenti
        {
            get { return diameCenti; }
            set { diameCenti = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public double Calcularradio()
        {
            return diameCenti / 2;
        }
        public double voluBalon()
        {
            double radio = Calcularradio();
            return (4 * 3.1416 * Math.Pow(radio, 3)) / 3;
        }
        public double descuento()
        {
            return Precio * 0.10;
        }
        public double impPagar()
        {
            return precio - descuento();
        }
    }
}
