using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.MODEL
{
    class Pericias
    {
        private string nome;
        private string descricao;


        public string Getnome()
        {
            return nome;
        }

        public void Setnome(string value)
        {
            nome = value;
        }

        

        public string Getdescricao()
        {
            return descricao;
        }

        public void Setdescricao(string value)
        {
            descricao = value;
        }
    }
}
