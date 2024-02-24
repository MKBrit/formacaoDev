using System;

namespace ReadWriteFile
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            //Path
            string filePath = "C:\\Users\\MigBr\\Desktop\\test\\file.txt";

            //Criar objeto de StreamWriter                  AKA ISTO ESCREVE
            using (StreamWriter escritor = new StreamWriter(filePath)) 
            {
                escritor.WriteLine("Hello Mundo");
                escritor.WriteLine("Este é um novo file de texto de teste");
            }
            Console.WriteLine("File escrito com Sucesso!");

            //Criar objeto de StreamReader                  AKA ISTO LÊ
            using (StreamReader leitor = new StreamReader(filePath))
            {
                string line;
                while((line = leitor.ReadLine()) != null) 
                { 
                    Console.WriteLine(line);
                }
            }
        }

    }

}
