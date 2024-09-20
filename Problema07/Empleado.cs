using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema07
{
    internal class Empleado
    {
        private int codigo;
        private string nombre;
        private int celular;
        private double suelSoles;

        public Empleado(int codigo, string nombre, int celular, double suelSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.celular = celular;
            this.suelSoles = suelSoles;
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
        public int Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public double SuelSoles
        {
            get { return suelSoles; }
            set { suelSoles = value; }
        }

        public string estaSuel()
        {
            if(suelSoles > 3500)
            {
                return "mayor a 3500";
            }else if (suelSoles < 3500)
            {
                return "menor a 3500";
            }
            else
            {
                return "igual a 3500";
            }
        }
    }
}
