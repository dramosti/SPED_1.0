namespace Hlp.Sped.UI
{
    partial class ConfigConnectionFirebird
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDadosFiscal = new System.Windows.Forms.GroupBox();
            this.txtServer = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhoBase = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblCaminhoBase = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpDadosFiscal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosFiscal
            // 
            this.grpDadosFiscal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDadosFiscal.BackColor = System.Drawing.Color.Transparent;
            this.grpDadosFiscal.Controls.Add(this.btnLimpar);
            this.grpDadosFiscal.Controls.Add(this.txtServer);
            this.grpDadosFiscal.Controls.Add(this.label1);
            this.grpDadosFiscal.Controls.Add(this.txtCaminhoBase);
            this.grpDadosFiscal.Controls.Add(this.btnSalvar);
            this.grpDadosFiscal.Controls.Add(this.lblCaminhoBase);
            this.grpDadosFiscal.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDadosFiscal.Location = new System.Drawing.Point(0, 0);
            this.grpDadosFiscal.Name = "grpDadosFiscal";
            this.grpDadosFiscal.Size = new System.Drawing.Size(528, 68);
            this.grpDadosFiscal.TabIndex = 9;
            this.grpDadosFiscal.TabStop = false;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(56, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(122, 20);
            this.txtServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Server";
            // 
            // txtCaminhoBase
            // 
            this.txtCaminhoBase.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtCaminhoBase.Location = new System.Drawing.Point(56, 43);
            this.txtCaminhoBase.Name = "txtCaminhoBase";
            this.txtCaminhoBase.Size = new System.Drawing.Size(372, 20);
            this.txtCaminhoBase.TabIndex = 2;
            // 
            // lblCaminhoBase
            // 
            this.lblCaminhoBase.AutoSize = true;
            this.lblCaminhoBase.Location = new System.Drawing.Point(12, 46);
            this.lblCaminhoBase.Name = "lblCaminhoBase";
            this.lblCaminhoBase.Size = new System.Drawing.Size(31, 13);
            this.lblCaminhoBase.TabIndex = 8;
            this.lblCaminhoBase.Text = "Base";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(452, 42);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 22);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::Hlp.Sped.UI.Properties.Resources.Pasta;
            this.buttonSpecAny1.UniqueName = "E2BED0334B7442E1B298D2917E9256F5";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(452, 14);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 22);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // ConfigConnectionFirebird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.grpDadosFiscal);
            this.Name = "ConfigConnectionFirebird";
            this.Size = new System.Drawing.Size(528, 106);
            this.grpDadosFiscal.ResumeLayout(false);
            this.grpDadosFiscal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosFiscal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCaminhoBase;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private System.Windows.Forms.Label lblCaminhoBase;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;


    }
}
