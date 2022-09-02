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
    public partial class FrmRelEntradas : Form
    {
        public FrmRelEntradas()
        {
            InitializeComponent();
        }

        private void FrmRelEntradas_Load(object sender, EventArgs e)
        {
            dtInicialBuscar.Value = DateTime.Today;
            dtFinalBuscar.Value = DateTime.Today;
            BuscarTudo();
        }

        //Método de buscar por datas e tipo de cultos
        private void BuscarTudo()
        {
            //recuperando os parametros das datas
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicialBuscar.Text));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinalBuscar.Text));

            this.buscarEntradasDataTableAdapter.Fill(this.igrejaBatistaDataSet.BuscarEntradasData, dtInicialBuscar.Text, dtFinalBuscar.Text);
            this.reportViewer1.RefreshReport();

        }

        private void DtInicialBuscar_ValueChanged(object sender, EventArgs e)
        {
            BuscarTudo();
        }

        private void DtFinalBuscar_ValueChanged(object sender, EventArgs e)
        {
            BuscarTudo();
        }
    }
}
