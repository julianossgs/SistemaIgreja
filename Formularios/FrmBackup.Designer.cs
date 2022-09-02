
namespace WindowsFormsApp1.Formularios
{
    partial class FrmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btBackup = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.cbBackup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVIDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BANCO DE DADOS";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(146, 84);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(177, 29);
            this.btBackup.TabIndex = 2;
            this.btBackup.Text = "Backup";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.Location = new System.Drawing.Point(146, 198);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(177, 29);
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.Text = "Restaurar Backup";
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Enabled = false;
            this.txtServidor.Location = new System.Drawing.Point(46, 48);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(177, 20);
            this.txtServidor.TabIndex = 4;
            this.txtServidor.Text = "DESKTOP-UPFUDB4";
            // 
            // txtDataBase
            // 
            this.txtDataBase.Enabled = false;
            this.txtDataBase.Location = new System.Drawing.Point(255, 48);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(177, 20);
            this.txtDataBase.TabIndex = 5;
            this.txtDataBase.Text = "IgrejaBatista";
            // 
            // cbBackup
            // 
            this.cbBackup.FormattingEnabled = true;
            this.cbBackup.Location = new System.Drawing.Point(87, 171);
            this.cbBackup.Name = "cbBackup";
            this.cbBackup.Size = new System.Drawing.Size(297, 21);
            this.cbBackup.TabIndex = 6;
            this.cbBackup.DropDown += new System.EventHandler(this.cbBackup_DropDown);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(480, 239);
            this.Controls.Add(this.cbBackup);
            this.Controls.Add(this.txtDataBase);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmBackup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BACKUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.ComboBox cbBackup;
    }
}