using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Batista.Dados
{
    public class Conexao
    {
        public string Cn = "Data Source=DESKTOP-UPFUDB4;initial catalog=IgrejaBatista ;integrated security=true";

        //Conexão p/ o Computador da minha casa
       // public string Cn = "Data Source=DESKTOP-QR2J153\\SQLEXPRESS;initial catalog=IgrejaBatista ;integrated security=true";

        public SqlConnection Con = null;

        public void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection(Cn);
                Con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao abrir a conexão: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                Con = new SqlConnection(Cn);
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao fechar a conexão: "+ ex.Message);
            }
        }


    }
}
