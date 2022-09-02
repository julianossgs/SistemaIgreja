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
    public partial class FrmRelInventario : Form
    {
        public FrmRelInventario()
        {
            InitializeComponent();
        }

        private void FrmRelInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'igrejaBatistaDataSet.ListarInventario'. Você pode movê-la ou removê-la conforme necessário.
            this.listarInventarioTableAdapter.Fill(this.igrejaBatistaDataSet.ListarInventario);

            this.reportViewer1.RefreshReport();
        }
    }
}
