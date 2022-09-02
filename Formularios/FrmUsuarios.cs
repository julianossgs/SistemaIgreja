using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{

    //FORMULÁRIO DE USUÁRIOS (PROJETO BATISTA)
    public partial class FrmUsuarios : Form
    {
        Conexao con = new Conexao();
        string idusuario;
        string usuarioAntigo;
        string senhaAntiga;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();

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
            txtUsuario.Clear();
            txtSenha.Clear();
            txtFuncao.Clear();
            txtUsuario.Focus();
        }

        private void HabilitarCampos(bool vr)
        {
            if (vr)
            {
                txtUsuario.Enabled = true;
                txtSenha.Enabled = true;
                txtFuncao.Enabled = true;
            }
            else
            {
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                txtFuncao.Enabled = false;
            }

        }

        private void ListarUsuarios()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "spListarUsuarios";
                Cmd0.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd0;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridUsuarios.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao listar os usuários!" + ex.Message);
            }
        }

        private void ExcluirUsuarios()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = con.Con;
                Cmd2.CommandText = "spExcluirUsuarios";
                Cmd2.CommandType = CommandType.StoredProcedure;
                Cmd2.Parameters.AddWithValue("@IdUsuario", idusuario);

                Cmd2.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao excluir usuário: " + ex.Message);
            }
        }


        //BOTÕES

        private void BtNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos(true);
            btExcluir.Enabled = true;
            btSalvar.Enabled = true;
        }

        //botão SALVAR
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                MsgErro("Preencha o campo Usuário!");
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text == string.Empty)
            {
                MsgErro("Preencha o campo Senha!");
                txtSenha.Focus();
                return;
            }

            if (txtFuncao.Text == string.Empty)
            {
                MsgErro("Preencha o campo Função!");
                txtFuncao.Focus();
                return;
            }

            //inserir usuário
            con.AbrirConexao();
            SqlCommand Cmd1 = new SqlCommand();
            Cmd1.Connection = con.Con;
            Cmd1.CommandText = "spInserirUsuarios";
            Cmd1.CommandType = CommandType.StoredProcedure;
            Cmd1.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            Cmd1.Parameters.AddWithValue("@Senha", txtSenha.Text);
            Cmd1.Parameters.AddWithValue("@Funcao", txtFuncao.Text);

            //verificar se o usuário e senha já estão cadastrados

            SqlCommand Cmd4 = new SqlCommand();
            Cmd4.Connection = con.Con;
            Cmd4.CommandText = "spVerificarUsuarioCadastrado";
            Cmd4.CommandType = CommandType.StoredProcedure;
            Cmd4.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            Cmd4.Parameters.AddWithValue("@Senha", txtSenha.Text);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Cmd4;
            DataTable Dt = new DataTable();
            da.Fill(Dt);

            if (Dt.Rows.Count > 0)
            {

                MsgErro("Usuário ou Senha já cadastrados!");
                LimparCampos();
                txtUsuario.Focus();
                return;
            }

            Cmd1.ExecuteNonQuery();
            con.FecharConexao();

            MsgOk("Registro salvo com sucesso!");
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            LimparCampos();
            ListarUsuarios();

        }

        //botão EXCLUIR
        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Selecione um Usuário para exclusão!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;

            }

            if (gridUsuarios.RowCount==1)
            {
                MessageBox.Show("Voçê não pode excluir este Usuário! - Há somente este registro para o Acesso ao Sistema! - Faça mais um cadastro de Usuário para manter a segurança do Sistema!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ExcluirUsuarios();
                MsgOk("Registro excluido com sucesso!");
                btNovo.Enabled = true;
                btExcluir.Enabled = false;
                LimparCampos();
                ListarUsuarios();
            }
        }

        //Grid
        private void GridUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btExcluir.Enabled = true;
            HabilitarCampos(false);
            idusuario = gridUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = gridUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = gridUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtFuncao.Text = gridUsuarios.CurrentRow.Cells[3].Value.ToString();

            usuarioAntigo = gridUsuarios.CurrentRow.Cells[1].Value.ToString();
            senhaAntiga = gridUsuarios.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
