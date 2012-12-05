namespace Hlp.Sped.UI
{
    partial class FormSpedContabil
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
            this.grpTipoRemessa = new System.Windows.Forms.GroupBox();
            this.rdbContabilLivroBalancetes = new System.Windows.Forms.RadioButton();
            this.rdbContabilRazaoAuxiliar = new System.Windows.Forms.RadioButton();
            this.rdbContabilDiarioAuxiliar = new System.Windows.Forms.RadioButton();
            this.rdbContabilDiarioEscrituracao = new System.Windows.Forms.RadioButton();
            this.rdbContabilDiarioGeral = new System.Windows.Forms.RadioButton();
            this.cbxEmpresas = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.titleStrip1 = new Hlp.Sped.UI.TitleStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            this.grpTipoRemessa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.titleStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.dtpFim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grpTipoRemessa);
            this.panel1.Controls.Add(this.cbxEmpresas);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.lblProgresso);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 325);
            this.panel1.TabIndex = 0;
            // 
            // grpTipoRemessa
            // 
            this.grpTipoRemessa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTipoRemessa.Controls.Add(this.rdbContabilLivroBalancetes);
            this.grpTipoRemessa.Controls.Add(this.rdbContabilRazaoAuxiliar);
            this.grpTipoRemessa.Controls.Add(this.rdbContabilDiarioAuxiliar);
            this.grpTipoRemessa.Controls.Add(this.rdbContabilDiarioEscrituracao);
            this.grpTipoRemessa.Controls.Add(this.rdbContabilDiarioGeral);
            this.grpTipoRemessa.Location = new System.Drawing.Point(18, 120);
            this.grpTipoRemessa.Name = "grpTipoRemessa";
            this.grpTipoRemessa.Size = new System.Drawing.Size(504, 127);
            this.grpTipoRemessa.TabIndex = 6;
            this.grpTipoRemessa.TabStop = false;
            this.grpTipoRemessa.Text = "Tipo de Remessa";
            // 
            // rdbContabilLivroBalancetes
            // 
            this.rdbContabilLivroBalancetes.AutoSize = true;
            this.rdbContabilLivroBalancetes.Location = new System.Drawing.Point(10, 97);
            this.rdbContabilLivroBalancetes.Name = "rdbContabilLivroBalancetes";
            this.rdbContabilLivroBalancetes.Size = new System.Drawing.Size(226, 17);
            this.rdbContabilLivroBalancetes.TabIndex = 4;
            this.rdbContabilLivroBalancetes.Text = "B - Livro de Balancetes Diários e Balanços";
            this.rdbContabilLivroBalancetes.UseVisualStyleBackColor = true;
            // 
            // rdbContabilRazaoAuxiliar
            // 
            this.rdbContabilRazaoAuxiliar.AutoSize = true;
            this.rdbContabilRazaoAuxiliar.Location = new System.Drawing.Point(10, 77);
            this.rdbContabilRazaoAuxiliar.Name = "rdbContabilRazaoAuxiliar";
            this.rdbContabilRazaoAuxiliar.Size = new System.Drawing.Size(465, 17);
            this.rdbContabilRazaoAuxiliar.TabIndex = 3;
            this.rdbContabilRazaoAuxiliar.Text = "Z - Razão Auxiliar (Livro Contábil Auxiliar conforme leiaute definido pelo titula" +
                "r da escrituração)";
            this.rdbContabilRazaoAuxiliar.UseVisualStyleBackColor = true;
            // 
            // rdbContabilDiarioAuxiliar
            // 
            this.rdbContabilDiarioAuxiliar.AutoSize = true;
            this.rdbContabilDiarioAuxiliar.Location = new System.Drawing.Point(10, 57);
            this.rdbContabilDiarioAuxiliar.Name = "rdbContabilDiarioAuxiliar";
            this.rdbContabilDiarioAuxiliar.Size = new System.Drawing.Size(310, 17);
            this.rdbContabilDiarioAuxiliar.TabIndex = 2;
            this.rdbContabilDiarioAuxiliar.Text = "A - Livro Diário Auxiliar ao Diário com Escrituração Resumida";
            this.rdbContabilDiarioAuxiliar.UseVisualStyleBackColor = true;
            // 
            // rdbContabilDiarioEscrituracao
            // 
            this.rdbContabilDiarioEscrituracao.AutoSize = true;
            this.rdbContabilDiarioEscrituracao.Location = new System.Drawing.Point(10, 37);
            this.rdbContabilDiarioEscrituracao.Name = "rdbContabilDiarioEscrituracao";
            this.rdbContabilDiarioEscrituracao.Size = new System.Drawing.Size(355, 17);
            this.rdbContabilDiarioEscrituracao.TabIndex = 1;
            this.rdbContabilDiarioEscrituracao.Text = "R - Livro Diário com Escrituração Resumida (com escrituração auxiliar)";
            this.rdbContabilDiarioEscrituracao.UseVisualStyleBackColor = true;
            // 
            // rdbContabilDiarioGeral
            // 
            this.rdbContabilDiarioGeral.AutoSize = true;
            this.rdbContabilDiarioGeral.Checked = true;
            this.rdbContabilDiarioGeral.Location = new System.Drawing.Point(10, 17);
            this.rdbContabilDiarioGeral.Name = "rdbContabilDiarioGeral";
            this.rdbContabilDiarioGeral.Size = new System.Drawing.Size(296, 17);
            this.rdbContabilDiarioGeral.TabIndex = 0;
            this.rdbContabilDiarioGeral.TabStop = true;
            this.rdbContabilDiarioGeral.Text = "G - Livro Diário Geral (completo, sem escrituração auxiliar)";
            this.rdbContabilDiarioGeral.UseVisualStyleBackColor = true;
            // 
            // cbxEmpresas
            // 
            this.cbxEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEmpresas.FormattingEnabled = true;
            this.cbxEmpresas.Location = new System.Drawing.Point(18, 93);
            this.cbxEmpresas.Name = "cbxEmpresas";
            this.cbxEmpresas.Size = new System.Drawing.Size(504, 21);
            this.cbxEmpresas.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(15, 77);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblProgresso
            // 
            this.lblProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProgresso.Location = new System.Drawing.Point(17, 253);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(175, 13);
            this.lblProgresso.TabIndex = 7;
            this.lblProgresso.Text = "Processando Registros Contábeis...";
            this.lblProgresso.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(18, 269);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(504, 11);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivo de texto|*.txt";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Hlp.Sped.UI.Properties.Resources.blueheader;
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Controls.Add(this.btnProcessar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 33);
            this.panel3.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(460, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessar.Location = new System.Drawing.Point(379, 5);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 0;
            this.btnProcessar.Text = "&Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "MMMM yyyy";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(172, 49);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(124, 20);
            this.dtpFim.TabIndex = 3;
            this.dtpFim.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mês Final:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "MMMM yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(18, 49);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(124, 20);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.Value = new System.DateTime(2010, 12, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mês Inicial:";
            // 
            // titleStrip1
            // 
            this.titleStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.titleStrip1.DrawEndLine = false;
            this.titleStrip1.GradientEndColor = System.Drawing.Color.White;
            this.titleStrip1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(186)))), ((int)(((byte)(214)))));
            this.titleStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titleStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.titleStrip1.Lines = 10;
            this.titleStrip1.Location = new System.Drawing.Point(0, 0);
            this.titleStrip1.Name = "titleStrip1";
            this.titleStrip1.Size = new System.Drawing.Size(545, 25);
            this.titleStrip1.TabIndex = 0;
            this.titleStrip1.Text = "titleStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(323, 22);
            this.toolStripLabel1.Text = "Selecione o período e a empresa para geração do arquivo";
            // 
            // FormSpedContabil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 325);
            this.Controls.Add(this.titleStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSpedContabil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sped - Contábil";
            this.Load += new System.EventHandler(this.FormSpedContabil_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSpedContabil_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTipoRemessa.ResumeLayout(false);
            this.grpTipoRemessa.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.titleStrip1.ResumeLayout(false);
            this.titleStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProcessar;
        private TitleStrip titleStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cbxEmpresas;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox grpTipoRemessa;
        private System.Windows.Forms.RadioButton rdbContabilDiarioGeral;
        private System.Windows.Forms.RadioButton rdbContabilLivroBalancetes;
        private System.Windows.Forms.RadioButton rdbContabilRazaoAuxiliar;
        private System.Windows.Forms.RadioButton rdbContabilDiarioAuxiliar;
        private System.Windows.Forms.RadioButton rdbContabilDiarioEscrituracao;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
    }
}