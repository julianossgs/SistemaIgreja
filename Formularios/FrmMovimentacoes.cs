using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Relatorios;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmMovimentacoes : Form
    {
        Conexao con = new Conexao();

        //variáveis globais
        decimal totalEntrada, totalSaida;
        public FrmMovimentacoes()
        {
            InitializeComponent();
        }

        private void MsgErro(string msg)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void MsgOk(string msg)
        {
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void FrmMovimentacoes_Load(object sender, EventArgs e)
        {
            ListarMovimentacoes();
            cBBuscar.SelectedIndex = 0;
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
          
        } 

        private void ListarMovimentacoes()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "spListarMovimentacoes";
                Cmd0.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd0;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridMovimentacao.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao Listar Movimentações: " + ex.Message);
            }

            totalEntradas();
            totalSaidas();
            Totalizar();
        } 

        //Método de buscar por datas
        private void BuscarDataMov()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd1 = new SqlCommand();
                Cmd1.Connection = con.Con;
                Cmd1.CommandText = "spBuscarDataMov";
                Cmd1.CommandType = CommandType.StoredProcedure;
                Cmd1.Parameters.AddWithValue("@DataInicial", dtInicial.Text);
                Cmd1.Parameters.AddWithValue("@DataFinal", dtFinal.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd1;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridMovimentacao.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de buscar por datas: " + ex.Message);
            }

            totalEntradas();
            totalSaidas();
            Totalizar();
        }

        //Método de buscar por datas e tipo
        private void BuscarDataTipoMov()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = con.Con;
                Cmd2.CommandText = "spBuscarDataTipoMov";
                Cmd2.CommandType = CommandType.StoredProcedure;
                Cmd2.Parameters.AddWithValue("@Tipo", cBBuscar.Text);
                Cmd2.Parameters.AddWithValue("@DataInicial", dtInicial.Text);
                Cmd2.Parameters.AddWithValue("@DataFinal", dtFinal.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd2;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridMovimentacao.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de buscar por data/tipo: " + ex.Message);
            }

            totalEntradas();
            totalSaidas();
            Totalizar();
        }

        private void CBBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBBuscar.SelectedIndex==0)
            {
                BuscarDataMov();
            }

            else
            {
                BuscarDataTipoMov();
            }
        }

        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            if (cBBuscar.SelectedIndex == 0)
            {
                BuscarDataMov();
            }

            else
            {
                BuscarDataTipoMov();
            }
        }

        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            if (cBBuscar.SelectedIndex == 0)
            {
                BuscarDataMov();
            }

            else
            {
                BuscarDataTipoMov();
            }
        } 


        private void Totalizar()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridMovimentacao.Rows)
            {
                total = totalEntrada - totalSaida;
            }
            lblTotal.Text = Convert.ToDecimal(total).ToString("C2");

            if (total >= 0)
            {
                lblTotal.ForeColor = Color.Black;
            }

            else
            {
                lblTotal.ForeColor = Color.Red;
            }
        } 

        private void totalEntradas()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridMovimentacao.Rows)
            {
                if (linha.Cells["Tipo"].Value.ToString()=="Entrada")
                {
                    total += Convert.ToDecimal(linha.Cells["Total"].Value);
                }
            }
            totalEntrada = total;
            lblEntrada.Text = Convert.ToDecimal(total).ToString("C2");
        }

        private void BtRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelMOV1 frmRelMOV = new FrmRelMOV1();
            frmRelMOV.Show();
        }

        private void totalSaidas()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridMovimentacao.Rows)
            {
                if (linha.Cells["Tipo"].Value.ToString() == "Saida")
                {
                   
                    total += Convert.ToDecimal(linha.Cells["Total"].Value);

                    //linha de cód p/ deixar a cor da linha em vermelho(valor negativo)
                    linha.Cells["Total"].Style.ForeColor = Color.Red;
                   
                }
            }
            totalSaida = total;
            lblSaida.Text = Convert.ToDecimal(total).ToString("C2");
        }


    }
}
