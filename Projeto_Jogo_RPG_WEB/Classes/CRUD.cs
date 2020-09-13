using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Projeto_Jogo_RPG_WEB.Classes
{
    //Classe de intereção com o BD para realização dos CRUDs
    //Recebendo herança da classe ConexaoBD, para que seja possível 
    //se conectar com o BD e realizar a validação das informações
    public class CRUD : ConexaoBD
    {
        public String resultado;
        //Método que realiza o select no Banco de Dados
        public String select()
        {
            //Instância de um novo objeto que recebe os comandos SQL para interação com o BD
            //Vide select que interage com a tabela login e puxa as informações de login cadastradas na tabela
            //E chama o método AbrirConexao() que realiza a conexão com o BD
            SqlCommand select = new SqlCommand("select login from personagem", AbrirConexao());
            //Objeto que recebe método de execução de comando SQL
            resultado = select.ExecuteScalar().ToString();
            //Chamada de método que encera a conexão após executado o comando requerido
            FecharConexao();
            //Retorno de variável com o resultado do select no BD
            return resultado;
        }
    }
}