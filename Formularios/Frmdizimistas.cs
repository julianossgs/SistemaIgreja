using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Relatorios;

namespace WindowsFormsApp1.Formularios
{
    public partial class Frmdizimistas : Form
    {
        Conexao con = new Conexao();
        string idDiz;
       // decimal totalOfertas, totalDizimos;
        public Frmdizimistas()
        {
            InitializeComponent();
        }

        private void Frmdizimistas_Load(object sender, EventArgs e)
        {
            ListarDizimistas();
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
         
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
           
            txtDizimou.Clear();
            txtMembro.Clear();
            txtOferta.Clear();
            txtTotal.Clear();

        }

        private void HabilitarCampos(bool vr)
        {
            if (vr)
            {
              
                txtDizimou.Enabled = true; 
                txtMembro.Enabled=true;
                txtOferta.Enabled=true;
                txtBuscarMembro.Enabled = true;
              
            }
            else
            {
              
                txtDizimou.Enabled = false;
                txtMembro.Enabled = false;
                txtOferta.Enabled = false;
              
            }

        }

        private void ListarDizimistas()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "spListarDizimista";
                Cmd0.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd0;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridDizimista.DataSource = Dt;

                con.FecharConexao();

                TotalizarDizimos();
                TotalizarOfertas();
                TotalizarOfertasEspeciais();
                Totalizar();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao listar dizimistas: " + ex.Message);
            }
        }

        //Método de buscar membros
        private void BuscarMembros()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd8 = new SqlCommand();
                Cmd8.Connection = con.Con;
                Cmd8.CommandText = "spBuscarMembro";
                Cmd8.CommandType = CommandType.StoredProcedure;
                Cmd8.Parameters.AddWithValue("@Nome", txtBuscarMembro.Text);
                Cmd8.Parameters.AddWithValue("@DataInicial", dtInicial.Text);
                Cmd8.Parameters.AddWithValue("@DataFinal", dtFinal.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd8;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridDizimista.DataSource = Dt;
                con.FecharConexao();

                TotalizarDizimos();
                TotalizarOfertas();
                TotalizarOfertasEspeciais();
                Totalizar();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao buscar Membros: " + ex.StackTrace);
            }
        } 

        private void Totalizar()
        {
            decimal total = TotalizarDizimos() + TotalizarOfertas() + TotalizarOfertasEspeciais();
            lblDizimos.Text = TotalizarDizimos().ToString("C2");
            lblOfertas.Text = TotalizarOfertas().ToString("C2");
            lblOfertasEspeciais.Text = TotalizarOfertasEspeciais().ToString("C2");
            lblTotal.Text = total.ToString("C2");
           
        }

        private decimal TotalizarDizimos()
        {
            decimal total = 0;
            for (int i = 0; i < gridDizimista.Rows.Count; i++)
            {
                total += Convert.ToDecimal(gridDizimista.Rows[i].Cells[3].Value);
            }
            return total;

        }

        private decimal TotalizarOfertas()
        {
            decimal total = 0;
            for (int i = 0; i < gridDizimista.Rows.Count; i++)
            {
                total += Convert.ToDecimal(gridDizimista.Rows[i].Cells[4].Value);
            }
            return total;
        }

        private decimal TotalizarOfertasEspeciais()
        {
            decimal total = 0;
            for (int i = 0; i < gridDizimista.Rows.Count; i++)
            {
                total += Convert.ToDecimal(gridDizimista.Rows[i].Cells[5].Value);
            }
            return total;
        }



        //BOTÕES
        private void BtAddMembro_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            LimparCampos();

            Program.chamadadizimistas = "dizimista";
            frmMembros1 frmMembros = new frmMembros1();
            frmMembros.Show();
        }

        private void Frmdizimistas_Activated(object sender, EventArgs e)
        {
            txtMembro.Text = Program.membroDizimista;
        }

        //botão SALVAR
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtMembro.Text==string.Empty)
            {
                MsgErro("Selecione um Membro!");
              
                return;
            }

            if (txtDizimou.Text==string.Empty)
            {
                MsgErro("Informe o valor do Dízimo");
                txtDizimou.Focus();
                return;
            }

            //Cód p/ Inserir dizimista
            con.AbrirConexao();
            SqlCommand Cmd2 = new SqlCommand();
            Cmd2.Connection = con.Con;
            Cmd2.CommandText = "spInserirDizimista";
            Cmd2.CommandType = CommandType.StoredProcedure;
            Cmd2.Parameters.AddWithValue("@ValorDizimou",Convert.ToDecimal (txtDizimou.Text));
            Cmd2.Parameters.AddWithValue("Oferta",Convert.ToDecimal(txtOferta.Text));
            Cmd2.Parameters.AddWithValue("@Id_Membro", Program.idmembro);
            Cmd2.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtDizimou.Text) + Convert.ToDecimal(txtOferta.Text));
          
            Cmd2.ExecuteNonQuery();
            con.FecharConexao();

            MsgOk("Registro inserido com sucesso!");
            LimparCampos();
            HabilitarCampos(false);
            ListarDizimistas();

            TotalizarDizimos();
            TotalizarOfertas();
            TotalizarOfertasEspeciais();
            Totalizar();
        }

        //botão EDITAR
        private void BtEditar_Click(object sender, EventArgs e)
        {
           
            if (txtDizimou.Text == string.Empty)
            {
                MsgErro("Selecione o valor do Dízimo para alteração!");
                txtDizimou.Focus();
                return;
            }

            if (txtOferta.Text == string.Empty)
            {
                MsgErro("Selecione o valor que Oferta para alteração!");
                txtOferta.Focus();
                return;
            }


            //Cód p/ Alterar dizimista
            con.AbrirConexao();
            SqlCommand Cmd1 = new SqlCommand();
            Cmd1.Connection = con.Con;
            Cmd1.CommandText = "spAlterarDizimista";
            Cmd1.CommandType = CommandType.StoredProcedure;
            Cmd1.Parameters.AddWithValue("@IdDiz", idDiz);
         
            Cmd1.Parameters.AddWithValue("@ValorDizimou", Convert.ToDecimal(txtDizimou.Text));
            Cmd1.Parameters.AddWithValue("@OfertaEspecial", Convert.ToDecimal(txtOfertaEspecial.Text));
            Cmd1.Parameters.AddWithValue("Oferta", Convert.ToDecimal(txtOferta.Text));
            Cmd1.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtDizimou.Text) + Convert.ToDecimal(txtOferta.Text)+Convert.ToDecimal(txtOfertaEspecial.Text));
          
            Cmd1.ExecuteNonQuery();
            con.FecharConexao();

            MsgOk("Registro alterado com sucesso!");
            LimparCampos();
            HabilitarCampos(false);
            ListarDizimistas();

            TotalizarDizimos();
            TotalizarOfertas();
            TotalizarOfertasEspeciais();
            Totalizar();
        }

        private void GridDizimista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            idDiz = gridDizimista.CurrentRow.Cells[0].Value.ToString();
            txtDizimou.Text = gridDizimista.CurrentRow.Cells[3].Value.ToString();
            txtOferta.Text = gridDizimista.CurrentRow.Cells[4].Value.ToString();
            txtMembro.Text = gridDizimista.CurrentRow.Cells[2].Value.ToString();
            txtTotal.Text = gridDizimista.CurrentRow.Cells[6].Value.ToString();
           
            txtOfertaEspecial.Text = gridDizimista.CurrentRow.Cells[5].Value.ToString();
          
        }

        private void TxtBuscarMembro_TextChanged(object sender, EventArgs e)
        {
            BuscarMembros();
        }

      
        private void BtRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelDizimista frm = new FrmRelDizimista();
            frm.Show();
        }

        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarMembros();
        }

      

        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarMembros();
        }

       
    }
}
