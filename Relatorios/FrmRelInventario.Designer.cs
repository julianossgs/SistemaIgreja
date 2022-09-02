
namespace WindowsFormsApp1.Relatorios
{
    partial class FrmRelInventario
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.igrejaBatistaDataSet = new WindowsFormsApp1.IgrejaBatistaDataSet();
            this.listarInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarInventarioTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.ListarInventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarInventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ListarInventario";
            reportDataSource1.Value = this.listarInventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Relatorios.RelInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(994, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // igrejaBatistaDataSet
            // 
            this.igrejaBatistaDataSet.DataSetName = "IgrejaBatistaDataSet";
            this.igrejaBatistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarInventarioBindingSource
            // 
            this.listarInventarioBindingSource.DataMember = "ListarInventario";
            this.listarInventarioBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // listarInventarioTableAdapter
            // 
            this.listarInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelInventario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENTÁRIO";
            this.Load += new System.EventHandler(this.FrmRelInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarInventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private IgrejaBatistaDataSet igrejaBatistaDataSet;
        private System.Windows.Forms.BindingSource listarInventarioBindingSource;
        private IgrejaBatistaDataSetTableAdapters.ListarInventarioTableAdapter listarInventarioTableAdapter;
    }
}