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
    public partial class FrmRelCulto : Form
    {
        public FrmRelCulto()
        {
            InitializeComponent();
        }

        private void FrmRelCulto_Load(object sender, EventArgs e)
        {
            this.buscarCultosTableAdapter.Fill(this.igrejaBatistaDataSet.buscarCultos, Convert.ToInt32(Program.idCULTO));

            this.buscarDetalhesCultosIdTableAdapter.Fill(this.igrejaBatistaDataSet.buscarDetalhesCultosId, Convert.ToInt32(Program.idCULTO));
            this.reportViewer1.RefreshReport();
        }
    }
}
