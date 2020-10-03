using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Projeto_Jogo_RPG_WEB.Classes;

namespace Projeto_Jogo_RPG_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        //Criação de uma nova instância da classe CRUD para que seja possível
        //utilizar seus métodos
        CRUD crud = new CRUD();
        public String nome;

        //Evento de carregamento da página (realiza as ações aqui especificadas logo que a página é carregada)
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Evento de clicar no botao (realiza as ações aqui especificadas logo que o botão é pressionado)
        protected void btnLogar_Click(object sender, EventArgs e)
        {
            nome = txtLogin.Text;

            //Aqui será criado a validação das informações apresentadas pelo usuário com as que estão cadastradas no banco

            //Comando condicional que verifica se o que o usuário digitou na área de login
            //existe no banco de dadaos (chamando o objeto crud, instância da classe CRUD, e
            //utilizando o método select()
            if (txtLogin.Text == crud.select_com_where("personagem", "nome", "nome", "'" + txtLogin.Text + "'"))
            {
                lblConexao.Text = "Entrou";
                //chamada de outra página dentro do projeto (página de teste da ficha)
                Response.Redirect("/Status.aspx");
            }
            else 
            {
                lblConexao.Text = "Dados inválidos!";
            }
        }
        
        public String nomePersonagem()
        {
            return nome;
        }
    }
}