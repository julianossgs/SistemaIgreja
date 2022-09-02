namespace WindowsFormsApp1.Formularios
{
    partial class frmMembros1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btExcluir1 = new System.Windows.Forms.Button();
            this.btRemoverImagem = new System.Windows.Forms.Button();
            this.btAddImagem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cBCargo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskCEP = new System.Windows.Forms.MaskedTextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.dtMembro = new System.Windows.Forms.DateTimePicker();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pBImagem = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskTel2 = new System.Windows.Forms.MaskedTextBox();
            this.maskTel1 = new System.Windows.Forms.MaskedTextBox();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.maskBuscar = new System.Windows.Forms.MaskedTextBox();
            this.rBBsucarCPF = new System.Windows.Forms.RadioButton();
            this.rBBuscarNome = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagem)).BeginInit();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastro);
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabCadastro.Controls.Add(this.btRelatorio);
            this.tabCadastro.Controls.Add(this.btExcluir1);
            this.tabCadastro.Controls.Add(this.btRemoverImagem);
            this.tabCadastro.Controls.Add(this.btAddImagem);
            this.tabCadastro.Controls.Add(this.label12);
            this.tabCadastro.Controls.Add(this.cBCargo);
            this.tabCadastro.Controls.Add(this.label11);
            this.tabCadastro.Controls.Add(this.maskCEP);
            this.tabCadastro.Controls.Add(this.btEditar);
            this.tabCadastro.Controls.Add(this.btSalvar);
            this.tabCadastro.Controls.Add(this.btNovo);
            this.tabCadastro.Controls.Add(this.dtMembro);
            this.tabCadastro.Controls.Add(this.dtNascimento);
            this.tabCadastro.Controls.Add(this.label10);
            this.tabCadastro.Controls.Add(this.label9);
            this.tabCadastro.Controls.Add(this.pBImagem);
            this.tabCadastro.Controls.Add(this.label8);
            this.tabCadastro.Controls.Add(this.label7);
            this.tabCadastro.Controls.Add(this.maskTel2);
            this.tabCadastro.Controls.Add(this.maskTel1);
            this.tabCadastro.Controls.Add(this.maskCPF);
            this.tabCadastro.Controls.Add(this.label6);
            this.tabCadastro.Controls.Add(this.txtEstado);
            this.tabCadastro.Controls.Add(this.label5);
            this.tabCadastro.Controls.Add(this.txtCidade);
            this.tabCadastro.Controls.Add(this.label4);
            this.tabCadastro.Controls.Add(this.txtBairro);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.txtEndereco);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Controls.Add(this.txtNome);
            this.tabCadastro.Controls.Add(this.label1);
            this.tabCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(1013, 474);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "CADASTRO DE MEMBROS";
            // 
            // btRelatorio
            // 
            this.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorio.Location = new System.Drawing.Point(715, 424);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(129, 34);
            this.btRelatorio.TabIndex = 50;
            this.btRelatorio.Text = "Imprimir";
            this.toolTip1.SetToolTip(this.btRelatorio, "Relatório");
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.BtRelatorio_Click);
            // 
            // btExcluir1
            // 
            this.btExcluir1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir1.Enabled = false;
            this.btExcluir1.Location = new System.Drawing.Point(580, 424);
            this.btExcluir1.Name = "btExcluir1";
            this.btExcluir1.Size = new System.Drawing.Size(129, 34);
            this.btExcluir1.TabIndex = 49;
            this.btExcluir1.Text = "Excluir";
            this.toolTip1.SetToolTip(this.btExcluir1, "Excluir");
            this.btExcluir1.UseVisualStyleBackColor = true;
            this.btExcluir1.Click += new System.EventHandler(this.BtExcluir1_Click);
            // 
            // btRemoverImagem
            // 
            this.btRemoverImagem.BackColor = System.Drawing.Color.Gainsboro;
            this.btRemoverImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemoverImagem.Enabled = false;
            this.btRemoverImagem.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_jee01_27_2184671;
            this.btRemoverImagem.Location = new System.Drawing.Point(893, 112);
            this.btRemoverImagem.Name = "btRemoverImagem";
            this.btRemoverImagem.Size = new System.Drawing.Size(51, 42);
            this.btRemoverImagem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btRemoverImagem, "Remover Imagem");
            this.btRemoverImagem.UseVisualStyleBackColor = false;
            this.btRemoverImagem.Click += new System.EventHandler(this.BtRemoverImagem_Click);
            // 
            // btAddImagem
            // 
            this.btAddImagem.BackColor = System.Drawing.Color.Gainsboro;
            this.btAddImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddImagem.Enabled = false;
            this.btAddImagem.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_jee01_26_2184672;
            this.btAddImagem.Location = new System.Drawing.Point(893, 21);
            this.btAddImagem.Name = "btAddImagem";
            this.btAddImagem.Size = new System.Drawing.Size(51, 42);
            this.btAddImagem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btAddImagem, "Inserir Imagem");
            this.btAddImagem.UseVisualStyleBackColor = false;
            this.btAddImagem.Click += new System.EventHandler(this.BtAddImagem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(617, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "Cargo";
            // 
            // cBCargo
            // 
            this.cBCargo.Enabled = false;
            this.cBCargo.FormattingEnabled = true;
            this.cBCargo.Location = new System.Drawing.Point(664, 323);
            this.cBCargo.Name = "cBCargo";
            this.cBCargo.Size = new System.Drawing.Size(150, 23);
            this.cBCargo.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Cep";
            // 
            // maskCEP
            // 
            this.maskCEP.Enabled = false;
            this.maskCEP.Location = new System.Drawing.Point(585, 180);
            this.maskCEP.Mask = "99999999";
            this.maskCEP.Name = "maskCEP";
            this.maskCEP.Size = new System.Drawing.Size(72, 21);
            this.maskCEP.TabIndex = 5;
            // 
            // btEditar
            // 
            this.btEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(445, 424);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(129, 34);
            this.btEditar.TabIndex = 0;
            this.btEditar.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btEditar, "Editar");
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(310, 424);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(129, 34);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.toolTip1.SetToolTip(this.btSalvar, "Salvar");
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovo.Location = new System.Drawing.Point(175, 424);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(129, 34);
            this.btNovo.TabIndex = 42;
            this.btNovo.Text = "Novo Cadastro";
            this.toolTip1.SetToolTip(this.btNovo, "Iniciar Novo Cadastro");
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // dtMembro
            // 
            this.dtMembro.Enabled = false;
            this.dtMembro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMembro.Location = new System.Drawing.Point(402, 326);
            this.dtMembro.Name = "dtMembro";
            this.dtMembro.Size = new System.Drawing.Size(125, 21);
            this.dtMembro.TabIndex = 10;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Enabled = false;
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(148, 326);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(116, 21);
            this.dtNascimento.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Membro desde";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Data de Nascimento";
            // 
            // pBImagem
            // 
            this.pBImagem.Location = new System.Drawing.Point(755, 21);
            this.pBImagem.Name = "pBImagem";
            this.pBImagem.Size = new System.Drawing.Size(119, 133);
            this.pBImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImagem.TabIndex = 37;
            this.pBImagem.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefone";
            // 
            // maskTel2
            // 
            this.maskTel2.Enabled = false;
            this.maskTel2.Location = new System.Drawing.Point(404, 274);
            this.maskTel2.Mask = "(99)99999-9999";
            this.maskTel2.Name = "maskTel2";
            this.maskTel2.Size = new System.Drawing.Size(126, 21);
            this.maskTel2.TabIndex = 8;
            // 
            // maskTel1
            // 
            this.maskTel1.Enabled = false;
            this.maskTel1.Location = new System.Drawing.Point(82, 273);
            this.maskTel1.Mask = "(99)99999-9999";
            this.maskTel1.Name = "maskTel1";
            this.maskTel1.Size = new System.Drawing.Size(126, 21);
            this.maskTel1.TabIndex = 7;
            // 
            // maskCPF
            // 
            this.maskCPF.Enabled = false;
            this.maskCPF.Location = new System.Drawing.Point(83, 227);
            this.maskCPF.Mask = "000.000.000-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(126, 21);
            this.maskCPF.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "CPF";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(453, 180);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(40, 21);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(82, 180);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(267, 21);
            this.txtCidade.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(82, 133);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(267, 21);
            this.txtBairro.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(82, 86);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(267, 21);
            this.txtEndereco.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Endereço";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(82, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 21);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // tabConsulta
            // 
            this.tabConsulta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabConsulta.Controls.Add(this.grid);
            this.tabConsulta.Controls.Add(this.panel1);
            this.tabConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(1013, 474);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "CONSULTA DE MEMBROS";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(29, 132);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 70;
            this.grid.Size = new System.Drawing.Size(944, 318);
            this.grid.TabIndex = 3;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellDoubleClick);
            this.grid.DoubleClick += new System.EventHandler(this.Grid_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.maskBuscar);
            this.panel1.Controls.Add(this.rBBsucarCPF);
            this.panel1.Controls.Add(this.rBBuscarNome);
            this.panel1.Location = new System.Drawing.Point(690, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 84);
            this.panel1.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(19, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(154, 21);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // maskBuscar
            // 
            this.maskBuscar.Location = new System.Drawing.Point(19, 38);
            this.maskBuscar.Name = "maskBuscar";
            this.maskBuscar.Size = new System.Drawing.Size(154, 21);
            this.maskBuscar.TabIndex = 2;
            this.maskBuscar.TextChanged += new System.EventHandler(this.MaskBuscar_TextChanged);
            // 
            // rBBsucarCPF
            // 
            this.rBBsucarCPF.AutoSize = true;
            this.rBBsucarCPF.Location = new System.Drawing.Point(151, 13);
            this.rBBsucarCPF.Name = "rBBsucarCPF";
            this.rBBsucarCPF.Size = new System.Drawing.Size(48, 19);
            this.rBBsucarCPF.TabIndex = 1;
            this.rBBsucarCPF.TabStop = true;
            this.rBBsucarCPF.Text = "CPF";
            this.rBBsucarCPF.UseVisualStyleBackColor = true;
            this.rBBsucarCPF.CheckedChanged += new System.EventHandler(this.RBBsucarCPF_CheckedChanged);
            // 
            // rBBuscarNome
            // 
            this.rBBuscarNome.AutoSize = true;
            this.rBBuscarNome.Location = new System.Drawing.Point(19, 13);
            this.rBBuscarNome.Name = "rBBuscarNome";
            this.rBBuscarNome.Size = new System.Drawing.Size(72, 19);
            this.rBBuscarNome.TabIndex = 0;
            this.rBBuscarNome.TabStop = true;
            this.rBBuscarNome.Text = "Membro";
            this.rBBuscarNome.UseVisualStyleBackColor = true;
            this.rBBuscarNome.CheckedChanged += new System.EventHandler(this.RBBuscarNome_CheckedChanged);
            // 
            // frmMembros1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1064, 531);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMembros1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE MEMBROS";
            this.Load += new System.EventHandler(this.FrmMembros1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagem)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.DateTimePicker dtMembro;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pBImagem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskTel2;
        private System.Windows.Forms.MaskedTextBox maskTel1;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.MaskedTextBox maskBuscar;
        private System.Windows.Forms.RadioButton rBBsucarCPF;
        private System.Windows.Forms.RadioButton rBBuscarNome;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskCEP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cBCargo;
        private System.Windows.Forms.Button btAddImagem;
        private System.Windows.Forms.Button btRemoverImagem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btExcluir1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button btRelatorio;
    }
}