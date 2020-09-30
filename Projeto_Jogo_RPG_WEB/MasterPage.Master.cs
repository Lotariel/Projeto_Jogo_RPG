using Projeto_Jogo_RPG_WEB.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Jogo_RPG_WEB
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        Login login = new Login();
        CRUD crud = new CRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            String nome = login.nomePersonagem();

            String cod = crud.select_com_where("personagem", "ID_PERSONAGEM", "NOME", nome);



            lblIdade.Text = crud.select_com_where("personagem", "IDADE", "ID_PERSONAGEM", "1");
            lblSexo.Text = crud.select_com_where("personagem", "SEXO", "ID_PERSONAGEM", "1");
            lblOlho.Text = crud.select_com_where("personagem", "COR_OLHOS", "ID_PERSONAGEM", "1");
            lblCabelo.Text = crud.select_com_where("personagem", "COR_CABELO", "ID_PERSONAGEM", "1");
            lblAltura.Text = crud.select_com_where("personagem", "ALTURA", "ID_PERSONAGEM", "1");
            lblPeso.Text = crud.select_com_where("personagem", "PESO", "ID_PERSONAGEM", "1");

            lblNome.Text = crud.select_com_where("personagem", "NOME", "ID_PERSONAGEM", "1");
            lblSobrenome.Text = crud.select_com_where("personagem", "SOBRENOME", "ID_PERSONAGEM", "1");
        }
    }
}