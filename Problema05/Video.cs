using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema05
{
    internal class Video
    {
        private int codigo;
        private string nomVideo;
        private double preSoles;
        private double tipoCambio;

        public Video(int codigo, string nomVideo, double preSoles, double tipoCambio)
        {
            this.codigo = codigo;
            this.nomVideo = nomVideo;
            this.preSoles = preSoles;
            this.tipoCambio = tipoCambio;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string NomVideo
        {
            get { return nomVideo; }
            set { nomVideo = value; }
        }
        public double PreSoles
        {
            get { return preSoles; }
            set { preSoles = value; }
        }
        public double TipoCambio
        {
            get { return tipoCambio; }
            set { tipoCambio = value; }
        }

        public double preVideo()
        {
            return preSoles / tipoCambio;
        }
    }
}
