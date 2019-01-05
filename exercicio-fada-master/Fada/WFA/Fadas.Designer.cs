namespace WFA
{
    partial class Fadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fadas));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFadas = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbcFada = new System.Windows.Forms.TabControl();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.lblQuantidadeFadas = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCadastroRapido = new System.Windows.Forms.Button();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.chkMulher = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTamanhoAsa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbElemento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkFazBarulho = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAsaQuebrada = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCorAsa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabPageCadastroRapido = new System.Windows.Forms.TabPage();
            this.rbCadastroRapido2 = new System.Windows.Forms.RadioButton();
            this.rbCadastroRapido1 = new System.Windows.Forms.RadioButton();
            this.gbCadastroRapido2 = new System.Windows.Forms.GroupBox();
            this.chkMulherRapido2 = new System.Windows.Forms.CheckBox();
            this.btnSalvarCadastroRapido2 = new System.Windows.Forms.Button();
            this.btnCancelarCadastroRapido2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNomeRapido2 = new System.Windows.Forms.TextBox();
            this.cbCorRapido2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbCadastroRapido1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCadastroRapido1 = new System.Windows.Forms.Button();
            this.btnSalvarCadastroRapido1 = new System.Windows.Forms.Button();
            this.txtFamiliaRapido1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeRapido1 = new System.Windows.Forms.TextBox();
            this.cbCorRapido1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFadas)).BeginInit();
            this.tbcFada.SuspendLayout();
            this.tabPageLista.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.tabPageCadastroRapido.SuspendLayout();
            this.gbCadastroRapido2.SuspendLayout();
            this.gbCadastroRapido1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // dgvFadas
            // 
            this.dgvFadas.AllowUserToAddRows = false;
            this.dgvFadas.AllowUserToDeleteRows = false;
            this.dgvFadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNome,
            this.ColumnCor});
            this.dgvFadas.Location = new System.Drawing.Point(7, 108);
            this.dgvFadas.Name = "dgvFadas";
            this.dgvFadas.ReadOnly = true;
            this.dgvFadas.Size = new System.Drawing.Size(740, 223);
            this.dgvFadas.TabIndex = 1;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnCor
            // 
            this.ColumnCor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCor.HeaderText = "Cor";
            this.ColumnCor.Name = "ColumnCor";
            this.ColumnCor.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(75, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(261, 26);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(409, 6);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 45);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Cadastro";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Image = ((System.Drawing.Image)(resources.GetObject("btnApagar.Image")));
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(640, 6);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(107, 45);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(535, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 45);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbcFada
            // 
            this.tbcFada.Controls.Add(this.tabPageLista);
            this.tbcFada.Controls.Add(this.tabPageCadastro);
            this.tbcFada.Controls.Add(this.tabPageCadastroRapido);
            this.tbcFada.Location = new System.Drawing.Point(12, 12);
            this.tbcFada.Name = "tbcFada";
            this.tbcFada.SelectedIndex = 0;
            this.tbcFada.Size = new System.Drawing.Size(761, 391);
            this.tbcFada.TabIndex = 6;
            this.tbcFada.Click += new System.EventHandler(this.tbcFada_Click);
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.lblQuantidadeFadas);
            this.tabPageLista.Controls.Add(this.label17);
            this.tabPageLista.Controls.Add(this.btnCadastroRapido);
            this.tabPageLista.Controls.Add(this.label1);
            this.tabPageLista.Controls.Add(this.btnEditar);
            this.tabPageLista.Controls.Add(this.dgvFadas);
            this.tabPageLista.Controls.Add(this.btnApagar);
            this.tabPageLista.Controls.Add(this.txtBuscar);
            this.tabPageLista.Controls.Add(this.btnNovo);
            this.tabPageLista.Location = new System.Drawing.Point(4, 27);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(753, 360);
            this.tabPageLista.TabIndex = 0;
            this.tabPageLista.Text = "Lista";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // lblQuantidadeFadas
            // 
            this.lblQuantidadeFadas.AutoSize = true;
            this.lblQuantidadeFadas.Location = new System.Drawing.Point(674, 334);
            this.lblQuantidadeFadas.Name = "lblQuantidadeFadas";
            this.lblQuantidadeFadas.Size = new System.Drawing.Size(17, 18);
            this.lblQuantidadeFadas.TabIndex = 8;
            this.lblQuantidadeFadas.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(505, 334);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 18);
            this.label17.TabIndex = 7;
            this.label17.Text = "Quantidade de fadas:";
            // 
            // btnCadastroRapido
            // 
            this.btnCadastroRapido.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroRapido.Image")));
            this.btnCadastroRapido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroRapido.Location = new System.Drawing.Point(489, 57);
            this.btnCadastroRapido.Name = "btnCadastroRapido";
            this.btnCadastroRapido.Size = new System.Drawing.Size(174, 45);
            this.btnCadastroRapido.TabIndex = 6;
            this.btnCadastroRapido.Text = "Cadastro Rápido";
            this.btnCadastroRapido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroRapido.UseVisualStyleBackColor = true;
            this.btnCadastroRapido.Click += new System.EventHandler(this.btnCadastroRapido_Click);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.chkMulher);
            this.tabPageCadastro.Controls.Add(this.btnSalvar);
            this.tabPageCadastro.Controls.Add(this.txtTamanhoAsa);
            this.tabPageCadastro.Controls.Add(this.label9);
            this.tabPageCadastro.Controls.Add(this.cbElemento);
            this.tabPageCadastro.Controls.Add(this.label8);
            this.tabPageCadastro.Controls.Add(this.chkFazBarulho);
            this.tabPageCadastro.Controls.Add(this.label7);
            this.tabPageCadastro.Controls.Add(this.label6);
            this.tabPageCadastro.Controls.Add(this.chkAsaQuebrada);
            this.tabPageCadastro.Controls.Add(this.label5);
            this.tabPageCadastro.Controls.Add(this.label4);
            this.tabPageCadastro.Controls.Add(this.cbCorAsa);
            this.tabPageCadastro.Controls.Add(this.label3);
            this.tabPageCadastro.Controls.Add(this.cbCor);
            this.tabPageCadastro.Controls.Add(this.txtFamilia);
            this.tabPageCadastro.Controls.Add(this.label2);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Controls.Add(this.label10);
            this.tabPageCadastro.Controls.Add(this.btnCancelar);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 27);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(753, 360);
            this.tabPageCadastro.TabIndex = 1;
            this.tabPageCadastro.Text = "Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // chkMulher
            // 
            this.chkMulher.AutoSize = true;
            this.chkMulher.Location = new System.Drawing.Point(501, 72);
            this.chkMulher.Name = "chkMulher";
            this.chkMulher.Size = new System.Drawing.Size(73, 22);
            this.chkMulher.TabIndex = 7;
            this.chkMulher.Text = "Mulher";
            this.chkMulher.UseVisualStyleBackColor = true;
            this.chkMulher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkMulher_KeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(590, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 45);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtTamanhoAsa
            // 
            this.txtTamanhoAsa.Location = new System.Drawing.Point(147, 217);
            this.txtTamanhoAsa.Name = "txtTamanhoAsa";
            this.txtTamanhoAsa.Size = new System.Drawing.Size(212, 26);
            this.txtTamanhoAsa.TabIndex = 5;
            this.txtTamanhoAsa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTamanhoAsa_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "Elemento:";
            // 
            // cbElemento
            // 
            this.cbElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbElemento.FormattingEnabled = true;
            this.cbElemento.Items.AddRange(new object[] {
            "Fogo",
            "Terra",
            "Ar",
            "Água",
            "Madeira"});
            this.cbElemento.Location = new System.Drawing.Point(501, 168);
            this.cbElemento.Name = "cbElemento";
            this.cbElemento.Size = new System.Drawing.Size(212, 26);
            this.cbElemento.TabIndex = 9;
            this.cbElemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbElemento_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Faz Barulho:";
            // 
            // chkFazBarulho
            // 
            this.chkFazBarulho.AutoSize = true;
            this.chkFazBarulho.Location = new System.Drawing.Point(501, 125);
            this.chkFazBarulho.Name = "chkFazBarulho";
            this.chkFazBarulho.Size = new System.Drawing.Size(15, 14);
            this.chkFazBarulho.TabIndex = 8;
            this.chkFazBarulho.UseVisualStyleBackColor = true;
            this.chkFazBarulho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkFazBarulho_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Asa Quebrada:";
            // 
            // chkAsaQuebrada
            // 
            this.chkAsaQuebrada.AutoSize = true;
            this.chkAsaQuebrada.Location = new System.Drawing.Point(501, 27);
            this.chkAsaQuebrada.Name = "chkAsaQuebrada";
            this.chkAsaQuebrada.Size = new System.Drawing.Size(15, 14);
            this.chkAsaQuebrada.TabIndex = 6;
            this.chkAsaQuebrada.UseVisualStyleBackColor = true;
            this.chkAsaQuebrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkAsaQuebrada_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tamanho da Asa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cor da Asa:";
            // 
            // cbCorAsa
            // 
            this.cbCorAsa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorAsa.FormattingEnabled = true;
            this.cbCorAsa.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta"});
            this.cbCorAsa.Location = new System.Drawing.Point(147, 168);
            this.cbCorAsa.Name = "cbCorAsa";
            this.cbCorAsa.Size = new System.Drawing.Size(212, 26);
            this.cbCorAsa.TabIndex = 4;
            this.cbCorAsa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCorAsa_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cor:";
            // 
            // cbCor
            // 
            this.cbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta"});
            this.cbCor.Location = new System.Drawing.Point(147, 119);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(212, 26);
            this.cbCor.TabIndex = 3;
            this.cbCor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCor_KeyDown);
            // 
            // txtFamilia
            // 
            this.txtFamilia.Location = new System.Drawing.Point(147, 70);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(212, 26);
            this.txtFamilia.TabIndex = 2;
            this.txtFamilia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFamilia_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Família:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(147, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Nome:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(464, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 45);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabPageCadastroRapido
            // 
            this.tabPageCadastroRapido.Controls.Add(this.rbCadastroRapido2);
            this.tabPageCadastroRapido.Controls.Add(this.rbCadastroRapido1);
            this.tabPageCadastroRapido.Controls.Add(this.gbCadastroRapido2);
            this.tabPageCadastroRapido.Controls.Add(this.gbCadastroRapido1);
            this.tabPageCadastroRapido.Location = new System.Drawing.Point(4, 27);
            this.tabPageCadastroRapido.Name = "tabPageCadastroRapido";
            this.tabPageCadastroRapido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastroRapido.Size = new System.Drawing.Size(753, 360);
            this.tabPageCadastroRapido.TabIndex = 2;
            this.tabPageCadastroRapido.Text = "Cadastro Rápido";
            this.tabPageCadastroRapido.UseVisualStyleBackColor = true;
            // 
            // rbCadastroRapido2
            // 
            this.rbCadastroRapido2.AutoSize = true;
            this.rbCadastroRapido2.Location = new System.Drawing.Point(550, 267);
            this.rbCadastroRapido2.Name = "rbCadastroRapido2";
            this.rbCadastroRapido2.Size = new System.Drawing.Size(174, 22);
            this.rbCadastroRapido2.TabIndex = 53;
            this.rbCadastroRapido2.Text = "Realizar Cadastro 02";
            this.rbCadastroRapido2.UseVisualStyleBackColor = true;
            this.rbCadastroRapido2.CheckedChanged += new System.EventHandler(this.rbCadastroRapido2_CheckedChanged);
            // 
            // rbCadastroRapido1
            // 
            this.rbCadastroRapido1.AutoSize = true;
            this.rbCadastroRapido1.Location = new System.Drawing.Point(550, 89);
            this.rbCadastroRapido1.Name = "rbCadastroRapido1";
            this.rbCadastroRapido1.Size = new System.Drawing.Size(174, 22);
            this.rbCadastroRapido1.TabIndex = 52;
            this.rbCadastroRapido1.Text = "Realizar Cadastro 01";
            this.rbCadastroRapido1.UseVisualStyleBackColor = true;
            this.rbCadastroRapido1.CheckedChanged += new System.EventHandler(this.rbCadastroRapido1_CheckedChanged);
            // 
            // gbCadastroRapido2
            // 
            this.gbCadastroRapido2.Controls.Add(this.chkMulherRapido2);
            this.gbCadastroRapido2.Controls.Add(this.btnSalvarCadastroRapido2);
            this.gbCadastroRapido2.Controls.Add(this.btnCancelarCadastroRapido2);
            this.gbCadastroRapido2.Controls.Add(this.label15);
            this.gbCadastroRapido2.Controls.Add(this.label16);
            this.gbCadastroRapido2.Controls.Add(this.txtNomeRapido2);
            this.gbCadastroRapido2.Controls.Add(this.cbCorRapido2);
            this.gbCadastroRapido2.Controls.Add(this.label11);
            this.gbCadastroRapido2.Location = new System.Drawing.Point(15, 201);
            this.gbCadastroRapido2.Name = "gbCadastroRapido2";
            this.gbCadastroRapido2.Size = new System.Drawing.Size(495, 150);
            this.gbCadastroRapido2.TabIndex = 51;
            this.gbCadastroRapido2.TabStop = false;
            this.gbCadastroRapido2.Text = "Cadastro Rápido 2";
            // 
            // chkMulherRapido2
            // 
            this.chkMulherRapido2.AutoSize = true;
            this.chkMulherRapido2.Location = new System.Drawing.Point(79, 112);
            this.chkMulherRapido2.Name = "chkMulherRapido2";
            this.chkMulherRapido2.Size = new System.Drawing.Size(73, 22);
            this.chkMulherRapido2.TabIndex = 3;
            this.chkMulherRapido2.Text = "Mulher";
            this.chkMulherRapido2.UseVisualStyleBackColor = true;
            this.chkMulherRapido2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkMulherRapido2_KeyDown);
            // 
            // btnSalvarCadastroRapido2
            // 
            this.btnSalvarCadastroRapido2.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCadastroRapido2.Image")));
            this.btnSalvarCadastroRapido2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCadastroRapido2.Location = new System.Drawing.Point(356, 25);
            this.btnSalvarCadastroRapido2.Name = "btnSalvarCadastroRapido2";
            this.btnSalvarCadastroRapido2.Size = new System.Drawing.Size(120, 45);
            this.btnSalvarCadastroRapido2.TabIndex = 4;
            this.btnSalvarCadastroRapido2.Text = "Salvar";
            this.btnSalvarCadastroRapido2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarCadastroRapido2.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroRapido2.Click += new System.EventHandler(this.btnSalvarCadastroRapido2_Click);
            // 
            // btnCancelarCadastroRapido2
            // 
            this.btnCancelarCadastroRapido2.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCadastroRapido2.Image")));
            this.btnCancelarCadastroRapido2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCadastroRapido2.Location = new System.Drawing.Point(356, 90);
            this.btnCancelarCadastroRapido2.Name = "btnCancelarCadastroRapido2";
            this.btnCancelarCadastroRapido2.Size = new System.Drawing.Size(120, 45);
            this.btnCancelarCadastroRapido2.TabIndex = 5;
            this.btnCancelarCadastroRapido2.TabStop = false;
            this.btnCancelarCadastroRapido2.Text = "Cancelar";
            this.btnCancelarCadastroRapido2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCadastroRapido2.UseVisualStyleBackColor = true;
            this.btnCancelarCadastroRapido2.Click += new System.EventHandler(this.btnCancelarCadastroRapido2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 18);
            this.label15.TabIndex = 50;
            this.label15.Text = "Nome:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 18);
            this.label16.TabIndex = 53;
            this.label16.Text = "Cor:";
            // 
            // txtNomeRapido2
            // 
            this.txtNomeRapido2.Location = new System.Drawing.Point(79, 25);
            this.txtNomeRapido2.Name = "txtNomeRapido2";
            this.txtNomeRapido2.Size = new System.Drawing.Size(212, 26);
            this.txtNomeRapido2.TabIndex = 1;
            this.txtNomeRapido2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeRapido2_KeyDown);
            // 
            // cbCorRapido2
            // 
            this.cbCorRapido2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorRapido2.FormattingEnabled = true;
            this.cbCorRapido2.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta"});
            this.cbCorRapido2.Location = new System.Drawing.Point(79, 65);
            this.cbCorRapido2.Name = "cbCorRapido2";
            this.cbCorRapido2.Size = new System.Drawing.Size(212, 26);
            this.cbCorRapido2.TabIndex = 2;
            this.cbCorRapido2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCorRapido2_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 47;
            this.label11.Text = "Sexo:";
            // 
            // gbCadastroRapido1
            // 
            this.gbCadastroRapido1.Controls.Add(this.btnCancelarCadastroRapido1);
            this.gbCadastroRapido1.Controls.Add(this.btnSalvarCadastroRapido1);
            this.gbCadastroRapido1.Controls.Add(this.txtFamiliaRapido1);
            this.gbCadastroRapido1.Controls.Add(this.label14);
            this.gbCadastroRapido1.Controls.Add(this.label12);
            this.gbCadastroRapido1.Controls.Add(this.txtNomeRapido1);
            this.gbCadastroRapido1.Controls.Add(this.cbCorRapido1);
            this.gbCadastroRapido1.Controls.Add(this.label13);
            this.gbCadastroRapido1.Location = new System.Drawing.Point(15, 21);
            this.gbCadastroRapido1.Name = "gbCadastroRapido1";
            this.gbCadastroRapido1.Size = new System.Drawing.Size(495, 150);
            this.gbCadastroRapido1.TabIndex = 50;
            this.gbCadastroRapido1.TabStop = false;
            this.gbCadastroRapido1.Text = "Cadastro Rápido 01";
            // 
            // btnCancelarCadastroRapido1
            // 
            this.btnCancelarCadastroRapido1.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCadastroRapido1.Image")));
            this.btnCancelarCadastroRapido1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCadastroRapido1.Location = new System.Drawing.Point(356, 94);
            this.btnCancelarCadastroRapido1.Name = "btnCancelarCadastroRapido1";
            this.btnCancelarCadastroRapido1.Size = new System.Drawing.Size(120, 45);
            this.btnCancelarCadastroRapido1.TabIndex = 5;
            this.btnCancelarCadastroRapido1.TabStop = false;
            this.btnCancelarCadastroRapido1.Text = "Cancelar";
            this.btnCancelarCadastroRapido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCadastroRapido1.UseVisualStyleBackColor = true;
            this.btnCancelarCadastroRapido1.Click += new System.EventHandler(this.btnCancelarCadastroRapido1_Click);
            // 
            // btnSalvarCadastroRapido1
            // 
            this.btnSalvarCadastroRapido1.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCadastroRapido1.Image")));
            this.btnSalvarCadastroRapido1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCadastroRapido1.Location = new System.Drawing.Point(356, 25);
            this.btnSalvarCadastroRapido1.Name = "btnSalvarCadastroRapido1";
            this.btnSalvarCadastroRapido1.Size = new System.Drawing.Size(120, 45);
            this.btnSalvarCadastroRapido1.TabIndex = 4;
            this.btnSalvarCadastroRapido1.Text = "Salvar";
            this.btnSalvarCadastroRapido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarCadastroRapido1.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroRapido1.Click += new System.EventHandler(this.btnSalvarCadastroRapido1_Click);
            // 
            // txtFamiliaRapido1
            // 
            this.txtFamiliaRapido1.Location = new System.Drawing.Point(79, 69);
            this.txtFamiliaRapido1.Name = "txtFamiliaRapido1";
            this.txtFamiliaRapido1.Size = new System.Drawing.Size(212, 26);
            this.txtFamiliaRapido1.TabIndex = 2;
            this.txtFamiliaRapido1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFamiliaRapido1_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 18);
            this.label14.TabIndex = 41;
            this.label14.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 18);
            this.label12.TabIndex = 46;
            this.label12.Text = "Cor:";
            // 
            // txtNomeRapido1
            // 
            this.txtNomeRapido1.Location = new System.Drawing.Point(79, 25);
            this.txtNomeRapido1.Name = "txtNomeRapido1";
            this.txtNomeRapido1.Size = new System.Drawing.Size(212, 26);
            this.txtNomeRapido1.TabIndex = 1;
            this.txtNomeRapido1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeRapido1_KeyDown);
            // 
            // cbCorRapido1
            // 
            this.cbCorRapido1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCorRapido1.FormattingEnabled = true;
            this.cbCorRapido1.Items.AddRange(new object[] {
            "Abóbora",
            "Açafrão",
            "Amarelo",
            "Âmbar",
            "Ameixa",
            "Amêndoa",
            "Ametista",
            "Anil",
            "Azul",
            "Bege",
            "Bordô",
            "Branco",
            "Bronze",
            "Cáqui",
            "Caramelo",
            "Carmesim",
            "Carmim",
            "Castanho",
            "Cereja",
            "Chocolate",
            "Ciano ",
            "Cinza",
            "Cinzento",
            "Cobre",
            "Coral",
            "Creme",
            "Damasco",
            "Dourado",
            "Escarlate",
            "Esmeralda",
            "Ferrugem",
            "Fúcsia",
            "Gelo",
            "Grená",
            "Gris",
            "Índigo",
            "Jade",
            "Jambo",
            "Laranja",
            "Lavanda",
            "Lilás ",
            "Limão",
            "Loiro",
            "Magenta",
            "Malva",
            "Marfim",
            "Marrom",
            "Mostarda",
            "Negro",
            "Ocre",
            "Oliva",
            "Ouro",
            "Pêssego",
            "Prata",
            "Preto",
            "Púrpura",
            "Rosa",
            "Roxo",
            "Rubro",
            "Salmão",
            "Sépia",
            "Terracota",
            "Tijolo",
            "Turquesa",
            "Uva",
            "Verde",
            "Vermelho",
            "Vinho",
            "Violeta"});
            this.cbCorRapido1.Location = new System.Drawing.Point(79, 113);
            this.cbCorRapido1.Name = "cbCorRapido1";
            this.cbCorRapido1.Size = new System.Drawing.Size(212, 26);
            this.cbCorRapido1.TabIndex = 3;
            this.cbCorRapido1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbCorRapido1_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 43;
            this.label13.Text = "Família:";
            // 
            // Fadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 410);
            this.Controls.Add(this.tbcFada);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Fadas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFadas)).EndInit();
            this.tbcFada.ResumeLayout(false);
            this.tabPageLista.ResumeLayout(false);
            this.tabPageLista.PerformLayout();
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.tabPageCadastroRapido.ResumeLayout(false);
            this.tabPageCadastroRapido.PerformLayout();
            this.gbCadastroRapido2.ResumeLayout(false);
            this.gbCadastroRapido2.PerformLayout();
            this.gbCadastroRapido1.ResumeLayout(false);
            this.gbCadastroRapido1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFadas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TabControl tbcFada;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbElemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkFazBarulho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAsaQuebrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCorAsa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTamanhoAsa;
        private System.Windows.Forms.Button btnCadastroRapido;
        private System.Windows.Forms.TabPage tabPageCadastroRapido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCorRapido1;
        private System.Windows.Forms.TextBox txtFamiliaRapido1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNomeRapido1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbCadastroRapido2;
        private System.Windows.Forms.Button btnSalvarCadastroRapido2;
        private System.Windows.Forms.Button btnCancelarCadastroRapido2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNomeRapido2;
        private System.Windows.Forms.ComboBox cbCorRapido2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbCadastroRapido1;
        private System.Windows.Forms.Button btnCancelarCadastroRapido1;
        private System.Windows.Forms.Button btnSalvarCadastroRapido1;
        private System.Windows.Forms.RadioButton rbCadastroRapido2;
        private System.Windows.Forms.RadioButton rbCadastroRapido1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblQuantidadeFadas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkMulher;
        private System.Windows.Forms.CheckBox chkMulherRapido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCor;
    }
}

