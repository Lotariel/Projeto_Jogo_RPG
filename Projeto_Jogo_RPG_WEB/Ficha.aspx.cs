using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;
using Classes.DAO;

namespace Projeto_Jogo_RPG_WEB
{
    public partial class Ficha : System.Web.UI.Page
    {
        //Criação de uma nova instância da classe CRUD para que seja possível
        //utilizar seus métodos
        CRUD crud = new CRUD();

        //Evento de carregamento da página (realiza as ações aqui especificadas logo que a página é carregada)
        protected void Page_Load(object sender, EventArgs e)
        {
            //label recebendo o valor que já tinha e contatenando com o resultado da busca no banco
            lblNomePersonagem.Text += crud.select();
        }
    }
}