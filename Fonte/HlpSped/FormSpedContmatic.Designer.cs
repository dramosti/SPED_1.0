namespace Hlp.Sped.UI
{
    partial class FormSpedContmatic
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
            this.rdbRemesssaSubstituta = new System.Windows.Forms.RadioButton();
            this.rdbRemessaOriginal = new System.Windows.Forms.RadioButton();
            this.cbxEmpresas = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.titleStrip1 = new Hlp.Sped.UI.TitleStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            this.grpTipoRemessa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.titleStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.titleStrip1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpTipoRemessa);
            this.panel1.Controls.Add(this.cbxEmpresas);
            this.panel1.Controls.Add(this.lblEmpresa);
            this.panel1.Controls.Add(this.lblProgresso);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.dtpFim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 355);
            this.panel1.TabIndex = 5;
            // 
            // grpTipoRemessa
            // 
            this.grpTipoRemessa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTipoRemessa.Controls.Add(this.rdbRemesssaSubstituta);
            this.grpTipoRemessa.Controls.Add(this.rdbRemessaOriginal);
            this.grpTipoRemessa.Location = new System.Drawing.Point(22, 138);
            this.grpTipoRemessa.Name = "grpTipoRemessa";
            this.grpTipoRemessa.Size = new System.Drawing.Size(327, 48);
            this.grpTipoRemessa.TabIndex = 7;
            this.grpTipoRemessa.TabStop = false;
            this.grpTipoRemessa.Text = "Tipo de Remessa";
            // 
            // rdbRemesssaSubstituta
            // 
            this.rdbRemesssaSubstituta.AutoSize = true;
            this.rdbRemesssaSubstituta.Location = new System.Drawing.Point(191, 19);
            this.rdbRemesssaSubstituta.Name = "rdbRemesssaSubstituta";
            this.rdbRemesssaSubstituta.Size = new System.Drawing.Size(72, 17);
            this.rdbRemesssaSubstituta.TabIndex = 8;
            this.rdbRemesssaSubstituta.Text = "Substituta";
            this.rdbRemesssaSubstituta.UseVisualStyleBackColor = true;
            // 
            // rdbRemessaOriginal
            // 
            this.rdbRemessaOriginal.AutoSize = true;
            this.rdbRemessaOriginal.Checked = true;
            this.rdbRemessaOriginal.Location = new System.Drawing.Point(44, 19);
            this.rdbRemessaOriginal.Name = "rdbRemessaOriginal";
            this.rdbRemessaOriginal.Size = new System.Drawing.Size(60, 17);
            this.rdbRemessaOriginal.TabIndex = 7;
            this.rdbRemessaOriginal.TabStop = true;
            this.rdbRemessaOriginal.Text = "Original";
            this.rdbRemessaOriginal.UseVisualStyleBackColor = true;
            // 
            // cbxEmpresas
            // 
            this.cbxEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEmpresas.FormattingEnabled = true;
            this.cbxEmpresas.Items.AddRange(new object[] {
            "001 - Empresa 001",
            "002 - Teste 002",
            "111 - Empresa 111",
            "999 - Teste 999"});
            this.cbxEmpresas.Location = new System.Drawing.Point(22, 106);
            this.cbxEmpresas.Name = "cbxEmpresas";
            this.cbxEmpresas.Size = new System.Drawing.Size(327, 21);
            this.cbxEmpresas.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(19, 90);
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
            this.lblProgresso.Location = new System.Drawing.Point(19, 278);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(144, 13);
            this.lblProgresso.TabIndex = 8;
            this.lblProgresso.Text = "Processando Notas Fiscais...";
            this.lblProgresso.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(22, 294);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 11);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "MMMM yyyy";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(225, 63);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(124, 20);
            this.dtpFim.TabIndex = 3;
            this.dtpFim.Value = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mês Final:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "MMMM yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(22, 63);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(124, 20);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.Value = new System.DateTime(2010, 12, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mês Inicial:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(22, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Dados Participante";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(191, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Dados Inventário";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(191, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Dados EFC";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(44, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Sped Completo";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Hlp.Sped.UI.Properties.Resources.blueheader;
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Controls.Add(this.btnProcessar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 33);
            this.panel3.TabIndex = 11;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(283, 5);
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
            this.btnProcessar.Location = new System.Drawing.Point(202, 5);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(75, 23);
            this.btnProcessar.TabIndex = 0;
            this.btnProcessar.Text = "&Processar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
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
            this.titleStrip1.Size = new System.Drawing.Size(368, 25);
            this.titleStrip1.TabIndex = 12;
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
            // FormSpedContmatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 355);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSpedContmatic";
            this.Text = "Sped - Contmatic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTipoRemessa.ResumeLayout(false);
            this.grpTipoRemessa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.titleStrip1.ResumeLayout(false);
            this.titleStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpTipoRemessa;
        private System.Windows.Forms.RadioButton rdbRemesssaSubstituta;
        private System.Windows.Forms.RadioButton rdbRemessaOriginal;
        private System.Windows.Forms.ComboBox cbxEmpresas;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProcessar;
        private TitleStrip titleStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}