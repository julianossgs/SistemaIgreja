using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Relatorios
{
    public partial class FrmRelDizimista : Form
    {
        public FrmRelDizimista()
        {
            InitializeComponent();
        }

        private void FrmRelDizimista_Load(object sender, EventArgs e)
        {

            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            BuscarMembros();

            this.reportViewer2.RefreshReport();
        }


        //Método de buscar por membro
        private void BuscarMembros()
        {

            //recuperando os parametros das datas
          
            this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInicial", dtInicial.Text));

            this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataFinal", dtFinal.Text));

            this.buscarMembrosTableAdapter.Fill (this.igrejaBatistaDataSet.buscarMembros,txtBuscarMembro.Text,dtInicial.Text,dtFinal.Text);

            this.reportViewer2.RefreshReport();
        }

       
        private void TxtBuscarMembro_TextChanged(object sender, EventArgs e)
        {
            BuscarMembros();
        }

        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarMembros();
        }

        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarMembros();
        }
    }
}
