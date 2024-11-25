using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            if (!double.TryParse(Console.ReadLine(), out double numero1))
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
                return;
            }
            Console.WriteLine("Digite o segundo número:");
            if (!double.TryParse(Console.ReadLine(), out double numero2))
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
                return;
            }
            Console.WriteLine("Digite o operador (+, -, *, /):");
            string operador = Console.ReadLine();
            switch (operador)
            {
                case "+":
                    Console.WriteLine($"Resultado: {numero1} + {numero2} = {numero1 + numero2}");
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {numero1} - {numero2} = {numero1 - numero2}");
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {numero1} * {numero2} = {numero1 * numero2}");
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        Console.WriteLine($"Resultado: {numero1} / {numero2} = {numero1 / numero2}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operador inválido. Use apenas +, -, * ou /.");
                    break;
            }
        }
    }
}
