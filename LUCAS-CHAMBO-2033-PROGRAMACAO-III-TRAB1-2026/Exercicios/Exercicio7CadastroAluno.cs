using System;

namespace ExerciciosConsole.Exercicios
{    public class Exercicio7CadastroAluno
    {
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("===== Exercício 7 - Cadastro de Aluno =====\n");

            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("Digite o R.A. do aluno: ");
            aluno.RA = Console.ReadLine() ?? string.Empty;

            aluno.NotaProva = LerNota("Digite a nota da prova (0 a 10): ");
            aluno.NotaTrabalho = LerNota("Digite a nota do trabalho (0 a 10): ");
            aluno.Faltas = LerFaltas("Digite a quantidade de faltas (0 a 40): ");

            aluno.Imprimir();
        }

        private double LerNota(string mensagem)
        {
            double nota;
            Console.Write(mensagem);

            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.Write("Valor inválido. Digite uma nota entre 0 e 10: ");
            }

            return nota;
        }

        private int LerFaltas(string mensagem)
        {
            int faltas;
            Console.Write(mensagem);

            while (!int.TryParse(Console.ReadLine(), out faltas) || faltas < 0 || faltas > 40)
            {
                Console.Write("Valor inválido. Digite a quantidade de faltas entre 0 e 40: ");
            }

            return faltas;
        }
    }
}
