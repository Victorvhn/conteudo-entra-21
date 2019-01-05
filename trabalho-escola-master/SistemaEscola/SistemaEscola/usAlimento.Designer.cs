namespace SistemaEscola
{
    partial class usAlimento
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlAlimentos = new System.Windows.Forms.TabControl();
            this.tpAlimento = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantidadeCalorias = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.dtpDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDeFabricacao = new System.Windows.Forms.DateTimePicker();
            this.cbGrupoAlimentar = new System.Windows.Forms.ComboBox();
            this.txtNomeAlimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpFornecedor = new System.Windows.Forms.TabPage();
            this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.mtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.nudNumeroCasa = new System.Windows.Forms.NumericUpDown();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBuscarAlimento = new System.Windows.Forms.TextBox();
            this.dgvAlimento = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlAlimentos.SuspendLayout();
            this.tpAlimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.tpFornecedor.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAlimentos
            // 
            this.tabControlAlimentos.Controls.Add(this.tpAlimento);
            this.tabControlAlimentos.Controls.Add(this.tpFornecedor);
            this.tabControlAlimentos.Location = new System.Drawing.Point(3, 3);
            this.tabControlAlimentos.Name = "tabControlAlimentos";
            this.tabControlAlimentos.SelectedIndex = 0;
            this.tabControlAlimentos.Size = new System.Drawing.Size(1172, 354);
            this.tabControlAlimentos.TabIndex = 0;
            // 
            // tpAlimento
            // 
            this.tpAlimento.Controls.Add(this.label9);
            this.tpAlimento.Controls.Add(this.txtQuantidadeCalorias);
            this.tpAlimento.Controls.Add(this.txtCodigoBarras);
            this.tpAlimento.Controls.Add(this.txtValorUnitario);
            this.tpAlimento.Controls.Add(this.nudQuantidade);
            this.tpAlimento.Controls.Add(this.dtpDataDeValidade);
            this.tpAlimento.Controls.Add(this.dtpDataDeFabricacao);
            this.tpAlimento.Controls.Add(this.cbGrupoAlimentar);
            this.tpAlimento.Controls.Add(this.txtNomeAlimento);
            this.tpAlimento.Controls.Add(this.label4);
            this.tpAlimento.Controls.Add(this.label7);
            this.tpAlimento.Controls.Add(this.label8);
            this.tpAlimento.Controls.Add(this.label5);
            this.tpAlimento.Controls.Add(this.label6);
            this.tpAlimento.Controls.Add(this.label3);
            this.tpAlimento.Controls.Add(this.label2);
            this.tpAlimento.Controls.Add(this.label1);
            this.tpAlimento.Location = new System.Drawing.Point(4, 27);
            this.tpAlimento.Name = "tpAlimento";
            this.tpAlimento.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlimento.Size = new System.Drawing.Size(1164, 323);
            this.tpAlimento.TabIndex = 0;
            this.tpAlimento.Text = "Alimento";
            this.tpAlimento.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(734, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kcal";
            // 
            // txtQuantidadeCalorias
            // 
            this.txtQuantidadeCalorias.Location = new System.Drawing.Point(593, 152);
            this.txtQuantidadeCalorias.Name = "txtQuantidadeCalorias";
            this.txtQuantidadeCalorias.Size = new System.Drawing.Size(135, 26);
            this.txtQuantidadeCalorias.TabIndex = 8;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(593, 108);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(180, 26);
            this.txtCodigoBarras.TabIndex = 6;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(593, 64);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(180, 26);
            this.txtValorUnitario.TabIndex = 4;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(593, 21);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(180, 26);
            this.nudQuantidade.TabIndex = 2;
            // 
            // dtpDataDeValidade
            // 
            this.dtpDataDeValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeValidade.Location = new System.Drawing.Point(170, 152);
            this.dtpDataDeValidade.Name = "dtpDataDeValidade";
            this.dtpDataDeValidade.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDeValidade.TabIndex = 7;
            // 
            // dtpDataDeFabricacao
            // 
            this.dtpDataDeFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeFabricacao.Location = new System.Drawing.Point(170, 108);
            this.dtpDataDeFabricacao.Name = "dtpDataDeFabricacao";
            this.dtpDataDeFabricacao.Size = new System.Drawing.Size(200, 26);
            this.dtpDataDeFabricacao.TabIndex = 5;
            // 
            // cbGrupoAlimentar
            // 
            this.cbGrupoAlimentar.FormattingEnabled = true;
            this.cbGrupoAlimentar.Items.AddRange(new object[] {
            "Verdura",
            "Frutas",
            "Enlatados",
            "Cereais",
            "Laticinios"});
            this.cbGrupoAlimentar.Location = new System.Drawing.Point(170, 64);
            this.cbGrupoAlimentar.Name = "cbGrupoAlimentar";
            this.cbGrupoAlimentar.Size = new System.Drawing.Size(200, 26);
            this.cbGrupoAlimentar.TabIndex = 3;
            // 
            // txtNomeAlimento
            // 
            this.txtNomeAlimento.Location = new System.Drawing.Point(170, 20);
            this.txtNomeAlimento.Name = "txtNomeAlimento";
            this.txtNomeAlimento.Size = new System.Drawing.Size(296, 26);
            this.txtNomeAlimento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade de Calorias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data de Validade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Código de Barras:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor Unitário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Fabricação:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grupo Alimentar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tpFornecedor
            // 
            this.tpFornecedor.Controls.Add(this.txtCodigoFornecedor);
            this.tpFornecedor.Controls.Add(this.txtNomeFornecedor);
            this.tpFornecedor.Controls.Add(this.mtbCnpj);
            this.tpFornecedor.Controls.Add(this.gbEndereco);
            this.tpFornecedor.Controls.Add(this.label12);
            this.tpFornecedor.Controls.Add(this.label11);
            this.tpFornecedor.Controls.Add(this.label10);
            this.tpFornecedor.Location = new System.Drawing.Point(4, 27);
            this.tpFornecedor.Name = "tpFornecedor";
            this.tpFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tpFornecedor.Size = new System.Drawing.Size(1164, 323);
            this.tpFornecedor.TabIndex = 1;
            this.tpFornecedor.Text = "Fornecedor";
            this.tpFornecedor.UseVisualStyleBackColor = true;
            // 
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.Location = new System.Drawing.Point(351, 60);
            this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
            this.txtCodigoFornecedor.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoFornecedor.TabIndex = 11;
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(92, 28);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(359, 26);
            this.txtNomeFornecedor.TabIndex = 9;
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.Location = new System.Drawing.Point(92, 60);
            this.mtbCnpj.Mask = "00,000,000/0000-00";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(170, 26);
            this.mtbCnpj.TabIndex = 10;
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.nudNumeroCasa);
            this.gbEndereco.Controls.Add(this.txtUf);
            this.gbEndereco.Controls.Add(this.txtLogradouro);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.mtbCep);
            this.gbEndereco.Controls.Add(this.label16);
            this.gbEndereco.Controls.Add(this.label18);
            this.gbEndereco.Controls.Add(this.label13);
            this.gbEndereco.Controls.Add(this.label17);
            this.gbEndereco.Controls.Add(this.label14);
            this.gbEndereco.Controls.Add(this.label15);
            this.gbEndereco.Location = new System.Drawing.Point(35, 92);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(502, 191);
            this.gbEndereco.TabIndex = 9;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // nudNumeroCasa
            // 
            this.nudNumeroCasa.Location = new System.Drawing.Point(373, 111);
            this.nudNumeroCasa.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudNumeroCasa.Name = "nudNumeroCasa";
            this.nudNumeroCasa.Size = new System.Drawing.Size(89, 26);
            this.nudNumeroCasa.TabIndex = 16;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(362, 29);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 26);
            this.txtUf.TabIndex = 13;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(78, 70);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(384, 26);
            this.txtLogradouro.TabIndex = 14;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(78, 152);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(174, 26);
            this.txtBairro.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(78, 111);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(174, 26);
            this.txtCidade.TabIndex = 15;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(78, 29);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(100, 26);
            this.mtbCep.TabIndex = 12;
            this.mtbCep.TextChanged += new System.EventHandler(this.mtbCep_TextChanged);
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 18);
            this.label16.TabIndex = 6;
            this.label16.Text = "Cidade:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(313, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 18);
            this.label18.TabIndex = 8;
            this.label18.Text = "UF:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Rua:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 18);
            this.label17.TabIndex = 7;
            this.label17.Text = "Bairro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "CEP:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(300, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "Número:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "CNPJ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Código:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(934, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(1096, 380);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 21;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1015, 379);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(853, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 385);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 18);
            this.label26.TabIndex = 17;
            this.label26.Text = "Buscar Alimento:";
            // 
            // txtBuscarAlimento
            // 
            this.txtBuscarAlimento.Location = new System.Drawing.Point(143, 382);
            this.txtBuscarAlimento.Name = "txtBuscarAlimento";
            this.txtBuscarAlimento.Size = new System.Drawing.Size(504, 26);
            this.txtBuscarAlimento.TabIndex = 22;
            this.txtBuscarAlimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlimento_KeyDown);
            // 
            // dgvAlimento
            // 
            this.dgvAlimento.AllowUserToAddRows = false;
            this.dgvAlimento.AllowUserToDeleteRows = false;
            this.dgvAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnDataEntrada,
            this.ColumnQuantidade,
            this.ColumnCodigo,
            this.ColumnCep});
            this.dgvAlimento.Location = new System.Drawing.Point(7, 414);
            this.dgvAlimento.Name = "dgvAlimento";
            this.dgvAlimento.ReadOnly = true;
            this.dgvAlimento.Size = new System.Drawing.Size(1164, 188);
            this.dgvAlimento.TabIndex = 15;
            this.dgvAlimento.DoubleClick += new System.EventHandler(this.dgvAlimento_DoubleClick);
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnDataEntrada
            // 
            this.ColumnDataEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataEntrada.HeaderText = "Data Entrada";
            this.ColumnDataEntrada.Name = "ColumnDataEntrada";
            this.ColumnDataEntrada.ReadOnly = true;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.ReadOnly = true;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCodigo.HeaderText = "COD Barra";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnCep
            // 
            this.ColumnCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCep.HeaderText = "CEP";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            // 
            // usAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBuscarAlimento);
            this.Controls.Add(this.dgvAlimento);
            this.Controls.Add(this.tabControlAlimentos);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usAlimento";
            this.Size = new System.Drawing.Size(1178, 605);
            this.tabControlAlimentos.ResumeLayout(false);
            this.tpAlimento.ResumeLayout(false);
            this.tpAlimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.tpFornecedor.ResumeLayout(false);
            this.tpFornecedor.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAlimentos;
        private System.Windows.Forms.TabPage tpAlimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidadeCalorias;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.DateTimePicker dtpDataDeValidade;
        private System.Windows.Forms.DateTimePicker dtpDataDeFabricacao;
        private System.Windows.Forms.ComboBox cbGrupoAlimentar;
        private System.Windows.Forms.TextBox txtNomeAlimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpFornecedor;
        private System.Windows.Forms.TextBox txtCodigoFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.MaskedTextBox mtbCnpj;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.NumericUpDown nudNumeroCasa;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBuscarAlimento;
        private System.Windows.Forms.DataGridView dgvAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCep;
    }
}
