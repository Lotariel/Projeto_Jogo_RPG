using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes.DAO
{
    public class BATALHA 
    {
        CRUD crud;
        public BATALHA()
        {
            crud = new CRUD();
        }

        //Precisão do personagem = 40 + nivel do personagem + foco
        public int Precisao(int ID)
        {
            int nivelPersonagem = Convert.ToInt32(crud.select_com_where("status", "NIVEL", "ID_PERSONAGEM", Convert.ToString(ID)));
            int foco = Convert.ToInt32(crud.select_com_where("status", "FOCO", "ID_PERSONAGEM", Convert.ToString(ID)));

            return 40 + nivelPersonagem + foco;
        }
        //metodo que retorna o dano
        public int dano(int ID)
        {
            //selecionar a FORÇA do personagem na tabela STATUS
            int força = Convert.ToInt32(crud.select_com_where("status", "FORCA", "ID_PERSONAGEM", Convert.ToString(ID)));
            //selecionar o MULTIPLICADOR na tabela ARMAS
            int multiplicador = Convert.ToInt32(crud.select_com_where("armas", "MULTIPLICADOR", "TIPO", Convert.ToString(1)));
            //multiplicar a FORÇA pelo MULTIPLICADOR
            return força * multiplicador;
        }
    }
}
