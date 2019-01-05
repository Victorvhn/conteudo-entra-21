namespace SistemaEscola
{
    partial class usFuncionario
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
            this.tpEndereco = new System.Windows.Forms.TabPage();
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
            this.tpFuncionario = new System.Windows.Forms.TabPage();
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
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlFuncionarios = new System.Windows.Forms.TabControl();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.txtBuscarFuncionario = new System.Windows.Forms.TextBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.ColumnNomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTurnoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCasa)).BeginInit();
            this.tpFuncionario.SuspendLayout();
            this.gbContaBancaria.SuspendLayout();
            this.tabControlFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // tpEndereco
            // 
            this.tpEndereco.Controls.Add(this.txtUf);
            this.tpEndereco.Controls.Add(this.txtComplemento);
            this.tpEndereco.Controls.Add(this.txtEmail);
            this.tpEndereco.Controls.Add(this.txtBairro);
            this.tpEndereco.Controls.Add(this.txtCidade);
            this.tpEndereco.Controls.Add(this.txtLogradouro);
            this.tpEndereco.Controls.Add(this.nudNumeroCasa);
            this.tpEndereco.Controls.Add(this.mtbCep);
            this.tpEndereco.Controls.Add(this.label17);
            this.tpEndereco.Controls.Add(this.label18);
            this.tpEndereco.Controls.Add(this.label15);
            this.tpEndereco.Controls.Add(this.label16);
            this.tpEndereco.Controls.Add(this.label13);
            this.tpEndereco.Controls.Add(this.label14);
            this.tpEndereco.Controls.Add(this.label12);
            this.tpEndereco.Controls.Add(this.label11);
            this.tpEndereco.Location = new System.Drawing.Point(4, 27);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tpEndereco.Size = new System.Drawing.Size(1164, 323);
            this.tpEndereco.TabIndex = 1;
            this.tpEndereco.Text = "Endereço";
            this.tpEndereco.UseVisualStyleBackColor = true;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(566, 75);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 26);
            this.txtUf.TabIndex = 14;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(566, 111);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 26);
            this.txtComplemento.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(551, 26);
            this.txtEmail.TabIndex = 18;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(115, 142);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(293, 26);
            this.txtBairro.TabIndex = 17;
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
            this.nudNumeroCasa.TabIndex = 15;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(115, 10);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(100, 26);
            this.mtbCep.TabIndex = 11;
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(450, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 18);
            this.label17.TabIndex = 55;
            this.label17.Text = "Complemento:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(527, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 18);
            this.label18.TabIndex = 54;
            this.label18.Text = "UF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 18);
            this.label15.TabIndex = 53;
            this.label15.Text = "E-mail:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 18);
            this.label16.TabIndex = 52;
            this.label16.Text = "Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 18);
            this.label13.TabIndex = 51;
            this.label13.Text = "Número:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 50;
            this.label14.Text = "Cidade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 18);
            this.label12.TabIndex = 49;
            this.label12.Text = "Logradouro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 48;
            this.label11.Text = "CEP:";
            // 
            // tpFuncionario
            // 
            this.tpFuncionario.Controls.Add(this.gbContaBancaria);
            this.tpFuncionario.Controls.Add(this.txtRg);
            this.tpFuncionario.Controls.Add(this.txtNome);
            this.tpFuncionario.Controls.Add(this.dtpDataNascimento);
            this.tpFuncionario.Controls.Add(this.mtbCpf);
            this.tpFuncionario.Controls.Add(this.cbSexo);
            this.tpFuncionario.Controls.Add(this.cbNacionalidade);
            this.tpFuncionario.Controls.Add(this.cbCargo);
            this.tpFuncionario.Controls.Add(this.cbTurno);
            this.tpFuncionario.Controls.Add(this.label10);
            this.tpFuncionario.Controls.Add(this.label7);
            this.tpFuncionario.Controls.Add(this.label6);
            this.tpFuncionario.Controls.Add(this.label5);
            this.tpFuncionario.Controls.Add(this.label3);
            this.tpFuncionario.Controls.Add(this.label4);
            this.tpFuncionario.Controls.Add(this.label2);
            this.tpFuncionario.Controls.Add(this.label1);
            this.tpFuncionario.Location = new System.Drawing.Point(4, 27);
            this.tpFuncionario.Name = "tpFuncionario";
            this.tpFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuncionario.Size = new System.Drawing.Size(1164, 323);
            this.tpFuncionario.TabIndex = 0;
            this.tpFuncionario.Text = "Funcionário";
            this.tpFuncionario.UseVisualStyleBackColor = true;
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
            this.gbContaBancaria.TabIndex = 88;
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
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Diretoria",
            "Secretaria",
            "Portaria",
            "Biblioteca",
            "Refeitorio"});
            this.cbCargo.Location = new System.Drawing.Point(143, 168);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(134, 26);
            this.cbCargo.TabIndex = 6;
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
            this.label10.Location = new System.Drawing.Point(81, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 79;
            this.label10.Text = "Cargo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 78;
            this.label7.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 77;
            this.label6.Text = "Nacionalidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Turno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 75;
            this.label3.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 74;
            this.label4.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 73;
            this.label2.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nome:";
            // 
            // tabControlFuncionarios
            // 
            this.tabControlFuncionarios.Controls.Add(this.tpFuncionario);
            this.tabControlFuncionarios.Controls.Add(this.tpEndereco);
            this.tabControlFuncionarios.Location = new System.Drawing.Point(3, 3);
            this.tabControlFuncionarios.Name = "tabControlFuncionarios";
            this.tabControlFuncionarios.SelectedIndex = 0;
            this.tabControlFuncionarios.Size = new System.Drawing.Size(1172, 354);
            this.tabControlFuncionarios.TabIndex = 0;
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
            this.label26.Size = new System.Drawing.Size(147, 18);
            this.label26.TabIndex = 17;
            this.label26.Text = "Buscar Funcionário:";
            // 
            // txtBuscarFuncionario
            // 
            this.txtBuscarFuncionario.Location = new System.Drawing.Point(157, 382);
            this.txtBuscarFuncionario.Name = "txtBuscarFuncionario";
            this.txtBuscarFuncionario.Size = new System.Drawing.Size(504, 26);
            this.txtBuscarFuncionario.TabIndex = 23;
            this.txtBuscarFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarFuncionario_KeyDown);
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeFuncionario,
            this.ColumnSexo,
            this.ColumnCEP,
            this.ColumnTurnoFuncionario,
            this.ColumnCargoFuncionario});
            this.dgvFuncionario.Location = new System.Drawing.Point(7, 414);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.Size = new System.Drawing.Size(1164, 188);
            this.dgvFuncionario.TabIndex = 15;
            this.dgvFuncionario.DoubleClick += new System.EventHandler(this.dgvFuncionario_DoubleClick);
            // 
            // ColumnNomeFuncionario
            // 
            this.ColumnNomeFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomeFuncionario.HeaderText = "Nome";
            this.ColumnNomeFuncionario.Name = "ColumnNomeFuncionario";
            this.ColumnNomeFuncionario.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // ColumnCEP
            // 
            this.ColumnCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCEP.HeaderText = "CEP";
            this.ColumnCEP.Name = "ColumnCEP";
            this.ColumnCEP.ReadOnly = true;
            // 
            // ColumnTurnoFuncionario
            // 
            this.ColumnTurnoFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTurnoFuncionario.HeaderText = "Turno";
            this.ColumnTurnoFuncionario.Name = "ColumnTurnoFuncionario";
            this.ColumnTurnoFuncionario.ReadOnly = true;
            // 
            // ColumnCargoFuncionario
            // 
            this.ColumnCargoFuncionario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCargoFuncionario.HeaderText = "Cargo";
            this.ColumnCargoFuncionario.Name = "ColumnCargoFuncionario";
            this.ColumnCargoFuncionario.ReadOnly = true;
            // 
            // usFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBuscarFuncionario);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.tabControlFuncionarios);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "usFuncionario";
            this.Size = new System.Drawing.Size(1178, 605);
            this.tpEndereco.ResumeLayout(false);
            this.tpEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCasa)).EndInit();
            this.tpFuncionario.ResumeLayout(false);
            this.tpFuncionario.PerformLayout();
            this.gbContaBancaria.ResumeLayout(false);
            this.gbContaBancaria.PerformLayout();
            this.tabControlFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        public System.Windows.Forms.ComboBox cbCargo;
        public System.Windows.Forms.ComboBox cbTurno;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabPage tpEndereco;
        public System.Windows.Forms.TabPage tpFuncionario;
        public System.Windows.Forms.TabControl tabControlFuncionarios;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtBuscarFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTurnoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargoFuncionario;
    }
}
