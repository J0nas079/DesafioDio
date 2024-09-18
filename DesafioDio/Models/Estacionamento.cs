using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio.Models
{
    public class Estacionamento
    {
        private decimal precoinitial;
        private decimal precoPorHora;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoinitial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdcionarVeiculo()
        {
            Console.WriteLine("Informe a placa do veiculo: ");
            string placa = Console.ReadLine().Trim();
            if (!Veiculos.Exists(a => a == placa))
            {
                Veiculos.Add(placa);
            }
            else
            {
                Console.WriteLine("Veiculo ja cadastrado");
            }
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Informe a placa do veiculo para remover ");
            string placa = Console.ReadLine().Trim();
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if (!decimal.TryParse(Console.ReadLine(), out decimal horasVeiculoPermaneceuEstacionado))
                {
                    Console.WriteLine("Quantidade de horas informada é inválida! Tente remover novamente!");
                    return;
                }
                decimal valor = (precoinitial + precoPorHora) + horasVeiculoPermaneceuEstacionado;
                Veiculos.Remove(placa);
                Console.WriteLine($"O veiculo com placa {placa} foi removido e o preço total foi de {valor.ToString("C")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine($"O total de veiculos estacionados são um total {Veiculos.Count} Veiculos");
                Veiculos.ForEach(Veiculos => Console.WriteLine($"placa:{Veiculos}"));
            }
            else
            {
                Console.WriteLine("Não há veiculos cadastrados!");
            }
        }
    }
}
