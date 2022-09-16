using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Estacionamento
    {
        public double precoInicial { get; set; }
        public double precoHora { get; set; }

        public Estacionamento(double precoInicial, double precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }
    }
}