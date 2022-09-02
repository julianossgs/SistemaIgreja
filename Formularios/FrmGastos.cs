using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Relatorios;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmGastos : Form
    {
        Conexao con = new Conexao();

        //variáveis globais
        string ultimoIdGasto;
        string IdGasto;
        string sql;
        public FrmGastos()
        {
            InitializeComponent();
        }

        private void FrmGastos_Load(object sender, EventArgs e)
        {
            ListarGastos();
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
                dtGastos.Enabled = true;
                txtDescricao.Enabled = true;
                txtValor.Enabled = true;
                btEditar.Enabled = true;
                btSalvar.Enabled = true;
                btLimpar.Enabled = true;
            }

            else
            {
                dtGastos.Enabled = false;
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
            gridGastos.Columns[0].HeaderText = "Id";
            gridGastos.Columns[1].HeaderText = "Data";
            gridGastos.Columns[2].HeaderText = "Descrição";
            gridGastos.Columns[3].HeaderText = "Total";
            gridGastos.Columns[4].HeaderText = "Tipo";

            gridGastos.Columns[3].DefaultCellStyle.Format = "C2";
            gridGastos.Columns[1].DefaultCellStyle.Format = "d";
            gridGastos.Columns[0].Visible = false;
            gridGastos.Columns[4].Visible = false;
            gridGastos.Columns[1].Width = 100;
            gridGastos.Columns[2].Width = 410;
            gridGastos.Columns[3].Width = 110;
        }

        private void ListarGastos()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spListarGastos";
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridGastos.DataSource = Dt;
                con.FecharConexao();

                FormatarDG();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao Listar Gastos: " + ex.Message);
            }

            Totalizar();


        }

        //Método de buscar por datas
        private void BuscarDataGastos()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spBuscarGastosData";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@DataInicial", dtInicial.Text);
                Cmd.Parameters.AddWithValue("@DataFinal", dtFinal.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridGastos.DataSource = Dt;
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
            foreach (DataGridViewRow linha in gridGastos.Rows)
            {
                total += Convert.ToDecimal(linha.Cells["Valor"].Value);
            }
           
            lblTotal.Text = Convert.ToDecimal(total).ToString("C2");
        }


        //BOTÔES

            //botão NOVO
        private void BtNovo_Click(object sender, EventArgs e)
        {
            pnBotoes.Visible = true;
            dtGastos.Value = DateTime.Now;
            LimparCampos();
            btEditar.Enabled = false;
            btLimpar.Enabled = true; 
            btSalvar.Enabled = true;
            btExcluir.Enabled = false;
            dtGastos.Enabled = true;
            txtValor.Enabled = true;
            txtDescricao.Enabled = true;
        }

        //botão SALVAR
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text==string.Empty)
            {
                MsgErro("Preencha o campo descrição!");
                txtDescricao.Focus();
                return;
            }

            if (txtValor.Text==string.Empty)
            {
                MsgErro("Preencha o campo valor!");
                txtValor.Focus();
                return;
            }

            //cód SALVAR nos GASTOS
            con.AbrirConexao();
            SqlCommand Cmd2 = new SqlCommand();
            Cmd2.Connection = con.Con;
            Cmd2.CommandText = "spInserirGastos";
            Cmd2.CommandType = CommandType.StoredProcedure;
            Cmd2.Parameters.AddWithValue("@Data", dtGastos.Text);
            Cmd2.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
            Cmd2.Parameters.AddWithValue("@Valor",Convert.ToDecimal(txtValor.Text));
            Cmd2.Parameters.AddWithValue("@Tipo", "Saida");
            Cmd2.ExecuteNonQuery();
            con.FecharConexao();

            //Recuperar último Id do Gasto
            con.AbrirConexao();
            SqlCommand CmdVerificar = new SqlCommand();
            CmdVerificar.Connection = con.Con;
            CmdVerificar.CommandText = "spRecuperarUltimoIdGasto";
            CmdVerificar.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;
            reader = CmdVerificar.ExecuteReader();

            if (reader.HasRows)
            {
                //extraíndo informações da consulta
                while (reader.Read())
                {
                    ultimoIdGasto = Convert.ToString(reader["IdGasto"]);
                }


            }

            //Cód p/ inserir GASTOS na movimentação
            con.AbrirConexao();
            SqlCommand Cmd54 = new SqlCommand();
            Cmd54.Connection = con.Con;
            Cmd54.CommandText = "spInserirMov";
            Cmd54.CommandType = CommandType.StoredProcedure;
            Cmd54.Parameters.AddWithValue("@Data", dtGastos.Text);
            Cmd54.Parameters.AddWithValue("@Tipo", "Saida");
            Cmd54.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
            Cmd54.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
            Cmd54.Parameters.AddWithValue("@Id_Movimento", ultimoIdGasto);
            Cmd54.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro salvo com sucesso!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            LimparCampos();
            btNovo.Enabled = true;
            btExcluir.Enabled = false;
            ListarGastos();

        }

        //botão EDITAR
        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text==string.Empty)
            {
                MsgErro("Selecione um Registro para Alterar!");
                txtDescricao.Focus();
                return;
            }


            //cód EDITAR nos GASTOS
            con.AbrirConexao();
            SqlCommand Cmd3 = new SqlCommand();
            Cmd3.Connection = con.Con;
            Cmd3.CommandText = "spAlterarGastos";
            Cmd3.CommandType = CommandType.StoredProcedure;
            Cmd3.Parameters.AddWithValue("@IdGasto", IdGasto);
            Cmd3.Parameters.AddWithValue("@Data", dtGastos.Text);
            Cmd3.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
            Cmd3.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
            Cmd3.Parameters.AddWithValue("@Tipo", "Saida");
            Cmd3.ExecuteNonQuery();
            con.FecharConexao();


            //Cód p/ Editar GASTOS na movimentação
            con.AbrirConexao();
            sql = "Update TblMovimentacoes set Data=@Data,Movimento=@Movimento,Total=@Total" +
                "where Id_Movimento = @IdGasto and Tipo=@Tipo";
           
            SqlCommand Cmd4 = new SqlCommand(sql,con.Con);
            Cmd4.Parameters.AddWithValue("@IdGasto",IdGasto);
            Cmd4.Parameters.AddWithValue("@Data", dtGastos.Text);
            Cmd4.Parameters.AddWithValue("@Tipo", "Saida");
            Cmd4.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
            Cmd4.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
           
            Cmd4.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro alterado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LimparCampos();
            btNovo.Enabled = true;
            btExcluir.Enabled = false;
            pnBotoes.Visible = false;
            gridGastos.Visible = true;
            ListarGastos();

        }

        //botão RELATÓRIO
        private void BtRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelGastos frmRelGastos = new FrmRelGastos();
            frmRelGastos.Show();
        }

        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarDataGastos();
        }

        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarDataGastos();
        }

        //botão LIMPAR
        private void BtLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtDescricao.Focus();
        }

        //botão FECHAR
        private void BtFechar_Click(object sender, EventArgs e)
        {
            gridGastos.Visible = true;
            pnBotoes.Visible = false;
            HabilitarCampos(true);
            LimparCampos();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.AbrirConexao();
                SqlCommand Cmd6 = new SqlCommand();
                Cmd6.Connection = con.Con;
                Cmd6.CommandText = "spExcluirGastos";
                Cmd6.CommandType = CommandType.StoredProcedure;
                Cmd6.Parameters.AddWithValue("@IdGasto",IdGasto);
                Cmd6.ExecuteNonQuery();
                con.FecharConexao();

                //Cod p/ excluir na Movimentação
                con.AbrirConexao();
                SqlCommand Cmd7 = new SqlCommand();
                Cmd7.Connection = con.Con;
                Cmd7.CommandText = "spExcluirMovGastos";
                Cmd7.CommandType = CommandType.StoredProcedure;
                Cmd7.Parameters.AddWithValue("@IdGasto",IdGasto);
                Cmd7.Parameters.AddWithValue("@Tipo", "Saida");

                Cmd7.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluido com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btNovo.Enabled = true;
                btExcluir.Enabled = false;
                LimparCampos();
                pnBotoes.Visible = false;
                gridGastos.Visible = true;
                ListarGastos();
            }
        }

       
        private void GridGastos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            gridGastos.Visible = false;
            pnBotoes.Visible = true;
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btExcluir.Enabled = true;
            btEditar.Enabled = true;
            btLimpar.Enabled = false;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            dtGastos.Enabled = true;

            try
            {
                IdGasto = gridGastos.CurrentRow.Cells[0].Value.ToString();
                dtGastos.Text = gridGastos.CurrentRow.Cells[1].Value.ToString();
                txtDescricao.Text = gridGastos.CurrentRow.Cells[2].Value.ToString();
                txtValor.Text = gridGastos.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao selecionar o grid: " + ex.Message + ex.StackTrace);
            }

        }

        //botão SAIR do formulário de lançamento de gastos
        private void BtSair_Click(object sender, EventArgs e)
        {
            pnBotoes.Visible = false;
            gridGastos.Visible = true;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        //cód p/ o usuário não digitar letras no txtVAlor
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
