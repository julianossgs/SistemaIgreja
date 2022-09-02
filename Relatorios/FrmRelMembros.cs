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
    public partial class FrmRelMembros : Form
    {
        public FrmRelMembros()
        {
            InitializeComponent();
        }

        private void FrmRelMembros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'igrejaBatistaDataSet.TblMembros'. Você pode movê-la ou removê-la conforme necessário.
            this.tblMembrosTableAdapter.Fill(this.igrejaBatistaDataSet.TblMembros);

            this.reportViewer1.RefreshReport();
        }
    }
}
