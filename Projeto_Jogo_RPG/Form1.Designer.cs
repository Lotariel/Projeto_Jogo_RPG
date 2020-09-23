namespace Projeto_Jogo_RPG
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tbc_personagem = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_historia = new System.Windows.Forms.TextBox();
            this.lbl_historia = new System.Windows.Forms.Label();
            this.txt_altua = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_cabelo = new System.Windows.Forms.Label();
            this.txt_cabelo = new System.Windows.Forms.TextBox();
            this.txt_olhos = new System.Windows.Forms.TextBox();
            this.lbl_olhos = new System.Windows.Forms.Label();
            this.cmb_raca = new System.Windows.Forms.ComboBox();
            this.lbl_raca = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbc_personagem.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(322, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(114, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "TELA DE CADASTRO";
            // 
            // tbc_personagem
            // 
            this.tbc_personagem.Controls.Add(this.tabPage1);
            this.tbc_personagem.Controls.Add(this.tabPage2);
            this.tbc_personagem.Location = new System.Drawing.Point(12, 53);
            this.tbc_personagem.Name = "tbc_personagem";
            this.tbc_personagem.SelectedIndex = 0;
            this.tbc_personagem.Size = new System.Drawing.Size(776, 559);
            this.tbc_personagem.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_historia);
            this.tabPage1.Controls.Add(this.lbl_historia);
            this.tabPage1.Controls.Add(this.txt_altua);
            this.tabPage1.Controls.Add(this.lbl_altura);
            this.tabPage1.Controls.Add(this.lbl_peso);
            this.tabPage1.Controls.Add(this.txt_peso);
            this.tabPage1.Controls.Add(this.lbl_cabelo);
            this.tabPage1.Controls.Add(this.txt_cabelo);
            this.tabPage1.Controls.Add(this.txt_olhos);
            this.tabPage1.Controls.Add(this.lbl_olhos);
            this.tabPage1.Controls.Add(this.cmb_raca);
            this.tabPage1.Controls.Add(this.lbl_raca);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.lbl_sexo);
            this.tabPage1.Controls.Add(this.txt_idade);
            this.tabPage1.Controls.Add(this.lbl_idade);
            this.tabPage1.Controls.Add(this.txt_sobrenome);
            this.tabPage1.Controls.Add(this.txt_nome);
            this.tabPage1.Controls.Add(this.lbl_sobrenome);
            this.tabPage1.Controls.Add(this.lbl_nome);
            this.tabPage1.Controls.Add(this.btn_enviar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_historia
            // 
            this.txt_historia.Location = new System.Drawing.Point(10, 389);
            this.txt_historia.Multiline = true;
            this.txt_historia.Name = "txt_historia";
            this.txt_historia.Size = new System.Drawing.Size(320, 128);
            this.txt_historia.TabIndex = 20;
            // 
            // lbl_historia
            // 
            this.lbl_historia.AutoSize = true;
            this.lbl_historia.Location = new System.Drawing.Point(7, 363);
            this.lbl_historia.Name = "lbl_historia";
            this.lbl_historia.Size = new System.Drawing.Size(99, 13);
            this.lbl_historia.TabIndex = 19;
            this.lbl_historia.Text = "Resumo da Historia";
            // 
            // txt_altua
            // 
            this.txt_altua.Location = new System.Drawing.Point(78, 327);
            this.txt_altua.Name = "txt_altua";
            this.txt_altua.Size = new System.Drawing.Size(100, 20);
            this.txt_altua.TabIndex = 18;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(6, 327);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_altura.TabIndex = 17;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(6, 290);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 16;
            this.lbl_peso.Text = "Peso";
            this.lbl_peso.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(78, 283);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 15;
            // 
            // lbl_cabelo
            // 
            this.lbl_cabelo.AutoSize = true;
            this.lbl_cabelo.Location = new System.Drawing.Point(6, 247);
            this.lbl_cabelo.Name = "lbl_cabelo";
            this.lbl_cabelo.Size = new System.Drawing.Size(40, 13);
            this.lbl_cabelo.TabIndex = 14;
            this.lbl_cabelo.Text = "Cabelo";
            // 
            // txt_cabelo
            // 
            this.txt_cabelo.Location = new System.Drawing.Point(78, 240);
            this.txt_cabelo.Name = "txt_cabelo";
            this.txt_cabelo.Size = new System.Drawing.Size(100, 20);
            this.txt_cabelo.TabIndex = 13;
            // 
            // txt_olhos
            // 
            this.txt_olhos.Location = new System.Drawing.Point(78, 198);
            this.txt_olhos.Name = "txt_olhos";
            this.txt_olhos.Size = new System.Drawing.Size(100, 20);
            this.txt_olhos.TabIndex = 12;
            // 
            // lbl_olhos
            // 
            this.lbl_olhos.AutoSize = true;
            this.lbl_olhos.Location = new System.Drawing.Point(3, 198);
            this.lbl_olhos.Name = "lbl_olhos";
            this.lbl_olhos.Size = new System.Drawing.Size(37, 13);
            this.lbl_olhos.TabIndex = 11;
            this.lbl_olhos.Text = " Olhos";
            // 
            // cmb_raca
            // 
            this.cmb_raca.FormattingEnabled = true;
            this.cmb_raca.Location = new System.Drawing.Point(78, 160);
            this.cmb_raca.Name = "cmb_raca";
            this.cmb_raca.Size = new System.Drawing.Size(100, 21);
            this.cmb_raca.TabIndex = 10;
            // 
            // lbl_raca
            // 
            this.lbl_raca.AutoSize = true;
            this.lbl_raca.Location = new System.Drawing.Point(6, 160);
            this.lbl_raca.Name = "lbl_raca";
            this.lbl_raca.Size = new System.Drawing.Size(33, 13);
            this.lbl_raca.TabIndex = 9;
            this.lbl_raca.Text = "Raça";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBox1.Location = new System.Drawing.Point(78, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(6, 121);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 7;
            this.lbl_sexo.Text = "Sexo";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(78, 89);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 20);
            this.txt_idade.TabIndex = 6;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(6, 89);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(34, 13);
            this.lbl_idade.TabIndex = 5;
            this.lbl_idade.Text = "Idade";
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(78, 51);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(100, 20);
            this.txt_sobrenome.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(78, 16);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(6, 54);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(61, 13);
            this.lbl_sobrenome.TabIndex = 2;
            this.lbl_sobrenome.Text = "Sobrenome";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 23);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(661, 494);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 0;
            this.btn_enviar.Text = "Cadastrar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "olavo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.tbc_personagem);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbc_personagem.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TabControl tbc_personagem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_cabelo;
        private System.Windows.Forms.TextBox txt_cabelo;
        private System.Windows.Forms.TextBox txt_olhos;
        private System.Windows.Forms.Label lbl_olhos;
        private System.Windows.Forms.ComboBox cmb_raca;
        private System.Windows.Forms.Label lbl_raca;
        private System.Windows.Forms.TextBox txt_altua;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox txt_historia;
        private System.Windows.Forms.Label lbl_historia;
        private System.Windows.Forms.Label label1;
    }
}

