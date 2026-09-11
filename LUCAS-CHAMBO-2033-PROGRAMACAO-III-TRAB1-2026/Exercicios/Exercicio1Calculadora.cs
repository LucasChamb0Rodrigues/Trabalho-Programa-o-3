using System;

namespace ExerciciosConsole.Exercicios
{
    public class Exercicio1Calculadora
    {
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("===== Exercício 1 - Calculadora =====\n");

            double numero1 = LerNumero("Digite o primeiro número: ");
            double numero2 = LerNumero("Digite o segundo número: ");

            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;

            Console.WriteLine();
            Console.WriteLine($"Soma: {numero1} + {numero2} = {soma}");
            Console.WriteLine($"Subtração: {numero1} - {numero2} = {subtracao}");
            Console.WriteLine($"Multiplicação: {numero1} x {numero2} = {multiplicacao}");

            if (numero2 == 0)
            {
                Console.WriteLine("Divisão: não é possível dividir por zero.");
                Console.WriteLine("Resto da divisão: não é possível calcular o resto com divisor zero.");
            }
            else
            {
                double divisao = numero1 / numero2;
                double resto = numero1 % numero2;

                Console.WriteLine($"Divisão: {numero1} / {numero2} = {divisao}");
                Console.WriteLine($"Resto da divisão: {numero1} % {numero2} = {resto}");
            }
        }

        private double LerNumero(string mensagem)
        {
            double numero;
            Console.Write(mensagem);

            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Valor inválido. Digite novamente: ");
            }

            return numero;
        }
    }
}
