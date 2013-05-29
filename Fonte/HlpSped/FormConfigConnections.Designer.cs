namespace Hlp.Sped.UI
{
    partial class FormConfigConnections
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.kryptonTabControl1 = new AC.ExtendedRenderer.Navigator.KryptonTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ckbCompleto = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCaminhoBase = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.lblCaminhoBase = new System.Windows.Forms.Label();
            this.configConnectionContmatic = new Hlp.Sped.UI.ConfigConnectionFirebird();
            this.configConnectionFirebirdSpedContabil = new Hlp.Sped.UI.ConfigConnectionFirebird();
            this.configConnectionFirebirdSpedFiscal = new Hlp.Sped.UI.ConfigConnectionFirebird();
            this.titleStrip2 = new Hlp.Sped.UI.TitleStrip();
            this.toolStripLabelConfigConnections = new System.Windows.Forms.ToolStripLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.kryptonTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.titleStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.kryptonTabControl1);
            this.panel1.Controls.Add(this.titleStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 404);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Hlp.Sped.UI.Properties.Resources.blueheader;
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 33);
            this.panel3.TabIndex = 27;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(484, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // kryptonTabControl1
            // 
            this.kryptonTabControl1.AllowCloseButton = false;
            this.kryptonTabControl1.AllowContextButton = true;
            this.kryptonTabControl1.AllowNavigatorButtons = false;
            this.kryptonTabControl1.AllowSelectedTabHigh = false;
            this.kryptonTabControl1.BorderWidth = 1;
            this.kryptonTabControl1.Controls.Add(this.tabPage1);
            this.kryptonTabControl1.CornerRoundRadiusWidth = 12;
            this.kryptonTabControl1.CornerSymmetry = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornSymmetry.Both;
            this.kryptonTabControl1.CornerType = AC.ExtendedRenderer.Toolkit.Drawing.DrawingMethods.CornerType.Rounded;
            this.kryptonTabControl1.CornerWidth = AC.ExtendedRenderer.Navigator.KryptonTabControl.CornWidth.Thin;
            this.kryptonTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.kryptonTabControl1.HotTrack = true;
            this.kryptonTabControl1.Location = new System.Drawing.Point(0, 25);
            this.kryptonTabControl1.Name = "kryptonTabControl1";
            this.kryptonTabControl1.PreserveTabColor = false;
            this.kryptonTabControl1.SelectedIndex = 0;
            this.kryptonTabControl1.Size = new System.Drawing.Size(554, 379);
            this.kryptonTabControl1.TabIndex = 26;
            this.kryptonTabControl1.UseExtendedLayout = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.kryptonPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(546, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = false;
            this.tabPage1.Text = "Configuração";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.ckbCompleto);
            this.kryptonPanel1.Controls.Add(this.btnSalvar);
            this.kryptonPanel1.Controls.Add(this.txtCaminhoBase);
            this.kryptonPanel1.Controls.Add(this.lblCaminhoBase);
            this.kryptonPanel1.Controls.Add(this.configConnectionContmatic);
            this.kryptonPanel1.Controls.Add(this.configConnectionFirebirdSpedContabil);
            this.kryptonPanel1.Controls.Add(this.configConnectionFirebirdSpedFiscal);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(546, 350);
            this.kryptonPanel1.TabIndex = 31;
            // 
            // ckbCompleto
            // 
            this.ckbCompleto.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.ckbCompleto.Location = new System.Drawing.Point(17, 133);
            this.ckbCompleto.Name = "ckbCompleto";
            this.ckbCompleto.Size = new System.Drawing.Size(118, 20);
            this.ckbCompleto.TabIndex = 45;
            this.ckbCompleto.Text = "SPED COMPLETO";
            this.ckbCompleto.Values.Text = "SPED COMPLETO";
            this.ckbCompleto.Click += new System.EventHandler(this.kryptonCheckBox1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(460, 23);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 22);
            this.btnSalvar.TabIndex = 44;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCaminhoBase
            // 
            this.txtCaminhoBase.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtCaminhoBase.Location = new System.Drawing.Point(16, 24);
            this.txtCaminhoBase.Name = "txtCaminhoBase";
            this.txtCaminhoBase.Size = new System.Drawing.Size(444, 20);
            this.txtCaminhoBase.TabIndex = 43;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::Hlp.Sped.UI.Properties.Resources.Pasta;
            this.buttonSpecAny1.UniqueName = "E2BED0334B7442E1B298D2917E9256F5";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // lblCaminhoBase
            // 
            this.lblCaminhoBase.AutoSize = true;
            this.lblCaminhoBase.Location = new System.Drawing.Point(14, 8);
            this.lblCaminhoBase.Name = "lblCaminhoBase";
            this.lblCaminhoBase.Size = new System.Drawing.Size(211, 13);
            this.lblCaminhoBase.TabIndex = 42;
            this.lblCaminhoBase.Text = "Diretório padrão para salvar a configuração";
            // 
            // configConnectionContmatic
            // 
            this.configConnectionContmatic.BackColor = System.Drawing.Color.Transparent;
            this.configConnectionContmatic.CaminhoBase = ":";
            this.configConnectionContmatic.Location = new System.Drawing.Point(16, 242);
            this.configConnectionContmatic.Name = "configConnectionContmatic";
            this.configConnectionContmatic.NomeConexao = "DBArquivoSpedContmatic";
            this.configConnectionContmatic.Size = new System.Drawing.Size(517, 74);
            this.configConnectionContmatic.TabIndex = 41;
            this.configConnectionContmatic.Title = "Configurações - Dados SPED Contmatic";
            this.configConnectionContmatic.Visible = false;
            this.configConnectionContmatic.TestarConexao += new Hlp.Sped.UI.Events.TestarConexaoFirebirdHandler(this.configConnectionFirebird_TestarConexao);
            this.configConnectionContmatic.SalvarConexao += new Hlp.Sped.UI.Events.SalvarConexaoFirebirdHandler(this.configConnectionFirebird_SalvarConexao);
            // 
            // configConnectionFirebirdSpedContabil
            // 
            this.configConnectionFirebirdSpedContabil.BackColor = System.Drawing.Color.Transparent;
            this.configConnectionFirebirdSpedContabil.CaminhoBase = ":";
            this.configConnectionFirebirdSpedContabil.Location = new System.Drawing.Point(16, 160);
            this.configConnectionFirebirdSpedContabil.Name = "configConnectionFirebirdSpedContabil";
            this.configConnectionFirebirdSpedContabil.NomeConexao = "DBArquivoSpedContabil";
            this.configConnectionFirebirdSpedContabil.Size = new System.Drawing.Size(517, 74);
            this.configConnectionFirebirdSpedContabil.TabIndex = 40;
            this.configConnectionFirebirdSpedContabil.Title = "Configurações - Dados SPED Contábil";
            this.configConnectionFirebirdSpedContabil.Visible = false;
            this.configConnectionFirebirdSpedContabil.TestarConexao += new Hlp.Sped.UI.Events.TestarConexaoFirebirdHandler(this.configConnectionFirebird_TestarConexao);
            this.configConnectionFirebirdSpedContabil.SalvarConexao += new Hlp.Sped.UI.Events.SalvarConexaoFirebirdHandler(this.configConnectionFirebird_SalvarConexao);
            // 
            // configConnectionFirebirdSpedFiscal
            // 
            this.configConnectionFirebirdSpedFiscal.BackColor = System.Drawing.Color.Transparent;
            this.configConnectionFirebirdSpedFiscal.CaminhoBase = ":";
            this.configConnectionFirebirdSpedFiscal.Location = new System.Drawing.Point(17, 51);
            this.configConnectionFirebirdSpedFiscal.Name = "configConnectionFirebirdSpedFiscal";
            this.configConnectionFirebirdSpedFiscal.NomeConexao = "DBArquivoSpedFiscal";
            this.configConnectionFirebirdSpedFiscal.Size = new System.Drawing.Size(518, 75);
            this.configConnectionFirebirdSpedFiscal.TabIndex = 39;
            this.configConnectionFirebirdSpedFiscal.Title = "Configurações - SPED BÁSICO";
            this.configConnectionFirebirdSpedFiscal.TestarConexao += new Hlp.Sped.UI.Events.TestarConexaoFirebirdHandler(this.configConnectionFirebird_TestarConexao);
            this.configConnectionFirebirdSpedFiscal.SalvarConexao += new Hlp.Sped.UI.Events.SalvarConexaoFirebirdHandler(this.configConnectionFirebird_SalvarConexao);
            // 
            // titleStrip2
            // 
            this.titleStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.titleStrip2.DrawEndLine = true;
            this.titleStrip2.GradientEndColor = System.Drawing.Color.White;
            this.titleStrip2.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(186)))), ((int)(((byte)(214)))));
            this.titleStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titleStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelConfigConnections});
            this.titleStrip2.Lines = 6;
            this.titleStrip2.Location = new System.Drawing.Point(0, 0);
            this.titleStrip2.Name = "titleStrip2";
            this.titleStrip2.Size = new System.Drawing.Size(554, 25);
            this.titleStrip2.TabIndex = 10;
            this.titleStrip2.Text = "titleStrip2";
            // 
            // toolStripLabelConfigConnections
            // 
            this.toolStripLabelConfigConnections.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelConfigConnections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.toolStripLabelConfigConnections.Name = "toolStripLabelConfigConnections";
            this.toolStripLabelConfigConnections.Size = new System.Drawing.Size(119, 22);
            this.toolStripLabelConfigConnections.Text = "Conexões de Acesso";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivo de texto|*.txt";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(323, 22);
            this.toolStripLabel1.Text = "Selecione o período e a empresa para geração do arquivo";
            // 
            // FormConfigConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 404);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfigConnections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sped - Configuração de Conexões ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfigConnections_FormClosing);
            this.Load += new System.EventHandler(this.FormConfigConnections_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSpedFiscal_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.kryptonTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.titleStrip2.ResumeLayout(false);
            this.titleStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private TitleStrip titleStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelConfigConnections;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private AC.ExtendedRenderer.Navigator.KryptonTabControl kryptonTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ConfigConnectionFirebird configConnectionContmatic;
        private ConfigConnectionFirebird configConnectionFirebirdSpedContabil;
        private ConfigConnectionFirebird configConnectionFirebirdSpedFiscal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCaminhoBase;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private System.Windows.Forms.Label lblCaminhoBase;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox ckbCompleto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}