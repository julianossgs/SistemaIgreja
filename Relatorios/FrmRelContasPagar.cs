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
    public partial class FrmRelContasPagar : Form
    {
        public FrmRelContasPagar()
        {
            InitializeComponent();
        }

        private void FrmRelContasPagar_Load(object sender, EventArgs e)
        {
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
         
            Buscar();
        }

        //Método buscar por Datas e Tipo
        private void Buscar()
        {
            //recuperando parametros
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));

            

            this.buscarContasPagarTableAdapter.Fill(this.igrejaBatistaDataSet.BuscarContasPagar, Convert.ToString(dtInicial.Value), Convert.ToString(dtFinal.Value));

            this.reportViewer1.RefreshReport();
        }


        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
