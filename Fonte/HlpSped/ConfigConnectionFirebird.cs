using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hlp.Sped.UI.Events;

namespace Hlp.Sped.UI
{
    public partial class ConfigConnectionFirebird : UserControl
    {
        public event TestarConexaoFirebirdHandler TestarConexao;
        public event SalvarConexaoFirebirdHandler SalvarConexao;

        public string NomeConexao { get; set; }

        public string Title
        {
            get { return this.grpDadosFiscal.Text; }
            set { this.grpDadosFiscal.Text = value; }
        }

        public string Dialeto
        {
            get
            {
                if (this.rdbDialeto1.Checked)
                    return "1";
                else
                    return "3";
            }
            set
            {
                if (value == "1")
                    this.rdbDialeto1.Checked = true;
                else
                    this.rdbDialeto3.Checked = true;
            }
        }

        public string Usuario
        {
            get { return this.txtUsuario.Text.Trim(); }
            set { this.txtUsuario.Text = value; }
        }

        public string Senha
        {
            get { return this.txtSenha.Text; }
            set { this.txtSenha.Text = value; }
        }

        public string CaminhoBase
        {
            get { return this.txtCaminhoBase.Text.Trim(); }
            set { this.txtCaminhoBase.Text = value; }
        }

        public ConfigConnectionFirebird()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (TestarConexao != null)
                TestarConexao(this);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (SalvarConexao != null)
                SalvarConexao(this);
        }
    }
}
