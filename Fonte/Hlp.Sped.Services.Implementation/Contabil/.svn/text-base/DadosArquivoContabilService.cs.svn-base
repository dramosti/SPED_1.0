using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Services.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Services.Implementation.Contabil
{
    public class DadosArquivoContabilService : IDadosArquivoContabilService
    {
        [Inject]
        public IDadosArquivoContabilRepository DadosArquivoContabilRepository { get; set; }

        public void Inicializar()
        {
            DadosArquivoContabilRepository.Inicializar();
        }

        public void PersistirRegistro(RegistroBase registro)
        {
            DadosArquivoContabilRepository.PersistirRegistro(registro);
        }

        public bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro)
        {
            return DadosArquivoContabilRepository.RegistroJaExistente(tipoRegistro, valorChaveRegistro);
        }

        public Registro0990 GetRegistro0990()
        {
            return DadosArquivoContabilRepository.GetRegistro0990();
        }

        public RegistroI990 GetRegistroI990()
        {
            return DadosArquivoContabilRepository.GetRegistroI990();
        }

        public RegistroJ990 GetRegistroJ990()
        {
            return DadosArquivoContabilRepository.GetRegistroJ990();
        }

        public Registro9001 GetRegistro9001()
        {
            return DadosArquivoContabilRepository.GetRegistro9001();
        }

        public IEnumerable<Registro9900> GetRegistros9900()
        {
            return DadosArquivoContabilRepository.GetRegistros9900();
        }

        public Registro9990 GetRegistro9990()
        {
            return DadosArquivoContabilRepository.GetRegistro9990();
        }

        public Registro9999 GetRegistro9999()
        {
            return DadosArquivoContabilRepository.GetRegistro9999();
        }

        public void OpenRegistros()
        {
            DadosArquivoContabilRepository.OpenRegistros();
        }

        public bool ReadRegistro()
        {
            return DadosArquivoContabilRepository.ReadRegistro();
        }

        public string GetConteudoRegistro()
        {
            return DadosArquivoContabilRepository.GetConteudoRegistro();
        }

        public void CloseRegistros()
        {
            DadosArquivoContabilRepository.CloseRegistros();
        }

        public void RegistrarExcecao(Exception ex)
        {
            DadosArquivoContabilRepository.RegistrarExcecao(ex);
        }

        public void Finalizar()
        {
            DadosArquivoContabilRepository.Finalizar();
        }
    }
}