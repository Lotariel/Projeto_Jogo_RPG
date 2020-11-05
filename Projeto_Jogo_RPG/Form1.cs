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
using Classes;
using Classes.DAO;
using Classes.CONTROL;


namespace Projeto_Jogo_RPG
{
    public partial class Form1 : Form
    {
        private CRUD crud;
        private Ctr_Tipo tipos;
        private Ctr_Pericias pericias;
        private Ctr_Classe classe;
        private Ctr_Raça raca;
        private Ctr_Itens itens;
        private Ctr_Personagem personagem;

        public Form1()
        {
            InitializeComponent();
            crud = new CRUD();
            tipos = new Ctr_Tipo();
            pericias = new Ctr_Pericias();
            classe = new Ctr_Classe();
            raca = new Ctr_Raça();
            itens = new Ctr_Itens();
            personagem = new Ctr_Personagem();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            //Código em MVC
            personagem.Coloca_Modelo_nome(txt_nomePersonagem.Text.ToString());
            personagem.Coloca_Modelo_sobrenome(txt_sobrenomePersonagem.Text.ToString());
            personagem.Coloca_Modelo_idade(txt_idadePersonagem.Text.ToString());
            personagem.Coloca_Modelo_sexo(cb_sexoPersonagem.SelectedItem.ToString());
            personagem.Coloca_Modelo_raca(Convert.ToInt16(cmb_racaPersonagem.SelectedValue));
            personagem.Coloca_Modelo_classe(Convert.ToInt16(cmb_classePersonagem.SelectedValue));
            personagem.Coloca_Modelo_olhos(txt_olhosPersonagem.Text.ToString());
            personagem.Coloca_Modelo_cabelo(txt_cabeloPersonagem.Text.ToString());
            personagem.Coloca_Modelo_altura(txt_altuaPersonagem.Text.ToString());
            personagem.Coloca_Modelo_peso(txt_pesoPersonagem.Text.ToString());
            personagem.Coloca_Modelo_historia(txt_historiaPersonagem.Text.ToString());
            personagem.Coloca_DAO();
            MessageBox.Show("Cadastro realizado com Sucesso!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet4.Classes'. Você pode movê-la ou removê-la conforme necessário.
            this.classesTableAdapter1.Fill(this.dataSet4.Classes);
            // TODO: esta linha de código carrega dados na tabela 'dataSet3.Racas'. Você pode movê-la ou removê-la conforme necessário.
            this.racasTableAdapter1.Fill(this.dataSet3.Racas);
            // TODO: esta linha de código carrega dados na tabela 'dataSet2.TIPOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tIPOSTableAdapter.Fill(this.dataSet2.TIPOS);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Racas'. Você pode movê-la ou removê-la conforme necessário.
            //this.racasTableAdapter.Fill(this.dataSet1.Racas);
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Classes'. Você pode movê-la ou removê-la conforme necessário.
            //this.classesTableAdapter.Fill(this.dataSet1.Classes);
            //cmb_classe.Items.Add(crud.select_geral("classes","nome"));
            //cmb_raca.Items.Add(crud.select_geral("racas", "nome"));                               

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
            // Código em MVC
            raca.Coloca_Model_nome(txt_nomeraca.Text.ToString());
            raca.Coloca_Model_descricao(txt_descricaoraca.Text.ToString());
            raca.Coloca_Model_forca(Convert.ToInt32(txt_forcaraca.Text));
            raca.Coloca_Model_vitalidade(Convert.ToInt32(txt_vitraca.Text));
            raca.Coloca_Model_magia(Convert.ToInt32(txt_magraca.Text));
            raca.Coloca_Model_aura(Convert.ToInt32(txt_auraraca.Text));
            raca.Coloca_Model_foco(Convert.ToInt32(txt_focoraca.Text));
            raca.Coloca_Model_velocidade(Convert.ToInt32(txt_velraca.Text));
            raca.Coloca_DAO();
            MessageBox.Show("Cadastro realizado com Sucesso!");

            //Código Antigo
            //crud.Insert_Raca(txt_nome.Text,
            //Convert.ToInt32(txt_forcaraca.Text),
            //Convert.ToInt32(txt_vitraca.Text),
            //Convert.ToInt32(txt_magraca.Text),
            //Convert.ToInt32(txt_auraraca.Text),
            //Convert.ToInt32(txt_focoraca.Text),
            //Convert.ToInt32(txt_velraca.Text),
            //txt_descricaoraca.Text.ToString()); ;
            //MessageBox.Show("Cadastro realizado com Sucesso!");
        }

        private void btn_inserir_classe_Click(object sender, EventArgs e)
        {
            // Código em MVC
            classe.Coloca_Model_nome(txt_nome_classe.Text);
            classe.Coloca_Model_forca(Convert.ToInt32(txt_for_classe.Text));
            classe.Coloca_Model_vitalidade(Convert.ToInt32(txt_vitalidade_classe.Text));
            classe.Coloca_Model_magia(Convert.ToInt32(txt_magia_classe.Text));
            classe.Coloca_Model_aura(Convert.ToInt32(txt_aura_classe.Text));
            classe.Coloca_Model_foco(Convert.ToInt32(txt_foco_classe.Text));
            classe.Coloca_Model_velocidade(Convert.ToInt32(txt_velocidade_classe.Text));
            classe.Coloca_Model_descricao(txt_descricao_classe.Text);
            classe.Coloca_Model_precisao(Convert.ToInt32(txt_prec_classe.Text));
            classe.Coloca_DAO();
            MessageBox.Show("Cadastro realizado com Sucesso!");

            //Código Antigo
            //crud.Insert_classe(txt_nome_classe.Text,
            //Convert.ToInt32(txt_for_classe.Text),
            //Convert.ToInt32(txt_vitalidade_classe.Text),
            //Convert.ToInt32(txt_magia_classe.Text),
            //Convert.ToInt32(txt_aura_classe.Text),
            //Convert.ToInt32(txt_foco_classe.Text),
            //Convert.ToInt32(txt_velocidade_classe.Text),
            //txt_descricao_classe.Text,
            //Convert.ToInt32(txt_prec_classe.Text));
            //MessageBox.Show("Cadastro realizado com Sucesso!");
        }

        private void btnCadastrarPericia_Click(object sender, EventArgs e)
        {
            // Código em MVC
            pericias.Coloca_Model_nome(txtNomePericia.Text);
            pericias.Coloca_Model_descricao(txtDescPericia.Text);
            pericias.Coloca_DAO();
            MessageBox.Show("Cadastro realizado com Sucesso!");

            //Código Antigo
            //crud.Insert_pericia(txtNomePericia.Text, txtDescPericia.Text);
            //MessageBox.Show("Cadastro realizado com Sucesso!");
            //txtDescPericia.Text = "";
            //txtNomePericia.Text = "";
            //txtNomePericia.Focus();
        }

        private void txt_TipoItens_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CadastrarItens_Click(object sender, EventArgs e)
        {
            // Código em MVC
            itens.Coloca_Model_nome(txt_NomeItens.Text.ToString());
            itens.Coloca_Model_descricao(txt_DescricaoItens.Text.ToString());
            itens.Coloca_Model_tipo(Convert.ToInt32(cb_TipoItens.SelectedValue));
            itens.Coloca_Model_preco(Convert.ToInt32(txt_PrecoItens.Text));
            itens.Coloca_DAO();
            MessageBox.Show("Cadastro realizado com Sucesso!");
            // Código Antigo
            //crud.Insert_itens(txt_NomeItens.Text,
            //txt_DescricaoItens.Text,
            //Convert.ToInt32(cb_TipoItens.SelectedValue),
            //Convert.ToInt32(txt_PrecoItens.Text));
            //MessageBox.Show("Cadastro realizado com Sucesso!");            
        }

        private void btn_CadastrarTipo_Click(object sender, EventArgs e)
        {
            // Código em MVC
            tipos.Coloca_Model_nome(txt_NomeTipo.Text);
            tipos.Coloca_DAO();
            MessageBox.Show("Cadastro realizado com Sucesso!");

            // Código Antigo
            //crud.Insert_tipos(txt_NomeTipo.Text);
            //MessageBox.Show("Cadastro realizado com Sucesso!");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.racasTableAdapter1.FillBy(this.dataSet3.Racas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmb_racaPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPersonagem_Click(object sender, EventArgs e)
        {

        }
    }
}
