using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


//Clase que abre e fecha a conexão com o Banco de Dados 
namespace Projeto_Jogo_RPG_WEB.Classes
{
    public class ConexaoBD
    {
        //Método que abre a conexão com o BD
        public SqlConnection AbrirConexao()
        {
            //Instância de um novo objeto de conexão
            //Atribuição da String de conexão ao objeto informando a fonte dos dados, nome do banco, senha, e usuário
            SqlConnection conexao = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Password=Sn4ho_Kvnnp-;User ID=pim;Initial Catalog=pim;");
            //Abrindo a conexão através do objeto que possui a String de conexão com o método Open()
            conexao.Open();
            //Retornando o objeto com a conexão iniciada ao método de abertura de conexão
            return conexao;
        }

        //Método que fecha a conexão com o BD
        public SqlConnection FecharConexao()
        {
            //Instancia de um novo objeto de conexão
            //Atribuição da String de conexão ao objeto informando a fonte dos dados, nome do banco, senha, e usuário
            SqlConnection conexao = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Password=Sn4ho_Kvnnp-;User ID=pim;Initial Catalog=pim;");
            //Fechando a conexão através do objeto que possui a String de conexão com o método Close();
            conexao.Close();
            //Retornando o objeto com a conexão fechada ao método de fechamento de conexao
            return conexao;
        }
    }
}