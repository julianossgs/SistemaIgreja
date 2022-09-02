using Batista.Dados;
using SQLBackup;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Formularios;
using System.IO;

namespace Batista.Views
{
    public partial class FrmPrincipal : Form
    {
        Conexao con = new Conexao();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.Show();
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargos frmCargos = new FrmCargos();
            frmCargos.Show();
        }

        private void MembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembros1 frm = new frmMembros1();
            frm.Show();
        }

        private void SairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DizimistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
            //buscando usuário e cargo p/ o menu principal
            lblCargo.Text = Program.funcaoUsuario;
            lblUsuario.Text = Program.nomeUsuario;
            lblData.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss:");

        }

        private void CULTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultarCultosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCultos frmCultos = new FrmCultos();
            frmCultos.Show();
        }

        private void CadastroDeCultosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BibliaOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Http://www.bibliaonline.com.br");
        }

        private void EntradasSaídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimentacoes frmMovimentacoes = new FrmMovimentacoes();
            frmMovimentacoes.Show();
        }

        private void DespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGastos frmGastos = new FrmGastos();
            frmGastos.Show();
        }

       

        private void DizimistasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frmdizimistas frmdizimistas = new Frmdizimistas();
            frmdizimistas.Show();
        }

        private void EntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradas frmEntradas = new FrmEntradas();
            frmEntradas.Show();
        }

        private void ContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasPagar frmContasPagar = new FrmContasPagar();
            frmContasPagar.Show();
        }

        private void CadastrarUmNovoCultoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoCultos frmCadastroTipo = new FrmCadastroTipoCultos();
            frmCadastroTipo.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss:");
        }

        //Limpeza dos dados do CULTO
        private void limparDadosDosCultosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dataInicial1, dataFinal1;
            int ano1;
            DateTime data1 = DateTime.Now;
            ano1 = data1.Year - 1;

            dataInicial1 = "01/01/" + ano1;
            dataFinal1 = "31/12/" + ano1;

            var result1 = MessageBox.Show("Deseja Limpar todos os dados dos Cultos de " + ano1 + "?", "ATENÇÃO !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {

                //excluindo os dados do culto
                con.AbrirConexao();
                SqlCommand Cmd3 = new SqlCommand();
                Cmd3.Connection = con.Con;
                Cmd3.CommandText = "spLimparDadosCulto";
                Cmd3.CommandType = CommandType.StoredProcedure;
                Cmd3.Parameters.AddWithValue("@dataInicial",Convert.ToDateTime(dataInicial1));
                Cmd3.Parameters.AddWithValue("@dataFinal",Convert.ToDateTime(dataFinal1));
                Cmd3.ExecuteNonQuery();
                con.FecharConexao();

                //excluindo os dados dos dizimistas
                con.AbrirConexao();
                SqlCommand Cmd4 = new SqlCommand();
                Cmd4.Connection = con.Con;
                Cmd4.CommandText = "spLimparDadosDizimista";
                Cmd4.CommandType = CommandType.StoredProcedure;
                Cmd4.Parameters.AddWithValue("@dataInicial",Convert.ToDateTime(dataInicial1));
                Cmd4.Parameters.AddWithValue("@dataFinal",Convert.ToDateTime(dataFinal1));
                Cmd4.ExecuteNonQuery();
                con.FecharConexao();

                //excluindo os dados das movimentações
                con.AbrirConexao();
                SqlCommand Cmd5 = new SqlCommand();
                Cmd5.Connection = con.Con;
                Cmd5.CommandText = "spLimparDadosMovimentacao";
                Cmd5.CommandType = CommandType.StoredProcedure;
                Cmd5.Parameters.AddWithValue("@dataInicial",Convert.ToDateTime(dataInicial1));
                Cmd5.Parameters.AddWithValue("@dataFinal",Convert.ToDateTime(dataFinal1));
                Cmd5.ExecuteNonQuery();
                con.FecharConexao();

            }
            if(result1==DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Dados apagados com sucesso!!");
        }

        //Limpeza de dados das Movimentações
        private void limparDadosDoFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dataInicial, dataFinal;
            int ano;
            DateTime data = DateTime.Now;
            ano = data.Year - 1;
          
            dataInicial = "01/01/" + ano;
            dataFinal = "31/12/" + ano;


            var result = MessageBox.Show("Deseja Limpar todos os dados do Financeiro de " + ano + "?", "ATENÇÃO !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                //excluindo dados da tab de Movimentações
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spLimparDadosMovimentacao";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@dataInicial",Convert.ToDateTime(dataInicial));
                Cmd.Parameters.AddWithValue("@dataFinal",Convert.ToDateTime(dataFinal));
                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                //excluindo dados da tab de entradas
                con.AbrirConexao();
                SqlCommand Cmd1 = new SqlCommand();
                Cmd1.Connection = con.Con;
                Cmd1.CommandText = "spLimparDadosEntrada";
                Cmd1.CommandType = CommandType.StoredProcedure;
                Cmd1.Parameters.AddWithValue("@dataInicial",Convert.ToDateTime(dataInicial));
                Cmd1.Parameters.AddWithValue("@dataFinal",Convert.ToDateTime(dataFinal));
                Cmd1.ExecuteNonQuery();
                con.FecharConexao();

                //excluindo dados da tab de saidas
                con.AbrirConexao();
                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = con.Con;
                Cmd2.CommandText = "spLimparDadosGasto";
                Cmd2.CommandType = CommandType.StoredProcedure;
                Cmd2.Parameters.AddWithValue("@dataInicial",Convert.ToDateTime(dataInicial));
                Cmd2.Parameters.AddWithValue("@dataFinal",Convert.ToDateTime(dataFinal));
                Cmd2.ExecuteNonQuery();
                con.FecharConexao();

                //excluindo dados da tab de contas pagas
                con.AbrirConexao();
                SqlCommand Cmd3 = new SqlCommand();
                Cmd3.Connection = con.Con;
                Cmd3.CommandText = "spLimparDadosContasPagas";
                Cmd3.CommandType = CommandType.StoredProcedure;
                Cmd3.Parameters.AddWithValue("@dataInicial", Convert.ToDateTime(dataInicial));
                Cmd3.Parameters.AddWithValue("@dataFinal", Convert.ToDateTime(dataFinal));
                Cmd3.ExecuteNonQuery();
                con.FecharConexao();
               
            }

            if (result == DialogResult.No)
            {
                return;
            }
            MessageBox.Show("Dados apagados com sucesso!!");
        }

        //Backup do Banco de dados
        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.Show();
           
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora frmCalculadora = new FrmCalculadora();
            frmCalculadora.Show();
        }

        private void inventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario1 frmInventario1 = new FrmInventario1();
            frmInventario1.Show();
        }
    }
}
