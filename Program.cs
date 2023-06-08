using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv06___If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema de passagens aereas do Wendell !");

            Console.WriteLine("Por favor, escolha o mês da viagem:");
            Console.WriteLine(" -08 Agosto");
            Console.WriteLine(" -09 Setembro");
            Console.WriteLine(" -10 Outubro");

            int mes = 0;
            while (true) // comando para fazer um loop sem usar o Main();
            {
                Console.Write("Digite o número correspondente ao mês desejado: ");
                if (int.TryParse(Console.ReadLine(), out mes))
                {
                    if (mes == 8 || mes == 9 || mes == 10)
                        break; // comando para parar o loop
                    else
                    {
                        Console.WriteLine("Mês inválido.");
                        return;
                    }
                }
                else
                    Console.WriteLine("Valor inválido\n Digite um número correspondente ao mês desejado:");
            }

            Console.WriteLine("Por favor\n escolha o dia da viagem (entre 6 e 21):");

            int dia = 0;
            while (true)
            {
                Console.Write("Digite o número correspondente ao dia desejado: ");
                if (int.TryParse(Console.ReadLine(), out dia))
                {
                    if (dia >= 6 && dia <= 21)
                        break;
                    else
                    {
                        Console.WriteLine("Dia inválido.");
                        return;
                    }
                }
                else
                    Console.WriteLine("Valor inválido\n Digite um número correspondente ao dia desejado.");
            }

            Console.WriteLine("Por favor, escolha o período da viagem:");
            Console.WriteLine("Tarde");
            Console.WriteLine("Manhã");
            Console.WriteLine("Noite");

            string periodo = "";
            while (true)
            {
                Console.Write("Digite o período desejado: ");
                periodo = Console.ReadLine();
                if (periodo.Equals("Tarde") || periodo.Equals("Manhã") || periodo.Equals("Noite"))// comando Equals funciona igual o referencial "=="
                    break;
                else
                {
                    Console.WriteLine("Período inválido.");
                    return;
                }
            }

            Console.WriteLine("Passagem comprada com sucesso!");
            Console.WriteLine("Recibo:");
            Console.WriteLine($"Data da viagem: {dia} do mês {mes}");
            Console.WriteLine($"Período da viagem:{periodo}");

            Console.ReadLine();
        }
    }
}

















