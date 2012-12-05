using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Repository.Interfaces.Files
{
    public interface ISpedFileWriterRepository
    {
        void Initialize(string caminhoArquivo);
        void WriteLine(string linha);
        void Close();
    }
}
