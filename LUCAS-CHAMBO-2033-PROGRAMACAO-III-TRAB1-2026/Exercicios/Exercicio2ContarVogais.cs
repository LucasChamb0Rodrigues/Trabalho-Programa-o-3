using System;

namespace ExerciciosConsole.Exercicios
{
    public class Exercicio2ContarVogais
    {
        private const string Vogais = "AEIOUaeiou";

        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("===== Exercício 2 - Contar Vogais =====\n");

            Console.Write("Digite uma string: ");
            string texto = Console.ReadLine() ?? string.Empty;

            int quantidadeVogais = 0;

            foreach (char caractere in texto)
            {
                if (Vogais.Contains(caractere))
                {
                    quantidadeVogais++;
                }
            }

            Console.WriteLine($"\nA string possui {quantidadeVogais} vogal(is).");
        }
    }
}
