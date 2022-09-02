using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Relatorios
{
    public partial class FrmRelContasPagas : Form
    {
        public FrmRelContasPagas()
        {
            InitializeComponent();
        }

        private void FrmRelContasPagas_Load(object sender, EventArgs e)
        {
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            Buscar();
        } 

        private void Buscar()
        {
            //recuperando parametros
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));

            this.buscarContasPagasTableAdapter.Fill(this.igrejaBatistaDataSet.BuscarContasPagas,Convert.ToString(dtInicial.Text),Convert.ToString(dtFinal.Text));

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
