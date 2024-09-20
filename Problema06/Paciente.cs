﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Problema06
{
    internal class Paciente
    {
        private string nombre;
        private string apellido;
        private int edad;
        private double talla;
        private double peso;

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public double Talla
        {
            get { return talla; }
            set { talla = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string mayorEdad()
        {
            return edad < 18 ? "menor de edad" : "mayor de edad";
        }

    }
}
