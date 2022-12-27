using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private string _sobrenome;
        private string _nomeCompleto;
        public string nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
            }
        }

        public string sobrenome
        {
            get => _sobrenome;
            set
            {

                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio!");
                }
                _sobrenome = value;
            }
        }
        public string nomeCompleto => $"{nome} {sobrenome}".ToUpper();
        public int idade
        {
            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Idade invalida! Sua idade não pode ser menor ou igual a 0!");
                }
                _idade = value;
            }
        }

        public void apresentar()
        {
            Console.WriteLine($"Nome:  {nomeCompleto}, Idade : {idade}");
        }
    }

}
