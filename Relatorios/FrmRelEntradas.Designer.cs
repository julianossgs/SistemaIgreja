namespace WindowsFormsApp1.Relatorios
{
    partial class FrmRelEntradas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFinalBuscar = new System.Windows.Forms.DateTimePicker();
            this.dtInicialBuscar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.igrejaBatistaDataSet = new WindowsFormsApp1.IgrejaBatistaDataSet();
            this.buscarEntradasDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarEntradasDataTableAdapter = new WindowsFormsApp1.IgrejaBatistaDataSetTableAdapters.BuscarEntradasDataTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarEntradasDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFinalBuscar);
            this.panel1.Controls.Add(this.dtInicialBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(70, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 100);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "CONSULTA ENTRE DATAS";
            // 
            // dtFinalBuscar
            // 
            this.dtFinalBuscar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinalBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinalBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinalBuscar.Location = new System.Drawing.Point(419, 56);
            this.dtFinalBuscar.Name = "dtFinalBuscar";
            this.dtFinalBuscar.Size = new System.Drawing.Size(141, 22);
            this.dtFinalBuscar.TabIndex = 76;
            this.dtFinalBuscar.ValueChanged += new System.EventHandler(this.DtFinalBuscar_ValueChanged);
            // 
            // dtInicialBuscar
            // 
            this.dtInicialBuscar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicialBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicialBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicialBuscar.Location = new System.Drawing.Point(419, 14);
            this.dtInicialBuscar.Name = "dtInicialBuscar";
            this.dtInicialBuscar.Size = new System.Drawing.Size(141, 22);
            this.dtInicialBuscar.TabIndex = 75;
            this.dtInicialBuscar.ValueChanged += new System.EventHandler(this.DtInicialBuscar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Data Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Data Inicial";
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
            // reportViewer1
            // 
            reportDataSource1.Name = "BuscarEntradasData";
            reportDataSource1.Value = this.buscarEntradasDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Relatorios.RelEntradas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(36, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(652, 519);
            this.reportViewer1.TabIndex = 4;
            // 
            // igrejaBatistaDataSet
            // 
            this.igrejaBatistaDataSet.DataSetName = "IgrejaBatistaDataSet";
            this.igrejaBatistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarEntradasDataBindingSource
            // 
            this.buscarEntradasDataBindingSource.DataMember = "BuscarEntradasData";
            this.buscarEntradasDataBindingSource.DataSource = this.igrejaBatistaDataSet;
            // 
            // buscarEntradasDataTableAdapter
            // 
            this.buscarEntradasDataTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRelEntradas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO DE ENTRADAS";
            this.Load += new System.EventHandler(this.FrmRelEntradas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.igrejaBatistaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarEntradasDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFinalBuscar;
        private System.Windows.Forms.DateTimePicker dtInicialBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource buscarEntradasDataBindingSource;
        private IgrejaBatistaDataSet igrejaBatistaDataSet;
        private IgrejaBatistaDataSetTableAdapters.BuscarEntradasDataTableAdapter buscarEntradasDataTableAdapter;
    }
}