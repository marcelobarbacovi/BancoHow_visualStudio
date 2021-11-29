namespace BancoHow
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
            this.Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbData_nascimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.Alterar = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbIDConta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbConta = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbAgencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTpConta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbidtransacao = new System.Windows.Forms.TextBox();
            this.tbContaTransacao = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbsaldotransacao = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.cbMovimento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAgencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(21, 31);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 16);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "cep";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "uf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "data";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(71, 31);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(58, 22);
            this.tbId.TabIndex = 5;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(71, 75);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(160, 22);
            this.tbNome.TabIndex = 6;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(71, 115);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(100, 22);
            this.tbCpf.TabIndex = 7;
            // 
            // tbData_nascimento
            // 
            this.tbData_nascimento.Location = new System.Drawing.Point(71, 155);
            this.tbData_nascimento.Name = "tbData_nascimento";
            this.tbData_nascimento.Size = new System.Drawing.Size(100, 22);
            this.tbData_nascimento.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "cpf";
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(71, 236);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(100, 22);
            this.tbCep.TabIndex = 11;
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Salvar.Location = new System.Drawing.Point(252, 24);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(76, 30);
            this.Salvar.TabIndex = 12;
            this.Salvar.Text = "salvar";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(926, 448);
            this.tabControl.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Yellow;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.cbUF);
            this.tabPage1.Controls.Add(this.Alterar);
            this.tabPage1.Controls.Add(this.delete);
            this.tabPage1.Controls.Add(this.tbNome);
            this.tabPage1.Controls.Add(this.Salvar);
            this.tabPage1.Controls.Add(this.Id);
            this.tabPage1.Controls.Add(this.tbCep);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbData_nascimento);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbCpf);
            this.tabPage1.Controls.Add(this.tbId);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de Clientes";
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC - ACRE",
            "AL - ALAGOAS",
            "AP - AMAPA",
            "AM- AMAZONAS",
            "BA - BAHIA",
            "CE- CEARA",
            "DF - DISTIRTO FERETAL",
            "ES - ESPIRITO SANTO",
            "GO - GOIAIS",
            "MA - MARANHÃO",
            "MT - MATO GROSSO",
            "MS - MATO GROSSO DO SUL",
            "MG - MINAS GERAIS",
            "PA - PARA",
            "PB - PARAIBA",
            "PR - PARANA",
            "PE- PERNAMBUCO",
            "PI - PIAIU",
            "RJ - RIO DE JANEIRO",
            "RN - RIO GRANDE DO NORTE",
            "RS - RIO GRANDE DO SUL",
            "RO - RONDONIA",
            "RR - RORAIMA",
            "SC - SANTA CATARINA",
            "SP - SAO PAULO",
            "SE - SERGIPE",
            "TO - TOCANTIS"});
            this.cbUF.Location = new System.Drawing.Point(71, 196);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(121, 24);
            this.cbUF.TabIndex = 16;
            // 
            // Alterar
            // 
            this.Alterar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Alterar.Location = new System.Drawing.Point(334, 24);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 30);
            this.Alterar.TabIndex = 15;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = false;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.MenuBar;
            this.delete.Location = new System.Drawing.Point(415, 24);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 30);
            this.delete.TabIndex = 14;
            this.delete.Text = "deletar";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Yellow;
            this.tabPage2.Controls.Add(this.tbIDConta);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tbTitular);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbConta);
            this.tabPage2.Controls.Add(this.tbSaldo);
            this.tabPage2.Controls.Add(this.tbAgencia);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbTpConta);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conta Bancaria";
            // 
            // tbIDConta
            // 
            this.tbIDConta.Location = new System.Drawing.Point(102, 27);
            this.tbIDConta.Name = "tbIDConta";
            this.tbIDConta.Size = new System.Drawing.Size(121, 22);
            this.tbIDConta.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Location = new System.Drawing.Point(322, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 14;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.alterarConta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Location = new System.Drawing.Point(322, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Desativar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(322, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CriarConta_Click);
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(102, 57);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(121, 22);
            this.tbTitular.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Titular";
            // 
            // tbConta
            // 
            this.tbConta.Location = new System.Drawing.Point(102, 174);
            this.tbConta.Name = "tbConta";
            this.tbConta.Size = new System.Drawing.Size(74, 22);
            this.tbConta.TabIndex = 9;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(102, 213);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(65, 22);
            this.tbSaldo.TabIndex = 8;
            // 
            // tbAgencia
            // 
            this.tbAgencia.Location = new System.Drawing.Point(102, 130);
            this.tbAgencia.Name = "tbAgencia";
            this.tbAgencia.Size = new System.Drawing.Size(74, 22);
            this.tbAgencia.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Saldo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nº da Conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Agência";
            // 
            // cbTpConta
            // 
            this.cbTpConta.FormattingEnabled = true;
            this.cbTpConta.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupança"});
            this.cbTpConta.Location = new System.Drawing.Point(102, 90);
            this.cbTpConta.Name = "cbTpConta";
            this.cbTpConta.Size = new System.Drawing.Size(121, 24);
            this.cbTpConta.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo de conta";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Yellow;
            this.tabPage4.Controls.Add(this.tbidtransacao);
            this.tabPage4.Controls.Add(this.tbContaTransacao);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.tbsaldotransacao);
            this.tabPage4.Controls.Add(this.tbValor);
            this.tabPage4.Controls.Add(this.cbMovimento);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(918, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transação";
            // 
            // tbidtransacao
            // 
            this.tbidtransacao.Location = new System.Drawing.Point(166, 274);
            this.tbidtransacao.Name = "tbidtransacao";
            this.tbidtransacao.Size = new System.Drawing.Size(100, 22);
            this.tbidtransacao.TabIndex = 11;
            // 
            // tbContaTransacao
            // 
            this.tbContaTransacao.Location = new System.Drawing.Point(166, 26);
            this.tbContaTransacao.Name = "tbContaTransacao";
            this.tbContaTransacao.Size = new System.Drawing.Size(100, 22);
            this.tbContaTransacao.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Conta";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(452, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Cancelar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(452, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Confirmar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(452, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(60, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Saldo";
            // 
            // tbsaldotransacao
            // 
            this.tbsaldotransacao.Location = new System.Drawing.Point(166, 202);
            this.tbsaldotransacao.Name = "tbsaldotransacao";
            this.tbsaldotransacao.Size = new System.Drawing.Size(100, 22);
            this.tbsaldotransacao.TabIndex = 4;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(166, 128);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 22);
            this.tbValor.TabIndex = 3;
            // 
            // cbMovimento
            // 
            this.cbMovimento.FormattingEnabled = true;
            this.cbMovimento.Items.AddRange(new object[] {
            "Depositar",
            "Sacar"});
            this.cbMovimento.Location = new System.Drawing.Point(166, 72);
            this.cbMovimento.Name = "cbMovimento";
            this.cbMovimento.Size = new System.Drawing.Size(121, 24);
            this.cbMovimento.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Valor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tipo de Movimento";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Yellow;
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.dtgrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(918, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Banco de dados";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(329, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(290, 34);
            this.label16.TabIndex = 14;
            this.label16.Text = "Tabela Banco de dados";
            // 
            // dtgrid
            // 
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNome,
            this.ColCpf,
            this.ColData,
            this.ColUf,
            this.ColCep,
            this.ColTitular,
            this.ColTipo,
            this.ColAgencia,
            this.ColConta,
            this.ColSaldo});
            this.dtgrid.Location = new System.Drawing.Point(14, 74);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.RowHeadersWidth = 51;
            this.dtgrid.RowTemplate.Height = 24;
            this.dtgrid.Size = new System.Drawing.Size(892, 257);
            this.dtgrid.TabIndex = 13;
            this.dtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "ID";
            this.ColId.HeaderText = "ID";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 50;
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.MinimumWidth = 6;
            this.ColNome.Name = "ColNome";
            this.ColNome.Width = 125;
            // 
            // ColCpf
            // 
            this.ColCpf.HeaderText = "cpf";
            this.ColCpf.MinimumWidth = 6;
            this.ColCpf.Name = "ColCpf";
            this.ColCpf.Width = 125;
            // 
            // ColData
            // 
            this.ColData.HeaderText = "Data Nascimento";
            this.ColData.MinimumWidth = 6;
            this.ColData.Name = "ColData";
            this.ColData.Width = 125;
            // 
            // ColUf
            // 
            this.ColUf.HeaderText = "UF";
            this.ColUf.MinimumWidth = 6;
            this.ColUf.Name = "ColUf";
            this.ColUf.Width = 50;
            // 
            // ColCep
            // 
            this.ColCep.HeaderText = "CEP";
            this.ColCep.MinimumWidth = 6;
            this.ColCep.Name = "ColCep";
            this.ColCep.Width = 125;
            // 
            // ColTitular
            // 
            this.ColTitular.HeaderText = "Titular";
            this.ColTitular.MinimumWidth = 6;
            this.ColTitular.Name = "ColTitular";
            this.ColTitular.Width = 125;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "TIpoConta";
            this.ColTipo.MinimumWidth = 6;
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.Width = 125;
            // 
            // ColAgencia
            // 
            this.ColAgencia.HeaderText = "Agencia";
            this.ColAgencia.MinimumWidth = 6;
            this.ColAgencia.Name = "ColAgencia";
            this.ColAgencia.Width = 125;
            // 
            // ColConta
            // 
            this.ColConta.HeaderText = "Conta";
            this.ColConta.MinimumWidth = 6;
            this.ColConta.Name = "ColConta";
            this.ColConta.Width = 125;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.MinimumWidth = 6;
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbData_nascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.TextBox tbConta;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.TextBox tbAgencia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTpConta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbIDConta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbsaldotransacao;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.ComboBox cbMovimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbContaTransacao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbidtransacao;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAgencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
    }
}

