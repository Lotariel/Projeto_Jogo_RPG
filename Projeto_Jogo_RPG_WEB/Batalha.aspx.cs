using Classes.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Jogo_RPG_WEB
{
    public partial class Batalha : System.Web.UI.Page
    {
        CRUD crud;
        Login login;
        Random aleatorio;
        
        public Batalha()
        {
            crud = new CRUD();
            login = new Login();
            aleatorio = new Random();
        }        

        //número aleatorio de 1 a 100
        public int valorAleatorio()
        {
            return aleatorio.Next(1, 100);
        }
        //Precisão do personagem = 40 + nivel do personagem + foco
        public int Precisao()
        {
            String ID = Session["ID"].ToString();
            int nivelPersonagem = Convert.ToInt32(crud.select_com_where("status", "NIVEL", "ID_PERSONAGEM", ID));
            int foco = Convert.ToInt32(crud.select_com_where("status", "FOCO", "ID_PERSONAGEM", ID));

            return 40 + nivelPersonagem + foco;
        }
        public int dano()
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_atacar_Click(object sender, EventArgs e)
        {

        }
    }
}