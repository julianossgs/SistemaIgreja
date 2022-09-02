
namespace WindowsFormsApp1.Relatorios
{
    partial class FrmRelCulto
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
            this.buscarCultosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejaBatistaDataSet = new WindowsFormsApp1.IgrejaBatistaDataSet();
            this.buscarDetalhesCultosIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buscarCultosTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.buscarCultosTableAdapter();
            this.buscarDetalhesCultosIdTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.buscarDetalhesCultosIdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.buscarCultosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDetalhesCultosIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarCultosBindingSource
            // 
            this.buscarCultosBindingSource.DataMember = "buscarCultos";
            this.buscarCultosBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // igrejaBatistaDataSet
            // 
            this.igrejaBatistaDataSet.DataSetName = "IgrejaBatistaDataSet";
            this.igrejaBatistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarDetalhesCultosIdBindingSource
            // 
            this.buscarDetalhesCultosIdBindingSource.DataMember = "buscarDetalhesCultosId";
            this.buscarDetalhesCultosIdBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "BuscarCultos";
            reportDataSource1.Value = this.buscarCultosBindingSource;
            reportDataSource2.Name = "BuscarDetalhesCultoId";
            reportDataSource2.Value = this.buscarDetalhesCultosIdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Relatorios.RelCulto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(683, 637);
            this.reportViewer1.TabIndex = 0;
            // 
            // buscarCultosTableAdapter
            // 
            this.buscarCultosTableAdapter.ClearBeforeFill = true;
            // 
            // buscarDetalhesCultosIdTableAdapter
            // 
            this.buscarDetalhesCultosIdTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelCulto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 661);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelCulto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DO CULTO";
            this.Load += new System.EventHandler(this.FrmRelCulto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buscarCultosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDetalhesCultosIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscarCultosBindingSource;
        private IgrejaBatistaDataSet igrejaBatistaDataSet;
        private System.Windows.Forms.BindingSource buscarDetalhesCultosIdBindingSource;
        private IgrejaBatistaDataSetTableAdapters.buscarCultosTableAdapter buscarCultosTableAdapter;
        private IgrejaBatistaDataSetTableAdapters.buscarDetalhesCultosIdTableAdapter buscarDetalhesCultosIdTableAdapter;
    }
}