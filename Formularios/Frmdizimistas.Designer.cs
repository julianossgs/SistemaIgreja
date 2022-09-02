namespace WindowsFormsApp1.Formularios
{
    partial class Frmdizimistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMembro = new System.Windows.Forms.TextBox();
            this.gridDizimista = new System.Windows.Forms.DataGridView();
            this.IdDiz1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dizimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfertaEspecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Membro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Culto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDizimou = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOferta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtBuscarMembro = new System.Windows.Forms.TextBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOfertasEspeciais = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDizimos = new System.Windows.Forms.Label();
            this.lblOfertas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOfertaEspecial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDizimista)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dizimista";
            // 
            // txtMembro
            // 
            this.txtMembro.Enabled = false;
            this.txtMembro.Location = new System.Drawing.Point(103, 129);
            this.txtMembro.Name = "txtMembro";
            this.txtMembro.Size = new System.Drawing.Size(343, 20);
            this.txtMembro.TabIndex = 0;
            // 
            // gridDizimista
            // 
            this.gridDizimista.AllowUserToAddRows = false;
            this.gridDizimista.AllowUserToDeleteRows = false;
            this.gridDizimista.AllowUserToOrderColumns = true;
            this.gridDizimista.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.gridDizimista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDizimista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDizimista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDiz1,
            this.Data,
            this.Nome,
            this.Dizimo,
            this.Oferta,
            this.OfertaEspecial,
            this.Total,
            this.Id_Membro,
            this.Id_Culto});
            this.gridDizimista.Location = new System.Drawing.Point(18, 220);
            this.gridDizimista.MultiSelect = false;
            this.gridDizimista.Name = "gridDizimista";
            this.gridDizimista.ReadOnly = true;
            this.gridDizimista.RowTemplate.Height = 26;
            this.gridDizimista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDizimista.Size = new System.Drawing.Size(815, 220);
            this.gridDizimista.TabIndex = 44;
            this.gridDizimista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDizimista_CellClick);
            // 
            // IdDiz1
            // 
            this.IdDiz1.DataPropertyName = "IdDiz";
            dataGridViewCellStyle1.Format = "#,##0";
            this.IdDiz1.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdDiz1.HeaderText = "IdDiz";
            this.IdDiz1.Name = "IdDiz1";
            this.IdDiz1.ReadOnly = true;
            this.IdDiz1.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Width = 90;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Membro";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 260;
            // 
            // Dizimo
            // 
            this.Dizimo.DataPropertyName = "Dizimo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Dizimo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dizimo.HeaderText = "Dizimo";
            this.Dizimo.Name = "Dizimo";
            this.Dizimo.ReadOnly = true;
            this.Dizimo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Oferta
            // 
            this.Oferta.DataPropertyName = "Oferta";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Oferta.DefaultCellStyle = dataGridViewCellStyle4;
            this.Oferta.HeaderText = "Oferta";
            this.Oferta.Name = "Oferta";
            this.Oferta.ReadOnly = true;
            this.Oferta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Oferta.Width = 90;
            // 
            // OfertaEspecial
            // 
            this.OfertaEspecial.DataPropertyName = "OfertaEspecial";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.OfertaEspecial.DefaultCellStyle = dataGridViewCellStyle5;
            this.OfertaEspecial.HeaderText = "Oferta Especial";
            this.OfertaEspecial.Name = "OfertaEspecial";
            this.OfertaEspecial.ReadOnly = true;
            this.OfertaEspecial.Width = 110;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.Width = 110;
            // 
            // Id_Membro
            // 
            this.Id_Membro.DataPropertyName = "Id_Membro";
            this.Id_Membro.HeaderText = "Id_Membro";
            this.Id_Membro.Name = "Id_Membro";
            this.Id_Membro.ReadOnly = true;
            this.Id_Membro.Visible = false;
            // 
            // Id_Culto
            // 
            this.Id_Culto.DataPropertyName = "Id_Culto";
            this.Id_Culto.HeaderText = "Id_Culto";
            this.Id_Culto.Name = "Id_Culto";
            this.Id_Culto.ReadOnly = true;
            this.Id_Culto.Visible = false;
            // 
            // txtDizimou
            // 
            this.txtDizimou.Enabled = false;
            this.txtDizimou.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDizimou.Location = new System.Drawing.Point(103, 175);
            this.txtDizimou.Name = "txtDizimou";
            this.txtDizimou.Size = new System.Drawing.Size(96, 24);
            this.txtDizimou.TabIndex = 5;
            this.txtDizimou.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Dizimo";
            // 
            // txtOferta
            // 
            this.txtOferta.Enabled = false;
            this.txtOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOferta.Location = new System.Drawing.Point(291, 175);
            this.txtOferta.Name = "txtOferta";
            this.txtOferta.Size = new System.Drawing.Size(96, 24);
            this.txtOferta.TabIndex = 6;
            this.txtOferta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Oferta";
            // 
            // txtBuscarMembro
            // 
            this.txtBuscarMembro.Location = new System.Drawing.Point(61, 41);
            this.txtBuscarMembro.Name = "txtBuscarMembro";
            this.txtBuscarMembro.Size = new System.Drawing.Size(229, 20);
            this.txtBuscarMembro.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBuscarMembro, "Informe o nome do Membro para a consulta");
            this.txtBuscarMembro.TextChanged += new System.EventHandler(this.TxtBuscarMembro_TextChanged);
            // 
            // btRelatorio
            // 
            this.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelatorio.Location = new System.Drawing.Point(18, 450);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(127, 31);
            this.btRelatorio.TabIndex = 0;
            this.btRelatorio.Text = "Imprimir";
            this.toolTip1.SetToolTip(this.btRelatorio, "Relatório");
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.BtRelatorio_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(710, 175);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 24);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 65;
            this.label8.Text = "Ofertas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 66;
            this.label9.Text = "Dizimos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 67;
            this.label10.Text = "TOTAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblOfertasEspeciais);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblDizimos);
            this.panel1.Controls.Add(this.lblOfertas);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(594, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 139);
            this.panel1.TabIndex = 68;
            // 
            // lblOfertasEspeciais
            // 
            this.lblOfertasEspeciais.AutoSize = true;
            this.lblOfertasEspeciais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfertasEspeciais.Location = new System.Drawing.Point(134, 79);
            this.lblOfertasEspeciais.Name = "lblOfertasEspeciais";
            this.lblOfertasEspeciais.Size = new System.Drawing.Size(15, 16);
            this.lblOfertasEspeciais.TabIndex = 72;
            this.lblOfertasEspeciais.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 15);
            this.label16.TabIndex = 71;
            this.label16.Text = "Oferta Especial";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(134, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 16);
            this.lblTotal.TabIndex = 70;
            this.lblTotal.Text = "0";
            // 
            // lblDizimos
            // 
            this.lblDizimos.AutoSize = true;
            this.lblDizimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDizimos.Location = new System.Drawing.Point(134, 17);
            this.lblDizimos.Name = "lblDizimos";
            this.lblDizimos.Size = new System.Drawing.Size(15, 16);
            this.lblDizimos.TabIndex = 69;
            this.lblDizimos.Text = "0";
            // 
            // lblOfertas
            // 
            this.lblOfertas.AutoSize = true;
            this.lblOfertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfertas.Location = new System.Drawing.Point(134, 48);
            this.lblOfertas.Name = "lblOfertas";
            this.lblOfertas.Size = new System.Drawing.Size(15, 16);
            this.lblOfertas.TabIndex = 68;
            this.lblOfertas.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtFinal);
            this.panel2.Controls.Add(this.dtInicial);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtBuscarMembro);
            this.panel2.Location = new System.Drawing.Point(18, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 91);
            this.panel2.TabIndex = 69;
            // 
            // dtFinal
            // 
            this.dtFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(629, 37);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(141, 22);
            this.dtFinal.TabIndex = 72;
            this.dtFinal.ValueChanged += new System.EventHandler(this.DtFinal_ValueChanged);
            // 
            // dtInicial
            // 
            this.dtInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(403, 37);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(141, 22);
            this.dtInicial.TabIndex = 71;
            this.dtInicial.ValueChanged += new System.EventHandler(this.DtInicial_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(400, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "Consulta por Datas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(568, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Data Final";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Data Inicial";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Consulta por Dizimista";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Membro";
            // 
            // txtOfertaEspecial
            // 
            this.txtOfertaEspecial.Enabled = false;
            this.txtOfertaEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfertaEspecial.Location = new System.Drawing.Point(525, 175);
            this.txtOfertaEspecial.Name = "txtOfertaEspecial";
            this.txtOfertaEspecial.Size = new System.Drawing.Size(96, 24);
            this.txtOfertaEspecial.TabIndex = 71;
            this.txtOfertaEspecial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 72;
            this.label3.Text = "Oferta Especial";
            // 
            // Frmdizimistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(864, 651);
            this.Controls.Add(this.txtOfertaEspecial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.txtOferta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDizimou);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridDizimista);
            this.Controls.Add(this.txtMembro);
            this.Controls.Add(this.label1);
            this.Name = "Frmdizimistas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE DIZIMISTAS";
            this.Activated += new System.EventHandler(this.Frmdizimistas_Activated);
            this.Load += new System.EventHandler(this.Frmdizimistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDizimista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMembro;
        private System.Windows.Forms.DataGridView gridDizimista;
        private System.Windows.Forms.TextBox txtDizimou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOferta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDizimos;
        private System.Windows.Forms.Label lblOfertas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscarMembro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.TextBox txtOfertaEspecial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOfertasEspeciais;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiz1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dizimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfertaEspecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Membro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Culto;
    }
}