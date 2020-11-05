using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Classes.DAO
{
    public class CRUD : CONEXAO
    {

        public String resultado;
        private SqlDataReader reader;
        //Método que realiza o select no Banco de Dados
        //public String select(String nomeColuna, String nomeTabela)
        public String select()
        {
            //Instância de um novo objeto que recebe os comandos SQL para interação com o BD
            //Vide select que interage com a tabela login e puxa as informações de login cadastradas na tabela
            //E chama o método AbrirConexao() que realiza a conexão com o BD
            SqlCommand sel = new SqlCommand("select nome from personagem", AbrirConexao());
            //SqlCommand sel = new SqlCommand("select "+nomeColuna+" from "+nomeTabela);

            //Objeto que recebe método de execução de comando SQL
            resultado = sel.ExecuteScalar().ToString();
            //Chamada de método que encera a conexão após executado o comando requerido
            FecharConexao();
            //Retorno de variável com o resultado do select no BD
            return resultado;
        }       

        public string select_com_where(string NomeTabela, string NomeColuna, string Filtro, string ValorFiltro)
        {
            //Metodo que será utilizado para executar uma SELECT com filtro em qualquer tabela do banco de dados
            //NomeTabela = Informar o nome da tabela
            //NomeColuna = Informar o nome da coluna da tabela selecionada
            //Filtro = Selecionar o nome da coluna que será filtrada
            //ValorFiltro = informar qual o valor será usado para coluna filtrada Exemplo where id_personagem = ValorFiltro

            SqlCommand query = new SqlCommand("select " + NomeColuna +
                                              " from " + NomeTabela +
                                              " where " + Filtro +
                                              " = @ValorFiltro", AbrirConexao());

            query.Parameters.Add(new SqlParameter("ValorFiltro", ValorFiltro));

            FecharConexao();

            try
            {
                if (query.ExecuteScalar() == null)
                {
                    resultado = "";
                    return resultado;
                }
                else
                {
                    resultado = resultado = query.ExecuteScalar().ToString();
                    return resultado;
                }
            }
            catch (SqlException erro)
            {
                return erro.ToString();
            }

        }

        public void update_com_where(string NomeTabela, string NomeColuna, string ValorUpdate, string ColunaFiltro, string ValorFiltro)
        {
            SqlCommand update = new SqlCommand("update " + NomeTabela + " set " + NomeColuna + " = @valor where " + ColunaFiltro + " = " + ValorFiltro, AbrirConexao());
            //Comando usado para o C# aceitar os valores do componete TextBox na hora de fazer o update.
            update.Parameters.Add(new SqlParameter("valor", ValorUpdate));
            update.ExecuteScalar();
            FecharConexao();
        }

      

        public String select_geral(string Nometabela, string nomecoluna)
        {

            SqlCommand sel = new SqlCommand("select * from " + Nometabela, AbrirConexao());
            reader = sel.ExecuteReader();
            reader.Read();
            FecharConexao();

            return reader[nomecoluna].ToString();
        }

        public void Insert_Raca(string nome, int forca, int vit, int mag, int aur, int foc, int vel, string descricao)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[Racas]([NOME],[DESCRICAO],[FORCA],[VITALIDADE],[MAGIA],[AURA],[FOCO],[VELOCIDADE])  VALUES(@nome,@des,@for,@vit,@mag,@aur,@foc,@vel)", AbrirConexao());
            insert.Parameters.Add(new SqlParameter("nome", nome));
            insert.Parameters.Add(new SqlParameter("for", forca));
            insert.Parameters.Add(new SqlParameter("vit", vit));
            insert.Parameters.Add(new SqlParameter("mag", mag));
            insert.Parameters.Add(new SqlParameter("aur", aur));
            insert.Parameters.Add(new SqlParameter("foc", foc));
            insert.Parameters.Add(new SqlParameter("vel", vel));
            insert.Parameters.Add(new SqlParameter("des", descricao));
            insert.ExecuteNonQuery();
            FecharConexao();
        }


        public void Insert_classe(string nome, int forca, int vit, int mag, int aur, int foc, int vel, string descricao, int prec)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[classes]([NOME],[DESCRICAO],[FORCA],[VITALIDADE],[MAGIA],[AURA],[FOCO],[VELOCIDADE],[PRECISAO])  VALUES(@nome,@des,@for,@vit,@mag,@aur,@foc,@vel,@prec)", AbrirConexao());
            insert.Parameters.Add(new SqlParameter("nome", nome));
            insert.Parameters.Add(new SqlParameter("for", forca));
            insert.Parameters.Add(new SqlParameter("vit", vit));
            insert.Parameters.Add(new SqlParameter("mag", mag));
            insert.Parameters.Add(new SqlParameter("aur", aur));
            insert.Parameters.Add(new SqlParameter("foc", foc));
            insert.Parameters.Add(new SqlParameter("vel", vel));
            insert.Parameters.Add(new SqlParameter("des", descricao));
            insert.Parameters.Add(new SqlParameter("prec", prec));
            insert.ExecuteNonQuery();
            FecharConexao();
        }

        public void Insert_pericia(string nome, string descricao)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[pericias]([NOME],[DESCRICAO]) VALUES(@nome,@desc)", AbrirConexao());
            insert.Parameters.Add(new SqlParameter("nome", nome));
            insert.Parameters.Add(new SqlParameter("desc", descricao));
            insert.ExecuteNonQuery();
            FecharConexao();
        }
        //Método de inserção dos dados da janela Itens
        public void Insert_itens(string nome, string descricao, int tipo, int preco)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[itens]([NOME],[DESCRICAO],[TIPO],[PRECO]) VALUES(@nome,@desc,@tipo,@preco)", AbrirConexao());
            insert.Parameters.Add(new SqlParameter("nome", nome));
            insert.Parameters.Add(new SqlParameter("desc", descricao));
            insert.Parameters.Add(new SqlParameter("tipo", tipo));
            insert.Parameters.Add(new SqlParameter("preco", preco));
            insert.ExecuteNonQuery();
            FecharConexao();
        }

        //Método de inserção dos dados da janela Tipos
        public void Insert_tipos(string nome)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[tipos]([NOME]) VALUES(@nome)", AbrirConexao());
            insert.Parameters.Add(new SqlParameter("nome", nome));
            insert.ExecuteNonQuery();
            FecharConexao();
        }

        public void Insert_Personagem(string nome, string sobrenome, string idade, string sexo, int raca, int classe, string olhos, string cabelo, string altura, string peso, string historia)
        {
            SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[personagem]([NOME],[SOBRENOME],[IDADE],[SEXO],[ID_RACA],[ID_CLASSE],[COR_OLHOS],[COR_CABELO],[ALTURA],[PESO],[HISTORIA]) VALUES(@nome,@sobre,@idade,@sexo,@raca,@classe,@olhos,@cabelo,@altura,@peso,@historia)", AbrirConexao());
            insert.Parameters.Add(new SqlParameter("nome", nome));
            insert.Parameters.Add(new SqlParameter("sobre", sobrenome));
            insert.Parameters.Add(new SqlParameter("idade", idade));
            insert.Parameters.Add(new SqlParameter("sexo", sexo));
            insert.Parameters.Add(new SqlParameter("raca", raca));
            insert.Parameters.Add(new SqlParameter("classe", classe));
            insert.Parameters.Add(new SqlParameter("olhos", olhos));
            insert.Parameters.Add(new SqlParameter("cabelo", cabelo));
            insert.Parameters.Add(new SqlParameter("altura", altura));
            insert.Parameters.Add(new SqlParameter("peso", peso));
            insert.Parameters.Add(new SqlParameter("historia", historia));
            insert.ExecuteNonQuery();
            FecharConexao();
        }
    }
}
