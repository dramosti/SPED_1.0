using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Hlp.Sped.Repository.Interfaces.Files;

namespace Hlp.Sped.Repository.Implementation.Files
{
    public class SpedFileWriterRepository : ISpedFileWriterRepository
    {
        private StreamWriter _writer;
        private int _NumeroLinhaAtual;
        private string _CaminhoArquivo;
        private string _CaminhoArquivoProvisorio;

        public SpedFileWriterRepository()
        {
        }

        public void Initialize(string caminhoArquivo)
        {
            this._CaminhoArquivo = caminhoArquivo;
            this._CaminhoArquivoProvisorio = new FileInfo(caminhoArquivo).DirectoryName + "\\" +
                Guid.NewGuid() + ".txt";
            this._writer = new StreamWriter(this._CaminhoArquivoProvisorio);
        }

        public void WriteLine(string linha)
        {
            this._NumeroLinhaAtual++;
            this._writer.WriteLine(linha);
            if (this._NumeroLinhaAtual % 100 == 0)
            {
                this._writer.Flush();
            }
        }

        public void Close()
        {
            this._writer.Flush();
            this._writer.Close();

            File.Move(this._CaminhoArquivoProvisorio, this._CaminhoArquivo);
        }
    }
}
