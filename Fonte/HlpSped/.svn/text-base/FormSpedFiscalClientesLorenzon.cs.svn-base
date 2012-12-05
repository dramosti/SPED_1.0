using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Hlp.Sped.Controllers.Fiscal;
using Hlp.Sped.Controllers.Fiscal.Lorenzon;
using Hlp.Sped.Controllers.Parameters.Fiscal;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Infrastructure.Helpers;

namespace Hlp.Sped.UI
{
    public partial class FormSpedFiscalClientesLorenzon : Form, IObserverAsynchronousExecution
    {
        private FrontController _FrontController;

        public FormSpedFiscalClientesLorenzon()
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

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (!this.ValidarAntesProcessamento())
                return;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            if (File.Exists(saveFileDialog1.FileName))
            {
                MessageBox.Show("Nome de arquivo já em uso. Selecione um nome diferente.");
                return;
            }

            lblProgresso.Visible = true;
            progressBar1.Visible = true;

            FiscalProcessParameters parameters = new FiscalProcessParameters();
            
            parameters.CodigoEmpresa = cbxEmpresas.SelectedValue.ToString();
            parameters.DataInicial = DateTimeHelper.GetFirstDayOfTheMonth(dtpInicio.Value);
            parameters.DataFinal = DateTimeHelper.GetLastDayOfTheMonth(dtpFim.Value);
            parameters.CaminhoArquivo = saveFileDialog1.FileName;
            parameters.TipoArquivo = TipoArquivo.Fiscal;
            parameters.TipoRemessa = TipoRemessa.Original;

            ClientesLorenzonProcessController controller =
                new ClientesLorenzonProcessController(parameters);
            controller.Initialize();
            ExecuteAsynchronousControllerDelegate execucaoController =
                new ExecuteAsynchronousControllerDelegate(ExecuteClientesFiscalLorenzonProcessController);
            execucaoController.BeginInvoke(controller, null, null);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSpedFiscal_Shown(object sender, EventArgs e)
        {
        }

        private void FormSpedFiscal_Load(object sender, EventArgs e)
        {
            _FrontController = new FrontController();
            _FrontController.Initialize();

            var empresas = from emp in _FrontController.ListEmpresasDisponiveis()
                           select new { emp.CODIGO_EMPRESA, DESC_EMPRESA = emp.CODIGO_EMPRESA + " - " + emp.NOME_EMPRESA };
            this.cbxEmpresas.Items.Clear();
            this.cbxEmpresas.DataSource = empresas.ToList();
            this.cbxEmpresas.DisplayMember = "DESC_EMPRESA";
            this.cbxEmpresas.ValueMember = "CODIGO_EMPRESA";
            this.cbxEmpresas.SelectedIndex = 0;

            DateTime dataAtual = DateTime.Now.Date;
            this.dtpInicio.MinDate = new DateTime(2000, 1, 1);
            this.dtpFim.MinDate = this.dtpInicio.MinDate;
            this.dtpInicio.MaxDate = dataAtual.AddDays(-1);
            this.dtpFim.MaxDate = this.dtpInicio.MaxDate;

            // Inicializa os filtros de data, atribuindo aos mesmos os dias inicial e
            // final do mês anterior
            this.dtpFim.Value = new DateTime(dataAtual.Year, dataAtual.Month, 1).AddDays(-1);
            this.dtpInicio.Value = new DateTime(this.dtpFim.Value.Year, this.dtpFim.Value.Month, 1);
        }

        public void ConfigureBeforeAsynchronousExecution()
        {
            if (!this.InvokeRequired)
            {
                this.Enabled = false;
                progressBar1.Value = 0;
                lblProgresso.Text = "Iniciando geração do arquivo...";
           }
            else
            {
                ConfigureBeforeAsynchronousDelegate configureBefore =
                    new ConfigureBeforeAsynchronousDelegate(ConfigureBeforeAsynchronousExecution);
                this.BeginInvoke(configureBefore);
            }
        }

        public void UpdateStatusAsynchronousExecution(string message)
        {
            if (!this.InvokeRequired)
            {
                Application.DoEvents();
                if (progressBar1.Value == 100)
                    progressBar1.Value = 0;
                progressBar1.Value += 1;
                lblProgresso.Text = message;
                Application.DoEvents();
            }
            else
            {
                UpdateStatusAsynchronousDelegate updateStatus =
                    new UpdateStatusAsynchronousDelegate(UpdateStatusAsynchronousExecution);
                this.BeginInvoke(updateStatus, new object[] { message });
            }
        }

        public void AsynchronousExecutionFinished()
        {
            if (!this.InvokeRequired)
            {
                progressBar1.Value = 100;
                lblProgresso.Text = String.Empty;
                this.Enabled = true;
                MessageBox.Show("Geração do arquivo concluída com sucesso!");
            }
            else
            {
                AsynchronousExecutionFinishedDelegate executionFinished =
                    new AsynchronousExecutionFinishedDelegate(AsynchronousExecutionFinished);
                this.BeginInvoke(executionFinished);
            }
        }

        public void AsynchronousExecutionAborted(Exception ex)
        {
            if (!this.InvokeRequired)
            {
                progressBar1.Value = 0;
                this.Enabled = true;
                lblProgresso.Text = String.Empty;
                MessageBox.Show(String.Format(
                    "Ocorreu o seguinte erro durante a tentativa de geração do arquivo: {0} - {1}\r\n\r\n{2}",
                    ex.GetType().ToString(), ex.Message, ex.StackTrace));
            }
            else
            {
                AsynchronousExecutionAbortedDelegate executionAborted =
                    new AsynchronousExecutionAbortedDelegate(AsynchronousExecutionAborted);
                this.BeginInvoke(executionAborted, new object[] { ex });
            }
        }

        private void ExecuteClientesFiscalLorenzonProcessController(BaseController controller)
        {
            controller.ExecuteAsynchronous(this);
        }

        private bool ValidarAntesProcessamento()
        {
            if (this.cbxEmpresas.SelectedValue == null)
            {
                MessageBox.Show("É obrigatória a seleção de uma empresa válida!");
                return false;
            }

            if (DateTimeHelper.GetFirstDayOfTheMonth(this.dtpInicio.Value) > 
                DateTimeHelper.GetLastDayOfTheMonth(this.dtpFim.Value))
            {
                MessageBox.Show("A Data Inicial não pode ser superior à Data Final!");
                return false;
            }

            return true;
        }
    }
}