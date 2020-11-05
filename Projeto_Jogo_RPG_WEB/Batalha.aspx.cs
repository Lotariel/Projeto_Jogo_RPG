using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes.CONTROL;
using Classes.DAO;

namespace Projeto_Jogo_RPG_WEB
{
    public partial class Batalha : System.Web.UI.Page
    {
        CRUD crud;
        Login login;
        Ctr_valorAleatorio valor;
        BATALHA batalha;
        public Batalha()
        {
            crud = new CRUD();
            login = new Login();
            valor = new Ctr_valorAleatorio();
            batalha = new BATALHA();
        }        

        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_atacar_Click(object sender, EventArgs e)
        {

        }
    }
}