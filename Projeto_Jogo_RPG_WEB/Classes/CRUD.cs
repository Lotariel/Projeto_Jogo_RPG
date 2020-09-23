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
            SqlCommand sel = new SqlCommand("select nome from personagem", AbrirConexao());
            //Objeto que recebe método de execução de comando SQL
            resultado = sel.ExecuteScalar().ToString();
            //Chamada de método que encera a conexão após executado o comando requerido
            FecharConexao();
            //Retorno de variável com o resultado do select no BD
            return resultado;
        }

        public string select_com_where(string NomeTabela,string NomeColuna,string Filtro,string ValorFiltro)
        {
            //Metodo que será utilizado para executar uma SELECT com filtro em qualquer tabela do banco de dados
            //NomeTabela = Informar o nome da tabela
            //NomeColuna = Informar o nome da coluna da tabela selecionada
            //Filtro = Selecionar o nome da coluna que será filtrada
            //ValorFiltro = informar qual o valor será usado para coluna filtrada Exemplo where id_personagem = ValorFiltro

            try
            {
                SqlCommand query = new SqlCommand("select " + NomeColuna + " from " + NomeTabela + " where " + Filtro + " = " + ValorFiltro, AbrirConexao());
                resultado = query.ExecuteScalar().ToString();
                FecharConexao();
                return resultado;
            }
            catch (SqlException erro)
            {

                return erro.ToString();
            }
            
        }

        public void update_com_where(string NomeTabela, string NomeColuna,string ValorUpdate, string ColunaFiltro, string ValorFiltro)
        {
            SqlCommand update = new SqlCommand("update "+ NomeTabela +" set "+ NomeColuna+ " = @valor where "+ColunaFiltro+" = "+ValorFiltro, AbrirConexao());
            //Comando usado para o C# aceitar os valores do componete TextBox na hora de fazer o update.
            update.Parameters.Add(new SqlParameter("valor", ValorUpdate));
            update.ExecuteScalar();
            FecharConexao();
        }
    }
}