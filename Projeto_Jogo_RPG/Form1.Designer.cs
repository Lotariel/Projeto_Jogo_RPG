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
            this.components = new System.ComponentModel.Container();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tbc_personagem = new System.Windows.Forms.TabControl();
            this.tabPersonagem = new System.Windows.Forms.TabPage();
            this.cmb_classe = new System.Windows.Forms.ComboBox();
            this.lbl_classe = new System.Windows.Forms.Label();
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
            this.tabItens = new System.Windows.Forms.TabPage();
            this.btn_CadastrarItens = new System.Windows.Forms.Button();
            this.txt_DescricaoItens = new System.Windows.Forms.TextBox();
            this.txt_PrecoItens = new System.Windows.Forms.TextBox();
            this.txt_NomeItens = new System.Windows.Forms.TextBox();
            this.lbl_DescricaoItens = new System.Windows.Forms.Label();
            this.lbl_PrecoItens = new System.Windows.Forms.Label();
            this.lbl_TipoItens = new System.Windows.Forms.Label();
            this.lbl_NomeItens = new System.Windows.Forms.Label();
            this.tabRaca = new System.Windows.Forms.TabPage();
            this.txt_descricaoraca = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_velraca = new System.Windows.Forms.TextBox();
            this.txt_focoraca = new System.Windows.Forms.TextBox();
            this.txt_auraraca = new System.Windows.Forms.TextBox();
            this.txt_magraca = new System.Windows.Forms.TextBox();
            this.txt_vitraca = new System.Windows.Forms.TextBox();
            this.txt_forcaraca = new System.Windows.Forms.TextBox();
            this.txt_nomeraca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClasse = new System.Windows.Forms.TabPage();
            this.btn_inserir_classe = new System.Windows.Forms.Button();
            this.txt_prec_classe = new System.Windows.Forms.TextBox();
            this.lbl_precisaoclasse = new System.Windows.Forms.Label();
            this.txt_descricao_classe = new System.Windows.Forms.TextBox();
            this.txt_velocidade_classe = new System.Windows.Forms.TextBox();
            this.txt_foco_classe = new System.Windows.Forms.TextBox();
            this.txt_aura_classe = new System.Windows.Forms.TextBox();
            this.txt_magia_classe = new System.Windows.Forms.TextBox();
            this.txt_vitalidade_classe = new System.Windows.Forms.TextBox();
            this.txt_for_classe = new System.Windows.Forms.TextBox();
            this.txt_nome_classe = new System.Windows.Forms.TextBox();
            this.lbl_velocidadeclasse = new System.Windows.Forms.Label();
            this.lbl_fococlasse = new System.Windows.Forms.Label();
            this.lbl_auraclasse = new System.Windows.Forms.Label();
            this.lbl_classemag = new System.Windows.Forms.Label();
            this.lbl_vitclasse = new System.Windows.Forms.Label();
            this.lbl_forcaclasse = new System.Windows.Forms.Label();
            this.lbl_descricaoclasse = new System.Windows.Forms.Label();
            this.lbl_nomeclasse = new System.Windows.Forms.Label();
            this.tabPericias = new System.Windows.Forms.TabPage();
            this.btnCadastrarPericia = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescPericia = new System.Windows.Forms.TextBox();
            this.txtNomePericia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.racasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Projeto_Jogo_RPG.DataSet1();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Projeto_Jogo_RPG.DataSet1TableAdapters.ClassesTableAdapter();
            this.racasTableAdapter = new Projeto_Jogo_RPG.DataSet1TableAdapters.RacasTableAdapter();
            this.racasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cb_TipoItens = new System.Windows.Forms.ComboBox();
            this.tabTipo = new System.Windows.Forms.TabPage();
            this.lbl_NomeTipo = new System.Windows.Forms.Label();
            this.txt_NomeTipo = new System.Windows.Forms.TextBox();
            this.btn_CadastrarTipo = new System.Windows.Forms.Button();
            this.tbc_personagem.SuspendLayout();
            this.tabPersonagem.SuspendLayout();
            this.tabItens.SuspendLayout();
            this.tabRaca.SuspendLayout();
            this.tabClasse.SuspendLayout();
            this.tabPericias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource1)).BeginInit();
            this.tabTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(483, 14);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(169, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "TELA DE CADASTRO";
            // 
            // tbc_personagem
            // 
            this.tbc_personagem.Controls.Add(this.tabPersonagem);
            this.tbc_personagem.Controls.Add(this.tabItens);
            this.tbc_personagem.Controls.Add(this.tabRaca);
            this.tbc_personagem.Controls.Add(this.tabClasse);
            this.tbc_personagem.Controls.Add(this.tabPericias);
            this.tbc_personagem.Controls.Add(this.tabTipo);
            this.tbc_personagem.Location = new System.Drawing.Point(18, 82);
            this.tbc_personagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbc_personagem.Name = "tbc_personagem";
            this.tbc_personagem.SelectedIndex = 0;
            this.tbc_personagem.ShowToolTips = true;
            this.tbc_personagem.Size = new System.Drawing.Size(1164, 922);
            this.tbc_personagem.TabIndex = 1;
            // 
            // tabPersonagem
            // 
            this.tabPersonagem.Controls.Add(this.cmb_classe);
            this.tabPersonagem.Controls.Add(this.lbl_classe);
            this.tabPersonagem.Controls.Add(this.txt_historia);
            this.tabPersonagem.Controls.Add(this.lbl_historia);
            this.tabPersonagem.Controls.Add(this.txt_altua);
            this.tabPersonagem.Controls.Add(this.lbl_altura);
            this.tabPersonagem.Controls.Add(this.lbl_peso);
            this.tabPersonagem.Controls.Add(this.txt_peso);
            this.tabPersonagem.Controls.Add(this.lbl_cabelo);
            this.tabPersonagem.Controls.Add(this.txt_cabelo);
            this.tabPersonagem.Controls.Add(this.txt_olhos);
            this.tabPersonagem.Controls.Add(this.lbl_olhos);
            this.tabPersonagem.Controls.Add(this.cmb_raca);
            this.tabPersonagem.Controls.Add(this.lbl_raca);
            this.tabPersonagem.Controls.Add(this.comboBox1);
            this.tabPersonagem.Controls.Add(this.lbl_sexo);
            this.tabPersonagem.Controls.Add(this.txt_idade);
            this.tabPersonagem.Controls.Add(this.lbl_idade);
            this.tabPersonagem.Controls.Add(this.txt_sobrenome);
            this.tabPersonagem.Controls.Add(this.txt_nome);
            this.tabPersonagem.Controls.Add(this.lbl_sobrenome);
            this.tabPersonagem.Controls.Add(this.lbl_nome);
            this.tabPersonagem.Controls.Add(this.btn_enviar);
            this.tabPersonagem.Location = new System.Drawing.Point(4, 29);
            this.tabPersonagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPersonagem.Name = "tabPersonagem";
            this.tabPersonagem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPersonagem.Size = new System.Drawing.Size(1156, 889);
            this.tabPersonagem.TabIndex = 0;
            this.tabPersonagem.Text = "Personagem";
            this.tabPersonagem.UseVisualStyleBackColor = true;
            // 
            // cmb_classe
            // 
            this.cmb_classe.FormattingEnabled = true;
            this.cmb_classe.Location = new System.Drawing.Point(117, 288);
            this.cmb_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_classe.Name = "cmb_classe";
            this.cmb_classe.Size = new System.Drawing.Size(148, 28);
            this.cmb_classe.TabIndex = 22;
            // 
            // lbl_classe
            // 
            this.lbl_classe.AutoSize = true;
            this.lbl_classe.Location = new System.Drawing.Point(9, 288);
            this.lbl_classe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_classe.Name = "lbl_classe";
            this.lbl_classe.Size = new System.Drawing.Size(57, 20);
            this.lbl_classe.TabIndex = 21;
            this.lbl_classe.Text = "Classe";
            // 
            // txt_historia
            // 
            this.txt_historia.Location = new System.Drawing.Point(15, 634);
            this.txt_historia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_historia.Multiline = true;
            this.txt_historia.Name = "txt_historia";
            this.txt_historia.Size = new System.Drawing.Size(478, 195);
            this.txt_historia.TabIndex = 20;
            // 
            // lbl_historia
            // 
            this.lbl_historia.AutoSize = true;
            this.lbl_historia.Location = new System.Drawing.Point(10, 594);
            this.lbl_historia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_historia.Name = "lbl_historia";
            this.lbl_historia.Size = new System.Drawing.Size(149, 20);
            this.lbl_historia.TabIndex = 19;
            this.lbl_historia.Text = "Resumo da Historia";
            // 
            // txt_altua
            // 
            this.txt_altua.Location = new System.Drawing.Point(117, 538);
            this.txt_altua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_altua.Name = "txt_altua";
            this.txt_altua.Size = new System.Drawing.Size(148, 26);
            this.txt_altua.TabIndex = 18;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(9, 538);
            this.lbl_altura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(51, 20);
            this.lbl_altura.TabIndex = 17;
            this.lbl_altura.Text = "Altura";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(9, 482);
            this.lbl_peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(45, 20);
            this.lbl_peso.TabIndex = 16;
            this.lbl_peso.Text = "Peso";
            this.lbl_peso.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(117, 471);
            this.txt_peso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(148, 26);
            this.txt_peso.TabIndex = 15;
            // 
            // lbl_cabelo
            // 
            this.lbl_cabelo.AutoSize = true;
            this.lbl_cabelo.Location = new System.Drawing.Point(9, 415);
            this.lbl_cabelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cabelo.Name = "lbl_cabelo";
            this.lbl_cabelo.Size = new System.Drawing.Size(59, 20);
            this.lbl_cabelo.TabIndex = 14;
            this.lbl_cabelo.Text = "Cabelo";
            // 
            // txt_cabelo
            // 
            this.txt_cabelo.Location = new System.Drawing.Point(117, 405);
            this.txt_cabelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cabelo.Name = "txt_cabelo";
            this.txt_cabelo.Size = new System.Drawing.Size(148, 26);
            this.txt_cabelo.TabIndex = 13;
            // 
            // txt_olhos
            // 
            this.txt_olhos.Location = new System.Drawing.Point(117, 340);
            this.txt_olhos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_olhos.Name = "txt_olhos";
            this.txt_olhos.Size = new System.Drawing.Size(148, 26);
            this.txt_olhos.TabIndex = 12;
            // 
            // lbl_olhos
            // 
            this.lbl_olhos.AutoSize = true;
            this.lbl_olhos.Location = new System.Drawing.Point(4, 340);
            this.lbl_olhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_olhos.Name = "lbl_olhos";
            this.lbl_olhos.Size = new System.Drawing.Size(54, 20);
            this.lbl_olhos.TabIndex = 11;
            this.lbl_olhos.Text = " Olhos";
            // 
            // cmb_raca
            // 
            this.cmb_raca.FormattingEnabled = true;
            this.cmb_raca.Location = new System.Drawing.Point(117, 246);
            this.cmb_raca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_raca.Name = "cmb_raca";
            this.cmb_raca.Size = new System.Drawing.Size(148, 28);
            this.cmb_raca.TabIndex = 10;
            // 
            // lbl_raca
            // 
            this.lbl_raca.AutoSize = true;
            this.lbl_raca.Location = new System.Drawing.Point(9, 246);
            this.lbl_raca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_raca.Name = "lbl_raca";
            this.lbl_raca.Size = new System.Drawing.Size(47, 20);
            this.lbl_raca.TabIndex = 9;
            this.lbl_raca.Text = "Raça";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBox1.Location = new System.Drawing.Point(117, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(9, 186);
            this.lbl_sexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(45, 20);
            this.lbl_sexo.TabIndex = 7;
            this.lbl_sexo.Text = "Sexo";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(117, 137);
            this.txt_idade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(148, 26);
            this.txt_idade.TabIndex = 6;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(9, 137);
            this.lbl_idade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(50, 20);
            this.lbl_idade.TabIndex = 5;
            this.lbl_idade.Text = "Idade";
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(117, 78);
            this.txt_sobrenome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(148, 26);
            this.txt_sobrenome.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(117, 25);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(148, 26);
            this.txt_nome.TabIndex = 3;
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(9, 83);
            this.lbl_sobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(92, 20);
            this.lbl_sobrenome.TabIndex = 2;
            this.lbl_sobrenome.Text = "Sobrenome";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(9, 35);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(992, 760);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(112, 35);
            this.btn_enviar.TabIndex = 0;
            this.btn_enviar.Text = "Cadastrar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // tabItens
            // 
            this.tabItens.Controls.Add(this.cb_TipoItens);
            this.tabItens.Controls.Add(this.btn_CadastrarItens);
            this.tabItens.Controls.Add(this.txt_DescricaoItens);
            this.tabItens.Controls.Add(this.txt_PrecoItens);
            this.tabItens.Controls.Add(this.txt_NomeItens);
            this.tabItens.Controls.Add(this.lbl_DescricaoItens);
            this.tabItens.Controls.Add(this.lbl_PrecoItens);
            this.tabItens.Controls.Add(this.lbl_TipoItens);
            this.tabItens.Controls.Add(this.lbl_NomeItens);
            this.tabItens.Location = new System.Drawing.Point(4, 29);
            this.tabItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabItens.Name = "tabItens";
            this.tabItens.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabItens.Size = new System.Drawing.Size(1156, 889);
            this.tabItens.TabIndex = 1;
            this.tabItens.Text = "Itens";
            this.tabItens.UseVisualStyleBackColor = true;
            // 
            // btn_CadastrarItens
            // 
            this.btn_CadastrarItens.Location = new System.Drawing.Point(985, 808);
            this.btn_CadastrarItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CadastrarItens.Name = "btn_CadastrarItens";
            this.btn_CadastrarItens.Size = new System.Drawing.Size(112, 35);
            this.btn_CadastrarItens.TabIndex = 19;
            this.btn_CadastrarItens.Text = "Cadastrar";
            this.btn_CadastrarItens.UseVisualStyleBackColor = true;
            this.btn_CadastrarItens.Click += new System.EventHandler(this.btn_CadastrarItens_Click);
            // 
            // txt_DescricaoItens
            // 
            this.txt_DescricaoItens.AcceptsTab = true;
            this.txt_DescricaoItens.Location = new System.Drawing.Point(128, 235);
            this.txt_DescricaoItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DescricaoItens.Multiline = true;
            this.txt_DescricaoItens.Name = "txt_DescricaoItens";
            this.txt_DescricaoItens.Size = new System.Drawing.Size(530, 246);
            this.txt_DescricaoItens.TabIndex = 18;
            // 
            // txt_PrecoItens
            // 
            this.txt_PrecoItens.AcceptsTab = true;
            this.txt_PrecoItens.Location = new System.Drawing.Point(128, 165);
            this.txt_PrecoItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PrecoItens.Name = "txt_PrecoItens";
            this.txt_PrecoItens.Size = new System.Drawing.Size(148, 26);
            this.txt_PrecoItens.TabIndex = 11;
            // 
            // txt_NomeItens
            // 
            this.txt_NomeItens.AcceptsTab = true;
            this.txt_NomeItens.Location = new System.Drawing.Point(128, 40);
            this.txt_NomeItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_NomeItens.Name = "txt_NomeItens";
            this.txt_NomeItens.Size = new System.Drawing.Size(148, 26);
            this.txt_NomeItens.TabIndex = 9;
            // 
            // lbl_DescricaoItens
            // 
            this.lbl_DescricaoItens.AutoSize = true;
            this.lbl_DescricaoItens.Location = new System.Drawing.Point(26, 238);
            this.lbl_DescricaoItens.Name = "lbl_DescricaoItens";
            this.lbl_DescricaoItens.Size = new System.Drawing.Size(80, 20);
            this.lbl_DescricaoItens.TabIndex = 3;
            this.lbl_DescricaoItens.Text = "Descrição";
            // 
            // lbl_PrecoItens
            // 
            this.lbl_PrecoItens.AutoSize = true;
            this.lbl_PrecoItens.Location = new System.Drawing.Point(26, 168);
            this.lbl_PrecoItens.Name = "lbl_PrecoItens";
            this.lbl_PrecoItens.Size = new System.Drawing.Size(50, 20);
            this.lbl_PrecoItens.TabIndex = 2;
            this.lbl_PrecoItens.Text = "Preço";
            // 
            // lbl_TipoItens
            // 
            this.lbl_TipoItens.AutoSize = true;
            this.lbl_TipoItens.Location = new System.Drawing.Point(26, 105);
            this.lbl_TipoItens.Name = "lbl_TipoItens";
            this.lbl_TipoItens.Size = new System.Drawing.Size(39, 20);
            this.lbl_TipoItens.TabIndex = 1;
            this.lbl_TipoItens.Text = "Tipo";
            // 
            // lbl_NomeItens
            // 
            this.lbl_NomeItens.AutoSize = true;
            this.lbl_NomeItens.Location = new System.Drawing.Point(26, 43);
            this.lbl_NomeItens.Name = "lbl_NomeItens";
            this.lbl_NomeItens.Size = new System.Drawing.Size(51, 20);
            this.lbl_NomeItens.TabIndex = 0;
            this.lbl_NomeItens.Text = "Nome";
            // 
            // tabRaca
            // 
            this.tabRaca.Controls.Add(this.txt_descricaoraca);
            this.tabRaca.Controls.Add(this.btn_cadastrar);
            this.tabRaca.Controls.Add(this.txt_velraca);
            this.tabRaca.Controls.Add(this.txt_focoraca);
            this.tabRaca.Controls.Add(this.txt_auraraca);
            this.tabRaca.Controls.Add(this.txt_magraca);
            this.tabRaca.Controls.Add(this.txt_vitraca);
            this.tabRaca.Controls.Add(this.txt_forcaraca);
            this.tabRaca.Controls.Add(this.txt_nomeraca);
            this.tabRaca.Controls.Add(this.label8);
            this.tabRaca.Controls.Add(this.label7);
            this.tabRaca.Controls.Add(this.label6);
            this.tabRaca.Controls.Add(this.label5);
            this.tabRaca.Controls.Add(this.label4);
            this.tabRaca.Controls.Add(this.label3);
            this.tabRaca.Controls.Add(this.label2);
            this.tabRaca.Controls.Add(this.label1);
            this.tabRaca.Location = new System.Drawing.Point(4, 29);
            this.tabRaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRaca.Name = "tabRaca";
            this.tabRaca.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRaca.Size = new System.Drawing.Size(1156, 889);
            this.tabRaca.TabIndex = 2;
            this.tabRaca.Text = "Raça";
            this.tabRaca.UseVisualStyleBackColor = true;
            // 
            // txt_descricaoraca
            // 
            this.txt_descricaoraca.AcceptsTab = true;
            this.txt_descricaoraca.Location = new System.Drawing.Point(135, 498);
            this.txt_descricaoraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descricaoraca.Multiline = true;
            this.txt_descricaoraca.Name = "txt_descricaoraca";
            this.txt_descricaoraca.Size = new System.Drawing.Size(530, 246);
            this.txt_descricaoraca.TabIndex = 17;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(964, 795);
            this.btn_cadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(112, 35);
            this.btn_cadastrar.TabIndex = 16;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_velraca
            // 
            this.txt_velraca.Location = new System.Drawing.Point(135, 386);
            this.txt_velraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_velraca.Name = "txt_velraca";
            this.txt_velraca.Size = new System.Drawing.Size(148, 26);
            this.txt_velraca.TabIndex = 14;
            // 
            // txt_focoraca
            // 
            this.txt_focoraca.Location = new System.Drawing.Point(135, 323);
            this.txt_focoraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_focoraca.Name = "txt_focoraca";
            this.txt_focoraca.Size = new System.Drawing.Size(148, 26);
            this.txt_focoraca.TabIndex = 13;
            // 
            // txt_auraraca
            // 
            this.txt_auraraca.Location = new System.Drawing.Point(135, 278);
            this.txt_auraraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_auraraca.Name = "txt_auraraca";
            this.txt_auraraca.Size = new System.Drawing.Size(148, 26);
            this.txt_auraraca.TabIndex = 12;
            // 
            // txt_magraca
            // 
            this.txt_magraca.Location = new System.Drawing.Point(135, 223);
            this.txt_magraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_magraca.Name = "txt_magraca";
            this.txt_magraca.Size = new System.Drawing.Size(148, 26);
            this.txt_magraca.TabIndex = 11;
            // 
            // txt_vitraca
            // 
            this.txt_vitraca.Location = new System.Drawing.Point(135, 169);
            this.txt_vitraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_vitraca.Name = "txt_vitraca";
            this.txt_vitraca.Size = new System.Drawing.Size(148, 26);
            this.txt_vitraca.TabIndex = 10;
            // 
            // txt_forcaraca
            // 
            this.txt_forcaraca.Location = new System.Drawing.Point(135, 117);
            this.txt_forcaraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_forcaraca.Name = "txt_forcaraca";
            this.txt_forcaraca.Size = new System.Drawing.Size(148, 26);
            this.txt_forcaraca.TabIndex = 9;
            // 
            // txt_nomeraca
            // 
            this.txt_nomeraca.AcceptsTab = true;
            this.txt_nomeraca.Location = new System.Drawing.Point(135, 42);
            this.txt_nomeraca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nomeraca.Name = "txt_nomeraca";
            this.txt_nomeraca.Size = new System.Drawing.Size(148, 26);
            this.txt_nomeraca.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 386);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Velocidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Aura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Foco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Magia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vitalidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Força";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 503);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabClasse
            // 
            this.tabClasse.Controls.Add(this.btn_inserir_classe);
            this.tabClasse.Controls.Add(this.txt_prec_classe);
            this.tabClasse.Controls.Add(this.lbl_precisaoclasse);
            this.tabClasse.Controls.Add(this.txt_descricao_classe);
            this.tabClasse.Controls.Add(this.txt_velocidade_classe);
            this.tabClasse.Controls.Add(this.txt_foco_classe);
            this.tabClasse.Controls.Add(this.txt_aura_classe);
            this.tabClasse.Controls.Add(this.txt_magia_classe);
            this.tabClasse.Controls.Add(this.txt_vitalidade_classe);
            this.tabClasse.Controls.Add(this.txt_for_classe);
            this.tabClasse.Controls.Add(this.txt_nome_classe);
            this.tabClasse.Controls.Add(this.lbl_velocidadeclasse);
            this.tabClasse.Controls.Add(this.lbl_fococlasse);
            this.tabClasse.Controls.Add(this.lbl_auraclasse);
            this.tabClasse.Controls.Add(this.lbl_classemag);
            this.tabClasse.Controls.Add(this.lbl_vitclasse);
            this.tabClasse.Controls.Add(this.lbl_forcaclasse);
            this.tabClasse.Controls.Add(this.lbl_descricaoclasse);
            this.tabClasse.Controls.Add(this.lbl_nomeclasse);
            this.tabClasse.Location = new System.Drawing.Point(4, 29);
            this.tabClasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabClasse.Name = "tabClasse";
            this.tabClasse.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabClasse.Size = new System.Drawing.Size(1156, 889);
            this.tabClasse.TabIndex = 3;
            this.tabClasse.Text = "Classe";
            this.tabClasse.UseVisualStyleBackColor = true;
            // 
            // btn_inserir_classe
            // 
            this.btn_inserir_classe.Location = new System.Drawing.Point(960, 769);
            this.btn_inserir_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_inserir_classe.Name = "btn_inserir_classe";
            this.btn_inserir_classe.Size = new System.Drawing.Size(112, 35);
            this.btn_inserir_classe.TabIndex = 18;
            this.btn_inserir_classe.Text = "Cadastrar";
            this.btn_inserir_classe.UseVisualStyleBackColor = true;
            this.btn_inserir_classe.Click += new System.EventHandler(this.btn_inserir_classe_Click);
            // 
            // txt_prec_classe
            // 
            this.txt_prec_classe.Location = new System.Drawing.Point(122, 397);
            this.txt_prec_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_prec_classe.Name = "txt_prec_classe";
            this.txt_prec_classe.Size = new System.Drawing.Size(148, 26);
            this.txt_prec_classe.TabIndex = 17;
            // 
            // lbl_precisaoclasse
            // 
            this.lbl_precisaoclasse.AutoSize = true;
            this.lbl_precisaoclasse.Location = new System.Drawing.Point(30, 402);
            this.lbl_precisaoclasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precisaoclasse.Name = "lbl_precisaoclasse";
            this.lbl_precisaoclasse.Size = new System.Drawing.Size(70, 20);
            this.lbl_precisaoclasse.TabIndex = 16;
            this.lbl_precisaoclasse.Text = "Precisão";
            // 
            // txt_descricao_classe
            // 
            this.txt_descricao_classe.Location = new System.Drawing.Point(34, 480);
            this.txt_descricao_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descricao_classe.Multiline = true;
            this.txt_descricao_classe.Name = "txt_descricao_classe";
            this.txt_descricao_classe.Size = new System.Drawing.Size(606, 267);
            this.txt_descricao_classe.TabIndex = 15;
            // 
            // txt_velocidade_classe
            // 
            this.txt_velocidade_classe.Location = new System.Drawing.Point(116, 332);
            this.txt_velocidade_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_velocidade_classe.Name = "txt_velocidade_classe";
            this.txt_velocidade_classe.Size = new System.Drawing.Size(148, 26);
            this.txt_velocidade_classe.TabIndex = 14;
            // 
            // txt_foco_classe
            // 
            this.txt_foco_classe.Location = new System.Drawing.Point(116, 283);
            this.txt_foco_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_foco_classe.Name = "txt_foco_classe";
            this.txt_foco_classe.Size = new System.Drawing.Size(148, 26);
            this.txt_foco_classe.TabIndex = 13;
            // 
            // txt_aura_classe
            // 
            this.txt_aura_classe.Location = new System.Drawing.Point(116, 237);
            this.txt_aura_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_aura_classe.Name = "txt_aura_classe";
            this.txt_aura_classe.Size = new System.Drawing.Size(148, 26);
            this.txt_aura_classe.TabIndex = 12;
            // 
            // txt_magia_classe
            // 
            this.txt_magia_classe.Location = new System.Drawing.Point(116, 192);
            this.txt_magia_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_magia_classe.Name = "txt_magia_classe";
            this.txt_magia_classe.Size = new System.Drawing.Size(148, 26);
            this.txt_magia_classe.TabIndex = 11;
            // 
            // txt_vitalidade_classe
            // 
            this.txt_vitalidade_classe.Location = new System.Drawing.Point(116, 138);
            this.txt_vitalidade_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_vitalidade_classe.Name = "txt_vitalidade_classe";
            this.txt_vitalidade_classe.Size = new System.Drawing.Size(148, 26);
            this.txt_vitalidade_classe.TabIndex = 10;
            // 
            // txt_for_classe
            // 
            this.txt_for_classe.Location = new System.Drawing.Point(116, 88);
            this.txt_for_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_for_classe.Name = "txt_for_classe";
            this.txt_for_classe.Size = new System.Drawing.Size(148, 26);
            this.txt_for_classe.TabIndex = 9;
            // 
            // txt_nome_classe
            // 
            this.txt_nome_classe.Location = new System.Drawing.Point(116, 35);
            this.txt_nome_classe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nome_classe.Name = "txt_nome_classe";
            this.txt_nome_classe.Size = new System.Drawing.Size(148, 26);
            this.txt_nome_classe.TabIndex = 8;
            // 
            // lbl_velocidadeclasse
            // 
            this.lbl_velocidadeclasse.AutoSize = true;
            this.lbl_velocidadeclasse.Location = new System.Drawing.Point(30, 343);
            this.lbl_velocidadeclasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_velocidadeclasse.Name = "lbl_velocidadeclasse";
            this.lbl_velocidadeclasse.Size = new System.Drawing.Size(88, 20);
            this.lbl_velocidadeclasse.TabIndex = 7;
            this.lbl_velocidadeclasse.Text = "Velocidade";
            // 
            // lbl_fococlasse
            // 
            this.lbl_fococlasse.AutoSize = true;
            this.lbl_fococlasse.Location = new System.Drawing.Point(30, 294);
            this.lbl_fococlasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fococlasse.Name = "lbl_fococlasse";
            this.lbl_fococlasse.Size = new System.Drawing.Size(45, 20);
            this.lbl_fococlasse.TabIndex = 6;
            this.lbl_fococlasse.Text = "Foco";
            // 
            // lbl_auraclasse
            // 
            this.lbl_auraclasse.AutoSize = true;
            this.lbl_auraclasse.Location = new System.Drawing.Point(30, 248);
            this.lbl_auraclasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_auraclasse.Name = "lbl_auraclasse";
            this.lbl_auraclasse.Size = new System.Drawing.Size(43, 20);
            this.lbl_auraclasse.TabIndex = 5;
            this.lbl_auraclasse.Text = "Aura";
            // 
            // lbl_classemag
            // 
            this.lbl_classemag.AutoSize = true;
            this.lbl_classemag.Location = new System.Drawing.Point(30, 197);
            this.lbl_classemag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_classemag.Name = "lbl_classemag";
            this.lbl_classemag.Size = new System.Drawing.Size(52, 20);
            this.lbl_classemag.TabIndex = 4;
            this.lbl_classemag.Text = "Magia";
            // 
            // lbl_vitclasse
            // 
            this.lbl_vitclasse.AutoSize = true;
            this.lbl_vitclasse.Location = new System.Drawing.Point(30, 149);
            this.lbl_vitclasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vitclasse.Name = "lbl_vitclasse";
            this.lbl_vitclasse.Size = new System.Drawing.Size(79, 20);
            this.lbl_vitclasse.TabIndex = 3;
            this.lbl_vitclasse.Text = "Vitalidade";
            // 
            // lbl_forcaclasse
            // 
            this.lbl_forcaclasse.AutoSize = true;
            this.lbl_forcaclasse.Location = new System.Drawing.Point(30, 98);
            this.lbl_forcaclasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_forcaclasse.Name = "lbl_forcaclasse";
            this.lbl_forcaclasse.Size = new System.Drawing.Size(50, 20);
            this.lbl_forcaclasse.TabIndex = 2;
            this.lbl_forcaclasse.Text = "Força";
            // 
            // lbl_descricaoclasse
            // 
            this.lbl_descricaoclasse.AutoSize = true;
            this.lbl_descricaoclasse.Location = new System.Drawing.Point(30, 455);
            this.lbl_descricaoclasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descricaoclasse.Name = "lbl_descricaoclasse";
            this.lbl_descricaoclasse.Size = new System.Drawing.Size(80, 20);
            this.lbl_descricaoclasse.TabIndex = 1;
            this.lbl_descricaoclasse.Text = "Descrição";
            // 
            // lbl_nomeclasse
            // 
            this.lbl_nomeclasse.AutoSize = true;
            this.lbl_nomeclasse.Location = new System.Drawing.Point(30, 40);
            this.lbl_nomeclasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomeclasse.Name = "lbl_nomeclasse";
            this.lbl_nomeclasse.Size = new System.Drawing.Size(51, 20);
            this.lbl_nomeclasse.TabIndex = 0;
            this.lbl_nomeclasse.Text = "Nome";
            // 
            // tabPericias
            // 
            this.tabPericias.Controls.Add(this.btnCadastrarPericia);
            this.tabPericias.Controls.Add(this.label10);
            this.tabPericias.Controls.Add(this.txtDescPericia);
            this.tabPericias.Controls.Add(this.txtNomePericia);
            this.tabPericias.Controls.Add(this.label9);
            this.tabPericias.Location = new System.Drawing.Point(4, 29);
            this.tabPericias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPericias.Name = "tabPericias";
            this.tabPericias.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPericias.Size = new System.Drawing.Size(1156, 889);
            this.tabPericias.TabIndex = 4;
            this.tabPericias.Text = "Pericias";
            this.tabPericias.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPericia
            // 
            this.btnCadastrarPericia.Location = new System.Drawing.Point(984, 778);
            this.btnCadastrarPericia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrarPericia.Name = "btnCadastrarPericia";
            this.btnCadastrarPericia.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrarPericia.TabIndex = 4;
            this.btnCadastrarPericia.Text = "Cadastrar";
            this.btnCadastrarPericia.UseVisualStyleBackColor = true;
            this.btnCadastrarPericia.Click += new System.EventHandler(this.btnCadastrarPericia_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Descricao";
            // 
            // txtDescPericia
            // 
            this.txtDescPericia.Location = new System.Drawing.Point(129, 120);
            this.txtDescPericia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescPericia.Multiline = true;
            this.txtDescPericia.Name = "txtDescPericia";
            this.txtDescPericia.Size = new System.Drawing.Size(498, 175);
            this.txtDescPericia.TabIndex = 2;
            // 
            // txtNomePericia
            // 
            this.txtNomePericia.Location = new System.Drawing.Point(129, 37);
            this.txtNomePericia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomePericia.Name = "txtNomePericia";
            this.txtNomePericia.Size = new System.Drawing.Size(148, 26);
            this.txtNomePericia.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nome";
            // 
            // racasBindingSource
            // 
            this.racasBindingSource.DataMember = "Racas";
            this.racasBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // racasTableAdapter
            // 
            this.racasTableAdapter.ClearBeforeFill = true;
            // 
            // racasBindingSource1
            // 
            this.racasBindingSource1.DataMember = "Racas";
            this.racasBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // cb_TipoItens
            // 
            this.cb_TipoItens.FormattingEnabled = true;
            this.cb_TipoItens.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_TipoItens.Location = new System.Drawing.Point(128, 102);
            this.cb_TipoItens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_TipoItens.Name = "cb_TipoItens";
            this.cb_TipoItens.Size = new System.Drawing.Size(148, 28);
            this.cb_TipoItens.TabIndex = 20;
            // 
            // tabTipo
            // 
            this.tabTipo.Controls.Add(this.btn_CadastrarTipo);
            this.tabTipo.Controls.Add(this.txt_NomeTipo);
            this.tabTipo.Controls.Add(this.lbl_NomeTipo);
            this.tabTipo.Location = new System.Drawing.Point(4, 29);
            this.tabTipo.Name = "tabTipo";
            this.tabTipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTipo.Size = new System.Drawing.Size(1156, 889);
            this.tabTipo.TabIndex = 5;
            this.tabTipo.Text = "Tipo";
            this.tabTipo.UseVisualStyleBackColor = true;
            // 
            // lbl_NomeTipo
            // 
            this.lbl_NomeTipo.AutoSize = true;
            this.lbl_NomeTipo.Location = new System.Drawing.Point(69, 48);
            this.lbl_NomeTipo.Name = "lbl_NomeTipo";
            this.lbl_NomeTipo.Size = new System.Drawing.Size(51, 20);
            this.lbl_NomeTipo.TabIndex = 0;
            this.lbl_NomeTipo.Text = "Nome";
            // 
            // txt_NomeTipo
            // 
            this.txt_NomeTipo.Location = new System.Drawing.Point(153, 45);
            this.txt_NomeTipo.Name = "txt_NomeTipo";
            this.txt_NomeTipo.Size = new System.Drawing.Size(100, 26);
            this.txt_NomeTipo.TabIndex = 1;
            // 
            // btn_CadastrarTipo
            // 
            this.btn_CadastrarTipo.Location = new System.Drawing.Point(830, 436);
            this.btn_CadastrarTipo.Name = "btn_CadastrarTipo";
            this.btn_CadastrarTipo.Size = new System.Drawing.Size(102, 34);
            this.btn_CadastrarTipo.TabIndex = 2;
            this.btn_CadastrarTipo.Text = "Cadastrar";
            this.btn_CadastrarTipo.UseVisualStyleBackColor = true;
            this.btn_CadastrarTipo.Click += new System.EventHandler(this.btn_CadastrarTipo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1003);
            this.Controls.Add(this.tbc_personagem);
            this.Controls.Add(this.lbltitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbc_personagem.ResumeLayout(false);
            this.tabPersonagem.ResumeLayout(false);
            this.tabPersonagem.PerformLayout();
            this.tabItens.ResumeLayout(false);
            this.tabItens.PerformLayout();
            this.tabRaca.ResumeLayout(false);
            this.tabRaca.PerformLayout();
            this.tabClasse.ResumeLayout(false);
            this.tabClasse.PerformLayout();
            this.tabPericias.ResumeLayout(false);
            this.tabPericias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource1)).EndInit();
            this.tabTipo.ResumeLayout(false);
            this.tabTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TabControl tbc_personagem;
        private System.Windows.Forms.TabPage tabPersonagem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_enviar;

        private System.Windows.Forms.TabPage tabItens;
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
        private System.Windows.Forms.ComboBox cmb_classe;
        private System.Windows.Forms.Label lbl_classe;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private DataSet1TableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource racasBindingSource;
        private DataSet1TableAdapters.RacasTableAdapter racasTableAdapter;
        private System.Windows.Forms.BindingSource racasBindingSource1;

        private System.Windows.Forms.TabPage tabRaca;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txt_velraca;
        private System.Windows.Forms.TextBox txt_focoraca;
        private System.Windows.Forms.TextBox txt_auraraca;
        private System.Windows.Forms.TextBox txt_magraca;
        private System.Windows.Forms.TextBox txt_vitraca;
        private System.Windows.Forms.TextBox txt_forcaraca;
        private System.Windows.Forms.TextBox txt_nomeraca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricaoraca;

        private System.Windows.Forms.TabPage tabClasse;
        private System.Windows.Forms.Button btn_inserir_classe;
        private System.Windows.Forms.TextBox txt_prec_classe;
        private System.Windows.Forms.Label lbl_precisaoclasse;
        private System.Windows.Forms.TextBox txt_descricao_classe;
        private System.Windows.Forms.TextBox txt_velocidade_classe;
        private System.Windows.Forms.TextBox txt_foco_classe;
        private System.Windows.Forms.TextBox txt_aura_classe;
        private System.Windows.Forms.TextBox txt_magia_classe;
        private System.Windows.Forms.TextBox txt_vitalidade_classe;
        private System.Windows.Forms.TextBox txt_for_classe;
        private System.Windows.Forms.TextBox txt_nome_classe;
        private System.Windows.Forms.Label lbl_velocidadeclasse;
        private System.Windows.Forms.Label lbl_fococlasse;
        private System.Windows.Forms.Label lbl_auraclasse;
        private System.Windows.Forms.Label lbl_classemag;
        private System.Windows.Forms.Label lbl_vitclasse;
        private System.Windows.Forms.Label lbl_forcaclasse;
        private System.Windows.Forms.Label lbl_descricaoclasse;
        private System.Windows.Forms.Label lbl_nomeclasse;

        private System.Windows.Forms.TabPage tabPericias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescPericia;
        private System.Windows.Forms.TextBox txtNomePericia;
        private System.Windows.Forms.Button btnCadastrarPericia;
        private System.Windows.Forms.TextBox txt_DescricaoItens;
        private System.Windows.Forms.TextBox txt_PrecoItens;
        private System.Windows.Forms.TextBox txt_NomeItens;
        private System.Windows.Forms.Label lbl_DescricaoItens;
        private System.Windows.Forms.Label lbl_PrecoItens;
        private System.Windows.Forms.Label lbl_TipoItens;
        private System.Windows.Forms.Label lbl_NomeItens;
        private System.Windows.Forms.Button btn_CadastrarItens;
        private System.Windows.Forms.ComboBox cb_TipoItens;
        private System.Windows.Forms.TabPage tabTipo;
        private System.Windows.Forms.Button btn_CadastrarTipo;
        private System.Windows.Forms.TextBox txt_NomeTipo;
        private System.Windows.Forms.Label lbl_NomeTipo;
    }
}

