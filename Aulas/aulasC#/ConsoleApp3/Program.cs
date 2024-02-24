using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class program
    {
        static void Main(string[] args)
        { 
            //Declaramos uma lista para ser usada
            List<int> numeros = new List<int>();

            //Adicionamos elementos à lista
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);

            // Inserir um elemento numa posição especifica
            numeros.Insert(1, 15);

            //Verificar se um elemento está presente na lista
            bool contem15 = numeros.Contains(15);

            //Encontrar a posição de um elemento na lista
            int posicao20 = numeros.IndexOf(20);

            //Ordenar a lista em ordem crescente
            numeros.Sort();

            //remover um elemento de uma posiçao especifica
            numeros.RemoveAt(2);

            //remover o primeiro elemento que apareça que tenha certo valor
            numeros.Remove(10);

            //obter tamanho da lista
            int tamanho = numeros.Count();

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            foreach (int numero in numeros)
            {
                Console.WriteLine(numeros[numero]);
            }
        }
            
    }
}