using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class RegistroVeiculo
    {
        private List<Veiculo> listaVeiculo { get; set; }

        public RegistroVeiculo() { }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            if (this.listaVeiculo == null)
            {
                this.listaVeiculo = new List<Veiculo>();
            }
            
            this.listaVeiculo.Add(veiculo);
        }

        public void mostrarVeiculos()
        {
            if (this.listaVeiculo != null)
            {
                foreach (var items in this.listaVeiculo)
                {
                    Console.WriteLine($"Placa: {items.placa} | Quantidade de hora do veiculo: {items.quantidadeHoras} | Situacao: {items.situacao} | Valor do estacionamento: {items.precoEstacionamento}");
                    break;
                }
            }
        }
    }
}