using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Ninject;
using Hlp.Sped.Services.Interfaces;
using Hlp.Sped.Controllers;
using Hlp.Sped.Domain.Models;
using System.Configuration;

namespace Hlp.Sped.UI
{
    public partial class MainForm : Form
    {

        ConfigConnectionsController _ConfigConnectionsController;

        public MainForm()
        {
            InitializeComponent();
            tsmPublish.Visible = false;
            if (System.Diagnostics.Debugger.IsAttached)
            {
                tsmPublish.Visible = true;
            }
            tsVersao.Text = "Versão: " + Assembly.GetEntryAssembly().GetName().Version; ;
            _ConfigConnectionsController = new ConfigConnectionsController();
            _ConfigConnectionsController.Initialize();





            CarregaMenus();
        }

        private void CarregaMenus()
        {
            tsBasico.Visible = false;
            tsContabil.Visible = false;
            tsContimatic.Visible = false;
            tsFull1.Visible = false;
            tsFull2.Visible = false;
            tsLorenzon1.Visible = false;
            tsLorenzon2.Visible = false;
            Conexao cx = null;
            ModelConexao conn = _ConfigConnectionsController.ConexoesService.GetConfigConexoes();
            if (conn != null)
            {
                if (conn.CONEXOES.Count > 0)
                {
                    if (conn.CONEXOES.Where(c => c.NAME == "DBArquivoSpedContmatic").Count() > 0)
                    {
                        cx = _ConfigConnectionsController.ObterConexao("DBArquivoSpedContmatic");
                        if (cx.bCOMPLETO)
                            tsContimatic.Visible = true;
                    }
                    if (conn.CONEXOES.Where(c => c.NAME == "DBArquivoSpedContabil").Count() > 0)
                    {
                        cx = _ConfigConnectionsController.ObterConexao("DBArquivoSpedContabil");
                        if (cx.bCOMPLETO)
                            tsContabil.Visible = true;
                    }

                    if (conn.CONEXOES.Where(c => c.NAME == "DBArquivoSpedFiscal").Count() > 0)
                    {
                        tsBasico.Visible = true;

                        if (conn.bCOMPLETO)
                        {
                            tsFull1.Visible = true;
                            tsFull2.Visible = true;
                        }

                        cx = _ConfigConnectionsController.ObterConexao("DBArquivoSpedFiscal");


                        if (cx.sNM_EMPRESA.ToUpper().Equals("LORENZON"))
                        {
                            tsLorenzon1.Visible = true;
                            tsLorenzon2.Visible = true;
                        }
                    }
                }
            }
            cx = null;
            cx = _ConfigConnectionsController.ConexoesService.Obter("DBArquivoSpedFiscal");
            if (cx != null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["DBArquivoSpedFiscal"].ConnectionString = _ConfigConnectionsController.ConexoesService.GetConnectionString(cx);
                config.Save(ConfigurationSaveMode.Modified, false);
                ConfigurationManager.RefreshSection("connectionStrings");
                cx = null;
            }
            cx = _ConfigConnectionsController.ConexoesService.Obter("DBArquivoSpedContabil");
            if (cx != null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["DBArquivoSpedContabil"].ConnectionString = _ConfigConnectionsController.ConexoesService.GetConnectionString(cx);
                config.Save(ConfigurationSaveMode.Modified, false);
                ConfigurationManager.RefreshSection("connectionStrings");
                cx = null;
            }
            cx = _ConfigConnectionsController.ConexoesService.Obter("DBArquivoSpedContmatic");
            if (cx != null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["DBArquivoSpedContmatic"].ConnectionString = _ConfigConnectionsController.ConexoesService.GetConnectionString(cx);
                config.Save(ConfigurationSaveMode.Modified, false);
                ConfigurationManager.RefreshSection("connectionStrings");
                cx = null;
            }
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
            CarregaMenus();
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.CarregaMenus();
        }
    }
}
