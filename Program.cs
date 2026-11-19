
using System;

class Program
{
    static double Adicao(double n1, double n2)
    {
        return n1 + n2;
    }

    static double Subtracao(double n1, double n2)
    {
        return n1 - n2;
    }

    static double Multiplicacao(double n1, double n2)
    {
        return n1 * n2;
    }

    static double Divisao(double n1, double n2)
    {
        return n1 / n2;
    }

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\nCalculadora");
            
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");



            opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + Adicao(n1, n2));
                        break;

                    case 2:
                        Console.WriteLine("Resultado: " + Subtracao(n1, n2));
                        break;

                    case 3:
                        Console.WriteLine("Resultado: " + Multiplicacao(n1, n2));
                        break;

                    case 4:
                        if (n2 == 0)
                        {
                            Console.WriteLine("Erro!! não é possível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("Resultado: " + Divisao(n1, n2));
                        }
                        break;
                }
            }
            else if (opcao != 0)
            {
                Console.WriteLine("Ops! Opção inválida!");
            }

        } while (opcao != 0);

        Console.WriteLine("Calculadora encerrada!");
    }
}

