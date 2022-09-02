using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Batista.Dados;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmCadastroTipoCultos : Form
    {
        Conexao con = new Conexao();
        string idtipoCulto;
        public FrmCadastroTipoCultos()
        {
            InitializeComponent();
        }

        private void FrmCadastroTipoCultos_Load(object sender, EventArgs e)
        {
            ListarTipoCulto();
        }

        private void MsgErro(string msg)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void MsgOk(string msg)
        {
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void LimparCampos()
        {
            txtTipoCulto.Clear();

        }

        private void HabilitarCampos()
        {
            txtTipoCulto.Enabled = true;

        }

        private void ExcluirTipoCulto()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = con.Con;
                Cmd2.CommandText = "spExcluirTipoCulto";
                Cmd2.CommandType = CommandType.StoredProcedure;
                Cmd2.Parameters.AddWithValue("@IdTipoCulto", idtipoCulto);

                Cmd2.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao excluir culto: " + ex.Message);
            }
        }


        private void ListarTipoCulto()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "spListarTipoCulto";
                Cmd0.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd0;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridTipoCulto.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao listar cultos: " + ex.Message);
            }
        }

        //botão NOVO
        private void BtNovo_Click(object sender, EventArgs e)
        {
            txtTipoCulto.Focus();
            LimparCampos();
            HabilitarCampos();
            btExcluir.Enabled = true;
            btSalvar.Enabled = true;
        }

        //botão SALVAR
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtTipoCulto.Text == string.Empty)
            {
                MsgErro("Preencha o campo Tipo de Culto!");
                txtTipoCulto.Focus();
                return;
            }

            //inserir Tipo de culto
            con.AbrirConexao();
            SqlCommand Cmd1 = new SqlCommand();
            Cmd1.Connection = con.Con;
            Cmd1.CommandText = "spInserirTipoCulto";
            Cmd1.CommandType = CommandType.StoredProcedure;
            Cmd1.Parameters.AddWithValue("@TipoCulto", txtTipoCulto.Text);

            //verificar se o tipo de culto já está cadastrado

            SqlCommand Cmd4 = new SqlCommand();
            Cmd4.Connection = con.Con;
            Cmd4.CommandText = "spVerificarCultoCadastrado";
            Cmd4.CommandType = CommandType.StoredProcedure;
            Cmd4.Parameters.AddWithValue("@TipoCulto", txtTipoCulto.Text);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Cmd4;
            DataTable Dt = new DataTable();
            da.Fill(Dt);

            if (Dt.Rows.Count > 0)
            {

                MsgErro("Culto já cadastrado!");
                txtTipoCulto.Clear();
                txtTipoCulto.Focus();
                return;
            }

            Cmd1.ExecuteNonQuery();
            con.FecharConexao();

            MsgOk("Registro salvo com sucesso!");
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            LimparCampos();
            ListarTipoCulto();
        }

        //botão EXCLUIR
        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (txtTipoCulto.Text == string.Empty)
            {
                MessageBox.Show("Selecione um Registro para exclusão!");
                return;
            }
            var result = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ExcluirTipoCulto();
                MsgOk("Registro excluido com sucesso!");
                btNovo.Enabled = true;
                btExcluir.Enabled = false;
                LimparCampos();
                ListarTipoCulto();
            }
        }

        private void GridTipoCulto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btSalvar.Enabled = true;
            btExcluir.Enabled = true;
            HabilitarCampos();
            idtipoCulto = gridTipoCulto.CurrentRow.Cells[0].Value.ToString();
            txtTipoCulto.Text = gridTipoCulto.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
