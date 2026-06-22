using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
        
            Console.Write("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
        Console.Write("Escolha a operação (+, -, *, /): ");
            string operacao = Console.ReadLine();
            double resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    if (n2 != 0)
                        resultado = n1 / n2;
                    else
                        Console.WriteLine("Erro: Divisão por zero!");
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
    }
    }
}
