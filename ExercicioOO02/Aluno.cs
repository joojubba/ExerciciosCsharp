using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO02
{
    internal class Aluno
    {
        public string nome;
        public int matricula;
        public DateTime nascimento;
        public int anoIngresso;
        public Aluno()
        {
        }
        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            Console.WriteLine("Instância 1:");
            Console.WriteLine("nome: " + this.nome);
            Console.WriteLine("matricula : " + this.matricula);

        }

        public Aluno(DateTime nascimento)
        {
            this.nascimento = nascimento;
            Console.WriteLine("Instância 2:");
            Console.WriteLine("data de nascimento : " + this.nascimento.ToShortDateString());
        }
        public Aluno(string nome, DateTime nascimento, int anoIngresso)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.anoIngresso = anoIngresso;
            Console.WriteLine("Instância 3:");
            Console.WriteLine("nome: " + this.nome);
            Console.WriteLine("data de nascimento : " + this.nascimento.ToShortDateString());
            Console.WriteLine("ano de ingresso : " + this.anoIngresso);
        }
    }
}
