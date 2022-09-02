namespace Batista.Views
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINANCEIROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasSaídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cULTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCultosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dizimistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUmNovoCultoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliaOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosDosCultosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparDadosDoFinanceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROSToolStripMenuItem,
            this.fINANCEIROToolStripMenuItem,
            this.cULTOSToolStripMenuItem,
            this.bibliaOnlineToolStripMenuItem,
            this.ferramentasDoSistemaToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "BibliaOnline";
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membrosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.inventárioToolStripMenuItem});
            this.cADASTROSToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_Save_1493294;
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cADASTROSToolStripMenuItem.Text = "CADASTROS";
            // 
            // membrosToolStripMenuItem
            // 
            this.membrosToolStripMenuItem.Name = "membrosToolStripMenuItem";
            this.membrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.membrosToolStripMenuItem.Text = "Membros";
            this.membrosToolStripMenuItem.Click += new System.EventHandler(this.MembrosToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.CargosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários do Sistema";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.UsuáriosToolStripMenuItem_Click);
            // 
            // fINANCEIROToolStripMenuItem
            // 
            this.fINANCEIROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasSaídasToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.entradasToolStripMenuItem,
            this.contasAPagarToolStripMenuItem});
            this.fINANCEIROToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_resolutions_16_897226;
            this.fINANCEIROToolStripMenuItem.Name = "fINANCEIROToolStripMenuItem";
            this.fINANCEIROToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.fINANCEIROToolStripMenuItem.Text = "FINANCEIRO";
            // 
            // entradasSaídasToolStripMenuItem
            // 
            this.entradasSaídasToolStripMenuItem.Name = "entradasSaídasToolStripMenuItem";
            this.entradasSaídasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.entradasSaídasToolStripMenuItem.Text = "Movimento do Caixa";
            this.entradasSaídasToolStripMenuItem.Click += new System.EventHandler(this.EntradasSaídasToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.despesasToolStripMenuItem.Text = "Saídas";
            this.despesasToolStripMenuItem.Click += new System.EventHandler(this.DespesasToolStripMenuItem_Click);
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.EntradasToolStripMenuItem_Click);
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.ContasAPagarToolStripMenuItem_Click);
            // 
            // cULTOSToolStripMenuItem
            // 
            this.cULTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCultosToolStripMenuItem,
            this.dizimistasToolStripMenuItem,
            this.cadastrarUmNovoCultoToolStripMenuItem});
            this.cULTOSToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_quran_book_ramadan_hand_drawn3_3213240;
            this.cULTOSToolStripMenuItem.Name = "cULTOSToolStripMenuItem";
            this.cULTOSToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.cULTOSToolStripMenuItem.Text = "CULTOS";
            this.cULTOSToolStripMenuItem.Click += new System.EventHandler(this.CULTOSToolStripMenuItem_Click);
            // 
            // consultarCultosToolStripMenuItem
            // 
            this.consultarCultosToolStripMenuItem.Name = "consultarCultosToolStripMenuItem";
            this.consultarCultosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.consultarCultosToolStripMenuItem.Text = "Registrar um novo Culto";
            this.consultarCultosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarCultosToolStripMenuItem_Click);
            // 
            // dizimistasToolStripMenuItem
            // 
            this.dizimistasToolStripMenuItem.Name = "dizimistasToolStripMenuItem";
            this.dizimistasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.dizimistasToolStripMenuItem.Text = "Dizimistas";
            this.dizimistasToolStripMenuItem.Click += new System.EventHandler(this.DizimistasToolStripMenuItem_Click_1);
            // 
            // cadastrarUmNovoCultoToolStripMenuItem
            // 
            this.cadastrarUmNovoCultoToolStripMenuItem.Name = "cadastrarUmNovoCultoToolStripMenuItem";
            this.cadastrarUmNovoCultoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastrarUmNovoCultoToolStripMenuItem.Text = "Cadastrar um novo Culto";
            this.cadastrarUmNovoCultoToolStripMenuItem.Click += new System.EventHandler(this.CadastrarUmNovoCultoToolStripMenuItem_Click);
            // 
            // bibliaOnlineToolStripMenuItem
            // 
            this.bibliaOnlineToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.biblia;
            this.bibliaOnlineToolStripMenuItem.Name = "bibliaOnlineToolStripMenuItem";
            this.bibliaOnlineToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.bibliaOnlineToolStripMenuItem.Text = "BIBLIA ONLINE";
            this.bibliaOnlineToolStripMenuItem.Click += new System.EventHandler(this.BibliaOnlineToolStripMenuItem_Click);
            // 
            // ferramentasDoSistemaToolStripMenuItem
            // 
            this.ferramentasDoSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDoBancoDeDadosToolStripMenuItem,
            this.limparDadosDosCultosToolStripMenuItem,
            this.limparDadosDoFinanceiroToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.ferramentasDoSistemaToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_Settings_2290860;
            this.ferramentasDoSistemaToolStripMenuItem.Name = "ferramentasDoSistemaToolStripMenuItem";
            this.ferramentasDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(186, 20);
            this.ferramentasDoSistemaToolStripMenuItem.Text = "FERRAMENTAS DO  SISTEMA";
            // 
            // backupDoBancoDeDadosToolStripMenuItem
            // 
            this.backupDoBancoDeDadosToolStripMenuItem.Name = "backupDoBancoDeDadosToolStripMenuItem";
            this.backupDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.backupDoBancoDeDadosToolStripMenuItem.Text = "Backup do Banco de Dados";
            this.backupDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.backupDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // limparDadosDosCultosToolStripMenuItem
            // 
            this.limparDadosDosCultosToolStripMenuItem.Name = "limparDadosDosCultosToolStripMenuItem";
            this.limparDadosDosCultosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.limparDadosDosCultosToolStripMenuItem.Text = "Limpar dados dos Cultos";
            this.limparDadosDosCultosToolStripMenuItem.ToolTipText = "Verifique se já foi feito o BACKUP antes de continuar!";
            this.limparDadosDosCultosToolStripMenuItem.Click += new System.EventHandler(this.limparDadosDosCultosToolStripMenuItem_Click);
            // 
            // limparDadosDoFinanceiroToolStripMenuItem
            // 
            this.limparDadosDoFinanceiroToolStripMenuItem.Name = "limparDadosDoFinanceiroToolStripMenuItem";
            this.limparDadosDoFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.limparDadosDoFinanceiroToolStripMenuItem.Text = "Limpar dados do Financeiro";
            this.limparDadosDoFinanceiroToolStripMenuItem.ToolTipText = "Verifique se já foi feito o BACKUP antes de continuar!";
            this.limparDadosDoFinanceiroToolStripMenuItem.Click += new System.EventHandler(this.limparDadosDoFinanceiroToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.sAIRToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.menu_sair;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.menu_sair;
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.sairToolStripMenuItem1.Text = "Sair do Sistema";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.SairToolStripMenuItem1_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(74, 40);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(45, 16);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário -";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cargo - ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(74, 8);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(45, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(733, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 102);
            this.panel1.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(93, 74);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(45, 16);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "label3";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 74);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 16);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Red;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "ATENÇÃO !";
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inventárioToolStripMenuItem.Text = "Inventário";
            this.inventárioToolStripMenuItem.Click += new System.EventHandler(this.inventárioToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Logo_PIBSGS1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IGREJA BATISTA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINANCEIROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cULTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem consultarCultosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliaOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasSaídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dizimistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUmNovoCultoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparDadosDosCultosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparDadosDoFinanceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
    }
}