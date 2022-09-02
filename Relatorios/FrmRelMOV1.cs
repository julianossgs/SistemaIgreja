using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Relatorios
{
    public partial class FrmRelMOV1 : Form
    {
        public FrmRelMOV1()
        {
            InitializeComponent();
        }

        private void FrmRelMOV1_Load(object sender, EventArgs e)
        {
            
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            Buscar();

        }

        private void Buscar()
        {
          
                //recuperando os parametros
               this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));

                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));

            //passando os tableAdapters
            this.entradasMovTableAdapter.Fill(this.igrejaBatistaDataSet.EntradasMov,Convert.ToString(dtInicial.Text),Convert.ToString(dtFinal.Text));

            this.saidasMovTableAdapter.Fill(this.igrejaBatistaDataSet.SaidasMov, Convert.ToString(dtInicial.Text), Convert.ToString(dtFinal.Text));

            this.buscarDataTipoMovTableAdapter.Fill(this.igrejaBatistaDataSet.BuscarDataTipoMov, Convert.ToString(dtInicial.Text), Convert.ToString(dtFinal.Text));

                this.reportViewer1.RefreshReport();
          
        }

        private void dtInicial_ValueChanged(object sender, EventArgs e)
        {
           
            Buscar();
            
        }

        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

    }
}
