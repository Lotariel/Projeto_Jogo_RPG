using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.MODEL
{
    class Itens
    {
        private string nome;

        public string Getnome()
        {
            return nome;
        }

        public void Setnome(string value)
        {
            nome = value;
        }

        private string descricao;

        public string Getdescricao()
        {
            return descricao;
        }

        public void Setdescricao(string value)
        {
            descricao = value;
        }

        private int tipo;

        public int Gettipo()
        {
            return tipo;
        }

        public void Settipo(int value)
        {
            tipo = value;
        }

        private int preco;

        public int Getpreco()
        {
            return preco;
        }

        public void Setpreco(int value)
        {
            preco = value;
        }
    }
}
