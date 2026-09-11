using System;

namespace ExerciciosConsole.Exercicios
{
    public class Exercicio5FaixaEtaria
    {
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("===== Exercício 5 - Faixa Etária =====\n");

            int idade = LerIdade("Digite a idade: ");

            string faixaEtaria;

            if (idade <= 19)
            {
                faixaEtaria = "Jovem";
            }
            else if (idade <= 59)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            Console.WriteLine($"\nUma pessoa com {idade} anos é considerada: {faixaEtaria}");
        }

        private int LerIdade(string mensagem)
        {
            int idade;
            Console.Write(mensagem);

            while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
            {
                Console.Write("Valor inválido. Digite uma idade válida (número inteiro >= 0): ");
            }

            return idade;
        }
    }
}
