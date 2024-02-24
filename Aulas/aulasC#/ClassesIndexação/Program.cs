using ClassesIndexacao;
using System;
using System.Reflection.Metadata.Ecma335;

namespace ClassesIndexacao
{
    class Program
    {
       static void Main(string[] args) 
       {
            ListaNomes lista = new ListaNomes();

            lista[0] = "João";
            lista[1] = "Maria";
            lista[2] = "Pedro";

            Console.WriteLine(lista[1]); // Saída "Maria"
       }
        // Não entendi a necessidade dos get e setters, nunca entendo 
    }

 }