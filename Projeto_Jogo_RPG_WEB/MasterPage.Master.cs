using Projeto_Jogo_RPG_WEB.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Jogo_RPG_WEB
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        Login login;
        CRUD crud;

        //Método obrigatório CONSTRUTOR
        public MasterPage()
        {
            login = new Login();
            crud = new CRUD();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String ID = Session["ID"].ToString();


                lblIdade.Text = crud.select_com_where("personagem", "IDADE", "ID_PERSONAGEM", ID);
                lblSexo.Text = crud.select_com_where("personagem", "SEXO", "ID_PERSONAGEM", ID);
                lblOlho.Text = crud.select_com_where("personagem", "COR_OLHOS", "ID_PERSONAGEM", ID);
                lblCabelo.Text = crud.select_com_where("personagem", "COR_CABELO", "ID_PERSONAGEM", ID);
                lblAltura.Text = crud.select_com_where("personagem", "ALTURA", "ID_PERSONAGEM", ID);
                lblPeso.Text = crud.select_com_where("personagem", "PESO", "ID_PERSONAGEM", ID);

                lblNome.Text = crud.select_com_where("personagem", "NOME", "ID_PERSONAGEM", ID);
                lblSobrenome.Text = crud.select_com_where("personagem", "SOBRENOME", "ID_PERSONAGEM", ID);
            }
            catch(IOException erro)
            {

            }
        }
    }
}