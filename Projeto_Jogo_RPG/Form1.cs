using Projeto_Jogo_RPG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projeto_Jogo_RPG
{
    public partial class Form1 : Form
    {
        private CRUD crud;
        
        public Form1()
        {
            InitializeComponent();
            crud = new CRUD();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Racas'. Você pode movê-la ou removê-la conforme necessário.
            //this.racasTableAdapter.Fill(this.dataSet1.Racas);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Classes'. Você pode movê-la ou removê-la conforme necessário.
            //this.classesTableAdapter.Fill(this.dataSet1.Classes);
            cmb_classe.Items.Add(crud.select_geral("classes","nome"));
            cmb_raca.Items.Add(crud.select_geral("racas", "nome"));                   

            SqlConnection AbrirConexao() { SqlConnection conexao = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Password=Sn4ho_Kvnnp-;User ID=pim;Initial Catalog=pim;"); conexao.Open(); return conexao; }
            SqlConnection FecharConexao() { SqlConnection conexao = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Password=Sn4ho_Kvnnp-;User ID=pim;Initial Catalog=pim;"); conexao.Close(); return conexao; }
            SqlCommand cmd = new SqlCommand("SELECT * FROM tipos ORDER BY nome", AbrirConexao());
            SqlDataReader dr = cmd.ExecuteReader();

            //percorre o SqlDataReader para obter os dados
            while (dr.Read())
            {
                //nome da categoria em dr["nome"]
                cb_TipoItens.Items.Add(dr["nome"]);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.racasTableAdapter.Fill(this.dataSet1.Racas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            crud.Insert_Raca(txt_nome.Text, Convert.ToInt32(txt_focoraca.Text), Convert.ToInt32(txt_vitraca.Text), Convert.ToInt32(txt_magraca.Text), Convert.ToInt32(txt_auraraca.Text), Convert.ToInt32(txt_focoraca.Text), Convert.ToInt32(txt_velraca.Text), txt_descricaoraca.Text.ToString()); ;
            MessageBox.Show("Cadastro realizado com Sucesso!");
        }

        private void btn_inserir_classe_Click(object sender, EventArgs e)
        {
            crud.Insert_classe(txt_nome_classe.Text, Convert.ToInt32(txt_for_classe.Text), Convert.ToInt32(txt_vitalidade_classe.Text), Convert.ToInt32(txt_magia_classe.Text), Convert.ToInt32(txt_aura_classe.Text), Convert.ToInt32(txt_foco_classe.Text), Convert.ToInt32(txt_velocidade_classe.Text), txt_descricao_classe.Text, Convert.ToInt32(txt_prec_classe.Text));
            MessageBox.Show("Cadastro realizado com Sucesso!");
        }

        private void btnCadastrarPericia_Click(object sender, EventArgs e)
        {
            crud.Insert_pericia(txtNomePericia.Text, txtDescPericia.Text);
            MessageBox.Show("Cadastro realizado com Sucesso!");
            txtDescPericia.Text = "";
            txtNomePericia.Text = "";
            txtNomePericia.Focus();
        }

        private void txt_TipoItens_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CadastrarItens_Click(object sender, EventArgs e)
        {
            crud.Insert_itens(txt_NomeItens.Text, txt_DescricaoItens.Text, Convert.ToInt32(cb_TipoItens.Text), Convert.ToInt32(txt_PrecoItens.Text));
            MessageBox.Show("Cadastro realizado com Sucesso!");
        }

        private void btn_CadastrarTipo_Click(object sender, EventArgs e)
        {
            crud.Insert_tipos(txt_NomeTipo.Text);
            MessageBox.Show("Cadastro realizado com Sucesso!");
        }
    }
}
