using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        //botão Backup
        private void btBackup_Click(object sender, EventArgs e)
        {

            var server = new Microsoft.SqlServer.Management.Smo.Server(txtServidor.Text);
            var backup = new Microsoft.SqlServer.Management.Smo.Backup();
            backup.Database = txtDataBase.Text;
            backup.Incremental = false;
            string nomeArquivoBackup = string.Format("{0}_{1:ddMMyyyy_HHmmss}.bak", txtDataBase.Text, DateTime.Now);
            backup.Devices.AddDevice(nomeArquivoBackup, Microsoft.SqlServer.Management.Smo.DeviceType.File);
            backup.SqlBackup(server);
            MessageBox.Show(string.Format("Backup '{0}' concluído com sucesso.", nomeArquivoBackup), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Lista de backup no combo box
        private void cbBackup_DropDown(object sender, EventArgs e)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(string.Format("Server={0};Database={1};Trusted_Connection=True;", txtServidor.Text, txtDataBase.Text)))
            {
                connection.Open();

                using (var command = new System.Data.SqlClient.SqlCommand(
                    "SELECT physical_device_name FROM msdb.dbo.backupmediafamily " +
                    "INNER JOIN msdb.dbo.backupset ON msdb.dbo.backupmediafamily.media_set_id = msdb.dbo.backupset.media_set_id " +
                    "WHERE (msdb.dbo.backupset.database_name LIKE @DatabaseName)", connection))
                {
                    command.Parameters.AddWithValue("DatabaseName", txtDataBase.Text);

                    using (var reader = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(reader);
                        table.Columns.Add("FriendlyName");
                        foreach (DataRow row in table.Rows)
                        {
                            row["FriendlyName"] = System.IO.Path.GetFileName(row["physical_device_name"].ToString());
                        }
                        if (cbBackup.DataSource != null && cbBackup.DataSource is DataTable)
                        {
                            var oldTable = ((DataTable)cbBackup.DataSource);
                            cbBackup.DataSource = null;
                            oldTable.Dispose();
                        }
                        cbBackup.DataSource = table;
                        cbBackup.DisplayMember = "FriendlyName";
                        cbBackup.ValueMember = "physical_device_name";
                    }
                }
            }
        }

        //botão RESTAURAR BACKUP
        private void btRestaurar_Click(object sender, EventArgs e)
        {
            var server = new Microsoft.SqlServer.Management.Smo.Server(txtServidor.Text);
            var restore = new Microsoft.SqlServer.Management.Smo.Restore();
            restore.Database = txtDataBase.Text;
            restore.Devices.AddDevice(cbBackup.SelectedValue.ToString(), Microsoft.SqlServer.Management.Smo.DeviceType.File);
            server.KillAllProcesses(txtDataBase.Text);
            restore.SqlRestore(server);
            MessageBox.Show(string.Format("Backup '{0}' restaurado com sucesso.", cbBackup.Text), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

