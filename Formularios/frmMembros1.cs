using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.Relatorios;

namespace WindowsFormsApp1.Formularios
{
    public partial class frmMembros1 : Form
    {
        Conexao con = new Conexao();

        //variáveis globais do formulário
        // string cpfAntigo;//var p/ verificação de CPF
        public string cpfAntigo;
        string idMembro;
        string foto;//var p/ trabalhar c/ imagens
        string alterouImagem;//var p/ trabalhar c/ a alteração das imagens
        string ultimoIdMembro;
        public frmMembros1()
        {
            InitializeComponent();
            grid.AutoGenerateColumns = false;
        }

        private void FrmMembros1_Load(object sender, EventArgs e)
        {
            LimparFoto();
            ListarMembros();
            PreencherCBCargos();
            rBBuscarNome.Checked = true;
            tabControl1.SelectedIndex = 1;
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
            txtNome.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEndereco.Clear();
            txtEstado.Clear();
            maskCPF.Clear();
            maskTel1.Clear();
            maskTel2.Clear();
            maskCEP.Clear();

        }

        private void HabilitarCampos(bool vr)
        {
            if (vr)
            {
                txtNome.Enabled=true;
                txtBairro.Enabled = true;
                txtCidade.Enabled = true;
                txtEndereco.Enabled = true;
                txtEstado.Enabled = true;
                maskCPF.Enabled = true;
                maskTel1.Enabled = true;
                maskTel2.Enabled = true;
                maskCEP.Enabled = true;
                cBCargo.Enabled = true;
                btAddImagem.Enabled = true;
                btRemoverImagem.Enabled = true;
                dtMembro.Enabled = true;
                dtNascimento.Enabled = true;
            }

            else
            {
                txtNome.Enabled =false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtEndereco.Enabled = false;
                txtEstado.Enabled = false;
                maskCPF.Enabled = false;
                maskTel1.Enabled = false;
                maskTel2.Enabled = false;
                maskCEP.Enabled = false;
                cBCargo.Enabled = false;
                btAddImagem.Enabled = false;
                btRemoverImagem.Enabled = false;
                dtMembro.Enabled = true;
                dtNascimento.Enabled = true;
            }

        } 

        private void PreencherCBCargos()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd4 = new SqlCommand();
                Cmd4.Connection = con.Con;
                Cmd4.CommandText = "ListarCargo";
                Cmd4.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd4;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                cBCargo.DataSource = Dt;
                cBCargo.ValueMember = "IdCargo";
                cBCargo.DisplayMember = "Cargo";
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao listar cargos no combobox de membros: " + ex.Message);
            }
        }

        private void ListarMembros()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "spListarMembros";
                Cmd0.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd0;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                grid.DataSource = Dt;
                con.FecharConexao();
              
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao listar membros: " + ex.Message);
            }
        } 

        //Método de buscar por nome
        private void BuscarMembroNome()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd8 = new SqlCommand();
                Cmd8.Connection = con.Con;
                Cmd8.CommandText = "spBuscarMembroNome";
                Cmd8.CommandType = CommandType.StoredProcedure;
               // Cmd8.Parameters.AddWithValue("@IdMembro", idMembro);
                Cmd8.Parameters.AddWithValue("@Nome", txtBuscar.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd8;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                grid.DataSource = Dt;
                con.FecharConexao();
             
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao buscar por nome: " + ex.Message);
            }
        }

        //Método de buscar membro por CPF
        private void BuscarMembroCPF()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd9 = new SqlCommand();
                Cmd9.Connection = con.Con;
                Cmd9.CommandText = "spBuscarMembroCPF";
                Cmd9.CommandType = CommandType.StoredProcedure;
                Cmd9.Parameters.AddWithValue("@CPF", maskBuscar.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd9;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                grid.DataSource = Dt;
                con.FecharConexao();
               
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao buscar por CPF: " + ex.Message);
            }
        }

        //BOTÕES

        //botão NOVO
        private void BtNovo_Click(object sender, EventArgs e)
        {
            if (cBCargo.Text == string.Empty)
            {
                MsgErro("Cadastre um Cargo!");
                Close();
            }
            LimparCampos();
            HabilitarCampos(true);
            LimparFoto();
            btSalvar.Enabled = true;
            btNovo.Enabled = false;
            btEditar.Enabled = false;
            btExcluir1.Enabled = false;
            
        }

        //botão SALVAR
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim()==string.Empty)
            {
                MsgErro("Preencha o campo Nome!");
                txtNome.Focus();
                return;
            }
            if (maskCPF.Text == "   ,   ,   -")
            {
                MsgErro("Preencha o campo CPF!");
                maskCPF.Focus();
                return;
            }

            //cód p/ salvar membro
            con.AbrirConexao();
            SqlCommand Cmd5 = new SqlCommand();
            Cmd5.Connection = con.Con;
            Cmd5.CommandText = "spInserirMembros";
            Cmd5.CommandType = CommandType.StoredProcedure;
            Cmd5.Parameters.AddWithValue("@Nome", txtNome.Text);
            Cmd5.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
            Cmd5.Parameters.AddWithValue("@Bairro", txtBairro.Text);
            Cmd5.Parameters.AddWithValue("@Cidade", txtCidade.Text);
            Cmd5.Parameters.AddWithValue("@Estado", txtEstado.Text);
            Cmd5.Parameters.AddWithValue("@Cep", maskCEP.Text);
            Cmd5.Parameters.AddWithValue("@CPF", maskCPF.Text);
            Cmd5.Parameters.AddWithValue("@Celular1", maskTel1.Text);
            Cmd5.Parameters.AddWithValue("@Celular2", maskTel2.Text);
            Cmd5.Parameters.AddWithValue("@Nascimento", dtNascimento.Text);
            Cmd5.Parameters.AddWithValue("@Imagem", Img());
            Cmd5.Parameters.AddWithValue("@Id_Cargo", cBCargo.SelectedValue);
            Cmd5.Parameters.AddWithValue("@Iniciou", dtMembro.Text);

            //Recuperar ultimo Id do Membro
           
            con.AbrirConexao();
            SqlCommand CmdVerificar = new SqlCommand();
            CmdVerificar.Connection = con.Con;
            CmdVerificar.CommandText = "spRecuperarUltimoIdMembro";
            CmdVerificar.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;
            reader = CmdVerificar.ExecuteReader();

            if (reader.HasRows)
            {
                //extraíndo informações da consulta
                while (reader.Read())
                {
                    ultimoIdMembro = Convert.ToString(reader["IdMembro"]);
                }

            }

            //Relacionar o Membro c/Dizimista
            con.AbrirConexao();
            SqlCommand CmdRelacionar = new SqlCommand();
            CmdRelacionar.Connection = con.Con;
            CmdRelacionar.CommandText = "spRelacionarMembroDiz";
            CmdRelacionar.CommandType = CommandType.StoredProcedure;
            CmdRelacionar.Parameters.AddWithValue("@IdMembro", "0");
            CmdRelacionar.Parameters.AddWithValue("@Id_Membro", ultimoIdMembro);
            CmdRelacionar.ExecuteNonQuery();
            con.FecharConexao();


            //verifcar se o CPF do membro já está cadastrado
            con.AbrirConexao();
            SqlCommand CmdVerificar1 = new SqlCommand();
            CmdVerificar1.Connection = con.Con;
            CmdVerificar1.CommandText = "spVerificarCPFCadastrado";
            CmdVerificar1.CommandType = CommandType.StoredProcedure;
            CmdVerificar1.Parameters.AddWithValue("@CPF", maskCPF.Text);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = CmdVerificar1;
            DataTable Dt = new DataTable();
            da.Fill(Dt);

            if (Dt.Rows.Count > 0)
            {

                MsgErro("CPF já cadastrado!");
                maskCPF.Clear();
                maskCPF.Focus();
                return;
            }

            Cmd5.ExecuteNonQuery();
            con.FecharConexao();

            MsgOk("Registro salvo com sucesso!");
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            LimparFoto();
            LimparCampos();
            ListarMembros();
          
        }

        //botão EDITAR
        private void BtEditar_Click(object sender, EventArgs e)
        {
           
            if (txtNome.Text.Trim() == string.Empty)
            {
                MsgErro("Selecione um Registro para alterar!");
                txtNome.Focus();
                return;
            }

            //Verificar se o CPF já está cadastrado quando o mesmo é alterado

            if (maskCPF.Text != cpfAntigo)
            {
                con.AbrirConexao();
                SqlCommand Cmd22 = new SqlCommand();
                Cmd22.Connection = con.Con;
                Cmd22.CommandText = "spVerificarCPFCadastrado";
                Cmd22.CommandType = CommandType.StoredProcedure;
                Cmd22.Parameters.AddWithValue("@CPF", maskCPF.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd22;
                DataTable Dt = new DataTable();
                da.Fill(Dt);

                if (Dt.Rows.Count > 0)
                {

                    MsgErro("CPF já cadastrado! Erro ao alterar!");
                    maskCPF.Clear();
                    maskCPF.Focus();
                    return;
                }


            }

            //condição p/ alterar a imagem
            con.AbrirConexao();
            SqlCommand Cmd7 = new SqlCommand();

            if (alterouImagem == "1")
            {
                Cmd7.Connection = con.Con;
                Cmd7.CommandText = "spAlterarMembros";
                Cmd7.CommandType = CommandType.StoredProcedure;
                Cmd7.Parameters.AddWithValue("@Imagem", Img());
            }
            else
            {
                Cmd7.Connection = con.Con;
                Cmd7.CommandText = "spAlterarMembroImgem";
                Cmd7.CommandType = CommandType.StoredProcedure;
            }

            Cmd7.Parameters.AddWithValue("@IdMembro", idMembro);
            Cmd7.Parameters.AddWithValue("@Nome", txtNome.Text);
            Cmd7.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
            Cmd7.Parameters.AddWithValue("@Bairro", txtBairro.Text);
            Cmd7.Parameters.AddWithValue("@Cidade", txtCidade.Text);
            Cmd7.Parameters.AddWithValue("@Estado", txtEstado.Text);
            Cmd7.Parameters.AddWithValue("@Cep", maskCEP.Text);
            Cmd7.Parameters.AddWithValue("@CPF", maskCPF.Text);
            Cmd7.Parameters.AddWithValue("@Celular1", maskTel1.Text);
            Cmd7.Parameters.AddWithValue("@Celular2", maskTel2.Text);
            Cmd7.Parameters.AddWithValue("@Nascimento", dtNascimento.Text);
            Cmd7.Parameters.AddWithValue("@Id_Cargo", cBCargo.SelectedValue);
            Cmd7.Parameters.AddWithValue("@Iniciou", dtMembro.Text);

            Cmd7.ExecuteNonQuery();
            con.FecharConexao();

            MsgOk("Registro alterado com sucesso!");
            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir1.Enabled = false;
            LimparFoto();
            LimparCampos();
            HabilitarCampos(false);
            ListarMembros();
            alterouImagem = "";
        }

        //botão Add imagem
        private void BtAddImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os arquivos(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                pBImagem.ImageLocation = foto;
                alterouImagem = "1";
            }
        }

        //botão Remover imagem
        private void BtRemoverImagem_Click(object sender, EventArgs e)
        {
            LimparFoto();
        } 

        //Método p/ limpar a foto
        private void LimparFoto()
        {
            pBImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pBImagem.Image = Resources.sem_foto;
            foto = "Img/sem-foto.jpg";
        } 

        //Método p/ conversão do arquivo da imagem p/ enviar ao banco
        private byte[] Img()
        {
            byte[] ImagemByte = null;
            if (foto == "")
            {
                return null;
            }
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            ImagemByte = br.ReadBytes((int)fs.Length);
            return ImagemByte;
        }

        //botão EXCLUIR
        private void BtExcluir1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja excluir?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //cód p/ excluir
                con.AbrirConexao();
                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = con.Con;
                Cmd2.CommandText = "spExcluirMembros";
                Cmd2.CommandType = CommandType.StoredProcedure;
                Cmd2.Parameters.AddWithValue("@IdMembro", idMembro);

                Cmd2.ExecuteNonQuery();
                con.FecharConexao();

                MsgOk("Registro excluido com sucesso!");
                btNovo.Enabled = true;
                btEditar.Enabled = false;
                btExcluir1.Enabled = false;
                LimparCampos();
                HabilitarCampos(false);
                ListarMembros();
            }
        }

        private void RBBuscarNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Visible = true;
            maskBuscar.Visible = false;
            txtBuscar.Clear();
            maskBuscar.Clear();
        }

        private void RBBsucarCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Visible = false;
            maskBuscar.Visible = true;
            txtBuscar.Clear();
            maskBuscar.Clear();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarMembroNome();
        }

        private void MaskBuscar_TextChanged(object sender, EventArgs e)
        {
            if (maskBuscar.Text == "   ,   ,   -")
            {
                ListarMembros();
            }
            else
            {
                BuscarMembroCPF();
            }
        }

        //grid
        //sempre usar o CellClick ou CellDoubleClick
        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void BtRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelMembros frm = new FrmRelMembros();
            frm.Show();
        }

        //grid
        //sempre usar o CellClick ou CellDoubleClick
        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            
            btEditar.Enabled = true;
            btExcluir1.Enabled = true;
            btSalvar.Enabled = false;
            HabilitarCampos(true);
            maskCPF.Enabled = false;

            idMembro = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtEndereco.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtBairro.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtCidade.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtEstado.Text = grid.CurrentRow.Cells[5].Value.ToString();
            maskCEP.Text = grid.CurrentRow.Cells[6].Value.ToString();
            maskCPF.Text = grid.CurrentRow.Cells[7].Value.ToString();
            maskTel1.Text = grid.CurrentRow.Cells[8].Value.ToString();
            maskTel2.Text = grid.CurrentRow.Cells[9].Value.ToString();
            dtNascimento.Text = grid.CurrentRow.Cells[10].Value.ToString();

            //indiçe do cpf antigo
            cpfAntigo = grid.CurrentRow.Cells[7].Value.ToString();

            //verificação p/ alteração da imagem
            if (grid.CurrentRow.Cells[11].Value != DBNull.Value)
            {
                byte[] imagem = (byte[])grid.CurrentRow.Cells[11].Value;

                System.IO.MemoryStream ms = new MemoryStream(imagem);
                pBImagem.Image = System.Drawing.Image.FromStream(ms);
                pBImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pBImagem.Image = Resources.sem_foto;
            }

            cBCargo.Text = grid.CurrentRow.Cells[12].Value.ToString();
            dtMembro.Text = grid.CurrentRow.Cells[13].Value.ToString();
            tabControl1.SelectedIndex = 0;
            
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Program.chamadadizimistas == "dizimista")
            {
                Program.idmembro = grid.CurrentRow.Cells[0].Value.ToString();
                Program.membroDizimista = grid.CurrentRow.Cells[1].Value.ToString();
                Close();
            }
        }

        private void BtConsultarDizimista_Click(object sender, EventArgs e)
        {
            Frmdizimistas frmdizimistas = new Frmdizimistas();
            frmdizimistas.Show();
        }
    }
}
