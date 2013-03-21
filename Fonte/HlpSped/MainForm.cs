using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Hlp.Sped.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tsmPublish.Visible = false;
            if (System.Diagnostics.Debugger.IsAttached)
            {
                tsmPublish.Visible = true;
            }
            tsVersao.Text = "Versão: " + Assembly.GetEntryAssembly().GetName().Version; ;
        }

        #region Private Implementation

        private void HideContent()
        {
            foreach (Control control in this.contentPanel.Controls)
            {
                // Hide all content
                control.Visible = false;
            }
        }
        #endregion

        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpedFiscal fiscal = new FormSpedFiscal();
            fiscal.ShowDialog();
        }

        private void fiscalClientesLorenzonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpedFiscalClientesLorenzon clientesFiscalLorenzon =
                new FormSpedFiscalClientesLorenzon();
            clientesFiscalLorenzon.ShowDialog();
        }

        private void fiscalInventarioLorenzonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpedFiscalInventarioLorenzon inventarioFiscalLorenzon =
                new FormSpedFiscalInventarioLorenzon();
            inventarioFiscalLorenzon.ShowDialog();
        }

        private void fiscalProdutosLorenzonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpedFiscalProdutosLorenzon produtosLorenzon =
                new FormSpedFiscalProdutosLorenzon();
            produtosLorenzon.ShowDialog();
        }

        private void contabilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpedContabil contabil = new FormSpedContabil();
            contabil.ShowDialog();
        }

        private void pisCofinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpedPisCofins pisCofins = new FormSpedPisCofins();
            pisCofins.ShowDialog();
        }

        private void conexoesAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigConnections configAcesso = new FormConfigConnections();
            configAcesso.ShowDialog();
        }

        #endregion

        private void fiscalContmaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpedContmatic objForm = new FormSpedContmatic();
            objForm.ShowDialog();
        }

        private void tsmPublish_Click(object sender, EventArgs e)
        {
            frmPublish objfrm = new frmPublish();            
            objfrm.ShowDialog();
        }
    }
}
