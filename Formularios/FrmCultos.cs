using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using WindowsFormsApp1.Relatorios;


namespace WindowsFormsApp1.Formularios
{
    public partial class FrmCultos : Form
    {
        Conexao con = new Conexao();

        public string IdDiz;
        public string idculto;
        public string ultimoIdculto;
        public string ultimoIdDiz;
        public string ultimoIdMov;
        public string idmov;
        public string ultimoIdExcluido;
        public string ultimoIdAlterado;
        public FrmCultos()
        {
            InitializeComponent();
        }

        private void FrmCultos_Load(object sender, EventArgs e)
        {

            txtDizimista.Text = "Dizimista/Ofertante não declarados";
            txtDizimo.Text = "0,00";
            txtOferta.Text = "0,00";
            txtOfertaEspecial.Text = "0,00";

            checkBox1.Checked = false;
            dtInicial.Value = DateTime.Today;
            dtFinal.Value = DateTime.Today;
            dtCulto.Value = DateTime.Today;
            ListarCultos();
            ListarDetalhesCulto();

            label20.Visible = false;
            PreencherCBoxBuscarCulto();
            PreencherCBoxTipoCulto();
            cBCulto.SelectedIndex = 0;

        }


        private void MsgErro(string msg)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void MsgOk(string msg)
        {
            MessageBox.Show(msg, "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void LimparCamposCulto()
        {
            txtDizimista.Text = "Dizimista/Ofertante não declarados";
            txtDizimo.Text = "0,00";
            txtOferta.Text = "0,00";
            txtOfertaEspecial.Text = "0,00";

            txtObs.Clear();
            txtPessoas.Clear();

        }

        private void LimparCamposDizimo()
        {
            txtDizimista.Text = "Dizimista/Ofertante não declarados";
            txtDizimo.Text = "0,00";
            txtOferta.Text = "0,00";
            txtOfertaEspecial.Text = "0,00";

            txtOferta.Clear();
            txtTotal.Clear();
            txtDizimo.Clear();
            txtOfertaEspecial.Clear();

        }

        private void HabilitarCampos(bool vr)
        {
            if (vr)
            {
                txtOfertaEspecial.Enabled = true;

                txtDizimo.Enabled = true;
                txtOferta.Enabled = true;
                btExcluirDiz.Enabled = true;
                btCancelarDizimo.Enabled = true;
                btAddDizimo.Enabled = true;
                btEditar.Enabled = true;
                btSalvar.Enabled = true;
                btSalvarDizimo.Enabled = true;

            }
            else
            {
                txtOfertaEspecial.Enabled = false;

                txtDizimo.Enabled = false;
                txtOferta.Enabled = false;
                btExcluirDiz.Enabled = false;
                btAddDizimo.Enabled = false;
                btCancelarDizimo.Enabled = false;
                btEditar.Enabled = false;

                btSalvar.Enabled = false;
                btSalvarDizimo.Enabled = false;
            }

        }

        //Preencher combo box de tipo de cultos
        private void PreencherCBoxTipoCulto()
        {
            con.AbrirConexao();
            SqlCommand Cmd5 = new SqlCommand();
            Cmd5.Connection = con.Con;
            Cmd5.CommandText = "spListarTipoCulto";
            Cmd5.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Cmd5;
            DataTable Dt = new DataTable();
            da.Fill(Dt);
            cBCulto.DataSource = Dt;
            cBCulto.ValueMember = "IdTipoCulto";
            cBCulto.DisplayMember = "TipoCulto";
            con.FecharConexao();
        }

        //Preencher comboBox de cBBuscarCulto
        private void PreencherCBoxBuscarCulto()
        {
            con.AbrirConexao();
            SqlCommand Cmd22 = new SqlCommand();
            Cmd22.Connection = con.Con;
            Cmd22.CommandText = "spListarTipoCulto";
            Cmd22.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Cmd22;
            DataTable Dt = new DataTable();
            da.Fill(Dt);
            cBBuscarCulto.DataSource = Dt;
            cBBuscarCulto.ValueMember = "IdTipoCulto";
            cBBuscarCulto.DisplayMember = "TipoCulto";
            con.FecharConexao();
        }

        private void ListarCultos()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "spListarCultos";
                Cmd0.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd0;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridCULTOS.DataSource = Dt;
                con.FecharConexao();
                gridDetalhesCulto.Visible = false;

            }
            catch (Exception ex)
            {

                MsgErro("Erro ao listar culto: " + ex.Message);
            }
        }

        //Mét p/ listar as movimentações que não tem o dizimista declarado
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
                gridDetalhesCulto.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao Listar Movimentações: " + ex.Message);
            }

            Totalizar();
            gridDetalhesCulto.Visible = true;

        }

        //Método / Listar Detalhes do Culto
        private void ListarDetalhesCulto()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd1 = new SqlCommand();
                Cmd1.Connection = con.Con;
                Cmd1.CommandText = "spListarDetalhesCulto2";
                Cmd1.CommandType = CommandType.StoredProcedure;
                Cmd1.Parameters.AddWithValue("@Id_Culto", "0");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd1;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridDetalhesCulto.DataSource = Dt;
                con.FecharConexao();

                TotalizarDizimos();
                TotalizarOfertas();
                TotalizarOfertasEspeciais();
                Totalizar();
                gridDetalhesCulto.Visible = true;

            }
            catch (Exception ex)
            {

                MsgErro("Erro ao Listar os Detalhes do Culto: " + ex.Message);
            }
        }

        //Método de buscar cultos
        private void BuscarCultos()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd8 = new SqlCommand();
                Cmd8.Connection = con.Con;
                Cmd8.CommandText = "spBuscarCultos";
                Cmd8.CommandType = CommandType.StoredProcedure;
                Cmd8.Parameters.AddWithValue("@TipoCulto", cBBuscarCulto.Text);
                Cmd8.Parameters.AddWithValue("@DataInicial", dtInicial.Text);
                Cmd8.Parameters.AddWithValue("@DataFinal", dtFinal.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd8;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridCULTOS.DataSource = Dt;
                con.FecharConexao();
                lblDizimos.Text = "";
                lblOfertas.Text = "";
                lblOfertasEspeciais.Text = "";
                lblTotal.Text = "";
                label20.Visible = false;
                gridDetalhesCulto.Visible = false;


            }
            catch (Exception ex)
            {

                MsgErro("Erro ao buscar cultos: " + ex.Message);
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
            for (int i = 0; i < gridDetalhesCulto.Rows.Count; i++)
            {
                total += Convert.ToDecimal(gridDetalhesCulto.Rows[i].Cells[3].Value);
            }
            return total;

        }

        private decimal TotalizarOfertas()
        {
            decimal total = 0;
            for (int i = 0; i < gridDetalhesCulto.Rows.Count; i++)
            {
                total += Convert.ToDecimal(gridDetalhesCulto.Rows[i].Cells[4].Value);
            }
            return total;
        }

        private decimal TotalizarOfertasEspeciais()
        {
            decimal total = 0;
            for (int i = 0; i < gridDetalhesCulto.Rows.Count; i++)
            {
                total += Convert.ToDecimal(gridDetalhesCulto.Rows[i].Cells[5].Value);
            }
            return total;
        }



        //Método de buscar os detalhes do culto
        private void BuscarDetalhesCulto()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd111 = new SqlCommand();
                Cmd111.Connection = con.Con;
                Cmd111.CommandText = "spBuscarDetalhesCulto2";
                Cmd111.CommandType = CommandType.StoredProcedure;
                Cmd111.Parameters.AddWithValue("@Id_Culto", idculto);//idculto
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd111;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridDetalhesCulto.DataSource = Dt;
                con.FecharConexao();
                gridDetalhesCulto.Visible = true;
                TotalizarDizimos();
                TotalizarOfertas();
                TotalizarOfertasEspeciais();
                Totalizar();

            }
            catch (Exception ex)
            {

                MsgErro("Erro ao buscar os detalhes do culto: " + ex.Message + ex.StackTrace);
            }
        } 

        //Método de Salvar o Culto
        private void SalvarCulto()
        {
            con.AbrirConexao();
            SqlCommand Cmd3 = new SqlCommand();
            Cmd3.Connection = con.Con;
            Cmd3.CommandText = "spInserirCultos";
            Cmd3.CommandType = CommandType.StoredProcedure;
            Cmd3.Parameters.AddWithValue("@Data", dtCulto.Text);
            Cmd3.Parameters.AddWithValue("@Obs", txtObs.Text);
            Cmd3.Parameters.AddWithValue("@Quant", Convert.ToInt32(txtPessoas.Text));
            Cmd3.Parameters.AddWithValue("@TipoCulto", cBCulto.Text);
            Cmd3.ExecuteNonQuery();
            con.FecharConexao();
        }

        //Método para Recuperar último Id do Culto que foi salvo
        private void RecuperarIdCulto()
        {
            con.AbrirConexao();
            SqlCommand CmdVerificar = new SqlCommand();
            CmdVerificar.Connection = con.Con;
            CmdVerificar.CommandText = "spRecuperarUltimoIdCulto";
            CmdVerificar.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;
            reader = CmdVerificar.ExecuteReader();

            if (reader.HasRows)
            {
                //extraíndo informações da consulta
                while (reader.Read())
                {
                    ultimoIdculto = Convert.ToString(reader["IdCulto"]);
                }

            }

        }

        //Método para Relacionar os dizimos com o culto
        private void RelacionarDizCulto()
        {
            con.AbrirConexao();
            SqlCommand CmdRelacionar = new SqlCommand();
            CmdRelacionar.Connection = con.Con;
            CmdRelacionar.CommandText = "spRelacionarDetalhesCulto";
            CmdRelacionar.CommandType = CommandType.StoredProcedure;
            CmdRelacionar.Parameters.AddWithValue("@IdDiz", "0");
            CmdRelacionar.Parameters.AddWithValue("@Id_Culto", ultimoIdculto);
            CmdRelacionar.ExecuteNonQuery();
            con.FecharConexao();
        }

        //Método p/ Alterar Cultos
        private void AlterarCulto()
        {
            //Cód p/ alterar o culto
            con.AbrirConexao();
            SqlCommand Cmd4 = new SqlCommand();
            Cmd4.Connection = con.Con;
            Cmd4.CommandText = "spAlterarCultos";
            Cmd4.CommandType = CommandType.StoredProcedure;
            Cmd4.Parameters.AddWithValue("@IdCulto", idculto);
            Cmd4.Parameters.AddWithValue("@Data", dtCulto.Text);
            Cmd4.Parameters.AddWithValue("@Obs", txtObs.Text);
            Cmd4.Parameters.AddWithValue("@Quant", Convert.ToInt32(txtPessoas.Text));
            Cmd4.Parameters.AddWithValue("@TipoCulto", cBCulto.Text);

            Cmd4.ExecuteNonQuery();
            con.FecharConexao();
        }

        //Método de Excluir cultos
        private void ExcluirCultos()
        {
            con.AbrirConexao();
            SqlCommand Cmd31 = new SqlCommand();
            Cmd31.Connection = con.Con;
            Cmd31.CommandText = "spExcluirCultos";
            Cmd31.CommandType = CommandType.StoredProcedure;
            Cmd31.Parameters.AddWithValue("@IdCulto", idculto);
            Cmd31.ExecuteNonQuery();
            con.FecharConexao();
        }


        //**************************************************

        //BOTÕES
        //botão Novo
        private void BtNovo_Click(object sender, EventArgs e)
        {
            dtCulto.Value = DateTime.Now;

            if (cBCulto.Text == string.Empty)
            {
                MessageBox.Show("Cadastre um culto!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Close();
            }

            checkBox1.Checked = false;
            btAddDizimo.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            txtDizimista.Enabled = false;
            txtPessoas.Enabled = true;
            txtObs.Enabled = true;
            dtCulto.Enabled = true;
            cBCulto.Enabled = true;
            txtDizimo.Enabled = true;
            txtOferta.Enabled = true;
            txtOfertaEspecial.Enabled = true;

            LimparCamposDizimo();
            LimparCamposCulto();
            HabilitarCampos(true);
            btSalvar.Enabled = true;
            btEditar.Enabled = false;
            btImprimir.Enabled = true;

        }

        //botão Salvar somente o culto 
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (dtCulto.Text == string.Empty)
            {
                MessageBox.Show("Informe a data do Culto!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                dtCulto.Focus();
                return;
            }
            if (txtPessoas.Text == string.Empty)
            {
                MessageBox.Show("Informe o número de pessoa presentes no Culto!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPessoas.Focus();
                return;
            }

            //Métodos
            SalvarCulto();
            RecuperarIdCulto();
            RelacionarDizCulto();
            
            if (txtTotal.Text == "0,00")
            {
                //Cód p/ salvar quando não houver valores p/ dizimos e ofertas
                con.AbrirConexao();
                SqlCommand Cmd001 = new SqlCommand();
                Cmd001.Connection = con.Con;
                Cmd001.CommandText = "spInserirDD";
                Cmd001.CommandType = CommandType.StoredProcedure;
                Cmd001.Parameters.AddWithValue("@Id_Culto", ultimoIdculto);
                Cmd001.Parameters.AddWithValue("@Id_Membro", "0");
                Cmd001.Parameters.AddWithValue("@Data", dtCulto.Text);
                Cmd001.Parameters.AddWithValue("@Dizimista", "Não houve entrada de valores no culto!");
                Cmd001.Parameters.AddWithValue("@Dizimo", Convert.ToDecimal(txtDizimo.Text));
                Cmd001.Parameters.AddWithValue("@Oferta", Convert.ToDecimal(txtOferta.Text));
                Cmd001.Parameters.AddWithValue("@OfertaEspecial", Convert.ToDecimal(txtOfertaEspecial.Text));
                Cmd001.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtDizimo.Text) + Convert.ToDecimal(txtOferta.Text) + Convert.ToDecimal(txtOfertaEspecial.Text));
                Cmd001.ExecuteNonQuery();
                con.FecharConexao();
            }

            MessageBox.Show("Registro(Culto) inserido com sucesso!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Information);

            
            LimparCamposDizimo();
            LimparCamposCulto();
            btNovo.Enabled = true;
            btNovo.Focus();
            btSalvar.Enabled = false;
            btImprimir.Enabled = false;
           
            txtPessoas.Enabled = false;
            txtObs.Enabled = false;
            dtCulto.Enabled = false;
            cBCulto.Enabled = false;
            checkBox1.Checked = false;

            tabControl1.SelectedIndex = 1;
            ListarCultos();
            ListarDetalhesCulto();
            if (lblTotal.Text == "R$ 0,00")
            {
               
                btExcluirDiz.Visible = false;
            }
            else
            {
                
                btExcluirDiz.Visible = true;
                btExcluirDiz.Enabled = true;
            }
           
        }

        //botão Editar Culto
        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (dtCulto.Text == string.Empty)
            {
                MessageBox.Show("Selecione a data do Culto para alteração!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                dtCulto.Focus();
                return;
            }

            if (cBCulto.Text == string.Empty)
            {
                MessageBox.Show("Selecione um Culto para alterar!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBCulto.Focus();
                return;
            }

            //Método
            AlterarCulto();

            MessageBox.Show("Registro(Culto) alterado com sucesso!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LimparCamposCulto();
            
            tabControl1.SelectedIndex = 1;
            label20.Visible = false;
            btExcluirDiz.Visible = false;
            btSalvarDizimo.Enabled = true;
            btCancelarDizimo.Enabled = true;
           
            ListarDetalhesCulto();
            ListarCultos();

        }

        //botão add Dízimos ao culto na tab de dizimistas e na movimentação
        private void BtSalvarDizimo_Click(object sender, EventArgs e)
        {

            if (txtDizimo.Text == string.Empty)
            {
                MessageBox.Show("Informe o valor do Dizimo!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDizimo.Focus();
                return;
               
            }

            //teste
            if (txtDizimista.Text == "Dizimista/Ofertante não declarados")
            {
                con.AbrirConexao();
                SqlCommand Cmd000 = new SqlCommand();
                Cmd000.Connection = con.Con;
                Cmd000.CommandText = "spInserirDD";
                Cmd000.CommandType = CommandType.StoredProcedure;
                Cmd000.Parameters.AddWithValue("@Data", dtCulto.Text);
                Cmd000.Parameters.AddWithValue("@Id_Culto", "0");
                Cmd000.Parameters.AddWithValue("@Id_Membro", "0");
                Cmd000.Parameters.AddWithValue("@Dizimista", "Dizimista/Ofertante não declarados");
                Cmd000.Parameters.AddWithValue("@Dizimo", Convert.ToDecimal(txtDizimo.Text));
                Cmd000.Parameters.AddWithValue("@Oferta", Convert.ToDecimal(txtOferta.Text));
                Cmd000.Parameters.AddWithValue("@OfertaEspecial", Convert.ToDecimal(txtOfertaEspecial.Text));
                Cmd000.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtDizimo.Text) + Convert.ToDecimal(txtOferta.Text) + Convert.ToDecimal(txtOfertaEspecial.Text));
                Cmd000.ExecuteNonQuery();
                con.FecharConexao();
            }

            else
            {
                con.AbrirConexao();
                SqlCommand Cmd6 = new SqlCommand();
                Cmd6.Connection = con.Con;
                Cmd6.CommandText = "spInserirDD";
                Cmd6.CommandType = CommandType.StoredProcedure;
                Cmd6.Parameters.AddWithValue("@Data", dtCulto.Text);
                Cmd6.Parameters.AddWithValue("@Id_Culto", "0");
                Cmd6.Parameters.AddWithValue("@Id_Membro", Program.idmembro);
                Cmd6.Parameters.AddWithValue("@Dizimista", txtDizimista.Text);
                Cmd6.Parameters.AddWithValue("@Dizimo", Convert.ToDecimal(txtDizimo.Text));
                Cmd6.Parameters.AddWithValue("@Oferta", Convert.ToDecimal(txtOferta.Text));
                Cmd6.Parameters.AddWithValue("@OfertaEspecial", Convert.ToDecimal(txtOfertaEspecial.Text));
                Cmd6.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtDizimo.Text) + Convert.ToDecimal(txtOferta.Text) + Convert.ToDecimal(txtOfertaEspecial.Text));
                Cmd6.ExecuteNonQuery();
                con.FecharConexao();
            }

            //recuperar ultimo Id do Diz
            con.AbrirConexao();
            SqlCommand CmdVerificar = new SqlCommand();
            CmdVerificar.Connection = con.Con;
            CmdVerificar.CommandText = "spRecuperarUltimoIdDiz";
            CmdVerificar.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;
            reader = CmdVerificar.ExecuteReader();

            if (reader.HasRows)
            {
                //extraíndo informações da consulta
                while (reader.Read())
                {
                    ultimoIdDiz = Convert.ToString(reader["IdDiz"]);
                }

            }

            //Cód p/ inserir dizimos/ofertas na movimentação
            con.AbrirConexao();
            SqlCommand Cmd44 = new SqlCommand();
            Cmd44.Connection = con.Con;
            Cmd44.CommandText = "spInserirMov";
            Cmd44.CommandType = CommandType.StoredProcedure;
            Cmd44.Parameters.AddWithValue("@Data", dtCulto.Text);
            Cmd44.Parameters.AddWithValue("@Tipo", "Entrada");
            Cmd44.Parameters.AddWithValue("@Movimento", "Dizimos e Ofertas");
            Cmd44.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtDizimo.Text) + Convert.ToDecimal(txtOferta.Text) + Convert.ToDecimal(txtOfertaEspecial.Text));
            Cmd44.Parameters.AddWithValue("@Id_Movimento", ultimoIdDiz);
            Cmd44.ExecuteNonQuery();
            con.FecharConexao();

            var result = MessageBox.Show("Valores inseridos com sucesso! - Lançar outros Dizimos/OFertas?", "ATENÇÃO !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
               
                    MessageBox.Show("Clique em SALVAR CULTO para finalizar a operação!", "ATENÇÃO !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btSalvar.Focus();
                
            }

            ListarDetalhesCulto();

            txtDizimista.Text = "Dizimista/Ofertante não declarados";
            txtDizimo.Text = "0,00";
            txtOferta.Text = "0,00";
            txtOfertaEspecial.Text = "0,00";
           
        }

        private void CBBuscarCulto_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarCultos();
        }

        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarCultos();
        }

        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarCultos();
        }

        //botão CANCELAR lançamento do dízimo
        private void BtCancelarDizimo_Click(object sender, EventArgs e)
        {
            LimparCamposDizimo();
            txtDizimista.Text = "Dizimista/Ofertante não declarados";
            txtDizimo.Text = "0,00";
            txtOferta.Text = "0,00";
            txtOfertaEspecial.Text = "0,00";
            txtTotal.Text = "0,00";
            btAddDizimo.Focus();
        }

        //botão de Add o Dizimista
        private void BtAddDizimo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            txtDizimista.Text = "Dizimista/Ofertante não declarados";
            txtDizimo.Text = "0,00";
            txtOferta.Text = "0,00";
            txtOfertaEspecial.Text = "0,00";
            btEditar.Enabled = false;

            Program.chamadadizimistas = "dizimista";
            frmMembros1 frmMembros = new frmMembros1();
            frmMembros.Show();

        }

        private void FrmCultos_Activated(object sender, EventArgs e)
        {
            txtDizimista.Text = Program.membroDizimista;
        }

        private void LblLancar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            LimparCamposDizimo();
        }

        //evento no grid de cultos p/ buscar os detalhes do culto
        private void GridCULTOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                idculto = gridCULTOS.CurrentRow.Cells[0].Value.ToString();

                //variável usada no relatório de cultos
                Program.idCULTO = gridCULTOS.CurrentRow.Cells[0].Value.ToString();

                dtCulto.Text = gridCULTOS.CurrentRow.Cells[1].Value.ToString();
                cBCulto.Text = gridCULTOS.CurrentRow.Cells[4].Value.ToString();
                txtPessoas.Text = gridCULTOS.CurrentRow.Cells[2].Value.ToString();
                txtObs.Text = gridCULTOS.CurrentRow.Cells[3].Value.ToString();

                BuscarDetalhesCulto();
                gridDetalhesCulto.Visible = true;
                label20.Visible = true;
                btEditar.Enabled = true;
                btSalvar.Enabled = true;
                btNovo.Enabled = false;
                btEditarCulto.Enabled = true;
                btExcluirCulto.Enabled = true;
                btImprimir.Enabled = true;

                if (lblTotal.Text == "R$ 0,00")
                {
                    btExcluirDiz.Visible = false;

                }
                else
                {
                    btExcluirDiz.Visible = true;
                    btExcluirDiz.Enabled = true;
                }
            
           
        }

        //botao para ALTERAR Dizimos/OFertas
        private void BtAlterarDizimosOfertas_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtDizimista.Enabled = true;
            txtDizimo.Enabled = true;
            txtOferta.Enabled = true;
            txtOfertaEspecial.Enabled = true;
            btAddDizimo.Enabled = false;
            btEditar.Enabled = true;
            btNovo.Enabled = false;
            btSalvarDizimo.Enabled = false;


            try
            {
                //Cód p/ alterar dizimo no Frmculto
                con.AbrirConexao();
                SqlCommand Cmd12 = new SqlCommand();
                Cmd12.Connection = con.Con;
                Cmd12.CommandText = "spAlterarDiz";
                Cmd12.CommandType = CommandType.StoredProcedure;
                Cmd12.Parameters.AddWithValue("@IdDiz", IdDiz);
                Cmd12.Parameters.AddWithValue("@Dizimo", Convert.ToDecimal(txtDizimo.Text));
                Cmd12.Parameters.AddWithValue("@Oferta", Convert.ToDecimal(txtOferta.Text));
                Cmd12.Parameters.AddWithValue("@OfertaEspecial", Convert.ToDecimal(txtOfertaEspecial.Text));
                Cmd12.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtDizimo.Text) + Convert.ToDecimal(txtOferta.Text) + Convert.ToDecimal(txtOfertaEspecial.Text));
                Cmd12.ExecuteNonQuery();
                con.FecharConexao();

                //Recuperar último Id do Dizimista que foi excluído
                con.AbrirConexao();
                SqlCommand CmdVerificar = new SqlCommand();
                CmdVerificar.Connection = con.Con;
                CmdVerificar.CommandText = "spRecuperarUltimoIdAlterado";
                CmdVerificar.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader;
                reader = CmdVerificar.ExecuteReader();

                if (reader.HasRows)
                {
                    //extraíndo informações da consulta
                    while (reader.Read())
                    {
                        ultimoIdAlterado = Convert.ToString(reader["IdDiz"]);
                    }

                }

                //Relacionar o dizimo alterado com a movimentação
                con.AbrirConexao();
                SqlCommand CmdRelacionar = new SqlCommand();
                CmdRelacionar.Connection = con.Con;
                CmdRelacionar.CommandText = "spRelacionarIdAlteradoMov";
                CmdRelacionar.CommandType = CommandType.StoredProcedure;
                CmdRelacionar.Parameters.AddWithValue("@IdDiz", "0");
                CmdRelacionar.Parameters.AddWithValue("@Id_Movimento", ultimoIdAlterado);
                CmdRelacionar.ExecuteNonQuery();
                con.FecharConexao();


                MessageBox.Show("Registro Alterado com sucesso!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimparCamposDizimo();
                ListarDetalhesCulto();


                //Alterar nas movimentações
                con.AbrirConexao();
                SqlCommand Cmd13 = new SqlCommand();
                Cmd13.Connection = con.Con;
                Cmd13.CommandText = "spAtualizarMovDiz";
                Cmd13.CommandType = CommandType.StoredProcedure;
                Cmd13.Parameters.AddWithValue("@IdMov", idmov);
                Cmd13.Parameters.AddWithValue("@Id_Movimento", IdDiz);
                Cmd13.Parameters.AddWithValue("@Movimento", "Dizimos e Ofertas");
                Cmd13.Parameters.AddWithValue("@Tipo", "Entrada");
                Cmd13.Parameters.AddWithValue("@Total", Convert.ToDouble(txtTotal.Text));
                Cmd13.ExecuteNonQuery();
                con.FecharConexao();

            }
            catch (Exception ex)
            {

                MsgErro("Erro ao executar o método de Alterar: " + ex.Message + ex.StackTrace);
            }

        }

        //evento de duplo click na grid de cultos
        //para alteração dos Cultos
        private void GridCULTOS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        //evento no tabcontrol(ao alterar a tabpage)
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //evento de click na grid de Detalhes do culto
        private void gridDetalhesCulto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //botão IMPRIMIR CULTOS
        private void btImprimir_Click(object sender, EventArgs e)
        {
            if (gridCULTOS.SelectedRows.Count < 0)//&& gridCULTOS.RowCount == 0)
            {
                MessageBox.Show("Não há Cultos cadastrados para a impressão!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmRelCulto frmRelCulto = new FrmRelCulto();
            frmRelCulto.Show();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            btEditar.Enabled = false;
            btSalvar.Visible = true;
            btSalvar.Enabled = false;
            groupBox1.Visible = true;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            btNovo.Visible = true;
            btNovo.Enabled = true;
            gridDetalhesCulto.Visible = false;
            label20.Visible = false;
            dtCulto.Value = DateTime.Today;
            btNovo.Enabled = true;
            groupBox2.Visible = true;
            ListarDetalhesCulto();
            if (lblTotal.Text == "R$ 0,00")
            {

                btExcluirDiz.Visible = false;
               
            }
            else
            {

                btExcluirDiz.Visible = true;
                btExcluirDiz.Enabled = true;
             
            }

            LimparCamposCulto();
            LimparCamposDizimo();
        }

        //botão de EXCLUIR CULTOS
        private void btExcluirCulto_Click(object sender, EventArgs e)
        {

            if (lblTotal.Text == "R$ 0,00")
            {
                var result = MessageBox.Show("Excluir o Culto?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if (result == DialogResult.OK)
                {
                    ExcluirCultos();
                    MessageBox.Show("Culto excluido com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label20.Visible = false;
                    btExcluirDiz.Visible = false;
                    ListarCultos();
                }
              
            }
            else
            {
                MessageBox.Show("Há Dizimos/Ofertas lançados no Culto! - Você precisa excluir todos os Dizimos/OFertas do Culto.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        }

        //evento do checBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtDizimista.Text = "Não houve entrada de valores no culto!";
                txtDizimo.Text = "0,00";
                txtOferta.Text = "0,00";
                txtOfertaEspecial.Text = "0,00";
                txtTotal.Text = "0,00";
                btSalvar.Focus();
                btSalvar.Enabled = true;
                btNovo.Enabled = true;
                groupBox1.Enabled = false;

            }
            else
            {
                groupBox1.Enabled = true;
                txtDizimista.Text = "Dizimista/Ofertante não declarados";
                txtDizimo.Text = "0,00";
                txtOferta.Text = "0,00";
                txtOfertaEspecial.Text = "0,00";
                txtTotal.Text = "0,00";
                btAddDizimo.Focus();
                btSalvar.Enabled = true;
                btNovo.Enabled = false;
            }
          

        }



        //botão de ACESSO para excluir os dizimos e ofertas do culto
        private void btExcluirDiz_Click(object sender, EventArgs e)
        {
            if (gridDetalhesCulto.RowCount == 0)
            {
                MessageBox.Show("Não há Dizimos/Ofertas cadastrados neste Culto!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.SelectedIndex = 0;
            groupBox2.Visible = true;
            groupBox2.Enabled = false;

            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            btExcluirDizimosOfertas.Focus();
            btExcluirDizimosOfertas.Enabled = true;
            btAddDizimo.Enabled = false;
            btNovo.Visible = true;
            btNovo.Enabled = false;
            btSalvar.Enabled = false;
            btSalvar.Visible = true;
            btEditar.Enabled = false;
            btImprimir.Enabled = false;
            btSalvarDizimo.Enabled = false;
            btCancelarDizimo.Enabled = false;
            txtTotal.Enabled = false;
            txtDizimo.Enabled = false;
            txtOferta.Enabled = false;
            txtOfertaEspecial.Enabled = false;

            idculto = gridCULTOS.CurrentRow.Cells[0].Value.ToString();
            dtCulto.Text = gridCULTOS.CurrentRow.Cells[1].Value.ToString();
            cBCulto.Text = gridCULTOS.CurrentRow.Cells[4].Value.ToString();
            txtPessoas.Text = gridCULTOS.CurrentRow.Cells[2].Value.ToString();
            txtObs.Text = gridCULTOS.CurrentRow.Cells[3].Value.ToString();

            IdDiz = gridDetalhesCulto.CurrentRow.Cells[0].Value.ToString();
            Program.idmembro = gridDetalhesCulto.CurrentRow.Cells[7].Value.ToString();
            txtDizimista.Text = gridDetalhesCulto.CurrentRow.Cells[2].Value.ToString();
            txtDizimo.Text = gridDetalhesCulto.CurrentRow.Cells[3].Value.ToString();
            txtOferta.Text = gridDetalhesCulto.CurrentRow.Cells[4].Value.ToString();
            txtOfertaEspecial.Text = gridDetalhesCulto.CurrentRow.Cells[5].Value.ToString();
            txtTotal.Text = gridDetalhesCulto.CurrentRow.Cells[6].Value.ToString();
        }


        //botão p/ EXCLUIR dizimos e ofertas
        private void btExcluirDizimosOfertas_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtDizimista.Enabled = false;
            txtDizimo.Enabled = false;
            txtOferta.Enabled = false;
            txtOfertaEspecial.Enabled = false;
            btAddDizimo.Enabled = false;
            btEditar.Enabled = false;
            btNovo.Enabled = false;
            btSalvarDizimo.Enabled = false;

            try
            {
                //Cód p/ excluir dizimo no Frmculto
                con.AbrirConexao();
                SqlCommand Cmd122 = new SqlCommand();
                Cmd122.Connection = con.Con;
                Cmd122.CommandText = "spExcluirDiz";
                Cmd122.CommandType = CommandType.StoredProcedure;
                Cmd122.Parameters.AddWithValue("@IdDiz", IdDiz);

                Cmd122.ExecuteNonQuery();
                con.FecharConexao();

                //Recuperar último Id do Dizimista que foi excluído
                con.AbrirConexao();
                SqlCommand CmdVerificar = new SqlCommand();
                CmdVerificar.Connection = con.Con;
                CmdVerificar.CommandText = "spRecuperarUltimoIdExcluido";
                CmdVerificar.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader;
                reader = CmdVerificar.ExecuteReader();

                if (reader.HasRows)
                {
                    //extraíndo informações da consulta
                    while (reader.Read())
                    {
                        ultimoIdExcluido = Convert.ToString(reader["IdDiz"]);
                    }

                }

                //Relacionar os dizimos com a movimentação
                con.AbrirConexao();
                SqlCommand CmdRelacionar = new SqlCommand();
                CmdRelacionar.Connection = con.Con;
                CmdRelacionar.CommandText = "spRelacionarIdExcluidoMov";
                CmdRelacionar.CommandType = CommandType.StoredProcedure;
                CmdRelacionar.Parameters.AddWithValue("@IdDiz", "0");
                CmdRelacionar.Parameters.AddWithValue("@Id_Movimento", ultimoIdExcluido);
                CmdRelacionar.ExecuteNonQuery();
                con.FecharConexao();

                //Excluir nas movimentações
                con.AbrirConexao();
                SqlCommand Cmd133 = new SqlCommand();
                Cmd133.Connection = con.Con;
                Cmd133.CommandText = "spExcluirMov";
                Cmd133.CommandType = CommandType.StoredProcedure;
                Cmd133.Parameters.AddWithValue("@IdDiz", IdDiz);
                Cmd133.Parameters.AddWithValue("@Tipo", "Entrada");
                Cmd133.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro Excluido com sucesso!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimparCamposDizimo();
                ListarDetalhesCulto();
                tabControl1.SelectedIndex = 1;

            }
            catch (Exception ex)
            {

                MsgErro("Erro ao executar o método de Excluir: " + ex.Message + ex.StackTrace);
            }

        }

       

        private void FrmCultos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (btSalvar.Enabled == true)
                {
                    MessageBox.Show("O Culto não foi salvo! - Finalize a operação antes de SAIR!");
                    e.Cancel = true;
                }
            }

        }

        //botão de ACESSO para EDITAR CULTOS
        private void btEditarCulto_Click(object sender, EventArgs e)
        {
            if (gridCULTOS.RowCount == 0)
            {
                MessageBox.Show("Não há Cultos cadastrados!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               
                tabControl1.SelectedIndex = 0;
                groupBox2.Visible = true;
                groupBox2.Enabled = true;
                groupBox1.Visible = false;
             
                idculto = gridCULTOS.CurrentRow.Cells[0].Value.ToString();
                dtCulto.Text = gridCULTOS.CurrentRow.Cells[1].Value.ToString();
                cBCulto.Text = gridCULTOS.CurrentRow.Cells[4].Value.ToString();
                txtPessoas.Text = gridCULTOS.CurrentRow.Cells[2].Value.ToString();
                txtObs.Text = gridCULTOS.CurrentRow.Cells[3].Value.ToString();

                btImprimir.Enabled = true;
                btSalvar.Visible = false;
                checkBox1.Visible = false;

                btEditar.Visible = true;
                btEditar.Enabled = true;
                btNovo.Visible = false;
                cBCulto.Enabled = true;
                txtObs.Enabled = true;
                txtPessoas.Enabled = true;

                if (gridDetalhesCulto.RowCount == 0)
                {
                    MessageBox.Show("Não há dizimos/Ofertas para este Culto!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }

        //cód para o usuário não digitar letras no txtDizimo
        private void txtDizimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //cód para o usuário não digitar letras no txtOferta
        private void txtOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //cód para o usuário não digitar letras no txtOfertaEspecial
        private void txtOfertaEspecial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //cód para o usuário não digitar letras no txtPessoas
        private void txtPessoas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
