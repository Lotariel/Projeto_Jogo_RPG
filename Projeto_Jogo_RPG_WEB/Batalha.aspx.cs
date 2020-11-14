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
        Ctr_valorAleatorio Random;
        BATALHA batalha;
        public Batalha()
        {
            crud = new CRUD();
            login = new Login();
            Random = new Ctr_valorAleatorio();
            batalha = new BATALHA();
        }        

        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_atacar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["ID"]);
            int precisao = batalha.Precisao(id), d100 = Random.valor(), dano = batalha.dano(id);
            if (d100 <= precisao)
            {
                txt_textogeral.Text = "Você acertou o ataque!\nDano causado: " + dano + "\nPrecisão: " + precisao + "\nValor do dado: " + d100; ;
            }
            else
            {
                txt_textogeral.Text = "Você errou o ataque!" + "\nPrecisão: " + precisao + "\nValor do dado: " + d100;
            }
        }

        protected void btn_iniciativa_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_reduzirHP_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["ID"]), valor = Convert.ToInt32(TextBox2.Text);
            batalha.HP_ATUAL(valor, id);
            txt_textogeral.Text = "Você perdeu " + valor + " de vida.";
            TextBox2.Text = "";
        }

        protected void btn_reduzirMP_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["ID"]), valor = Convert.ToInt32(TextBox2.Text);
            batalha.MP_ATUAL(valor, id);
            txt_textogeral.Text = "Você perdeu " + valor + " de Mana.";
            TextBox2.Text = "";
        }

        protected void btn_corteduplo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["ID"]);
            int dano = batalha.dano(id);
            txt_textogeral.Text = "Você atacou duas vezes causando o dano de: " + (dano * 2);
        }

        protected void btn_bolafogo_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["ID"]);
            int magia = batalha.magia(id);
            batalha.MP_ATUAL(3, id);
            txt_textogeral.Text = "Você conjurou uma bola de fogo.\nCusto: 3 de MP\nDano causado: " + magia;
        }

        protected void btn_esquivar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["ID"]);
            int esquiva = batalha.esquiva(id),d100 = Random.valor();
            if (d100 <= esquiva)
            {
                txt_textogeral.Text = "Você conseguiu se esquivar do ataque!\nvalor da Esquiva: " + esquiva + "\nValor do Dado:" + d100;
            }
            else
            {
                txt_textogeral.Text = "Você não se esquivou!\nvalor da Esquiva: " + esquiva + "\nValor do Dado:" + d100;
            }
            
        }
    }
}