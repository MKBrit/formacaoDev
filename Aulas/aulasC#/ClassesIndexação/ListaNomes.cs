using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIndexacao
{
    class ListaNomes
    {
        private string[] nomes = new string[5];

        public string this[int index]
        {
            get
            {
                return nomes[index];
            }

            set
            {
                nomes[index] = value;
            }
        }
    }
}
