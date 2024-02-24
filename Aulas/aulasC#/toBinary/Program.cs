using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using toBinary;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa { Nome = "João", Idade = 25 },
                new Pessoa { Nome = "Maria", Idade = 35 },
                new Pessoa { Nome = "Carlos", Idade = 55 },
            };

            // caminho do arquivo binário

            string caminhoArquivo = "C:\\Users\\MigBr\\Desktop\\test\\file.bin";

            //Serializar a lista de objectos para o arquivo binário

            using (FileStream arquivo = File.Create(caminhoArquivo))
            {
                BinaryWriter writer = new BinaryWriter(arquivo);

                writer.Write(pessoas.Count);

                foreach (Pessoa pessoa in pessoas)
                {
                    writer.Write(pessoa.Nome);
                    writer.Write(pessoa.Idade);
                }
            }

            //Imprimir a lista de pessoas

            using (FileStream arquivo = File.Open(caminhoArquivo, FileMode.Open))
            {
                BinaryReader reader = new BinaryReader(arquivo);

                int numeroPessoas = reader.ReadInt32();

                for (int i = 0; i < numeroPessoas; i++)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Nome = reader.ReadString();
                    pessoa.Idade = reader.ReadInt32();
                    pessoas.Add(pessoa);
                }
            }

            //Imprimir a lista de pessoas

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine("{0} {1}", pessoa.Nome, pessoa.Idade);
            }
        }
    }
}