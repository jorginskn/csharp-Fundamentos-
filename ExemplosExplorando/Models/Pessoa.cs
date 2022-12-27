using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public void apresentar()
        {
            Console.WriteLine($"Nome:  {nome}, Idade : {idade}");
        }
    }
}