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
            this.configConnectionContmatic = new Hlp.Sped.UI.ConfigConnectionFirebird();
            this.configConnectionFirebirdSpedContabil = new Hlp.Sped.UI.ConfigConnectionFirebird();
            this.configConnectionFirebirdSpedFiscal = new Hlp.Sped.UI.ConfigConnectionFirebird();
            this.configConnectionFirebirdContabil = new Hlp.Sped.UI.ConfigConnectionFirebird();
            this.configConnectionFirebirdFiscal = new Hlp.Sped.UI.ConfigConnectionFirebird();
            this.titleStrip2 = new Hlp.Sped.UI.TitleStrip();
            this.toolStripLabelConfigConnections = new System.Windows.Forms.ToolStripLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            this.titleStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.configConnectionContmatic);
            this.panel1.Controls.Add(this.configConnectionFirebirdSpedContabil);
            this.panel1.Controls.Add(this.configConnectionFirebirdSpedFiscal);
            this.panel1.Controls.Add(this.configConnectionFirebirdContabil);
            this.panel1.Controls.Add(this.configConnectionFirebirdFiscal);
            this.panel1.Controls.Add(this.titleStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 723);
            this.panel1.TabIndex = 4;
            // 
            // configConnectionContmatic
            // 
            this.configConnectionContmatic.CaminhoBase = "";
            this.configConnectionContmatic.Dialeto = "1";
            this.configConnectionContmatic.Location = new System.Drawing.Point(6, 556);
            this.configConnectionContmatic.Name = "configConnectionContmatic";
            this.configConnectionContmatic.NomeConexao = "DBArquivoSpedContmatic";
            this.configConnectionContmatic.Senha = "";
            this.configConnectionContmatic.Size = new System.Drawing.Size(517, 139);
            this.configConnectionContmatic.TabIndex = 15;
            this.configConnectionContmatic.Title = "Configurações - Dados SPED Contmatic";
            this.configConnectionContmatic.Usuario = "";
            this.configConnectionContmatic.TestarConexao += new Hlp.Sped.UI.Events.TestarConexaoFirebirdHandler(this.configConnectionFirebird_TestarConexao);
            this.configConnectionContmatic.SalvarConexao += new Hlp.Sped.UI.Events.SalvarConexaoFirebirdHandler(this.configConnectionFirebird_SalvarConexao);
            // 
            // configConnectionFirebirdSpedContabil
            // 
            this.configConnectionFirebirdSpedContabil.CaminhoBase = "";
            this.configConnectionFirebirdSpedContabil.Dialeto = "1";
            this.configConnectionFirebirdSpedContabil.Location = new System.Drawing.Point(6, 425);
            this.configConnectionFirebirdSpedContabil.Name = "configConnectionFirebirdSpedContabil";
            this.configConnectionFirebirdSpedContabil.NomeConexao = "DBArquivoSpedContabil";
            this.configConnectionFirebirdSpedContabil.Senha = "";
            this.configConnectionFirebirdSpedContabil.Size = new System.Drawing.Size(517, 139);
            this.configConnectionFirebirdSpedContabil.TabIndex = 14;
            this.configConnectionFirebirdSpedContabil.Title = "Configurações - Dados SPED Contábil";
            this.configConnectionFirebirdSpedContabil.Usuario = "";
            this.configConnectionFirebirdSpedContabil.TestarConexao += new Hlp.Sped.UI.Events.TestarConexaoFirebirdHandler(this.configConnectionFirebird_TestarConexao);
            this.configConnectionFirebirdSpedContabil.SalvarConexao += new Hlp.Sped.UI.Events.SalvarConexaoFirebirdHandler(this.configConnectionFirebird_SalvarConexao);
            // 
            // configConnectionFirebirdSpedFiscal
            // 
            this.configConnectionFirebirdSpedFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configConnectionFirebirdSpedFiscal.CaminhoBase = "";
            this.configConnectionFirebirdSpedFiscal.Dialeto = "1";
            this.configConnectionFirebirdSpedFiscal.Location = new System.Drawing.Point(6, 292);
            this.configConnectionFirebirdSpedFiscal.Name = "configConnectionFirebirdSpedFiscal";
            this.configConnectionFirebirdSpedFiscal.NomeConexao = "DBArquivoSpedFiscal";
            this.configConnectionFirebirdSpedFiscal.Senha = "";
            this.configConnectionFirebirdSpedFiscal.Size = new System.Drawing.Size(513, 139);
            this.configConnectionFirebirdSpedFiscal.TabIndex = 13;
            this.configConnectionFirebirdSpedFiscal.Title = "Configurações - Dados SPED Fiscal";
            this.configConnectionFirebirdSpedFiscal.Usuario = "";
            this.configConnectionFirebirdSpedFiscal.TestarConexao += new Hlp.Sped.UI.Events.TestarConexaoFirebirdHandler(this.configConnectionFirebird_TestarConexao);
            this.configConnectionFirebirdSpedFiscal.SalvarConexao += new Hlp.Sped.UI.Events.SalvarConexaoFirebirdHandler(this.configConnectionFirebird_SalvarConexao);
            // 
            // configConnectionFirebirdContabil
            // 
            this.configConnectionFirebirdContabil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configConnectionFirebirdContabil.CaminhoBase = "";
            this.configConnectionFirebirdContabil.Dialeto = "1";
            this.configConnectionFirebirdContabil.Location = new System.Drawing.Point(6, 159);
            this.configConnectionFirebirdContabil.Name = "configConnectionFirebirdContabil";
            this.configConnectionFirebirdContabil.NomeConexao = "DBOrigemDadosContabil";
            this.configConnectionFirebirdContabil.Senha = "";
            this.configConnectionFirebirdContabil.Size = new System.Drawing.Size(513, 139);
            this.configConnectionFirebirdContabil.TabIndex = 12;
            this.configConnectionFirebirdContabil.Title = "Configurações - Contábil";
            this.configConnectionFirebirdContabil.Usuario = "";
            this.configConnectionFirebirdContabil.TestarConexao += new Hlp.Sped.UI.Events.TestarConexaoFirebirdHandler(this.configConnectionFirebird_TestarConexao);
            this.configConnectionFirebirdContabil.SalvarConexao += new Hlp.Sped.UI.Events.SalvarConexaoFirebirdHandler(this.configConnectionFirebird_SalvarConexao);
            // 
            // configConnectionFirebirdFiscal
            // 
            this.configConnectionFirebirdFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configConnectionFirebirdFiscal.CaminhoBase = "";
            this.configConnectionFirebirdFiscal.Dialeto = "1";
            this.configConnectionFirebirdFiscal.Location = new System.Drawing.Point(6, 26);
            this.configConnectionFirebirdFiscal.Name = "configConnectionFirebirdFiscal";
            this.configConnectionFirebirdFiscal.NomeConexao = "DBOrigemDadosFiscal";
            this.configConnectionFirebirdFiscal.Senha = "";
            this.configConnectionFirebirdFiscal.Size = new System.Drawing.Size(513, 139);
            this.configConnectionFirebirdFiscal.TabIndex = 11;
            this.configConnectionFirebirdFiscal.Title = "Configurações - Fiscal";
            this.configConnectionFirebirdFiscal.Usuario = "";
            this.configConnectionFirebirdFiscal.TestarConexao += new Hlp.Sped.UI.Events.TestarConexaoFirebirdHandler(this.configConnectionFirebird_TestarConexao);
            this.configConnectionFirebirdFiscal.SalvarConexao += new Hlp.Sped.UI.Events.SalvarConexaoFirebirdHandler(this.configConnectionFirebird_SalvarConexao);
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
            this.titleStrip2.Size = new System.Drawing.Size(526, 25);
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
            // panel3
            // 
            this.panel3.BackgroundImage = global::Hlp.Sped.UI.Properties.Resources.blueheader;
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 690);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 33);
            this.panel3.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(441, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.ClientSize = new System.Drawing.Size(526, 723);
            this.Controls.Add(this.panel3);
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
            this.titleStrip2.ResumeLayout(false);
            this.titleStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private TitleStrip titleStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelConfigConnections;
        private ConfigConnectionFirebird configConnectionFirebirdFiscal;
        private ConfigConnectionFirebird configConnectionFirebirdContabil;
        private ConfigConnectionFirebird configConnectionFirebirdSpedFiscal;
        private ConfigConnectionFirebird configConnectionFirebirdSpedContabil;
        private ConfigConnectionFirebird configConnectionContmatic;
    }
}