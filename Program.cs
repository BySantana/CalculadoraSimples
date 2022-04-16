using System;
using System.Collections.Generic;

namespace Exercicio2
{  
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Escolha a operação: ");
                Console.WriteLine("1 - Soma \n2 - Subtração \n3 - Divisão \n4 - Multiplicação \n5 - Potência \n6 - raiz \n7 - Sair");
                int opcInt = int.Parse(Console.ReadLine());
                Menu escolha = (Menu)opcInt;

                switch (escolha)
                {
                    case Menu.Soma:
                        Somar();
                        break;
                    case Menu.Subtracao:
                        Subtrair();
                        break;
                    case Menu.Divisao:
                        Dividir();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicar();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void Somar()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calcular soma: ");
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine().Replace(".",","));
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine().Replace(".", ","));
            double calculo = n1 + n2;
            Console.WriteLine($"A soma é igual a {calculo:f2}");
            Console.WriteLine("--------------------------------");
        }
        static void Subtrair()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calcular subtração: ");
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine().Replace(".", ","));
            double calculo = n1 - n2;
            Console.WriteLine($"A subtração é igual a {calculo:f2}");
            Console.WriteLine("--------------------------------");
        }
        static void Dividir()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calcular divisão: ");
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine().Replace(".", ","));
            double calculo = n1 / n2;
            Console.WriteLine($"A divisão é igual a {calculo:f2}");
            Console.WriteLine("--------------------------------");
        }
        static void Multiplicar()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calcular multiplicação: ");
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine().Replace(".", ","));
            double calculo = n1 * n2;
            Console.WriteLine($"A multiplicação é igual a {calculo:f2}");
            Console.WriteLine("--------------------------------");
        }
        static void Potencia()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calcular potência: ");
            Console.WriteLine("Digite a base da potência: ");
            double n1 = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Digite o expoente: ");
            double n2 = double.Parse(Console.ReadLine().Replace(".", ","));
            double calculo = Math.Pow(n1, n2);
            Console.WriteLine($"{n1} elevado à {n2} é igual a {calculo:f2}");
            Console.WriteLine("--------------------------------");
        }
        static void Raiz()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Calcular a raiz: ");
            Console.WriteLine("Digite o número: ");
            double n1 = double.Parse(Console.ReadLine().Replace(".", ","));
            double calculo = Math.Sqrt(n1);
            Console.WriteLine($"A raiz quadrada de {n1} é igual a {calculo:f2}");
            Console.WriteLine("--------------------------------");
        }
    }
}
