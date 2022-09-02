namespace WindowsFormsApp1.Relatorios
{
    partial class FrmRelMembros
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
            this.tblMembrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejaBatistaDataSet = new WindowsFormsApp1.IgrejaBatistaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblMembrosTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.TblMembrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblMembrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMembrosBindingSource
            // 
            this.tblMembrosBindingSource.DataMember = "TblMembros";
            this.tblMembrosBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // igrejaBatistaDataSet
            // 
            this.igrejaBatistaDataSet.DataSetName = "IgrejaBatistaDataSet";
            this.igrejaBatistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSMembros";
            reportDataSource1.Value = this.tblMembrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Relatorios.RelMembros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblMembrosTableAdapter
            // 
            this.tblMembrosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelMembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRelMembros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE MEMBROS";
            this.Load += new System.EventHandler(this.FrmRelMembros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMembrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private IgrejaBatistaDataSet igrejaBatistaDataSet;
        private System.Windows.Forms.BindingSource tblMembrosBindingSource;
        private IgrejaBatistaDataSetTableAdapters.TblMembrosTableAdapter tblMembrosTableAdapter;
    }
}