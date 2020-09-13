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
        //Evento de carregamento da página (realiza as ações aqui especificadas logo que a página é carregada)
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Evento de clicar no botao (realiza as ações aqui especificadas logo que o botão é pressionado)
        protected void btnLogar_Click(object sender, EventArgs e)
        {
            //Aqui será criado a validação das informações apresentadas pelo usuário com as que estão cadastradas no banco

            //Variável que recebe a informação login do usuário
            String login = txtLogin.Text;
        }
    }
}