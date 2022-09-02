using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Relatorios;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmEntradas : Form
    {
        Conexao con = new Conexao();
        string Id;
       
        string ultimoIdEntrada;
       
        public FrmEntradas()
        {
            InitializeComponent();
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            ListarEntradas();
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            pnBotoes.Visible = false;
        }

        private void MsgErro(string msg)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void MsgOk(string msg)
        {
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void HabilitarCampos(bool vr)
        {
            if (vr)
            {
                dtEntradas.Enabled = true;
                txtDescricao.Enabled = true;
                txtValor.Enabled = true;
                btEditar.Enabled = true;
                btSalvar.Enabled = true;
                btLimpar.Enabled = true;
            }

            else
            {
                dtEntradas.Enabled = false;
                txtDescricao.Enabled = false;
                txtValor.Enabled = false;
                btEditar.Enabled = false;
                btSalvar.Enabled = false;
                btLimpar.Enabled = false;
            }
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
        }

        private void FormatarDG()
        {
            gridEntradas.Columns[0].HeaderText = "Id";
            gridEntradas.Columns[1].HeaderText = "Data";
            gridEntradas.Columns[2].HeaderText = "Tipo";
            gridEntradas.Columns[3].HeaderText = "Descrição";
            gridEntradas.Columns[4].HeaderText = "Total";

            gridEntradas.Columns[4].DefaultCellStyle.Format = "C2";
            gridEntradas.Columns[1].DefaultCellStyle.Format = "d";
            gridEntradas.Columns[0].Visible = false;
            gridEntradas.Columns[2].Visible = false;
            gridEntradas.Columns[1].Width = 100;
            gridEntradas.Columns[3].Width = 380;
            gridEntradas.Columns[4].Width = 110;
        }
        private void ListarEntradas()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spListarEntradas";
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridEntradas.DataSource = Dt;
                con.FecharConexao();

                 FormatarDG();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao Listar Entradas: " + ex.Message);
            }

            Totalizar();


        }

        //Método de buscar por datas
        private void BuscarDataEntradas()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spBuscarEntradasData";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@DataInicial", dtInicial.Text);
                Cmd.Parameters.AddWithValue("@DataFinal", dtFinal.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridEntradas.DataSource = Dt;
                con.FecharConexao();
                 FormatarDG();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de buscar por datas: " + ex.Message);
            }

            Totalizar();


        }

        private void Totalizar()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridEntradas.Rows)
            {
                total += Convert.ToDecimal(linha.Cells["Total"].Value);
            }

            lblTotal.Text = Convert.ToDecimal(total).ToString("C2");
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            pnBotoes.Visible = true;
            dtEntradas.Value = DateTime.Now;
            LimparCampos();
            btEditar.Enabled = false;
            btLimpar.Enabled = true;
            btSalvar.Enabled = true;
            btExcluir.Enabled = false;
            dtEntradas.Enabled = true;
            txtValor.Enabled = true;
            txtDescricao.Enabled = true;
        }

        //botão SALVAR
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty)
            {
                MsgErro("Preencha o campo descrição!");
                txtDescricao.Focus();
                return;
            }

            if (txtValor.Text == string.Empty)
            {
                MsgErro("Preencha o campo valor!");
                txtValor.Focus();
                return;
            }

            //cód SALVAR nas Entradas
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spInserirEntrada";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Data", dtEntradas.Text);
            Cmd.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
            Cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
            Cmd.Parameters.AddWithValue("@Tipo", "Entrada");
            Cmd.ExecuteNonQuery();
            con.FecharConexao();

            //Recuperar último Id do Gasto
            con.AbrirConexao();
            SqlCommand CmdVerificar = new SqlCommand();
            CmdVerificar.Connection = con.Con;
            CmdVerificar.CommandText = "spRecuperarUltimoIdEntrada";
            CmdVerificar.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;
            reader = CmdVerificar.ExecuteReader();

            if (reader.HasRows)
            {
                //extraíndo informações da consulta
                while (reader.Read())
                {
                    ultimoIdEntrada = Convert.ToString(reader["IdEntrada"]);
                }


            }

            //Cód p/ inserir ENTRADAS na movimentação
            con.AbrirConexao();
            SqlCommand Cmdd = new SqlCommand();
            Cmdd.Connection = con.Con;
            Cmdd.CommandText = "spInserirEntradaMov";
            Cmdd.CommandType = CommandType.StoredProcedure;
            Cmdd.Parameters.AddWithValue("@Data", dtEntradas.Text);
            Cmdd.Parameters.AddWithValue("@Tipo", "Entrada");
            Cmdd.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
            Cmdd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
            Cmdd.Parameters.AddWithValue("@Id_Movimento", ultimoIdEntrada);
            Cmdd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro salvo com sucesso!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LimparCampos();
            btNovo.Enabled = true;
            btExcluir.Enabled = false;
            ListarEntradas();
        }

        //botão EDITAR
        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == string.Empty)
            {
                MsgErro("Selecione um Registro para Alterar!");
                txtDescricao.Focus();
                return;
            }


            //cód EDITAR nas ENTRADAS
            con.AbrirConexao();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = con.Con;
            Cmd.CommandText = "spAlterarEntrada";
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IdEntrada", Id);
            Cmd.Parameters.AddWithValue("@Data", dtEntradas.Text);
            Cmd.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
            Cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
            Cmd.Parameters.AddWithValue("@Tipo", "Entrada");
            Cmd.ExecuteNonQuery();
            con.FecharConexao();


            //Cód p/ Editar ENTRADAS na movimentação
            con.AbrirConexao();
            SqlCommand Cmdd = new SqlCommand();
            Cmdd.Connection = con.Con;
            Cmdd.CommandText = "spAlterarEntradaMov";
            Cmdd.CommandType = CommandType.StoredProcedure;
            Cmdd.Parameters.AddWithValue("@IdEntrada", Id);
            Cmdd.Parameters.AddWithValue("@Data", dtEntradas.Text);
            Cmdd.Parameters.AddWithValue("@Tipo", "Entrada");
            Cmdd.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
            Cmdd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
            Cmdd.Parameters.AddWithValue("Id_Movimento", Id);
            Cmdd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro alterado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            btNovo.Enabled = true;
            btExcluir.Enabled = false;
            pnBotoes.Visible = false;
            gridEntradas.Visible = true;
            ListarEntradas();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirEntrada";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdEntrada", Id);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                //Cod p/ excluir na Movimentação
                con.AbrirConexao();
               // SqlCommand Cmd7 = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirMovEntradas";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdEntrada", Id);
                Cmd.Parameters.AddWithValue("@Tipo", "Entrada");

                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluido com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btNovo.Enabled = true;
                btExcluir.Enabled = false;
                LimparCampos();
                pnBotoes.Visible = false;
                gridEntradas.Visible = true;
                ListarEntradas();
            }
        }

            private void BtLimpar_Click(object sender, EventArgs e)
            {
                LimparCampos();
                txtDescricao.Focus();
            }

            private void BtRelatorio_Click(object sender, EventArgs e)
            {

            }

            private void BtFechar_Click(object sender, EventArgs e)
            {
                gridEntradas.Visible = true;
                pnBotoes.Visible = false;
                HabilitarCampos(true);
                LimparCampos();
            }

        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarDataEntradas();
        }

        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarDataEntradas();
        }

        private void GridEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridEntradas.Visible = false;
            pnBotoes.Visible = true;
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btExcluir.Enabled = true;
            btEditar.Enabled = true;
            btLimpar.Enabled = false;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dtEntradas.Enabled = true;

            try
            {
                Id = gridEntradas.CurrentRow.Cells[0].Value.ToString();
                dtEntradas.Text = gridEntradas.CurrentRow.Cells[1].Value.ToString();
                txtDescricao.Text = gridEntradas.CurrentRow.Cells[3].Value.ToString();
                txtValor.Text = gridEntradas.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao selecionar o grid: " + ex.Message + ex.StackTrace);
            }

        }

        private void BtRelatorio_Click_1(object sender, EventArgs e)
        {
            FrmRelEntradas frmRelEntradas = new FrmRelEntradas();
            frmRelEntradas.Show();
        }

        //Cód para o usuário não digitar letras no txtValor
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}