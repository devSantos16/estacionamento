using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public class Estacionamento
    {
        private double precoInicial { get; set; }
        private double precoHora { get; set; }
        private List<Veiculo> veiculos { get; set; }

        public Estacionamento(double precoInicial, double precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            this.veiculos = new List<Veiculo>();
        }

        public void adicionarVeiculo(string placa)
        {
            foreach (var itens in this.veiculos)
            {
                if (itens.placa == placa)
                {
                    Console.WriteLine("Já possui um carro com esta placa");
                    return;
                }
            }
            this.veiculos.Add(new Veiculo(placa));
            Console.WriteLine("Veiculo adicionado com sucesso");
        }

        public void removerVeiculo(string placa)
        {
            foreach (var itens in this.veiculos)
            {
                if (itens.placa == placa)
                {

                    Console.WriteLine("Digite a quantidade de horas que o veiculo ficou:");
                    double quantidade = Convert.ToDouble(Console.ReadLine());
                    double tarifa = returnTarifa(quantidade);


                    Console.WriteLine("Informações do veiculo: ");
                    Console.WriteLine($"Placa: {itens.placa}");
                    Console.WriteLine($"Tarifa: {tarifa}");

                    int opcao;
                    Console.WriteLine("Deseja remover o veiculo? (1 para sim, 0 para não)");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Veiculo removido com sucesso");
                        this.veiculos.Remove(itens);
                        return;
                    }
                    else if (opcao == 0)
                    {
                        Console.WriteLine("Veiculo não foi removido");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Erro! Digite novamente");
                        return;
                    }
                }
            }
            Console.WriteLine("Não existe veiculo com esta placa");
        }

        public void showVeiculos()
        {
            foreach (var itens in this.veiculos)
            {
                Console.WriteLine($"{itens.placa}");
            }
        }

        public double returnTarifa(double quantidade)
        {
            return (precoInicial + precoHora) * quantidade;
        }

    }
}