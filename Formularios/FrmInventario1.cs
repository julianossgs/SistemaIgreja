using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;
using Batista.Dados;
using System.Data.SqlClient;
using WindowsFormsApp1.Relatorios;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmInventario1 : Form
    {
        Conexao con = new Conexao();

        //variáveis globais
        public string idIv;
        public FrmInventario1()
        {
            InitializeComponent();
        }

        //Métodos
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
            txtItem.Clear();
            txtDescricao.Clear();
            txtDocumento.Clear();
            txtValorAtual.Clear();
            txtValorCompra.Clear();
            maskBem.Clear();


        }

        private void HabilitarCampos()
        {

            txtItem.Enabled = true;
            txtDescricao.Enabled = true;
            txtDocumento.Enabled = true;
            txtValorAtual.Enabled = true;
            txtValorCompra.Enabled = true;
            cBConservacao.Enabled = true;
            cBCategoria.Enabled = true;
            btSalvar.Enabled = true;
            btEditar.Enabled = true;
            btExcluir1.Enabled = true;
            dtCadastro.Enabled = true;
            dtCompra.Enabled = true;

        }

        private void DesabilitarCampos()
        {
            txtItem.Enabled = false;
            txtDescricao.Enabled = false;
            txtDocumento.Enabled = false;
            txtValorAtual.Enabled = false;
            txtValorCompra.Enabled = false;
            cBConservacao.Enabled = false;
            cBCategoria.Enabled = false;
            btSalvar.Enabled = false;
            btEditar.Enabled = false;
            btExcluir1.Enabled = false;
            dtCadastro.Enabled = false;
            dtCompra.Enabled = false;
        }

        //Método de SALVAR
        private void SalvarInventario()
        {
            try
            {
                con.AbrirConexao();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spInserirInventario";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@DataCadastro", dtCadastro.Text);
                Cmd.Parameters.AddWithValue("@Categoria", cBCategoria.Text);
                Cmd.Parameters.AddWithValue("@Item", txtItem.Text);
                Cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                Cmd.Parameters.AddWithValue("@DataCompra", dtCompra.Text);
                Cmd.Parameters.AddWithValue("@documento", txtDocumento.Text);
                Cmd.Parameters.AddWithValue("@ValorCompra", Convert.ToDecimal(txtValorCompra.Text));
                Cmd.Parameters.AddWithValue("@ValorAtual", Convert.ToDecimal(txtValorAtual.Text));
                Cmd.Parameters.AddWithValue("@Estado", cBConservacao.Text);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();
                MsgOk("Item salvo com sucesso!");
                LimparCampos();
                cBCategoria.Focus();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de salvar: " + ex.Message);
            }
        }

        //Método de ALTERAR
        private void AlterarInventario()
        {
            try
            {
                con.AbrirConexao();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spAlterarInventario";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdIv", idIv);
                Cmd.Parameters.AddWithValue("@DataCadastro", dtCadastro.Text);
                Cmd.Parameters.AddWithValue("@Categoria", cBCategoria.Text);
                Cmd.Parameters.AddWithValue("@Item", txtItem.Text);
                Cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                Cmd.Parameters.AddWithValue("@DataCompra", dtCompra.Text);
                Cmd.Parameters.AddWithValue("@documento", txtDocumento.Text);
                Cmd.Parameters.AddWithValue("@ValorCompra", Convert.ToDecimal(txtValorCompra.Text));
                Cmd.Parameters.AddWithValue("@ValorAtual", Convert.ToDecimal(txtValorAtual.Text));
                Cmd.Parameters.AddWithValue("@Estado", cBConservacao.Text);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();

                MsgOk("Item alterado com sucesso!");
                LimparCampos();
                cBCategoria.Focus();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de alterar: " + ex.Message);
            }
        }

        //Método de excluir
        private void ExcluirInventario()
        {
            try
            {
                con.AbrirConexao();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spExcluirInventario";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@IdIv", idIv);
                Cmd.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MsgErro("Erro no método de excluir: " + ex.Message);

            }
        }

        //Método de Buscar item por Nome
        private void BuscarItemNome()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "spBuscarItemNome";
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Item", txtBuscar.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridInventario.DataSource = Dt;
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MsgErro("Erro ao buscar por nome: " + ex.Message);
            }
        }

        //Método LISTAR
        private void Listar()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = con.Con;
                Cmd.CommandText = "Listar";
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridInventario.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no Método de Listar: " + ex.Message);
            }
        }

        //BOTÕES

        //botão NOVO
        private void btNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            btExcluir1.Enabled = false;
            btEditar.Enabled = false;
        }

        //botão SALVAR
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (cBCategoria.Text.Trim() == string.Empty)
            {
                MsgErro("Não há Categorias cadastradas! Favor cadastre uma categoria para continuar");
                return;
            }
            if (txtItem.Text == string.Empty)
            {
                MsgErro("Preencha o campo Item!");
                txtItem.Focus();
                return;
            }

            //Método p/ salvar membro
            SalvarInventario();
            Listar();
        }

        //botão ALTERAR
        private void btEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btExcluir1.Enabled = false;

            if (txtItem.Text == string.Empty)
            {
                MsgErro("Selecione um Item para alterar!");
                txtItem.Focus();
                return;
            }

            AlterarInventario();
            Listar();
        }

        //botão EXCLUIR
        private void btExcluir1_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            btEditar.Enabled = false;

            var result = MessageBox.Show("Deseja excluir?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                ExcluirInventario();
                MsgOk("Registro excluido com sucesso!!");
                Listar();
            }
        }

        //GRID
        private void gridInventario_DoubleClick(object sender, EventArgs e)
        {
            
            maskBem.Text = gridInventario.CurrentRow.Cells[0].Value.ToString();
            idIv = gridInventario.CurrentRow.Cells[0].Value.ToString();
            dtCadastro.Text = gridInventario.CurrentRow.Cells[1].Value.ToString();
            cBCategoria.Text = gridInventario.CurrentRow.Cells[2].Value.ToString();
            txtItem.Text = gridInventario.CurrentRow.Cells[3].Value.ToString();
            txtDescricao.Text = gridInventario.CurrentRow.Cells[4].Value.ToString();
            dtCompra.Text = gridInventario.CurrentRow.Cells[5].Value.ToString();
            txtDocumento.Text = gridInventario.CurrentRow.Cells[6].Value.ToString();
            txtValorCompra.Text = gridInventario.CurrentRow.Cells[7].Value.ToString();
            txtValorAtual.Text = gridInventario.CurrentRow.Cells[8].Value.ToString();
            cBConservacao.Text = gridInventario.CurrentRow.Cells[9].Value.ToString();
            tabControl1.SelectedIndex = 0;
            HabilitarCampos();
            txtDocumento.Enabled = false;
            btNovo.Enabled = false;
            btSalvar.Enabled = false;

        }

        //evento de Buscar por Nomes
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarItemNome();
        }

        //carregar FORMULÁRIO
        private void FrmInventario1_Load(object sender, EventArgs e)
        {
            Listar();
            cBCategoria.SelectedIndex = 0;
            cBConservacao.SelectedIndex = 0;
        }

        //botão CONSULTAR
        private void btConsulta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            FrmRelInventario frm = new FrmRelInventario();
            frm.Show();
        }
    }
}
