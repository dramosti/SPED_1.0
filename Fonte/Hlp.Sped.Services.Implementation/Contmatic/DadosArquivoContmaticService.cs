using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Ninject;
using Hlp.Sped.Repository.Interfaces.Contmatic;

namespace Hlp.Sped.Services.Implementation.Contmatic
{
    public class DadosArquivoContmaticService : IDadosArquivoContmaticService
    {
        [Inject]
        public IDadosArquivoContmaticRepository dadosArquivoContmaticRepository { get; set; }

        public void Inicializar()
        {
            dadosArquivoContmaticRepository.Inicializar();
        }

        public void PersistirRegistro(Infrastructure.Registro.RegistroBase registro)
        {
            dadosArquivoContmaticRepository.PersistirRegistro(registro);
        }

        public bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro)
        {
            return dadosArquivoContmaticRepository.RegistroJaExistente(tipoRegistro, valorChaveRegistro);
        }

        public bool BlocoPossuiRegistros(string identificadorBloco)
        {
            return dadosArquivoContmaticRepository.BlocoPossuiRegistros(identificadorBloco);
        }

        public void OpenRegistros()
        {
            dadosArquivoContmaticRepository.OpenRegistros();
        }

        public bool ReadRegistro()
        {
            return dadosArquivoContmaticRepository.ReadRegistro();
        }

        public string GetConteudoRegistro()
        {
            return dadosArquivoContmaticRepository.GetConteudoRegistro();
        }

        public void CloseRegistros()
        {
            dadosArquivoContmaticRepository.CloseRegistros();
        }

        public void RegistrarExcecao(Exception ex)
        {
            dadosArquivoContmaticRepository.RegistrarExcecao(ex);
        }

        public void Finalizar()
        {
            dadosArquivoContmaticRepository.Finalizar();
        }

        public Domain.Models.Contmatic.Registro0990 GetRegistro0990()
        {
            return dadosArquivoContmaticRepository.GetRegistro0990();
        }

        public Domain.Models.Contmatic.RegistroA990 GetRegistroA990()
        {
            return dadosArquivoContmaticRepository.GetRegistroA990();
        }

        public Domain.Models.Contmatic.RegistroC990 GetRegistroC990()
        {
            return dadosArquivoContmaticRepository.GetRegistroC990();
        }

        public Domain.Models.Contmatic.RegistroD990 GetRegistroD990()
        {
            return dadosArquivoContmaticRepository.GetRegistroD990();
        }




        public Domain.Models.Contmatic.Registro1990 GetRegistro1990()
        {
            return dadosArquivoContmaticRepository.GetRegistro1990();
        }
    }
}
