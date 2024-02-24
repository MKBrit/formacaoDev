using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exLists
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Nota { get; set; }
    }
    class Turma 
    {
        private List<Aluno> alunos = new List<Aluno>();

        public Aluno this[string nome]
        {
            get
            {
                return alunos.Find(aluno => aluno.Nome == nome);
            }
            set
            {
                Aluno alunoExistente = alunos.Find(aluno => aluno.Nome == nome);
                if (alunoExistente != null)
                {
                    alunoExistente.Idade = value.Idade;
                    alunoExistente.Nota = value.Nota;
                }
                else
                {
                    alunos.Add(value);
                }
            }
        }
        public void showList()
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Nota: {aluno.Nota}");
            }
        }

        public static double getMedia(List<Aluno> alunos) 
        {
            double sum = 0.0;
            foreach (Aluno aluno in alunos)
            {
                sum += aluno.Nota;
            }
            return sum / alunos.Count;
        }
    }
}