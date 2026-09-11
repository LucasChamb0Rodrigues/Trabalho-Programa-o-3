using System;

namespace ExerciciosConsole.Exercicios
{    public class Exercicio6CadastroLivro
    {
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("===== Exercício 6 - Cadastro de Livro =====\n");

            Livro livro = new Livro();

            Console.Write("Digite o título do livro: ");
            livro.Titulo = Console.ReadLine() ?? string.Empty;

            Console.Write("Digite o autor do livro: ");
            livro.Autor = Console.ReadLine() ?? string.Empty;

            livro.Valor = LerValor("Digite o valor do livro: ");

            livro.Imprimir();
        }

        private decimal LerValor(string mensagem)
        {
            decimal valor;
            Console.Write(mensagem);

            while (!decimal.TryParse(Console.ReadLine(), out valor) || valor < 0)
            {
                Console.Write("Valor inválido. Digite um valor válido (número >= 0): ");
            }

            return valor;
        }
    }
}
