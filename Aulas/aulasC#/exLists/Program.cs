using exLists;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Turma turma = new Turma();

        turma["João"] = new Aluno { Nome = "João", Idade = 20, Nota = 8.5 };
        turma["Maria"] = new Aluno { Nome = "Maria", Idade = 21, Nota = 9.0 };

        turma.showList();

        Aluno alunoJoao = turma["João"];
        Console.WriteLine($"Nota do João: {alunoJoao.Nota}");
    }
}