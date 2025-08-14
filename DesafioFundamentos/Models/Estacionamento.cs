using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        private readonly List<string> veiculos = new List<string>();
        private readonly decimal precoInicial = precoInicial;
        private readonly decimal precoPorHora = precoPorHora;

        // métodos:
        public static bool PlacaValida(string placa)
        {
            if (Regex.IsMatch(placa.Trim().ToUpper(), @"^[A-Za-z]{3}-\d{4}$"))
            {
                return true;
            }

            else
            {
                Console.WriteLine("Placa invalida");
                return false;
            }

        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine();
            Console.Write("Digite a placa do veículo para estacionar (Ex: ABC-1234): ");
            string placa = Console.ReadLine().ToUpper();

            if (!PlacaValida(placa)) return;

            // Verifica se o veículo já se encontra estacionado
            if (!veiculos.Any(x => string.Equals(x.ToUpper(), placa.ToUpper())))
            {
                veiculos.Add(placa);
            }
            else
            {
                Console.WriteLine("\nDesculpe, mas este veículo já está estacionado aqui. \nConfira se digitou a placa corretamente");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine();
            Console.Write("Digite a placa do veículo para remover (Ex: ABC-1234): ");
            string placa = Console.ReadLine().ToUpper();

            if (!PlacaValida(placa)) return;

            // Verifica se o veículo existe
            if (veiculos.Any(x => string.Equals(x.ToUpper(), placa.ToUpper())))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);

                Console.WriteLine();
                Console.WriteLine($"• O veículo {placa} foi removido.");
                Console.WriteLine($"• Preço total: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("== Os veículos estacionados são: ==");
                Console.WriteLine("Nº\t| Placa:");
                
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"• {i+1:00} \t| {veiculos[i]}");
                }

                Console.WriteLine();
                Console.WriteLine($"Total de veículos estacionados: {veiculos.Count}");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
