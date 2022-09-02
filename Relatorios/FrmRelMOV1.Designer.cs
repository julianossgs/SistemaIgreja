namespace WindowsFormsApp1.Relatorios
{
    partial class FrmRelMOV1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.buscarDataTipoMovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejaBatistaDataSet = new WindowsFormsApp1.IgrejaBatistaDataSet();
            this.EntradasMovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaidasMovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.buscarDataTipoMovTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.BuscarDataTipoMovTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buscarDataTipoMovBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entradasMovBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entradasMovTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.EntradasMovTableAdapter();
            this.saidasMovBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.saidasMovTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.SaidasMovTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataTipoMovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasMovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaidasMovBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataTipoMovBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasMovBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasMovBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarDataTipoMovBindingSource
            // 
            this.buscarDataTipoMovBindingSource.DataMember = "BuscarDataTipoMov";
            this.buscarDataTipoMovBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // igrejaBatistaDataSet
            // 
            this.igrejaBatistaDataSet.DataSetName = "IgrejaBatistaDataSet";
            this.igrejaBatistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EntradasMovBindingSource
            // 
            this.EntradasMovBindingSource.DataMember = "EntradasMov";
            this.EntradasMovBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // SaidasMovBindingSource
            // 
            this.SaidasMovBindingSource.DataMember = "SaidasMov";
            this.SaidasMovBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtFinal);
            this.panel1.Controls.Add(this.dtInicial);
            this.panel1.Location = new System.Drawing.Point(73, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 100);
            this.panel1.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "CONSULTA POR DATAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Data Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Data Inicial";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(401, 62);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(160, 21);
            this.dtFinal.TabIndex = 21;
            this.dtFinal.ValueChanged += new System.EventHandler(this.dtFinal_ValueChanged);
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(401, 35);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(160, 21);
            this.dtInicial.TabIndex = 18;
            this.dtInicial.ValueChanged += new System.EventHandler(this.dtInicial_ValueChanged);
            // 
            // buscarDataTipoMovTableAdapter
            // 
            this.buscarDataTipoMovTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dataSetMOV";
            reportDataSource1.Value = this.buscarDataTipoMovBindingSource1;
            reportDataSource2.Name = "dataSetEntrada";
            reportDataSource2.Value = this.entradasMovBindingSource1;
            reportDataSource3.Name = "dataSetSaida";
            reportDataSource3.Value = this.saidasMovBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Relatorios.RelMOV4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(644, 531);
            this.reportViewer1.TabIndex = 27;
            // 
            // buscarDataTipoMovBindingSource1
            // 
            this.buscarDataTipoMovBindingSource1.DataMember = "BuscarDataTipoMov";
            this.buscarDataTipoMovBindingSource1.DataSource = this.igrejaBatistaDataSet;
            // 
            // entradasMovBindingSource1
            // 
            this.entradasMovBindingSource1.DataMember = "EntradasMov";
            this.entradasMovBindingSource1.DataSource = this.igrejaBatistaDataSet;
            // 
            // entradasMovTableAdapter
            // 
            this.entradasMovTableAdapter.ClearBeforeFill = true;
            // 
            // saidasMovBindingSource1
            // 
            this.saidasMovBindingSource1.DataMember = "SaidasMov";
            this.saidasMovBindingSource1.DataSource = this.igrejaBatistaDataSet;
            // 
            // saidasMovTableAdapter
            // 
            this.saidasMovTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelMOV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 661);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRelMOV1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMENTO DO CAIXA";
            this.Load += new System.EventHandler(this.FrmRelMOV1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataTipoMovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradasMovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaidasMovBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataTipoMovBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasMovBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasMovBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource buscarDataTipoMovBindingSource;
        private IgrejaBatistaDataSet igrejaBatistaDataSet;
        private IgrejaBatistaDataSetTableAdapters.BuscarDataTipoMovTableAdapter buscarDataTipoMovTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.BindingSource EntradasMovBindingSource;
        private System.Windows.Forms.BindingSource SaidasMovBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscarDataTipoMovBindingSource1;
        private System.Windows.Forms.BindingSource entradasMovBindingSource1;
        private System.Windows.Forms.BindingSource saidasMovBindingSource1;
        private IgrejaBatistaDataSetTableAdapters.EntradasMovTableAdapter entradasMovTableAdapter;
        private IgrejaBatistaDataSetTableAdapters.SaidasMovTableAdapter saidasMovTableAdapter;
    }
}