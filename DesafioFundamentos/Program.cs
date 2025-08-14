using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Variaveis
decimal precoInicial;
decimal precoPorHora;
bool exibirMenu = true;

Console.WriteLine("\nSeja bem vindo ao sistema de estacionamento!\n");

// Obtem os valores do preco inicial e preco por hora e instancia a classe Estacionamento
Console.Write("• Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("• Agora digite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new(precoInicial, precoPorHora);

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("== Digite a sua opção: ==");
    Console.WriteLine("1. Cadastrar veículo");
    Console.WriteLine("2. Remover veículo");
    Console.WriteLine("3. Listar veículos");
    Console.WriteLine("4. Encerrar");
    Console.WriteLine();
    Console.Write("Selecione uma opção: ");

    switch (Console.ReadLine())
    {
        case "1": estacionamento.AdicionarVeiculo();    break;
        case "2": estacionamento.RemoverVeiculo();      break;
        case "3": estacionamento.ListarVeiculos();      break;
        case "4": exibirMenu = false;                   break;
        
        default: Console.WriteLine("Opção inválida");   break;
    }

    Console.Write("\nPressione qualquer tecla para continuar...");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");