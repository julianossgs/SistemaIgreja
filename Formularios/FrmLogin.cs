using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Batista.Views
{

    //FOMULÁRIO DE LOGIN (PROJETO BATISTA) 
    public partial class FrmLogin : Form
    {
       
        Conexao con = new Conexao();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


        private void MsgErro(string msg)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void MsgOk(string msg)
        {
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        } 

        private void LimparCamposLogin()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void ChamarLogin()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "spChamarLogin";
                Cmd0.CommandType = CommandType.StoredProcedure;
                Cmd0.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                Cmd0.Parameters.AddWithValue("@Senha", txtSenha.Text);
                SqlDataReader reader;
                reader = Cmd0.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        Program.nomeUsuario = Convert.ToString(reader["Usuario"]);
                        Program.funcaoUsuario = Convert.ToString(reader["Funcao"]);
                    }


                    MsgOk("BEM VINDO  "  + Program.nomeUsuario);
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    LimparCamposLogin();
                    this.Hide();
                    frmPrincipal.Show();
                }
                else
                {
                    MsgErro("Erro ao acessar! Usuário ou Senha inválidos!");
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                    return;
                }

            }
            catch (Exception ex)
            {

                MsgErro("Erro ao Chamar o login " + ex.Message);
            }
        }

        private void BtAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text==string.Empty)
            {
                MsgErro("Informe o Usuário!");
                txtUsuario.Focus();
                return;
            }

            if (txtSenha.Text == string.Empty)
            {
                MsgErro("Informe a Senha!");
                txtSenha.Focus();
                return;
            }
            ChamarLogin();
        }

        //Evento do teclado
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }

        //botão SAIR
        private void BtSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja sair ?", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
                return;
                
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
