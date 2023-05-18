using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO04
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get 
            { 
                return nome; 
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nome = value;
                }
            }
        }

        public int Idade
        {
            get 
            { 
                return idade; 
            }
            set
            {
                if (value > 0)
                {
                    idade = value;
                }
            }
        }
    }

}

