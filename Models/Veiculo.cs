using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Veiculo
    {
        public string placa { get; set; }
        public string situacao { get; set; }
        public double quantidadeHoras { get; set; }
        public double precoEstacionamento { get; set; }

        public Veiculo(string placa, Estacionamento estacionamento)
        {
            this.placa = placa;
            this.quantidadeHoras = 0;
            this.situacao = "Andamento";
            this.precoEstacionamento = estacionamento.precoInicial + estacionamento.precoHora;
        }

        /// <summary>
        /// Trata toda a situação do veiculo antes de remover na lista
        /// </summary>
        /// <param name="estacionamento"></param>
        public void tratarVeiculoRetirado(Estacionamento estacionamento)
        {
            this.situacao = "Retirado";
            this.precoEstacionamento = (this.quantidadeHoras * estacionamento.precoInicial) + estacionamento.precoHora;
        }
    }
}