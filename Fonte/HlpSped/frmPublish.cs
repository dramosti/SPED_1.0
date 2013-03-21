using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Reflection;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;

namespace Hlp.Sped.UI
{
    public partial class frmPublish : KryptonForm
    {
        public frmPublish()
        {
            InitializeComponent();
            CarregaVersao();
        }

        private void CarregaVersao()
        {
            if (Directory.Exists(txtPastaToPublish.Text))
            {
                txtProximaVersao.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
                DirectoryInfo dinfo = new DirectoryInfo(txtPastaToPublish.Text);
                DirectoryInfo[] diretorios = dinfo.GetDirectories().Where(c => !c.Name.ToUpper().Contains("TESTE")).OrderByDescending(c => c.Name).ToArray();
                if (diretorios.Count() > 0)
                {
                    string sNameUltArquivo = diretorios.FirstOrDefault().Name.Replace(".zip", "");
                    lblUltimaVersao.Text = sNameUltArquivo; // ex: 3.0.0.0                    
                    if (lblUltimaVersao.Text.Equals(txtProximaVersao.Text))
                    {
                        MessageBox.Show("Verifique as Versões", "A V I S O");
                    }

                }
                else
                {
                    lblUltimaVersao.Text = "";
                }
            }
            else
            {
                txtPastaToPublish.Text = "";
            }
        }

        private void btnLocalInstalador_Click(object sender, EventArgs e)
        {
            ButtonSpecAny btn = (ButtonSpecAny)sender;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (btn.UniqueName == "btnLocalToPublish")
                {
                    txtPastaToPublish.Text = folderBrowserDialog1.SelectedPath;
                    CarregaVersao();
                }
                else
                {
                    txtPastaInstalador.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtPastaInstalador.Text) && Directory.Exists(txtPastaToPublish.Text))
                {
                    Comprimir();
                    MessageBox.Show("Procedimento Finalizado", "A V I S O");
                    CarregaVersao();
                }
                else
                {
                    MessageBox.Show("Caminho de Pasta Inválido", "A V I S O");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Comprimir()
        {
            string sFileZip = txtPastaInstalador.Text + "\\" + txtProximaVersao.Text + ".zip";
            WriteZipFile(Directory.GetFiles(txtPastaInstalador.Text).ToList(), sFileZip, 9);
            string sPathSave = txtPastaToPublish.Text + "\\" + txtProximaVersao.Text + (chkTeste.Checked ? "_TESTE" : "");
            if (!Directory.Exists(sPathSave))
            {
                Directory.CreateDirectory(sPathSave);
            }
            else
            {
                Directory.Delete(sPathSave, true);
                Directory.CreateDirectory(sPathSave);
            }

            if (txtDetalhe.Text != "")
            {
                StreamWriter sw = new StreamWriter(sPathSave + "\\Detalhes.txt");
                try
                {

                    sw.Write(txtDetalhe.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    sw.Close();
                    throw;
                }

            }
            sPathSave = sPathSave + "\\" + txtProximaVersao.Text + ".zip"; ;

            File.Move(sFileZip, sPathSave);
        }

        private void WriteZipFile(List<string> filesToZip, string path, int compression)
        {
            if (compression < 0 || compression > 9)
                throw new ArgumentException("Invalid compression rate.");

            if (!Directory.Exists(new FileInfo(path).Directory.ToString()))
                throw new ArgumentException("The Path does not exist.");

            foreach (string c in filesToZip)
                if (!File.Exists(c))
                    throw new ArgumentException(string.Format("The File{0}does not exist!", c));


            Crc32 crc32 = new Crc32();
            ZipOutputStream stream = new ZipOutputStream(File.Create(path));
            stream.SetLevel(compression);

            for (int i = 0; i < filesToZip.Count; i++)
            {
                ZipEntry entry = new ZipEntry(Path.GetFileName(filesToZip[i]));
                entry.DateTime = DateTime.Now;

                using (FileStream fs = File.OpenRead(filesToZip[i]))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    entry.Size = fs.Length;
                    fs.Close();
                    crc32.Reset();
                    crc32.Update(buffer);
                    entry.Crc = crc32.Value;
                    stream.PutNextEntry(entry);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            stream.Finish();
            stream.Close();
        }
    }
}
