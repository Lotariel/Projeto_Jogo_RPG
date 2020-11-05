using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.MODEL;
using Classes.DAO;

namespace Classes.CONTROL
{
    public class Ctr_Itens
    {
        Itens itens = new Itens();
        CRUD crud = new CRUD();

        public void Coloca_Model_nome(string nome)
        {
            itens.Setnome(nome);
        }

        public void Coloca_Model_descricao(string desc)
        {
            itens.Setdescricao(desc);
        }

        public void Coloca_Model_tipo(int tipo)
        {
            itens.Settipo(tipo);
        }

        public void Coloca_Model_preco(int preco)
        {
            itens.Setpreco(preco);
        }


        public void Coloca_DAO()
        {
            crud.Insert_itens(itens.Getnome(), itens.Getdescricao(), itens.Gettipo(), itens.Getpreco());
        }
    }
}
