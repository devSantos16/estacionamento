using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Veiculo
    {
        public string placa { get; set; }

        public Veiculo(string placa)
        {
            this.placa = placa;
        }
    }
}