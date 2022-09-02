using Batista.Dados;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Relatorios;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmContasPagar : Form
    {
        Conexao con = new Conexao();
        // string ultimoidconta;
        string idDetalhe;
        public FrmContasPagar()
        {
            InitializeComponent();
            EventoGrid();

        }

        private void EventoGrid()
        {
            this.gridContarPagar.CellDoubleClick += new DataGridViewCellEventHandler(this.gridContarPagar_DoubleClick);
        }

        private void FrmContasPagar_Load(object sender, EventArgs e)
        {
           
            btPagarTeste.Enabled = true;
            btAlterarTeste.Enabled = true;
            tabControl1.SelectedIndex = 1;
            cBBuscarPagar.SelectedIndex = 0;
            cBBuscarPagas.SelectedIndex = 0;
            cBDocumento.SelectedIndex = 0;
            BuscarDataTipo();
            BuscarData();
            BuscarDataPagas();
            BuscarDataTipoPagas();

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
                btPagarTeste.Enabled = true;
                dtContas.Enabled = true;
                txtCredor.Enabled = true;
                txtValor.Enabled = true;
                cBDocumento.Enabled = true;
                cBDocumento.SelectedIndex = 0;
                txtParcela.Enabled = true;
                txtNºDoc.Enabled = true;
                txtDescricao.Enabled = true;
                btSalvar.Enabled = true;
                btAlterarTeste.Enabled = true;
                btCancelarConta.Enabled = true;
              
            }

            else
            {
                btPagarTeste.Enabled = false;
                dtContas.Enabled = false;
                txtCredor.Enabled = false;
                txtValor.Enabled = false;
                cBDocumento.Enabled = false;
                cBDocumento.SelectedIndex = 0;
                txtParcela.Enabled = false;
                txtNºDoc.Enabled = false;
                txtDescricao.Enabled = false;
                btSalvar.Enabled = false;
                btAlterarTeste.Enabled = false;
                btCancelarConta.Enabled = false;
             
            }
        }

        private void LimparCampos()
        {
            txtCredor.Clear();
            txtDescricao.Clear();
            txtNºDoc.Clear();
            txtParcela.Clear();
            txtValor.Clear();
            lblTotal.Text = "0";
            cBDocumento.SelectedItem = 0;
        }



        //Listar contas a pagar no Grid de contas a pagar
        private void ListarContasPagar()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd0 = new SqlCommand();
                Cmd0.Connection = con.Con;
                Cmd0.CommandText = "spListarContasPagar";
                Cmd0.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd0;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridContarPagar.DataSource = Dt;
                con.FecharConexao();

                Totalizar();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao Listar Contas a Pagar: " + ex.Message);
            }

        }

        //Listar contas já pagas no Grid de contas pagas
        private void ListarContasPagas()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd7 = new SqlCommand();
                Cmd7.Connection = con.Con;
                Cmd7.CommandText = "spListarContasPagas";
                Cmd7.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd7;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridContasPagas.DataSource = Dt;
                con.FecharConexao();
                TotalizarPagas();
            }
            catch (Exception ex)
            {

                MsgErro("Erro ao Listar Contas Pagas: " + ex.Message);
            }

        }

        //Método de buscar por datas no grid de contas a pagar
        private void BuscarData()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd1 = new SqlCommand();
                Cmd1.Connection = con.Con;
                Cmd1.CommandText = "spBuscarDatasContasPagar";
                Cmd1.CommandType = CommandType.StoredProcedure;
                Cmd1.Parameters.AddWithValue("@DataInicial", dtInicial.Text);
                Cmd1.Parameters.AddWithValue("@DataFinal", dtFinal.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd1;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridContarPagar.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de buscar por datas: " + ex.Message);
            }

            Totalizar();
        }

        //Método de buscar por datas e tipo no grid de Contas a pagar
        private void BuscarDataTipo()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = con.Con;
                Cmd2.CommandText = "spBuscarDatasTipoContasPagar";
                Cmd2.CommandType = CommandType.StoredProcedure;
                Cmd2.Parameters.AddWithValue("@TipoDocumento", cBBuscarPagar.Text);
                Cmd2.Parameters.AddWithValue("@DataInicial", dtInicial.Text);
                Cmd2.Parameters.AddWithValue("@DataFinal", dtFinal.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd2;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridContarPagar.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de buscar por data/tipo: " + ex.Message);
            }

            Totalizar();
        }

        //Método de Buscar por datas no grid de contas pagas
        private void BuscarDataPagas()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd11 = new SqlCommand();
                Cmd11.Connection = con.Con;
                Cmd11.CommandText = "spBuscarDatasContasPagas";
                Cmd11.CommandType = CommandType.StoredProcedure;
                Cmd11.Parameters.AddWithValue("@DataInicial", dtInicial1.Text);
                Cmd11.Parameters.AddWithValue("@DataFinal", dtFinal1.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd11;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridContasPagas.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de buscar por datas: " + ex.Message);
            }

            TotalizarPagas();
        }

        private void BuscarDataTipoPagas()
        {
            try
            {
                con.AbrirConexao();
                SqlCommand Cmd12 = new SqlCommand();
                Cmd12.Connection = con.Con;
                Cmd12.CommandText = "spBuscarDatasTipoContasPagas";
                Cmd12.CommandType = CommandType.StoredProcedure;
                Cmd12.Parameters.AddWithValue("@TipoDocumento", cBBuscarPagas.Text);
                Cmd12.Parameters.AddWithValue("@DataInicial", dtInicial1.Text);
                Cmd12.Parameters.AddWithValue("@DataFinal", dtFinal1.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Cmd12;
                DataTable Dt = new DataTable();
                da.Fill(Dt);
                gridContasPagas.DataSource = Dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MsgErro("Erro no método de buscar por data/tipo: " + ex.Message);
            }

            TotalizarPagas();
        }


        //Método de TOTALIZAR no grid de contas a pagar
        private void Totalizar()
        {
            decimal total = 0;
            foreach (DataGridViewRow linha in gridContarPagar.Rows)
            {
                total += Convert.ToDecimal(linha.Cells["Total"].Value);
            }
            lblTotal.Text = Convert.ToDecimal(total).ToString("C2");
        }

        //Método de TOTALIZAR no grid de contas pagas
        private void TotalizarPagas()
        {
            decimal total1 = 0;
            foreach (DataGridViewRow linha1 in gridContasPagas.Rows)
            {
                total1 += Convert.ToDecimal(linha1.Cells["Totall"].Value);
            }
            lblTotal1.Text = Convert.ToDecimal(total1).ToString("C2");
        }

        //BOTÕES

        //botão NOVO
        private void BtNovo_Click(object sender, EventArgs e)
        {
            dtContas.Value = DateTime.Now;
            HabilitarCampos(true);
            btSalvar.Enabled = true;
            btAlterarTeste.Enabled = false;
            btNovo.Enabled = false;
            btPagarTeste.Enabled = false;
            LimparCampos();
        }

        //botão SALVAR Contas a pagar
        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtCredor.Text == string.Empty)
            {
                MsgErro("Informe o Credor!");
                txtCredor.Focus();
                return;
            }

            if (txtValor.Text == string.Empty)
            {
                MsgErro("Informe o Valor da Conta!");
                txtValor.Focus();
                return;
            }

            //Cód p/ salvar Conta 
            con.AbrirConexao();

            SqlCommand Cmd4 = new SqlCommand();
            Cmd4.Connection = con.Con;
            Cmd4.CommandText = "spInserirDetalheContasPagar";
            Cmd4.CommandType = CommandType.StoredProcedure;
            //Cmd4.Parameters.AddWithValue("@Data",Convert.ToDateTime(mskVenc.Text));
            Cmd4.Parameters.AddWithValue("@Data", dtContas.Text);
            Cmd4.Parameters.AddWithValue("@TipoDocumento", cBDocumento.Text);
            Cmd4.Parameters.AddWithValue("@NºDocumento", txtNºDoc.Text);
            Cmd4.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            Cmd4.Parameters.AddWithValue("@Parcela", Convert.ToInt32(txtParcela.Text));
            Cmd4.Parameters.AddWithValue("@Credor", txtCredor.Text);
            Cmd4.Parameters.AddWithValue("@Status", "CONTA A PAGAR");
            Cmd4.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
            Cmd4.ExecuteNonQuery();
            con.FecharConexao();
            LimparCampos();

            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btCancelarConta.Enabled = false;
            btPagarTeste.Enabled = false;
            btAlterarTeste.Enabled = false;

            ListarContasPagar();

            MessageBox.Show("Registro salvo com sucesso!","ATENÇÃO!",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        //botão CANCELAR
        private void BtCancelarConta_Click(object sender, EventArgs e)
        {

            LimparCampos();
            btNovo.Enabled = true;
            btNovo.Focus();
            btAlterarTeste.Enabled = false;
            btSalvar.Enabled = false;
            tabControl1.SelectedIndex = 1;
            gridContarPagar.Focus();

        }

        //Buscar contas a pagar no comboBox
        private void CBBuscarPagar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBBuscarPagar.SelectedIndex == 0)
            {
                BuscarData();
            }

            else
            {

                BuscarDataTipo();
            }
        }

        //Buscar contas a pagar por data inicial
        private void DtInicial_ValueChanged(object sender, EventArgs e)
        {
            if (cBBuscarPagar.SelectedIndex == 0)
            {
                BuscarData();
            }

            else
            {
                BuscarDataTipo();
            }
        }

        //Buscar contas a pagar por data final
        private void DtFinal_ValueChanged(object sender, EventArgs e)
        {
            if (cBBuscarPagar.SelectedIndex == 0)
            {
                BuscarData();
            }

            else
            {
                BuscarDataTipo();
            }
        }

        //Buscar contas pagas no comboBox
        private void CBBuscarPagas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBBuscarPagas.SelectedIndex == 0)
            {
                BuscarDataPagas();
            }

            else
            {
                BuscarDataTipoPagas();
            }
        }

        //Buscar contas pagas por data inicial
        private void DtInicial1_ValueChanged(object sender, EventArgs e)
        {
            if (cBBuscarPagas.SelectedIndex == 0)
            {
                BuscarDataPagas();
            }

            else
            {
                BuscarDataTipoPagas();
            }
        }

        //Buscar contas pagas por data final
        private void DtFinal1_ValueChanged(object sender, EventArgs e)
        {
            if (cBBuscarPagas.SelectedIndex == 0)
            {
                BuscarDataPagas();
            }

            else
            {
                BuscarDataTipoPagas();
            }
        }

        //botão Relatório de contas a pagar
        private void BtImprimirPagar_Click(object sender, EventArgs e)
        {
            if (gridContarPagar.RowCount ==0)
            {
                MsgErro("Não há contas cadastradas para impressão!");
                return;
            }
            FrmRelContasPagar frmRelContasPagar = new FrmRelContasPagar();
            frmRelContasPagar.Show();
        }

        //botão Relatório de contas pagas
        private void BtImprimirPagas_Click(object sender, EventArgs e)
        {
            if (gridContarPagar.RowCount == 0)
            {
                MsgErro("Não há contas cadastradas para impressão!");
                return;
            }
            FrmRelContasPagas frmRelContasPagas = new FrmRelContasPagas();
            frmRelContasPagas.Show();
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }




        private void gridContarPagar_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridContarPagar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridContarPagar_DoubleClick_1(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                
                panelBotoes.Visible = true;
                btAlterarTeste.Enabled = false;
                btSalvar.Enabled = false;
                btCancelarConta.Enabled = false;
                btPagarVdd.Enabled = false;
                txtCredor.Enabled = false;
                txtDescricao.Enabled = false;
                txtNºDoc.Enabled = false;
                txtParcela.Enabled = false;
                txtValor.Enabled = false;
                dtContas.Enabled = true;
                cBDocumento.Enabled = false;
                cBDocumento.SelectedIndex = 0;
                
            }

            if (tabControl1.SelectedIndex == 1)
            {
                ListarContasPagar();
                btAlterarTeste.Enabled = true;
                btPagarTeste.Enabled = true;

            }

            if (tabControl1.SelectedIndex == 2)
            {
                ListarContasPagas();

            }
        } 

       

        //Método de pagar a conta
        private void PagarConta()
        {

            EventoGrid();
            dtContas.Enabled = true;
            dtContas.Focus();
           
            idDetalhe = gridContarPagar.CurrentRow.Cells[0].Value.ToString();
           
            dtContas.Text = gridContarPagar.CurrentRow.Cells[1].Value.ToString();
            cBDocumento.Text = gridContarPagar.CurrentRow.Cells[2].Value.ToString();
            txtNºDoc.Text = gridContarPagar.CurrentRow.Cells[3].Value.ToString();
            txtDescricao.Text = gridContarPagar.CurrentRow.Cells[4].Value.ToString();
            txtParcela.Text = gridContarPagar.CurrentRow.Cells[5].Value.ToString();
            txtValor.Text = gridContarPagar.CurrentRow.Cells[6].Value.ToString();
            txtCredor.Text = gridContarPagar.CurrentRow.Cells[7].Value.ToString();
            txtStatus.Text = gridContarPagar.CurrentRow.Cells[8].Value.ToString();
            panelBotoes.Visible = true;

            var result = MessageBox.Show("Deseja pagar a conta?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Cód p/ excluir(usado também com uma trigger no banco de dados)
                con.AbrirConexao();
                SqlCommand trigger = new SqlCommand();
                trigger.Connection = con.Con;
                trigger.CommandText = "spExcluirDetalhesContasPagar";
                trigger.CommandType = CommandType.StoredProcedure;
                trigger.Parameters.AddWithValue("@IdDetalhe", idDetalhe);
                trigger.Parameters.AddWithValue("@Status", "CONTA PAGA");
                trigger.ExecuteNonQuery();
                con.FecharConexao();
                ListarContasPagas();

                //Cód p/ inserir Conta paga na tab de Movimentações
                con.AbrirConexao();

                SqlCommand Cmd9 = new SqlCommand();
                Cmd9.Connection = con.Con;
                Cmd9.CommandText = "spInserirContasPagarMov";
                Cmd9.CommandType = CommandType.StoredProcedure;
                Cmd9.Parameters.AddWithValue("@Id_Movimento", idDetalhe);
               // Cmd9.Parameters.AddWithValue("@Data",dtContas.Text);
                Cmd9.Parameters.AddWithValue("@Tipo", "Saida");
                Cmd9.Parameters.AddWithValue("@Movimento", txtDescricao.Text);
                Cmd9.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
                Cmd9.ExecuteNonQuery();
                con.FecharConexao();
                MessageBox.Show("Conta paga com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btNovo.Enabled = true;
                btNovo.Focus();
                btCancelarConta.Enabled = true;
                btNovo.Enabled = false;
                LimparCampos();
                panelBotoes.Visible = true;
                tabControl1.SelectedIndex = 1;
            }

            else
            {
                MessageBox.Show("Operação cancelada!","ATENÇÃO",MessageBoxButtons.OK);
                panelBotoes.Visible = true;
                tabControl1.SelectedIndex = 1;
                btNovo.Enabled = true;
                btNovo.Focus();
                btCancelarConta.Enabled = true;
                LimparCampos();
                ListarContasPagar();
            }

        }

        //Método de alterar a conta
        private void AlterarConta()
        {
            panelBotoes.Visible = true;
            con.AbrirConexao();

            SqlCommand Cmd5 = new SqlCommand();
            Cmd5.Connection = con.Con;
            Cmd5.CommandText = "spAlterarDetalheContasPagar";
            Cmd5.CommandType = CommandType.StoredProcedure;

            Cmd5.Parameters.AddWithValue("@IdDetalhe", idDetalhe);
            Cmd5.Parameters.AddWithValue("@Data", dtContas.Text);
            Cmd5.Parameters.AddWithValue("@TipoDocumento", cBDocumento.Text);
            Cmd5.Parameters.AddWithValue("@NºDocumento", txtNºDoc.Text);
            Cmd5.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
            Cmd5.Parameters.AddWithValue("@Parcela", Convert.ToInt32(txtParcela.Text));
            Cmd5.Parameters.AddWithValue("@Credor", txtCredor.Text);
            Cmd5.Parameters.AddWithValue("@Status", "CONTA A PAGAR");
            Cmd5.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtValor.Text));
            Cmd5.ExecuteNonQuery();
            con.FecharConexao();


            var result2 = MessageBox.Show("Confirma alteração?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {

                MessageBox.Show("Registro alterado com sucesso!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btNovo.Enabled = true;
                btNovo.Focus();
                btCancelarConta.Enabled = true;
                LimparCampos();
                ListarContasPagar();
                tabControl1.SelectedIndex = 1;

            }

            else
            {
                MessageBox.Show("Operação cancelada!", "ATENÇÃO", MessageBoxButtons.OK);
                tabControl1.SelectedIndex = 1;
                btNovo.Enabled = true;
                btNovo.Focus();
                btCancelarConta.Enabled = true;
                LimparCampos();
                ListarContasPagar();
            }


        }

        //botão ACESSO PAGAR A CONTA
        private void btPagarTeste_Click(object sender, EventArgs e)
        {
            if (gridContarPagar.RowCount==0)
            {
                MsgErro("Não há Contas Cadastradas no momento!");
                return;
            }
          
            idDetalhe = gridContarPagar.CurrentRow.Cells[0].Value.ToString();
            dtContas.Text = gridContarPagar.CurrentRow.Cells[1].Value.ToString();
            cBDocumento.Text = gridContarPagar.CurrentRow.Cells[2].Value.ToString();
            txtNºDoc.Text = gridContarPagar.CurrentRow.Cells[3].Value.ToString();
            txtDescricao.Text = gridContarPagar.CurrentRow.Cells[4].Value.ToString();
            txtParcela.Text = gridContarPagar.CurrentRow.Cells[5].Value.ToString();
            txtValor.Text = gridContarPagar.CurrentRow.Cells[6].Value.ToString();
            txtCredor.Text = gridContarPagar.CurrentRow.Cells[7].Value.ToString();
            txtStatus.Text = gridContarPagar.CurrentRow.Cells[8].Value.ToString();
            tabControl1.SelectedIndex = 0;
           
            btNovo.Enabled = false;
            btAlterarTeste.Enabled = false;
            btPagarVdd.Enabled = true;
            btPagarVdd.Focus();
            btCancelarConta.Enabled = true;
            btSalvar.Enabled = false;
        }

        //botão ALTERAR CONTA

        private void btAlterarTeste_Click_1(object sender, EventArgs e)
        {
            if (txtValor.Text==string.Empty)
            {
                MsgErro("Selecione uma conta para alteração!");
                return;
            }
            AlterarConta();
           
        }


        private void gridContarPagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            idDetalhe = gridContarPagar.CurrentRow.Cells[0].Value.ToString();
            dtContas.Text = gridContarPagar.CurrentRow.Cells[1].Value.ToString();
            cBDocumento.Text = gridContarPagar.CurrentRow.Cells[2].Value.ToString();
            txtNºDoc.Text = gridContarPagar.CurrentRow.Cells[3].Value.ToString();
            txtDescricao.Text = gridContarPagar.CurrentRow.Cells[4].Value.ToString();
            txtParcela.Text = gridContarPagar.CurrentRow.Cells[5].Value.ToString();
            txtValor.Text = gridContarPagar.CurrentRow.Cells[6].Value.ToString();
            txtCredor.Text = gridContarPagar.CurrentRow.Cells[7].Value.ToString();
            txtStatus.Text = gridContarPagar.CurrentRow.Cells[8].Value.ToString();
            tabControl1.SelectedIndex = 0;
            panelBotoes.Visible = false;
        }

        //botão de ACESSO ALTERAR CONTAS
        private void btAlterarTeste2_Click(object sender, EventArgs e)
        {
            if (gridContarPagar.RowCount == 0)
            {
                MessageBox.Show("Não há contas cadastradas no momento!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            idDetalhe = gridContarPagar.CurrentRow.Cells[0].Value.ToString();
            dtContas.Text = gridContarPagar.CurrentRow.Cells[1].Value.ToString();
            cBDocumento.Text = gridContarPagar.CurrentRow.Cells[2].Value.ToString();
            txtNºDoc.Text = gridContarPagar.CurrentRow.Cells[3].Value.ToString();
            txtDescricao.Text = gridContarPagar.CurrentRow.Cells[4].Value.ToString();
            txtParcela.Text = gridContarPagar.CurrentRow.Cells[5].Value.ToString();
            txtValor.Text = gridContarPagar.CurrentRow.Cells[6].Value.ToString();
            txtCredor.Text = gridContarPagar.CurrentRow.Cells[7].Value.ToString();
            txtStatus.Text = gridContarPagar.CurrentRow.Cells[8].Value.ToString();
            tabControl1.SelectedIndex = 0;

            txtCredor.Enabled = true;
            txtDescricao.Enabled = true;
            txtNºDoc.Enabled = true;
            txtParcela.Enabled = true;
            txtStatus.Enabled = true;
            dtContas.Enabled = true;
            cBDocumento.Enabled = true;
            txtValor.Enabled = true;
            btNovo.Enabled = false;
            btAlterarTeste.Enabled = true;
            btAlterarTeste.Focus();
            btSalvar.Enabled = false;
            btPagarVdd.Enabled = false;
            btCancelarConta.Enabled = true;
        }

        //botão PAGAR A CONTA
        private void btPagarVdd_Click(object sender, EventArgs e)
        {
            if (txtValor.Text==string.Empty)
            {
                MsgErro("Selecione uma conta para pagamento!");
                return;
            }
            PagarConta();
           
        }

        //cód p/ o usuário não digitar letras no txtValor
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //cód p/ o usuário não digitar letras no txtParcela
        private void txtParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
