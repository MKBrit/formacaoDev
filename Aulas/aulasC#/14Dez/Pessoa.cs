using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Dez
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public string cidade;
        
        public Pessoa(string nme, int idd, string cid) 
        {
            nome = nme;
            idade = idd;
            cidade = cid;
        }

        public override string ToString() 
        {
            return $"Pessoa: {nome} - Idade: {idade} - Cidade: {cidade}";
        }
    }
    
}
