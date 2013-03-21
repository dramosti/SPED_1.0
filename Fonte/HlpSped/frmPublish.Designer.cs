namespace Hlp.Sped.UI
{
    partial class frmPublish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPublish));
            this.txtProximaVersao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblUltimaVersao = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chkTeste = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPublish = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDetalhe = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPastaToPublish = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLocalToPublish = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txtPastaInstalador = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLocalInstalador = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProximaVersao
            // 
            this.txtProximaVersao.Location = new System.Drawing.Point(140, 145);
            this.txtProximaVersao.Name = "txtProximaVersao";
            this.txtProximaVersao.Size = new System.Drawing.Size(87, 20);
            this.txtProximaVersao.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.txtProximaVersao);
            this.kryptonPanel1.Controls.Add(this.lblUltimaVersao);
            this.kryptonPanel1.Controls.Add(this.chkTeste);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.btnCancelar);
            this.kryptonPanel1.Controls.Add(this.btnPublish);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.txtDetalhe);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txtPastaToPublish);
            this.kryptonPanel1.Controls.Add(this.txtPastaInstalador);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(464, 391);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // lblUltimaVersao
            // 
            this.lblUltimaVersao.Location = new System.Drawing.Point(12, 145);
            this.lblUltimaVersao.Name = "lblUltimaVersao";
            this.lblUltimaVersao.Size = new System.Drawing.Size(6, 2);
            this.lblUltimaVersao.TabIndex = 12;
            this.lblUltimaVersao.Values.Text = "";
            // 
            // chkTeste
            // 
            this.chkTeste.Checked = true;
            this.chkTeste.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTeste.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkTeste.Location = new System.Drawing.Point(12, 184);
            this.chkTeste.Name = "chkTeste";
            this.chkTeste.Size = new System.Drawing.Size(130, 20);
            this.chkTeste.TabIndex = 3;
            this.chkTeste.Text = "Executável de Teste";
            this.chkTeste.Values.Text = "Executável de Teste";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(135, 119);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(95, 20);
            this.kryptonLabel5.TabIndex = 10;
            this.kryptonLabel5.Values.Text = "Próxima Versão";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 119);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel4.TabIndex = 9;
            this.kryptonLabel4.Values.Text = "Última Versão";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(342, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Values.Text = "Cancel";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(246, 340);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(90, 25);
            this.btnPublish.TabIndex = 5;
            this.btnPublish.Values.Text = "Publish";
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 210);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(153, 20);
            this.kryptonLabel3.TabIndex = 8;
            this.kryptonLabel3.Values.Text = "Observação da Publicação";
            // 
            // txtDetalhe
            // 
            this.txtDetalhe.Location = new System.Drawing.Point(12, 236);
            this.txtDetalhe.Multiline = true;
            this.txtDetalhe.Name = "txtDetalhe";
            this.txtDetalhe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalhe.Size = new System.Drawing.Size(420, 98);
            this.txtDetalhe.TabIndex = 4;
            this.txtDetalhe.Text = "PRINCIPAIS ALTERACOES\r\n--------------------------------------------------------\r\n" +
    "\r\n\r\n--------------------------------------------------------\r\nCopyright © 2012 -" +
    " HLP Informatica Ltda";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 65);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(310, 20);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Caminho da Pasta será publicado a versão compactada";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(215, 20);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Caminho da Pasta onde foi publicado";
            // 
            // txtPastaToPublish
            // 
            this.txtPastaToPublish.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnLocalToPublish});
            this.txtPastaToPublish.Location = new System.Drawing.Point(12, 91);
            this.txtPastaToPublish.Name = "txtPastaToPublish";
            this.txtPastaToPublish.Size = new System.Drawing.Size(420, 20);
            this.txtPastaToPublish.TabIndex = 1;
            this.txtPastaToPublish.Text = "C:\\GeraXml\\Versoes\\SPED 1.0";
            // 
            // btnLocalToPublish
            // 
            this.btnLocalToPublish.UniqueName = "btnLocalToPublish";
            // 
            // txtPastaInstalador
            // 
            this.txtPastaInstalador.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnLocalInstalador});
            this.txtPastaInstalador.Location = new System.Drawing.Point(12, 37);
            this.txtPastaInstalador.Name = "txtPastaInstalador";
            this.txtPastaInstalador.Size = new System.Drawing.Size(420, 20);
            this.txtPastaInstalador.TabIndex = 0;
            this.txtPastaInstalador.Text = "D:\\GIT-SVN\\Fontes\\SPED_1.0\\Fonte\\SPED_Installer\\Debug\\";
            // 
            // btnLocalInstalador
            // 
            this.btnLocalInstalador.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalInstalador.Image")));
            this.btnLocalInstalador.UniqueName = "btnLocalInstalador";
            this.btnLocalInstalador.Click += new System.EventHandler(this.btnLocalInstalador_Click);
            // 
            // frmPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frmPublish";
            this.ShowIcon = false;
            this.Text = "Publicar Versão";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProximaVersao;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUltimaVersao;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkTeste;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPublish;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDetalhe;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPastaToPublish;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLocalToPublish;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPastaInstalador;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnLocalInstalador;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}