using estacionamento.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        double precoInicial, precoHora;
        bool loop = true;


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
            Console.WriteLine("Opção 4: Sair do programa");
            Console.WriteLine("Digite a opção: ");


            opcao = Convert.ToInt32(Console.ReadLine());
            string placa;
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite a placa");
                    placa = Console.ReadLine();
                    estacionamento.adicionarVeiculo(placa);
                    break;
                case 2:
                    estacionamento.showVeiculos();
                    break;
                case 3:
                    Console.WriteLine("Digite a placa do veiculo");
                    placa = Console.ReadLine();
                    estacionamento.removerVeiculo(placa);
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa");
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Opção errada, digite novamente!");
                    break;
            }
        } while (loop);
    }
}