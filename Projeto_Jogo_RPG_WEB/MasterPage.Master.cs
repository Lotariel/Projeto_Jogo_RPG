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

                lblNivel.Text = crud.select_com_where("status", "NIVEL", "ID_PERSONAGEM", ID);
                lblHP_Atual.Text = crud.select_com_where("status", "HP_ATUAL", "ID_PERSONAGEM", ID);
                lblHP_MAX.Text = crud.select_com_where("status", "HP_MAXIMO", "ID_PERSONAGEM", ID);
                lblExp_Atual.Text = crud.select_com_where("status", "EXP_ATUAL", "ID_PERSONAGEM", ID);
                int Exp_Max = Convert.ToInt32(lblNivel.Text);
                lblExp_MAX.Text = Convert.ToString(Exp_Max * 500);
                lblMP_Atual.Text = crud.select_com_where("status", "MP_ATUAL", "ID_PERSONAGEM", ID);
                lblMP_MAX.Text = crud.select_com_where("status", "MP_MAXIMO", "ID_PERSONAGEM", ID);

                //ESTATÍSTICAS
                lblCDS_Critico.Text = crud.select_com_where("status", "CDS_Critico", "ID_PERSONAGEM", ID);
                lblDano_Critico.Text = crud.select_com_where("status", "Dano_Critico", "ID_PERSONAGEM", ID);
                lblQtd_Ataque.Text = crud.select_com_where("status", "QUANTIDADE_ATAQUES", "ID_PERSONAGEM", ID);
                lblQtd_Acao.Text = crud.select_com_where("status", "QUANTIDADE_ACOES", "ID_PERSONAGEM", ID);
                //Esquiva = VELOCIDADE + Nivel do personagem
                //Ele começa nível 1; Toda vez que a exp_atual for igual o maior que exp_max
                //O personagem sobe um nível
                int velocidade = Convert.ToInt32(crud.select_com_where("status", "VELOCIDADE", "ID_PERSONAGEM", ID));
                int nivelP = Convert.ToInt32(crud.select_com_where("status", "NIVEL", "ID_PERSONAGEM", ID));
                lblEsquiva.Text = Convert.ToString(velocidade + nivelP);

                //Precisão = 40 + FOCO + PRECISÃO da tabela ARMA
                int foco = Convert.ToInt32(crud.select_com_where("status", "FOCO", "ID_PERSONAGEM", ID));
                int id_arma = Convert.ToInt32(crud.select_com_where("Arsenal", "id_ama", "ID_PERSONAGEM", ID));
                int precisao = Convert.ToInt32(crud.select_com_where("armas", "PRECISAO", "ID_ARMA", Convert.ToString(id_arma)));
                lblPrecisao.Text = Convert.ToString(foco + precisao + 40);

            }
            catch (IOException erro)
            {

            }
        }
    }
}