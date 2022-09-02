namespace WindowsFormsApp1.Formularios
{
    partial class FrmCadastroTipoCultos
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
            this.gridTipoCulto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Culto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoCulto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoCulto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTipoCulto
            // 
            this.gridTipoCulto.AllowUserToAddRows = false;
            this.gridTipoCulto.AllowUserToDeleteRows = false;
            this.gridTipoCulto.AllowUserToOrderColumns = true;
            this.gridTipoCulto.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.gridTipoCulto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTipoCulto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipoCulto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Culto});
            this.gridTipoCulto.Location = new System.Drawing.Point(47, 99);
            this.gridTipoCulto.MultiSelect = false;
            this.gridTipoCulto.Name = "gridTipoCulto";
            this.gridTipoCulto.ReadOnly = true;
            this.gridTipoCulto.RowTemplate.Height = 26;
            this.gridTipoCulto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTipoCulto.Size = new System.Drawing.Size(347, 307);
            this.gridTipoCulto.TabIndex = 18;
            this.gridTipoCulto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTipoCulto_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdTipoCulto";
            dataGridViewCellStyle1.Format = "#,##0";
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "IdTipoCulto";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Culto
            // 
            this.Culto.DataPropertyName = "TipoCulto";
            this.Culto.HeaderText = "Culto";
            this.Culto.Name = "Culto";
            this.Culto.ReadOnly = true;
            this.Culto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Culto.Width = 300;
            // 
            // txtTipoCulto
            // 
            this.txtTipoCulto.Enabled = false;
            this.txtTipoCulto.Location = new System.Drawing.Point(139, 49);
            this.txtTipoCulto.Name = "txtTipoCulto";
            this.txtTipoCulto.Size = new System.Drawing.Size(255, 21);
            this.txtTipoCulto.TabIndex = 17;
            this.txtTipoCulto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de Culto";
            // 
            // btExcluir
            // 
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.Enabled = false;
            this.btExcluir.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_button_delete_blue_14750;
            this.btExcluir.Location = new System.Drawing.Point(409, 292);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(60, 48);
            this.btExcluir.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btExcluir, "Excluir");
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.Enabled = false;
            this.btSalvar.Image = global::WindowsFormsApp1.Properties.Resources.salvar_32x32;
            this.btSalvar.Location = new System.Drawing.Point(409, 221);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(60, 48);
            this.btSalvar.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btSalvar, "Salvar");
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovo.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_list_add_118777__1_;
            this.btNovo.Location = new System.Drawing.Point(409, 158);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(60, 44);
            this.btNovo.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btNovo, "Inserir Culto");
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // FrmCadastroTipoCultos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(519, 431);
            this.Controls.Add(this.gridTipoCulto);
            this.Controls.Add(this.txtTipoCulto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btNovo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmCadastroTipoCultos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE CULTOS";
            this.Load += new System.EventHandler(this.FrmCadastroTipoCultos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoCulto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTipoCulto;
        private System.Windows.Forms.TextBox txtTipoCulto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Culto;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}