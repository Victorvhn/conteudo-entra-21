namespace SistemaEscola
{
    partial class usAluno
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
            this.tabControlAlunos = new System.Windows.Forms.TabControl();
            this.tpAluno = new System.Windows.Forms.TabPage();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.nudNumeroCasa = new System.Windows.Forms.NumericUpDown();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBairo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpDataNascimentoAluno = new System.Windows.Forms.DateTimePicker();
            this.dtpDataMatricual = new System.Windows.Forms.DateTimePicker();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.cbSexoAluno = new System.Windows.Forms.ComboBox();
            this.txtMatriculaAluno = new System.Windows.Forms.TextBox();
            this.txtRgAluno = new System.Windows.Forms.TextBox();
            this.mtbCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.cbNacionalidadeAluno = new System.Windows.Forms.ComboBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpResponsavel = new System.Windows.Forms.TabPage();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDataNascimentoResponsavel = new System.Windows.Forms.DateTimePicker();
            this.cbSexoResponsavel = new System.Windows.Forms.ComboBox();
            this.txtRgResponsavel = new System.Windows.Forms.TextBox();
            this.mtbCpfResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.cbNacionalidadeResponsavel = new System.Windows.Forms.ComboBox();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.ColumnNomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTurnoAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabControlAlunos.SuspendLayout();
            this.tpAluno.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCasa)).BeginInit();
            this.tpResponsavel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAlunos
            // 
            this.tabControlAlunos.Controls.Add(this.tpAluno);
            this.tabControlAlunos.Controls.Add(this.tpResponsavel);
            this.tabControlAlunos.Location = new System.Drawing.Point(3, 3);
            this.tabControlAlunos.Name = "tabControlAlunos";
            this.tabControlAlunos.SelectedIndex = 0;
            this.tabControlAlunos.Size = new System.Drawing.Size(1172, 354);
            this.tabControlAlunos.TabIndex = 66;
            // 
            // tpAluno
            // 
            this.tpAluno.Controls.Add(this.gbEndereco);
            this.tpAluno.Controls.Add(this.dtpDataNascimentoAluno);
            this.tpAluno.Controls.Add(this.dtpDataMatricual);
            this.tpAluno.Controls.Add(this.cbTurma);
            this.tpAluno.Controls.Add(this.cbTurno);
            this.tpAluno.Controls.Add(this.cbSexoAluno);
            this.tpAluno.Controls.Add(this.txtMatriculaAluno);
            this.tpAluno.Controls.Add(this.txtRgAluno);
            this.tpAluno.Controls.Add(this.mtbCpfAluno);
            this.tpAluno.Controls.Add(this.cbNacionalidadeAluno);
            this.tpAluno.Controls.Add(this.txtNomeAluno);
            this.tpAluno.Controls.Add(this.label12);
            this.tpAluno.Controls.Add(this.label9);
            this.tpAluno.Controls.Add(this.label10);
            this.tpAluno.Controls.Add(this.label8);
            this.tpAluno.Controls.Add(this.label5);
            this.tpAluno.Controls.Add(this.label6);
            this.tpAluno.Controls.Add(this.label3);
            this.tpAluno.Controls.Add(this.label4);
            this.tpAluno.Controls.Add(this.label2);
            this.tpAluno.Controls.Add(this.label1);
            this.tpAluno.Location = new System.Drawing.Point(4, 27);
            this.tpAluno.Name = "tpAluno";
            this.tpAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tpAluno.Size = new System.Drawing.Size(1164, 323);
            this.tpAluno.TabIndex = 0;
            this.tpAluno.Text = "Aluno";
            this.tpAluno.UseVisualStyleBackColor = true;
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.mtbCep);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.label22);
            this.gbEndereco.Controls.Add(this.nudNumeroCasa);
            this.gbEndereco.Controls.Add(this.txtUf);
            this.gbEndereco.Controls.Add(this.label18);
            this.gbEndereco.Controls.Add(this.label25);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtLogradouro);
            this.gbEndereco.Controls.Add(this.label19);
            this.gbEndereco.Controls.Add(this.label23);
            this.gbEndereco.Controls.Add(this.txtBairo);
            this.gbEndereco.Controls.Add(this.label20);
            this.gbEndereco.Controls.Add(this.label21);
            this.gbEndereco.Location = new System.Drawing.Point(25, 141);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(582, 168);
            this.gbEndereco.TabIndex = 105;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(119, 29);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(100, 26);
            this.mtbCep.TabIndex = 28;
            this.mtbCep.TextChanged += new System.EventHandler(this.mtbCep_TextChanged);
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(422, 126);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(120, 26);
            this.txtComplemento.TabIndex = 35;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(306, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 18);
            this.label22.TabIndex = 78;
            this.label22.Text = "Complemento:";
            // 
            // nudNumeroCasa
            // 
            this.nudNumeroCasa.Location = new System.Drawing.Point(422, 94);
            this.nudNumeroCasa.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudNumeroCasa.Name = "nudNumeroCasa";
            this.nudNumeroCasa.Size = new System.Drawing.Size(120, 26);
            this.nudNumeroCasa.TabIndex = 32;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(442, 29);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 26);
            this.txtUf.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(67, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 18);
            this.label18.TabIndex = 65;
            this.label18.Text = "CEP:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(307, 96);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(109, 18);
            this.label25.TabIndex = 70;
            this.label25.Text = "Número Casa:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(119, 125);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(172, 26);
            this.txtCidade.TabIndex = 34;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(119, 61);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(423, 26);
            this.txtLogradouro.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 18);
            this.label19.TabIndex = 66;
            this.label19.Text = "Logradouro:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(403, 32);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 18);
            this.label23.TabIndex = 69;
            this.label23.Text = "UF:";
            // 
            // txtBairo
            // 
            this.txtBairo.Location = new System.Drawing.Point(119, 93);
            this.txtBairo.Name = "txtBairo";
            this.txtBairo.Size = new System.Drawing.Size(172, 26);
            this.txtBairo.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(58, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 18);
            this.label20.TabIndex = 68;
            this.label20.Text = "Bairro:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(49, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 18);
            this.label21.TabIndex = 67;
            this.label21.Text = "Cidade:";
            // 
            // dtpDataNascimentoAluno
            // 
            this.dtpDataNascimentoAluno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoAluno.Location = new System.Drawing.Point(523, 76);
            this.dtpDataNascimentoAluno.Name = "dtpDataNascimentoAluno";
            this.dtpDataNascimentoAluno.Size = new System.Drawing.Size(121, 26);
            this.dtpDataNascimentoAluno.TabIndex = 23;
            // 
            // dtpDataMatricual
            // 
            this.dtpDataMatricual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMatricual.Location = new System.Drawing.Point(523, 43);
            this.dtpDataMatricual.Name = "dtpDataMatricual";
            this.dtpDataMatricual.Size = new System.Drawing.Size(121, 26);
            this.dtpDataMatricual.TabIndex = 20;
            // 
            // cbTurma
            // 
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Items.AddRange(new object[] {
            "8• EM - Turma 1.3",
            "5• EF - Turma 5.1",
            "3• EF - Turma 2.0",
            "9• EM - Turma 4.2",
            "2• EM - Turma 1.2"});
            this.cbTurma.Location = new System.Drawing.Point(712, 107);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(121, 26);
            this.cbTurma.TabIndex = 27;
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cbTurno.Location = new System.Drawing.Point(712, 76);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(121, 26);
            this.cbTurno.TabIndex = 14;
            // 
            // cbSexoAluno
            // 
            this.cbSexoAluno.FormattingEnabled = true;
            this.cbSexoAluno.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexoAluno.Location = new System.Drawing.Point(712, 45);
            this.cbSexoAluno.Name = "cbSexoAluno";
            this.cbSexoAluno.Size = new System.Drawing.Size(119, 26);
            this.cbSexoAluno.TabIndex = 21;
            // 
            // txtMatriculaAluno
            // 
            this.txtMatriculaAluno.Location = new System.Drawing.Point(522, 108);
            this.txtMatriculaAluno.Name = "txtMatriculaAluno";
            this.txtMatriculaAluno.Size = new System.Drawing.Size(122, 26);
            this.txtMatriculaAluno.TabIndex = 26;
            // 
            // txtRgAluno
            // 
            this.txtRgAluno.Location = new System.Drawing.Point(141, 109);
            this.txtRgAluno.Name = "txtRgAluno";
            this.txtRgAluno.Size = new System.Drawing.Size(135, 26);
            this.txtRgAluno.TabIndex = 25;
            // 
            // mtbCpfAluno
            // 
            this.mtbCpfAluno.Location = new System.Drawing.Point(141, 76);
            this.mtbCpfAluno.Mask = "000,000,000-00";
            this.mtbCpfAluno.Name = "mtbCpfAluno";
            this.mtbCpfAluno.Size = new System.Drawing.Size(135, 26);
            this.mtbCpfAluno.TabIndex = 22;
            // 
            // cbNacionalidadeAluno
            // 
            this.cbNacionalidadeAluno.FormattingEnabled = true;
            this.cbNacionalidadeAluno.Items.AddRange(new object[] {
            "Brasil",
            "Afeganistão",
            "África do Sul",
            "Albânia",
            "Alemanha",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antilhas Holandesas",
            "Antárctida",
            "Antígua e Barbuda",
            "Argentina",
            "Argélia",
            "Armênia",
            "Aruba",
            "Arábia Saudita",
            "Austrália",
            "Áustria",
            "Azerbaijão",
            "Bahamas",
            "Bahrein",
            "Bangladesh",
            "Barbados",
            "Belize",
            "Benim",
            "Bermudas",
            "Bielorrússia",
            "Bolívia",
            "Botswana",
            "Brunei",
            "Bulgária",
            "Burkina Faso",
            "Burundi",
            "Butão",
            "Bélgica",
            "Bósnia e Herzegovina",
            "Cabo Verde",
            "Camarões",
            "Camboja",
            "Canadá",
            "Catar",
            "Cazaquistão",
            "Chade",
            "Chile",
            "China",
            "Chipre",
            "Colômbia",
            "Comores",
            "Coreia do Norte",
            "Coreia do Sul",
            "Costa do Marfim",
            "Costa Rica",
            "Croácia",
            "Cuba",
            "Dinamarca",
            "Djibouti",
            "Dominica",
            "Egito",
            "El Salvador",
            "Emirados Árabes Unidos",
            "Equador",
            "Eritreia",
            "Escócia",
            "Eslováquia",
            "Eslovênia",
            "Espanha",
            "Estados Federados da Micronésia",
            "Estados Unidos",
            "Estônia",
            "Etiópia",
            "Fiji",
            "Filipinas",
            "Finlândia",
            "França",
            "Gabão",
            "Gana",
            "Geórgia",
            "Gibraltar",
            "Granada",
            "Gronelândia",
            "Grécia",
            "Guadalupe",
            "Guam",
            "Guatemala",
            "Guernesei",
            "Guiana",
            "Guiana Francesa",
            "Guiné",
            "Guiné Equatorial",
            "Guiné-Bissau",
            "Gâmbia",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "Ilha Bouvet",
            "Ilha de Man",
            "Ilha do Natal",
            "Ilha Heard e Ilhas McDonald",
            "Ilha Norfolk",
            "Ilhas Cayman",
            "Ilhas Cocos (Keeling)",
            "Ilhas Cook",
            "Ilhas Feroé",
            "Ilhas Geórgia do Sul e Sandwich do Sul",
            "Ilhas Malvinas",
            "Ilhas Marshall",
            "Ilhas Menores Distantes dos Estados Unidos",
            "Ilhas Salomão",
            "Ilhas Virgens Americanas",
            "Ilhas Virgens Britânicas",
            "Ilhas Åland",
            "Indonésia",
            "Inglaterra",
            "Índia",
            "Iraque",
            "Irlanda do Norte",
            "Irlanda",
            "Irã",
            "Islândia",
            "Israel",
            "Itália",
            "Iêmen",
            "Jamaica",
            "Japão",
            "Jersey",
            "Jordânia",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letônia",
            "Libéria",
            "Liechtenstein",
            "Lituânia",
            "Luxemburgo",
            "Líbano",
            "Líbia",
            "Macau",
            "Macedônia",
            "Madagáscar",
            "Malawi",
            "Maldivas",
            "Mali",
            "Malta",
            "Malásia",
            "Marianas Setentrionais",
            "Marrocos",
            "Martinica",
            "Mauritânia",
            "Maurícia",
            "Mayotte",
            "Moldávia",
            "Mongólia",
            "Montenegro",
            "Montserrat",
            "Moçambique",
            "Myanmar",
            "México",
            "Mônaco",
            "Namíbia",
            "Nauru",
            "Nepal",
            "Nicarágua",
            "Nigéria",
            "Niue",
            "Noruega",
            "Nova Caledônia",
            "Nova Zelândia",
            "Níger",
            "Omã",
            "Palau",
            "Palestina",
            "Panamá",
            "Papua-Nova Guiné",
            "Paquistão",
            "Paraguai",
            "País de Gales",
            "Países Baixos",
            "Peru",
            "Pitcairn",
            "Polinésia Francesa",
            "Polônia",
            "Porto Rico",
            "Portugal",
            "Quirguistão",
            "Quênia",
            "Reino Unido",
            "República Centro-Africana",
            "República Checa",
            "República Democrática do Congo",
            "República do Congo",
            "República Dominicana",
            "Reunião",
            "Romênia",
            "Ruanda",
            "Rússia",
            "Saara Ocidental",
            "Saint Martin",
            "Saint-Barthélemy",
            "Saint-Pierre e Miquelon",
            "Samoa Americana",
            "Samoa",
            "Santa Helena, Ascensão e Tristão da Cunha",
            "Santa Lúcia",
            "Senegal",
            "Serra Leoa",
            "Seychelles",
            "Singapura",
            "Somália",
            "Sri Lanka",
            "Suazilândia",
            "Sudão",
            "Suriname",
            "Suécia",
            "Suíça",
            "Svalbard e Jan Mayen",
            "São Cristóvão e Nevis",
            "São Marino",
            "São Tomé e Príncipe",
            "São Vicente e Granadinas",
            "Sérvia",
            "Síria",
            "Tadjiquistão",
            "Tailândia",
            "Taiwan",
            "Tanzânia",
            "Terras Austrais e Antárticas Francesas",
            "Território Britânico do Oceano Índico",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Toquelau",
            "Trinidad e Tobago",
            "Tunísia",
            "Turcas e Caicos",
            "Turquemenistão",
            "Turquia",
            "Tuvalu",
            "Ucrânia",
            "Uganda",
            "Uruguai",
            "Uzbequistão",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietname",
            "Wallis e Futuna",
            "Zimbabwe",
            "Zâmbia"});
            this.cbNacionalidadeAluno.Location = new System.Drawing.Point(141, 43);
            this.cbNacionalidadeAluno.Name = "cbNacionalidadeAluno";
            this.cbNacionalidadeAluno.Size = new System.Drawing.Size(236, 26);
            this.cbNacionalidadeAluno.TabIndex = 19;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(141, 10);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(395, 26);
            this.txtNomeAluno.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(660, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 87;
            this.label12.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 86;
            this.label9.Text = "Data de Matrícula:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 18);
            this.label10.TabIndex = 85;
            this.label10.Text = "Data de Nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 84;
            this.label8.Text = "Número matrícula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "Turma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 82;
            this.label6.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Nacionalidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nome:";
            // 
            // tpResponsavel
            // 
            this.tpResponsavel.Controls.Add(this.mtbTelefone);
            this.tpResponsavel.Controls.Add(this.label17);
            this.tpResponsavel.Controls.Add(this.dtpDataNascimentoResponsavel);
            this.tpResponsavel.Controls.Add(this.cbSexoResponsavel);
            this.tpResponsavel.Controls.Add(this.txtRgResponsavel);
            this.tpResponsavel.Controls.Add(this.mtbCpfResponsavel);
            this.tpResponsavel.Controls.Add(this.cbNacionalidadeResponsavel);
            this.tpResponsavel.Controls.Add(this.txtNomeResponsavel);
            this.tpResponsavel.Controls.Add(this.label7);
            this.tpResponsavel.Controls.Add(this.label11);
            this.tpResponsavel.Controls.Add(this.label13);
            this.tpResponsavel.Controls.Add(this.label14);
            this.tpResponsavel.Controls.Add(this.label15);
            this.tpResponsavel.Controls.Add(this.label16);
            this.tpResponsavel.Location = new System.Drawing.Point(4, 27);
            this.tpResponsavel.Name = "tpResponsavel";
            this.tpResponsavel.Padding = new System.Windows.Forms.Padding(3);
            this.tpResponsavel.Size = new System.Drawing.Size(1164, 323);
            this.tpResponsavel.TabIndex = 1;
            this.tpResponsavel.Text = "Responsável";
            this.tpResponsavel.UseVisualStyleBackColor = true;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(701, 54);
            this.mtbTelefone.Mask = "(00) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(148, 26);
            this.mtbTelefone.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(625, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 18);
            this.label17.TabIndex = 72;
            this.label17.Text = "Telefone:";
            // 
            // dtpDataNascimentoResponsavel
            // 
            this.dtpDataNascimentoResponsavel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoResponsavel.Location = new System.Drawing.Point(181, 90);
            this.dtpDataNascimentoResponsavel.Name = "dtpDataNascimentoResponsavel";
            this.dtpDataNascimentoResponsavel.Size = new System.Drawing.Size(200, 26);
            this.dtpDataNascimentoResponsavel.TabIndex = 71;
            // 
            // cbSexoResponsavel
            // 
            this.cbSexoResponsavel.FormattingEnabled = true;
            this.cbSexoResponsavel.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexoResponsavel.Location = new System.Drawing.Point(181, 58);
            this.cbSexoResponsavel.Name = "cbSexoResponsavel";
            this.cbSexoResponsavel.Size = new System.Drawing.Size(121, 26);
            this.cbSexoResponsavel.TabIndex = 70;
            // 
            // txtRgResponsavel
            // 
            this.txtRgResponsavel.Location = new System.Drawing.Point(446, 90);
            this.txtRgResponsavel.Name = "txtRgResponsavel";
            this.txtRgResponsavel.Size = new System.Drawing.Size(124, 26);
            this.txtRgResponsavel.TabIndex = 69;
            // 
            // mtbCpfResponsavel
            // 
            this.mtbCpfResponsavel.Location = new System.Drawing.Point(446, 58);
            this.mtbCpfResponsavel.Mask = "000,000,000-00";
            this.mtbCpfResponsavel.Name = "mtbCpfResponsavel";
            this.mtbCpfResponsavel.Size = new System.Drawing.Size(124, 26);
            this.mtbCpfResponsavel.TabIndex = 68;
            // 
            // cbNacionalidadeResponsavel
            // 
            this.cbNacionalidadeResponsavel.FormattingEnabled = true;
            this.cbNacionalidadeResponsavel.Items.AddRange(new object[] {
            "Brasil",
            "Afeganistão",
            "África do Sul",
            "Albânia",
            "Alemanha",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antilhas Holandesas",
            "Antárctida",
            "Antígua e Barbuda",
            "Argentina",
            "Argélia",
            "Armênia",
            "Aruba",
            "Arábia Saudita",
            "Austrália",
            "Áustria",
            "Azerbaijão",
            "Bahamas",
            "Bahrein",
            "Bangladesh",
            "Barbados",
            "Belize",
            "Benim",
            "Bermudas",
            "Bielorrússia",
            "Bolívia",
            "Botswana",
            "Brunei",
            "Bulgária",
            "Burkina Faso",
            "Burundi",
            "Butão",
            "Bélgica",
            "Bósnia e Herzegovina",
            "Cabo Verde",
            "Camarões",
            "Camboja",
            "Canadá",
            "Catar",
            "Cazaquistão",
            "Chade",
            "Chile",
            "China",
            "Chipre",
            "Colômbia",
            "Comores",
            "Coreia do Norte",
            "Coreia do Sul",
            "Costa do Marfim",
            "Costa Rica",
            "Croácia",
            "Cuba",
            "Dinamarca",
            "Djibouti",
            "Dominica",
            "Egito",
            "El Salvador",
            "Emirados Árabes Unidos",
            "Equador",
            "Eritreia",
            "Escócia",
            "Eslováquia",
            "Eslovênia",
            "Espanha",
            "Estados Federados da Micronésia",
            "Estados Unidos",
            "Estônia",
            "Etiópia",
            "Fiji",
            "Filipinas",
            "Finlândia",
            "França",
            "Gabão",
            "Gana",
            "Geórgia",
            "Gibraltar",
            "Granada",
            "Gronelândia",
            "Grécia",
            "Guadalupe",
            "Guam",
            "Guatemala",
            "Guernesei",
            "Guiana",
            "Guiana Francesa",
            "Guiné",
            "Guiné Equatorial",
            "Guiné-Bissau",
            "Gâmbia",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "Ilha Bouvet",
            "Ilha de Man",
            "Ilha do Natal",
            "Ilha Heard e Ilhas McDonald",
            "Ilha Norfolk",
            "Ilhas Cayman",
            "Ilhas Cocos (Keeling)",
            "Ilhas Cook",
            "Ilhas Feroé",
            "Ilhas Geórgia do Sul e Sandwich do Sul",
            "Ilhas Malvinas",
            "Ilhas Marshall",
            "Ilhas Menores Distantes dos Estados Unidos",
            "Ilhas Salomão",
            "Ilhas Virgens Americanas",
            "Ilhas Virgens Britânicas",
            "Ilhas Åland",
            "Indonésia",
            "Inglaterra",
            "Índia",
            "Iraque",
            "Irlanda do Norte",
            "Irlanda",
            "Irã",
            "Islândia",
            "Israel",
            "Itália",
            "Iêmen",
            "Jamaica",
            "Japão",
            "Jersey",
            "Jordânia",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letônia",
            "Libéria",
            "Liechtenstein",
            "Lituânia",
            "Luxemburgo",
            "Líbano",
            "Líbia",
            "Macau",
            "Macedônia",
            "Madagáscar",
            "Malawi",
            "Maldivas",
            "Mali",
            "Malta",
            "Malásia",
            "Marianas Setentrionais",
            "Marrocos",
            "Martinica",
            "Mauritânia",
            "Maurícia",
            "Mayotte",
            "Moldávia",
            "Mongólia",
            "Montenegro",
            "Montserrat",
            "Moçambique",
            "Myanmar",
            "México",
            "Mônaco",
            "Namíbia",
            "Nauru",
            "Nepal",
            "Nicarágua",
            "Nigéria",
            "Niue",
            "Noruega",
            "Nova Caledônia",
            "Nova Zelândia",
            "Níger",
            "Omã",
            "Palau",
            "Palestina",
            "Panamá",
            "Papua-Nova Guiné",
            "Paquistão",
            "Paraguai",
            "País de Gales",
            "Países Baixos",
            "Peru",
            "Pitcairn",
            "Polinésia Francesa",
            "Polônia",
            "Porto Rico",
            "Portugal",
            "Quirguistão",
            "Quênia",
            "Reino Unido",
            "República Centro-Africana",
            "República Checa",
            "República Democrática do Congo",
            "República do Congo",
            "República Dominicana",
            "Reunião",
            "Romênia",
            "Ruanda",
            "Rússia",
            "Saara Ocidental",
            "Saint Martin",
            "Saint-Barthélemy",
            "Saint-Pierre e Miquelon",
            "Samoa Americana",
            "Samoa",
            "Santa Helena, Ascensão e Tristão da Cunha",
            "Santa Lúcia",
            "Senegal",
            "Serra Leoa",
            "Seychelles",
            "Singapura",
            "Somália",
            "Sri Lanka",
            "Suazilândia",
            "Sudão",
            "Suriname",
            "Suécia",
            "Suíça",
            "Svalbard e Jan Mayen",
            "São Cristóvão e Nevis",
            "São Marino",
            "São Tomé e Príncipe",
            "São Vicente e Granadinas",
            "Sérvia",
            "Síria",
            "Tadjiquistão",
            "Tailândia",
            "Taiwan",
            "Tanzânia",
            "Terras Austrais e Antárticas Francesas",
            "Território Britânico do Oceano Índico",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Toquelau",
            "Trinidad e Tobago",
            "Tunísia",
            "Turcas e Caicos",
            "Turquemenistão",
            "Turquia",
            "Tuvalu",
            "Ucrânia",
            "Uganda",
            "Uruguai",
            "Uzbequistão",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietname",
            "Wallis e Futuna",
            "Zimbabwe",
            "Zâmbia"});
            this.cbNacionalidadeResponsavel.Location = new System.Drawing.Point(701, 86);
            this.cbNacionalidadeResponsavel.Name = "cbNacionalidadeResponsavel";
            this.cbNacionalidadeResponsavel.Size = new System.Drawing.Size(188, 26);
            this.cbNacionalidadeResponsavel.TabIndex = 67;
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.Location = new System.Drawing.Point(181, 26);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(279, 26);
            this.txtNomeResponsavel.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "Sexo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Data de Nascimento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(405, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "RG:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(395, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 18);
            this.label14.TabIndex = 62;
            this.label14.Text = "CPF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(582, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 18);
            this.label15.TabIndex = 61;
            this.label15.Text = "Nacionalidade:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 18);
            this.label16.TabIndex = 60;
            this.label16.Text = "Nome:";
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeAluno,
            this.ColumnTurnoAluno,
            this.ColumnSexo});
            this.dgvAluno.Location = new System.Drawing.Point(7, 414);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.Size = new System.Drawing.Size(1164, 188);
            this.dgvAluno.TabIndex = 1;
            this.dgvAluno.DoubleClick += new System.EventHandler(this.dgvAluno_DoubleClick);
            // 
            // ColumnNomeAluno
            // 
            this.ColumnNomeAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomeAluno.HeaderText = "Nome";
            this.ColumnNomeAluno.Name = "ColumnNomeAluno";
            this.ColumnNomeAluno.ReadOnly = true;
            // 
            // ColumnTurnoAluno
            // 
            this.ColumnTurnoAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTurnoAluno.HeaderText = "Turno";
            this.ColumnTurnoAluno.Name = "ColumnTurnoAluno";
            this.ColumnTurnoAluno.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Location = new System.Drawing.Point(110, 382);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(504, 26);
            this.txtBuscarAluno.TabIndex = 36;
            this.txtBuscarAluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAluno_KeyDown);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 385);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 18);
            this.label26.TabIndex = 3;
            this.label26.Text = "Buscar Aluno:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(853, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1015, 379);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 39;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(1096, 380);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 40;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(934, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // usAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBuscarAluno);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.tabControlAlunos);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usAluno";
            this.Size = new System.Drawing.Size(1178, 605);
            this.tabControlAlunos.ResumeLayout(false);
            this.tpAluno.ResumeLayout(false);
            this.tpAluno.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCasa)).EndInit();
            this.tpResponsavel.ResumeLayout(false);
            this.tpResponsavel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAlunos;
        private System.Windows.Forms.TabPage tpAluno;
        private System.Windows.Forms.TabPage tpResponsavel;
        public System.Windows.Forms.TextBox txtUf;
        public System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.NumericUpDown nudNumeroCasa;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtBairo;
        public System.Windows.Forms.TextBox txtLogradouro;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.MaskedTextBox mtbCep;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.DateTimePicker dtpDataNascimentoAluno;
        public System.Windows.Forms.DateTimePicker dtpDataMatricual;
        public System.Windows.Forms.ComboBox cbTurma;
        public System.Windows.Forms.ComboBox cbTurno;
        public System.Windows.Forms.ComboBox cbSexoAluno;
        public System.Windows.Forms.TextBox txtMatriculaAluno;
        public System.Windows.Forms.TextBox txtRgAluno;
        public System.Windows.Forms.MaskedTextBox mtbCpfAluno;
        public System.Windows.Forms.ComboBox cbNacionalidadeAluno;
        public System.Windows.Forms.TextBox txtNomeAluno;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mtbTelefone;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.DateTimePicker dtpDataNascimentoResponsavel;
        public System.Windows.Forms.ComboBox cbSexoResponsavel;
        public System.Windows.Forms.TextBox txtRgResponsavel;
        public System.Windows.Forms.MaskedTextBox mtbCpfResponsavel;
        public System.Windows.Forms.ComboBox cbNacionalidadeResponsavel;
        public System.Windows.Forms.TextBox txtNomeResponsavel;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTurnoAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
    }
}
