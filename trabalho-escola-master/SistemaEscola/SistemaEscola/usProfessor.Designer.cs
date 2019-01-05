namespace SistemaEscola
{
    partial class usProfessor
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
            this.tabControlProfessores = new System.Windows.Forms.TabControl();
            this.tpProfessor = new System.Windows.Forms.TabPage();
            this.gbContaBancaria = new System.Windows.Forms.GroupBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbNacionalidade = new System.Windows.Forms.ComboBox();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TabPage();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.nudNumeroCasa = new System.Windows.Forms.NumericUpDown();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBuscarProfessor = new System.Windows.Forms.TextBox();
            this.dgvProfessores = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlProfessores.SuspendLayout();
            this.tpProfessor.SuspendLayout();
            this.gbContaBancaria.SuspendLayout();
            this.tbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProfessores
            // 
            this.tabControlProfessores.Controls.Add(this.tpProfessor);
            this.tabControlProfessores.Controls.Add(this.tbEndereco);
            this.tabControlProfessores.Location = new System.Drawing.Point(3, 3);
            this.tabControlProfessores.Name = "tabControlProfessores";
            this.tabControlProfessores.SelectedIndex = 0;
            this.tabControlProfessores.Size = new System.Drawing.Size(1172, 354);
            this.tabControlProfessores.TabIndex = 0;
            // 
            // tpProfessor
            // 
            this.tpProfessor.Controls.Add(this.gbContaBancaria);
            this.tpProfessor.Controls.Add(this.txtRg);
            this.tpProfessor.Controls.Add(this.txtNome);
            this.tpProfessor.Controls.Add(this.dtpDataNascimento);
            this.tpProfessor.Controls.Add(this.mtbCpf);
            this.tpProfessor.Controls.Add(this.cbSexo);
            this.tpProfessor.Controls.Add(this.cbNacionalidade);
            this.tpProfessor.Controls.Add(this.cbEspecialidade);
            this.tpProfessor.Controls.Add(this.cbTurno);
            this.tpProfessor.Controls.Add(this.label10);
            this.tpProfessor.Controls.Add(this.label7);
            this.tpProfessor.Controls.Add(this.label6);
            this.tpProfessor.Controls.Add(this.label5);
            this.tpProfessor.Controls.Add(this.label3);
            this.tpProfessor.Controls.Add(this.label4);
            this.tpProfessor.Controls.Add(this.label2);
            this.tpProfessor.Controls.Add(this.label1);
            this.tpProfessor.Location = new System.Drawing.Point(4, 27);
            this.tpProfessor.Name = "tpProfessor";
            this.tpProfessor.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfessor.Size = new System.Drawing.Size(1164, 323);
            this.tpProfessor.TabIndex = 0;
            this.tpProfessor.Text = "Professor";
            this.tpProfessor.UseVisualStyleBackColor = true;
            // 
            // gbContaBancaria
            // 
            this.gbContaBancaria.Controls.Add(this.txtConta);
            this.gbContaBancaria.Controls.Add(this.label8);
            this.gbContaBancaria.Controls.Add(this.txtAgencia);
            this.gbContaBancaria.Controls.Add(this.label9);
            this.gbContaBancaria.Location = new System.Drawing.Point(296, 112);
            this.gbContaBancaria.Name = "gbContaBancaria";
            this.gbContaBancaria.Size = new System.Drawing.Size(407, 104);
            this.gbContaBancaria.TabIndex = 71;
            this.gbContaBancaria.TabStop = false;
            this.gbContaBancaria.Text = "Conta bancária";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(92, 61);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(309, 26);
            this.txtConta.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Agência:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(92, 29);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(309, 26);
            this.txtAgencia.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Conta:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(143, 106);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(134, 26);
            this.txtRg.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(560, 26);
            this.txtNome.TabIndex = 1;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(454, 77);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(249, 26);
            this.dtpDataNascimento.TabIndex = 8;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(143, 75);
            this.mtbCpf.Mask = "000,000,000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(134, 26);
            this.mtbCpf.TabIndex = 3;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(143, 44);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(134, 26);
            this.cbSexo.TabIndex = 2;
            // 
            // cbNacionalidade
            // 
            this.cbNacionalidade.FormattingEnabled = true;
            this.cbNacionalidade.Items.AddRange(new object[] {
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
            this.cbNacionalidade.Location = new System.Drawing.Point(454, 45);
            this.cbNacionalidade.Name = "cbNacionalidade";
            this.cbNacionalidade.Size = new System.Drawing.Size(249, 26);
            this.cbNacionalidade.TabIndex = 7;
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Items.AddRange(new object[] {
            "Português",
            "Matemática",
            "História",
            "Geografica",
            "Biologia",
            "Física",
            "Química",
            "Inglês",
            "Educação Artística",
            "Filosofia",
            "Sociologia"});
            this.cbEspecialidade.Location = new System.Drawing.Point(143, 168);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(134, 26);
            this.cbEspecialidade.TabIndex = 6;
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cbTurno.Location = new System.Drawing.Point(143, 137);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(134, 26);
            this.cbTurno.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 62;
            this.label10.Text = "Especialidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 61;
            this.label7.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Nacionalidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nome:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Controls.Add(this.txtUf);
            this.tbEndereco.Controls.Add(this.txtComplemento);
            this.tbEndereco.Controls.Add(this.txtEmail);
            this.tbEndereco.Controls.Add(this.txtBairro);
            this.tbEndereco.Controls.Add(this.txtCidade);
            this.tbEndereco.Controls.Add(this.txtLogradouro);
            this.tbEndereco.Controls.Add(this.nudNumeroCasa);
            this.tbEndereco.Controls.Add(this.mtbCep);
            this.tbEndereco.Controls.Add(this.label17);
            this.tbEndereco.Controls.Add(this.label18);
            this.tbEndereco.Controls.Add(this.label15);
            this.tbEndereco.Controls.Add(this.label16);
            this.tbEndereco.Controls.Add(this.label13);
            this.tbEndereco.Controls.Add(this.label14);
            this.tbEndereco.Controls.Add(this.label12);
            this.tbEndereco.Controls.Add(this.label11);
            this.tbEndereco.Location = new System.Drawing.Point(4, 27);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tbEndereco.Size = new System.Drawing.Size(1164, 323);
            this.tbEndereco.TabIndex = 1;
            this.tbEndereco.Text = "Endereco";
            this.tbEndereco.UseVisualStyleBackColor = true;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(566, 75);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 26);
            this.txtUf.TabIndex = 17;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(566, 111);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 26);
            this.txtComplemento.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(551, 26);
            this.txtEmail.TabIndex = 16;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(115, 142);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(293, 26);
            this.txtBairro.TabIndex = 15;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(115, 76);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(293, 26);
            this.txtCidade.TabIndex = 13;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(115, 43);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(551, 26);
            this.txtLogradouro.TabIndex = 12;
            // 
            // nudNumeroCasa
            // 
            this.nudNumeroCasa.Location = new System.Drawing.Point(115, 110);
            this.nudNumeroCasa.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudNumeroCasa.Name = "nudNumeroCasa";
            this.nudNumeroCasa.Size = new System.Drawing.Size(120, 26);
            this.nudNumeroCasa.TabIndex = 14;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(115, 10);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(100, 26);
            this.mtbCep.TabIndex = 11;
            this.mtbCep.TextChanged += new System.EventHandler(this.mtbCep_TextChanged);
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(450, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 18);
            this.label17.TabIndex = 39;
            this.label17.Text = "Complemento:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(527, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 18);
            this.label18.TabIndex = 38;
            this.label18.Text = "UF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 18);
            this.label15.TabIndex = 37;
            this.label15.Text = "E-mail:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 18);
            this.label16.TabIndex = 36;
            this.label16.Text = "Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "Número:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 34;
            this.label14.Text = "Cidade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Logradouro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 32;
            this.label11.Text = "CEP:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(934, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(1096, 380);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 22;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1015, 379);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(853, 380);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 385);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 18);
            this.label26.TabIndex = 10;
            this.label26.Text = "Buscar Professor:";
            // 
            // txtBuscarProfessor
            // 
            this.txtBuscarProfessor.Location = new System.Drawing.Point(143, 382);
            this.txtBuscarProfessor.Name = "txtBuscarProfessor";
            this.txtBuscarProfessor.Size = new System.Drawing.Size(504, 26);
            this.txtBuscarProfessor.TabIndex = 23;
            this.txtBuscarProfessor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProfessor_KeyDown);
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.AllowUserToAddRows = false;
            this.dgvProfessores.AllowUserToDeleteRows = false;
            this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnSexo,
            this.ColumnCPF,
            this.ColumnTurno,
            this.ColumnEspecialidade});
            this.dgvProfessores.Location = new System.Drawing.Point(7, 414);
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.ReadOnly = true;
            this.dgvProfessores.Size = new System.Drawing.Size(1164, 188);
            this.dgvProfessores.TabIndex = 8;
            this.dgvProfessores.DoubleClick += new System.EventHandler(this.dgvProfessores_DoubleClick);
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            this.ColumnCPF.ReadOnly = true;
            // 
            // ColumnTurno
            // 
            this.ColumnTurno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTurno.HeaderText = "Turno";
            this.ColumnTurno.Name = "ColumnTurno";
            this.ColumnTurno.ReadOnly = true;
            // 
            // ColumnEspecialidade
            // 
            this.ColumnEspecialidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEspecialidade.HeaderText = "Especialidade";
            this.ColumnEspecialidade.Name = "ColumnEspecialidade";
            this.ColumnEspecialidade.ReadOnly = true;
            // 
            // usProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBuscarProfessor);
            this.Controls.Add(this.dgvProfessores);
            this.Controls.Add(this.tabControlProfessores);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usProfessor";
            this.Size = new System.Drawing.Size(1178, 605);
            this.tabControlProfessores.ResumeLayout(false);
            this.tpProfessor.ResumeLayout(false);
            this.tpProfessor.PerformLayout();
            this.gbContaBancaria.ResumeLayout(false);
            this.gbContaBancaria.PerformLayout();
            this.tbEndereco.ResumeLayout(false);
            this.tbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox gbContaBancaria;
        public System.Windows.Forms.TextBox txtConta;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtAgencia;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtRg;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.DateTimePicker dtpDataNascimento;
        public System.Windows.Forms.MaskedTextBox mtbCpf;
        public System.Windows.Forms.ComboBox cbSexo;
        public System.Windows.Forms.ComboBox cbNacionalidade;
        public System.Windows.Forms.ComboBox cbEspecialidade;
        public System.Windows.Forms.ComboBox cbTurno;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUf;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtLogradouro;
        public System.Windows.Forms.NumericUpDown nudNumeroCasa;
        public System.Windows.Forms.MaskedTextBox mtbCep;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TabControl tabControlProfessores;
        public System.Windows.Forms.TabPage tpProfessor;
        public System.Windows.Forms.TabPage tbEndereco;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBuscarProfessor;
        private System.Windows.Forms.DataGridView dgvProfessores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEspecialidade;
    }
}
