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
            _ConfigConnectionsController = new ConfigConnectionsController();
            _ConfigConnectionsController.Initialize();

            this.CarregarConfiguracoes(configConnectionFirebirdFiscal);
            this.CarregarConfiguracoes(configConnectionFirebirdContabil);
            this.CarregarConfiguracoes(configConnectionFirebirdSpedFiscal);
            this.CarregarConfiguracoes(configConnectionFirebirdSpedContabil);
        }

        private void configConnectionFirebird_TestarConexao(ConfigConnectionFirebird sender)
        {
            if (_ConfigConnectionsController.ValidarConexao(
                this.GetInformacoesConexao(sender)))
                MessageBox.Show("Conexão válida!");
            else
                MessageBox.Show("Erro ao se tentar efetuar a conexão com a base de dados!");
        }

        private void configConnectionFirebird_SalvarConexao(ConfigConnectionFirebird sender)
        {
            Conexao conexao = this.GetInformacoesConexao(sender);
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
            config.Dialeto = conexao.PROPRIEDADES["Dialect"];
            config.Usuario = conexao.PROPRIEDADES["uid"];
            config.Senha = conexao.PROPRIEDADES["pwd"];
            config.CaminhoBase = conexao.PROPRIEDADES["dbname"];
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
    }
}