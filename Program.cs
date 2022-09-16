﻿using estacionamento.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        double precoInicial, precoHora;
        bool loop = true;
        List<Veiculo> listaVeiculo = new List<Veiculo>();

        Console.WriteLine("Olá, digite o preco inicial: ");
        precoInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Agora digite o preço por hora: ");
        precoHora = Convert.ToDouble(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);


        do
        {
            int opcao;


            Console.WriteLine("Menu");
            Console.WriteLine("Opcao 1: Cadastrar um carro");
            Console.WriteLine("Opcao 2: Mostrar todos os veiculos");
            Console.WriteLine("Opção 3: Retirar o veiculo");
            Console.WriteLine("Digite a opção: ");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    string placa;
                    Console.WriteLine("Digite a placa");
                    placa = Console.ReadLine();

                    if (placa == null)
                    {
                        Console.WriteLine("ops ! digita a placa novamente");
                        return;
                    }

                    Veiculo veiculo = new Veiculo(placa, estacionamento);
                    listaVeiculo.Add(veiculo);
                    break;

                case 2:
                    foreach (var items in listaVeiculo)
                    {
                        Console.WriteLine($"Placa: {items.placa} | Quantidade de hora do veiculo: {items.quantidadeHoras} | Situacao: {items.situacao} | Valor do estacionamento: {items.precoEstacionamento}");
                    }
                    break;

                case 3:
                    string placaPesquisa = string.Empty;
                    Console.WriteLine("Digite a placa: ");
                    placaPesquisa = Console.ReadLine();

                    foreach (var items in listaVeiculo)
                    {
                        if (items.placa == placaPesquisa)
                        {
                            Console.WriteLine("Informe o numero de horas que o veiculo ficou");
                            items.quantidadeHoras = Convert.ToDouble(Console.ReadLine());
                            items.retirarVeiculo(estacionamento);
                            Console.WriteLine($"Veiculo com a placa {items.placa} retirado com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Não existe veiculo com esta placa");
                        }
                    }
                    break;
            }

        } while (loop);
    }
}