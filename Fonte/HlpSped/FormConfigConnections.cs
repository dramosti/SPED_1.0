using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Hlp.Sped.Controllers;
using Hlp.Sped.Controllers.Fiscal;
using Hlp.Sped.Controllers.Parameters.Fiscal;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Infrastructure.Helpers;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.UI
{
    public partial class FormConfigConnections : Form
    {
        private ConfigConnectionsController _ConfigConnectionsController;

        public FormConfigConnections()
        {
            InitializeComponent();
        }

        private void FormSpedFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void FormConfigConnections_Load(object sender, EventArgs e)
        {
            txtCaminhoBase.Text = Util.GetPastaConfiguracao();


            _ConfigConnectionsController = new ConfigConnectionsController();
            _ConfigConnectionsController.Initialize();

            //this.CarregarConfiguracoes(configConnectionFirebirdFiscal);
            //this.CarregarConfiguracoes(configConnectionFirebirdContabil);
            this.CarregarConfiguracoes(configConnectionFirebirdSpedFiscal);
            this.CarregarConfiguracoes(configConnectionFirebirdSpedContabil);
            this.CarregarConfiguracoes(configConnectionContmatic);



        }

        private void configConnectionFirebird_TestarConexao(ConfigConnectionFirebird sender)
        {
            //if (_ConfigConnectionsController.ValidarConexao(
            //    this.GetInformacoesConexao(sender)))
            //    MessageBox.Show("Conexão válida!");
            //else
            //    MessageBox.Show("Erro ao se tentar efetuar a conexão com a base de dados!");
            Conexao conexao = this.GetInformacoesConexao(sender);

            if (conexao != null)
            {
                _ConfigConnectionsController.ConexoesService.RemoveConexao(conexao);
                sender.Clear();                
            }
        }

        private void configConnectionFirebird_SalvarConexao(ConfigConnectionFirebird sender)
        {
            Conexao conexao = this.GetInformacoesConexao(sender);

            conexao.bCOMPLETO = ckbCompleto.Checked;

            if (!_ConfigConnectionsController.ValidarConexao(conexao))
            {
                MessageBox.Show("Impossível salvar esta configuração, pois ocorreu um erro " +
                    "ao se tentar efetuar a conexão com a base de dados!");
                return;
            }

            _ConfigConnectionsController.SalvarConexao(conexao);
            MessageBox.Show("Conexão salva com sucesso!");
        }

        #region Métodos privados

        private void CarregarConfiguracoes(ConfigConnectionFirebird config)
        {
            Conexao conexao = _ConfigConnectionsController.ObterConexao(
                config.NomeConexao);
            if (conexao != null)
            {
                //config.Dialeto = conexao.PROPRIEDADES["Dialect"];
                //config.Usuario = conexao.PROPRIEDADES["uid"];
                //config.Senha = conexao.PROPRIEDADES["pwd"];
                config.CaminhoBase = conexao.PROPRIEDADES["dbname"];

                if (conexao.bCOMPLETO)
                {
                    config.Visible = true;
                    ckbCompleto.Checked = true;
                    configConnectionFirebirdSpedContabil.Visible = true;
                    configConnectionContmatic.Visible = true;
                }
            }
        }

        private Conexao GetInformacoesConexao(ConfigConnectionFirebird config)
        {
            Conexao conexao = new Conexao();

            conexao.NOME = config.NomeConexao;
            conexao.PROPRIEDADES.Add("Driver", "{Firebird/InterBase(r) driver}");
            conexao.PROPRIEDADES.Add("Dialect", config.Dialeto);
            conexao.PROPRIEDADES.Add("uid", config.Usuario);
            conexao.PROPRIEDADES.Add("dbname", config.CaminhoBase);
            conexao.PROPRIEDADES.Add("pwd", config.Senha);

            return conexao;
        }

        #endregion

        private void FormConfigConnections_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Caso tenha alterado alguma configuração de acesso, " +
                "encerre esta aplicação e execute a mesma novamente, a fim de que as mudanças " +
                "efetuadas possam surtir efeito.");
        }

        private void kryptonCheckBox1_Click(object sender, EventArgs e)
        {
            if (ckbCompleto.Checked)
            {
                this.Visible = false;
                FormSenhaSped frm = new FormSenhaSped();
                frm.ShowDialog();
                if (frm.bSenhaValida)
                {
                    configConnectionFirebirdSpedContabil.Visible = ckbCompleto.Checked;
                    configConnectionContmatic.Visible = ckbCompleto.Checked;
                }
                else
                {
                    ckbCompleto.Checked = false;
                }
                this.Visible = true;
            }
            else
            {
                configConnectionFirebirdSpedContabil.Visible = ckbCompleto.Checked;
                configConnectionContmatic.Visible = ckbCompleto.Checked;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCaminhoBase.Text != "")
            {
                if (Directory.Exists(txtCaminhoBase.Text))
                {
                    Util.SalvarRegistro(txtCaminhoBase.Text);
                }
            }
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Selecione um diretório Válido na ree";
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCaminhoBase.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}