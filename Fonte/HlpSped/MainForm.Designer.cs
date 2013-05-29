namespace Hlp.Sped.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.customMenuStrip1 = new Hlp.Sped.UI.CustomMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLorenzon1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBasico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLorenzon2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFull1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFull2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsContabil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsContimatic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.conexoesAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPublish = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.spine1 = new Hlp.Sped.UI.Spine();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customToolStrip1 = new Hlp.Sped.UI.CustomToolStrip();
            this.customToolStrip2 = new Hlp.Sped.UI.CustomToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsVersao = new System.Windows.Forms.ToolStripLabel();
            this.customMenuStrip1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.customToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customMenuStrip1
            // 
            this.customMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItemConfiguracoes,
            this.helpToolStripMenuItem});
            this.customMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.customMenuStrip1.Name = "customMenuStrip1";
            this.customMenuStrip1.Size = new System.Drawing.Size(799, 24);
            this.customMenuStrip1.TabIndex = 0;
            this.customMenuStrip1.Text = "customMenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLorenzon1,
            this.tsBasico,
            this.tsLorenzon2,
            this.tsFull1,
            this.tsFull2,
            this.tsContabil,
            this.tsContimatic,
            this.toolStripSeparator4,
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.fileToolStripMenuItem.Text = "&Escrituração";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // tsLorenzon1
            // 
            this.tsLorenzon1.Name = "tsLorenzon1";
            this.tsLorenzon1.Size = new System.Drawing.Size(222, 22);
            this.tsLorenzon1.Text = "Fiscal - Clientes (Lorenzon)";
            this.tsLorenzon1.Visible = false;
            this.tsLorenzon1.Click += new System.EventHandler(this.fiscalClientesLorenzonToolStripMenuItem_Click);
            // 
            // tsBasico
            // 
            this.tsBasico.Name = "tsBasico";
            this.tsBasico.Size = new System.Drawing.Size(222, 22);
            this.tsBasico.Text = "Fiscal - Inventário";
            this.tsBasico.Visible = false;
            this.tsBasico.Click += new System.EventHandler(this.fiscalInventarioLorenzonToolStripMenuItem_Click);
            // 
            // tsLorenzon2
            // 
            this.tsLorenzon2.Name = "tsLorenzon2";
            this.tsLorenzon2.Size = new System.Drawing.Size(222, 22);
            this.tsLorenzon2.Text = "Fiscal - Produtos (Lorenzon)";
            this.tsLorenzon2.Visible = false;
            this.tsLorenzon2.Click += new System.EventHandler(this.fiscalProdutosLorenzonToolStripMenuItem_Click);
            // 
            // tsFull1
            // 
            this.tsFull1.Name = "tsFull1";
            this.tsFull1.Size = new System.Drawing.Size(222, 22);
            this.tsFull1.Text = "&Fiscal";
            this.tsFull1.Visible = false;
            this.tsFull1.Click += new System.EventHandler(this.fiscalToolStripMenuItem_Click);
            // 
            // tsFull2
            // 
            this.tsFull2.Name = "tsFull2";
            this.tsFull2.Size = new System.Drawing.Size(222, 22);
            this.tsFull2.Text = "&Pis / Cofins";
            this.tsFull2.Visible = false;
            this.tsFull2.Click += new System.EventHandler(this.pisCofinsToolStripMenuItem_Click);
            // 
            // tsContabil
            // 
            this.tsContabil.Name = "tsContabil";
            this.tsContabil.Size = new System.Drawing.Size(222, 22);
            this.tsContabil.Text = "&Contábil";
            this.tsContabil.Visible = false;
            this.tsContabil.Click += new System.EventHandler(this.contabilToolStripMenuItem_Click);
            // 
            // tsContimatic
            // 
            this.tsContimatic.Name = "tsContimatic";
            this.tsContimatic.Size = new System.Drawing.Size(222, 22);
            this.tsContimatic.Text = "Contmatic";
            this.tsContimatic.Visible = false;
            this.tsContimatic.Click += new System.EventHandler(this.fiscalContmaticToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItemConfiguracoes
            // 
            this.toolStripMenuItemConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexoesAcessoToolStripMenuItem});
            this.toolStripMenuItemConfiguracoes.Name = "toolStripMenuItemConfiguracoes";
            this.toolStripMenuItemConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.toolStripMenuItemConfiguracoes.Text = "&Configurações";
            // 
            // conexoesAcessoToolStripMenuItem
            // 
            this.conexoesAcessoToolStripMenuItem.Name = "conexoesAcessoToolStripMenuItem";
            this.conexoesAcessoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.conexoesAcessoToolStripMenuItem.Text = "&Conexões de Acesso";
            this.conexoesAcessoToolStripMenuItem.Click += new System.EventHandler(this.conexoesAcessoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.tsmPublish});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.helpToolStripMenuItem.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            // 
            // tsmPublish
            // 
            this.tsmPublish.Name = "tsmPublish";
            this.tsmPublish.Size = new System.Drawing.Size(155, 22);
            this.tsmPublish.Text = "Publicar Versao";
            this.tsmPublish.Click += new System.EventHandler(this.tsmPublish_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(169, 95);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(630, 382);
            this.contentPanel.TabIndex = 3;
            // 
            // spine1
            // 
            this.spine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.spine1.Dock = System.Windows.Forms.DockStyle.Left;
            this.spine1.Location = new System.Drawing.Point(0, 49);
            this.spine1.Name = "spine1";
            this.spine1.Size = new System.Drawing.Size(169, 428);
            this.spine1.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(169, 49);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(630, 46);
            this.topPanel.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.panel2.Location = new System.Drawing.Point(14, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.panel1.Location = new System.Drawing.Point(14, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 1);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPED - Sistema Público de Escrituração Digital";
            // 
            // customToolStrip1
            // 
            this.customToolStrip1.BackgroundImage = global::Hlp.Sped.UI.Properties.Resources.blueheader;
            this.customToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.customToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.customToolStrip1.Name = "customToolStrip1";
            this.customToolStrip1.Padding = new System.Windows.Forms.Padding(0, 4, 1, 0);
            this.customToolStrip1.Size = new System.Drawing.Size(799, 25);
            this.customToolStrip1.TabIndex = 1;
            this.customToolStrip1.Text = "customToolStrip1";
            // 
            // customToolStrip2
            // 
            this.customToolStrip2.BackgroundImage = global::Hlp.Sped.UI.Properties.Resources.bluefooter;
            this.customToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.customToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsVersao});
            this.customToolStrip2.Location = new System.Drawing.Point(0, 477);
            this.customToolStrip2.Name = "customToolStrip2";
            this.customToolStrip2.Size = new System.Drawing.Size(799, 25);
            this.customToolStrip2.TabIndex = 2;
            this.customToolStrip2.Text = "customToolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(224, 22);
            this.toolStripLabel1.Text = "Copyright © 2011 - Hlp Informática Ltda.";
            // 
            // tsVersao
            // 
            this.tsVersao.ForeColor = System.Drawing.SystemColors.Window;
            this.tsVersao.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tsVersao.Name = "tsVersao";
            this.tsVersao.Size = new System.Drawing.Size(45, 22);
            this.tsVersao.Text = "Versão:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 502);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.spine1);
            this.Controls.Add(this.customToolStrip1);
            this.Controls.Add(this.customToolStrip2);
            this.Controls.Add(this.customMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.customMenuStrip1;
            this.Name = "MainForm";
            this.Text = "HlpSped";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.customMenuStrip1.ResumeLayout(false);
            this.customMenuStrip1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.customToolStrip2.ResumeLayout(false);
            this.customToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hlp.Sped.UI.CustomMenuStrip customMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel contentPanel;
        private Hlp.Sped.UI.CustomToolStrip customToolStrip1;
        private Hlp.Sped.UI.CustomToolStrip customToolStrip2;
        private Spine spine1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsFull1;
        private System.Windows.Forms.ToolStripMenuItem tsContabil;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem conexoesAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsFull2;
        private System.Windows.Forms.ToolStripMenuItem tsLorenzon1;
        private System.Windows.Forms.ToolStripMenuItem tsBasico;
        private System.Windows.Forms.ToolStripMenuItem tsLorenzon2;
        private System.Windows.Forms.ToolStripMenuItem tsContimatic;
        private System.Windows.Forms.ToolStripMenuItem tsmPublish;
        private System.Windows.Forms.ToolStripLabel tsVersao;
    }
}