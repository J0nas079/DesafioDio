using DesafioDio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precoInicial = 0;
            decimal precoPorHora= 0;
            Console.WriteLine("Seja Bem vindo ao sistama de Estacionamento\n Digite o preço inicial");
            precoInicial=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Agora Informe o preço por hora");
            precoPorHora= Convert.ToDecimal(Console.ReadLine());
            
            Estacionamento es=new Estacionamento(precoInicial,precoPorHora);
            string opcao=string.Empty;
            bool exibirMenu=true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        es.AdcionarVeiculo();
                        break;
                     case "2":
                        es.RemoverVeiculo();
                        break;
                    case "3":
                        es.ListarVeiculos(); 
                        break;
                    case "4":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opcão Invalida");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadLine();
            }
            Console.WriteLine("O programa foi encerrado!!");

        }
    }
}
