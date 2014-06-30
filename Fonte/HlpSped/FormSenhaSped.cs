using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hlp.Sped.UI
{
    public partial class FormSenhaSped : Form
    {
        public FormSenhaSped()
        {
            InitializeComponent();
        }
        public bool bSenhaValida = false;

        private void btnSair_Click(object sender, EventArgs e)
        {
            bSenhaValida = false;
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtSenha.Text.ToString().ToUpper().Equals("SUPORTESPED"))
            {
                if (txtUser.Text.ToString().ToUpper().Equals("HLP"))
                {
                    bSenhaValida = true;
                    this.Close();
                }
                else
                {
                    txtUser.Focus();
                    errorProvider1.SetError(txtUser, "Usuário inválido");
                }
            }
            else
            {
                txtSenha.Focus();
                errorProvider1.SetError(txtSenha, "Senha inválida");
            }
        }
    }
}
