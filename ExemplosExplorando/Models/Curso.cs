using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Curso
    {
        public string nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        void adicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int obterQuantidadeDeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        bool removerAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);

        }
    }
}