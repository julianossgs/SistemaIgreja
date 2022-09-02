namespace WindowsFormsApp1.Relatorios
{
    partial class FrmRelDizimista
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.buscarMembrosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.igrejaBatistaDataSet = new WindowsFormsApp1.IgrejaBatistaDataSet();
            this.buscarMembrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buscarDizimistaMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarDizimistaAnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarDizimistaNomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarDizimistaMesTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.buscarDizimistaMesTableAdapter();
            this.buscarDizimistaAnoTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.buscarDizimistaAnoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarMembro = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buscarDizimistaNomeTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.buscarDizimistaNomeTableAdapter();
            this.buscarMembrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarMembrosTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.buscarMembrosTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.buscarMembrosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarMembrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDizimistaMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDizimistaAnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDizimistaNomeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarMembrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarMembrosBindingSource2
            // 
            this.buscarMembrosBindingSource2.DataMember = "buscarMembros";
            this.buscarMembrosBindingSource2.DataSource = this.igrejaBatistaDataSet;
            // 
            // igrejaBatistaDataSet
            // 
            this.igrejaBatistaDataSet.DataSetName = "IgrejaBatistaDataSet";
            this.igrejaBatistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarMembrosBindingSource1
            // 
            this.buscarMembrosBindingSource1.DataMember = "buscarMembros";
            this.buscarMembrosBindingSource1.DataSource = this.igrejaBatistaDataSet;
            // 
            // buscarDizimistaMesBindingSource
            // 
            this.buscarDizimistaMesBindingSource.DataMember = "buscarDizimistaMes";
            this.buscarDizimistaMesBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // buscarDizimistaAnoBindingSource
            // 
            this.buscarDizimistaAnoBindingSource.DataMember = "buscarDizimistaAno";
            this.buscarDizimistaAnoBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // buscarDizimistaNomeBindingSource
            // 
            this.buscarDizimistaNomeBindingSource.DataMember = "buscarDizimistaNome";
            this.buscarDizimistaNomeBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // buscarDizimistaMesTableAdapter
            // 
            this.buscarDizimistaMesTableAdapter.ClearBeforeFill = true;
            // 
            // buscarDizimistaAnoTableAdapter
            // 
            this.buscarDizimistaAnoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtFinal);
            this.panel1.Controls.Add(this.dtInicial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtBuscarMembro);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 100);
            this.panel1.TabIndex = 1;
            // 
            // dtFinal
            // 
            this.dtFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(530, 61);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(141, 22);
            this.dtFinal.TabIndex = 76;
            this.dtFinal.ValueChanged += new System.EventHandler(this.DtFinal_ValueChanged);
            // 
            // dtInicial
            // 
            this.dtInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(530, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(141, 22);
            this.dtInicial.TabIndex = 75;
            this.dtInicial.ValueChanged += new System.EventHandler(this.DtInicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Data Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Data Inicial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Dizimista";
            // 
            // txtBuscarMembro
            // 
            this.txtBuscarMembro.Location = new System.Drawing.Point(104, 62);
            this.txtBuscarMembro.Name = "txtBuscarMembro";
            this.txtBuscarMembro.Size = new System.Drawing.Size(229, 21);
            this.txtBuscarMembro.TabIndex = 21;
            this.txtBuscarMembro.TextChanged += new System.EventHandler(this.TxtBuscarMembro_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "CONSULTA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(99, -21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Consulta por Membro";
            // 
            // buscarDizimistaNomeTableAdapter
            // 
            this.buscarDizimistaNomeTableAdapter.ClearBeforeFill = true;
            // 
            // buscarMembrosBindingSource
            // 
            this.buscarMembrosBindingSource.DataMember = "buscarMembros";
            this.buscarMembrosBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // buscarMembrosTableAdapter
            // 
            this.buscarMembrosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DsMembros";
            reportDataSource1.Value = this.buscarMembrosBindingSource2;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Relatorios.RelDisimista.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 118);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(748, 508);
            this.reportViewer2.TabIndex = 2;
            // 
            // FrmRelDizimista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 651);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRelDizimista";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO MENSAL  DE DIZIMISTAS";
            this.Load += new System.EventHandler(this.FrmRelDizimista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscarMembrosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarMembrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDizimistaMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDizimistaAnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDizimistaNomeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarMembrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource buscarDizimistaMesBindingSource;
        private IgrejaBatistaDataSet igrejaBatistaDataSet;
        private System.Windows.Forms.BindingSource buscarDizimistaAnoBindingSource;
        private IgrejaBatistaDataSetTableAdapters.buscarDizimistaMesTableAdapter buscarDizimistaMesTableAdapter;
        private IgrejaBatistaDataSetTableAdapters.buscarDizimistaAnoTableAdapter buscarDizimistaAnoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource buscarDizimistaNomeBindingSource;
        private IgrejaBatistaDataSetTableAdapters.buscarDizimistaNomeTableAdapter buscarDizimistaNomeTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscarMembro;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
       // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscarMembrosBindingSource;
        private System.Windows.Forms.BindingSource buscarMembrosBindingSource1;
        private IgrejaBatistaDataSetTableAdapters.buscarMembrosTableAdapter buscarMembrosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource buscarMembrosBindingSource2;
    }
}