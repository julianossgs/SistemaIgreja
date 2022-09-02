using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmCargos : Form
    {
        Conexao con = new Conexao();
        string idcargo;
        public FrmCargos()
        {
            InitializeComponent();
        }

        private void FrmCargos_Load(object sender, EventArgs e)
        {
            ListarCargo();
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
            txtCargo.Clear();
          
        }

        private void HabilitarCampos(bool vr)
        {
            if (vr)
            {
                txtCargo.Enabled = true;
            }

            else
            {
                txtCargo.Enabled = false;
            }
         
        }

        private void ListarCargo()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "ListarCargo";
                Cmd0.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd0;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridCargos.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao listar cargos: " +ex.Message);
            }
        }

        private void InserirCargos()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd1 = new SqlCommand();
                Cmd1.Connection = con.Con;
                Cmd1.CommandText = "spInserirCargo";
                Cmd1.CommandType = CommandType.StoredProcedure;
                Cmd1.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                Cmd1.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao inserir cargo: " + ex.Message);
            }
        }

        private void ExcluirCargos()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = con.Con;
                Cmd2.CommandText = "spExcluirCargo";
                Cmd2.CommandType = CommandType.StoredProcedure;
                Cmd2.Parameters.AddWithValue("@IdCargo", idcargo);

                Cmd2.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao excluir cargo: " + ex.Message);
            }
        }

        

        private void BtNovo_Click(object sender, EventArgs e)
        {
            txtCargo.Focus();
            LimparCampos();
            HabilitarCampos(true);
            btExcluir.Enabled = true;
            btSalvar.Enabled = true;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == string.Empty)
            {
                MsgErro("Preencha o campo Cargo!");
                txtCargo.Focus();
                return;
            }
          
            //inserir cargo
            con.AbrirConexao();
            SqlCommand Cmd1 = new SqlCommand();
            Cmd1.Connection = con.Con;
            Cmd1.CommandText = "spInserirCargo";
            Cmd1.CommandType = CommandType.StoredProcedure;
            Cmd1.Parameters.AddWithValue("@Cargo", txtCargo.Text);
          
            //verificar se o usuário já está cadastrado

            SqlCommand Cmd4 = new SqlCommand();
            Cmd4.Connection = con.Con;
            Cmd4.CommandText = "spVerificarCargoCadastrado";
            Cmd4.CommandType = CommandType.StoredProcedure;
            Cmd4.Parameters.AddWithValue("@Cargo", txtCargo.Text);
          
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Cmd4;
            DataTable Dt = new DataTable();
            da.Fill(Dt);

            if (Dt.Rows.Count > 0)
            {

                MsgErro("Cargo já cadastrado!");
                txtCargo.Clear();
                txtCargo.Focus();
                return;
            }

            Cmd1.ExecuteNonQuery();
            con.FecharConexao();

            MsgOk("Registro salvo com sucesso!");
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            LimparCampos();
            ListarCargo();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text==string.Empty)
            {
                MessageBox.Show("Selecione um Cargo para exclusão!", "ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Question);
                return;

            }

            var result = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ExcluirCargos();
                MsgOk("Registro excluido com sucesso!");
                btNovo.Enabled = true;
                btExcluir.Enabled = false;
                LimparCampos();
                ListarCargo();
            }

        }

        //Grid
        private void GridCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btNovo.Enabled = true;
            btSalvar.Enabled = false; ;
            btExcluir.Enabled = true;
            HabilitarCampos(false);
            idcargo = gridCargos.CurrentRow.Cells[0].Value.ToString();
            txtCargo.Text = gridCargos.CurrentRow.Cells[1].Value.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
