using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Repository.Interfaces.Files;
using Hlp.Sped.Services.Interfaces.Files;

namespace Hlp.Sped.Services.Implementation.Files
{
    public class SpedFileWriterService : ISpedFileWriterService
    {
        [Inject]
        public ISpedFileWriterRepository SpedFileRepository { get; set; }

        public void Initialize(string caminhoArquivo)
        {
            SpedFileRepository.Initialize(caminhoArquivo);
        }

        public void WriteLine(string linha)
        {
            SpedFileRepository.WriteLine(linha);
        }

        public void Close()
        {
            SpedFileRepository.Close();
        }
    }
}
