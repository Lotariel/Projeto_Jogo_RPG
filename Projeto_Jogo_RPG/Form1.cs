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

namespace Projeto_Jogo_RPG
{
    public partial class Form1 : Form
    {
        private CRUD crud = new CRUD();
        
        public Form1()
        {
            InitializeComponent();
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
            MessageBox.Show("Cadastro realizado com Sucesso");
        }
    }
}
