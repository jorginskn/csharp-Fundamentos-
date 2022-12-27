using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        public string nome
        {
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        private int _idade;
        public int idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Idade invalida!");
                }
                _idade = value;
            }
        }

        public void apresentar()
        {
            Console.WriteLine($"Nome:  {nome}, Idade : {idade}");
        }
    }
}