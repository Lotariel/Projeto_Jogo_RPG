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
        //metodo que retorna o resultado da formula (magia *3)
        public int magia(int ID)
        {
            int magia = Convert.ToInt32(crud.select_com_where("status", "FORCA", "ID_PERSONAGEM", Convert.ToString(ID)));

            return magia * 3;
        }

        //metodo que retorna o valor da esquiva (VELOCIDADE + Nivel do personagem)
        //Ele começa nível 1; Toda vez que a exp_atual for igual o maior que exp_max
        //O personagem sobe um nível
        public int esquiva(int ID)
        {
            int velocidade = Convert.ToInt32(crud.select_com_where("status", "VELOCIDADE", "ID_PERSONAGEM", Convert.ToString(ID)));
            int nivelP = Convert.ToInt32(crud.select_com_where("status", "NIVEL", "ID_PERSONAGEM", Convert.ToString(ID)));
            return velocidade + nivelP;
        }

        //metodo que recebe um valor INTEIRO do usuario, 
        //subtrai esse valor do HP_ATUAL do personagem 
        //e da um update  de valor no HP_ATUAL
        public void HP_ATUAL(int valor, int ID)
        {
            int hpAtual = Convert.ToInt32(crud.select_com_where("status", "HP_ATUAL", "ID_PERSONAGEM", Convert.ToString(ID)));
            hpAtual = hpAtual - valor;
            crud.update_com_where("status", "HP_ATUAL", Convert.ToString(hpAtual), "ID_PERSONAGEM", Convert.ToString(ID));
        }

    }
}
