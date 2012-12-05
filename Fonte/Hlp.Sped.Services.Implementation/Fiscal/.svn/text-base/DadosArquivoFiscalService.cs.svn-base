using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Implementation.Fiscal
{
    public class DadosArquivoFiscalService : IDadosArquivoFiscalService
    {
        [Inject]
        public IDadosArquivoFiscalRepository DadosArquivoFiscalRepository { get; set; }

        public void Inicializar()
        {
            DadosArquivoFiscalRepository.Inicializar();
        }

        public void PersistirRegistro(RegistroBase registro)
        {
            DadosArquivoFiscalRepository.PersistirRegistro(registro);
        }

        public bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro)
        {
            return DadosArquivoFiscalRepository.RegistroJaExistente(tipoRegistro, valorChaveRegistro);
        }

        public bool BlocoPossuiRegistros(string identificadorBloco)
        {
            return DadosArquivoFiscalRepository.BlocoPossuiRegistros(identificadorBloco);
        }

        public Registro0990 GetRegistro0990()
        {
            return DadosArquivoFiscalRepository.GetRegistro0990();
        }

        public RegistroC990 GetRegistroC990()
        {
            return DadosArquivoFiscalRepository.GetRegistroC990();
        }

        public RegistroD990 GetRegistroD990()
        {
            return DadosArquivoFiscalRepository.GetRegistroD990();
        }

        public RegistroE990 GetRegistroE990()
        {
            return DadosArquivoFiscalRepository.GetRegistroE990();
        }

        public RegistroG990 GetRegistroG990()
        {
            return DadosArquivoFiscalRepository.GetRegistroG990();
        }

        public RegistroH990 GetRegistroH990()
        {
            return DadosArquivoFiscalRepository.GetRegistroH990();
        }

        public Registro1990 GetRegistro1990()
        {
            return DadosArquivoFiscalRepository.GetRegistro1990();
        }

        public Registro9001 GetRegistro9001()
        {
            return DadosArquivoFiscalRepository.GetRegistro9001();
        }

        public IEnumerable<Registro9900> GetRegistros9900()
        {
            return DadosArquivoFiscalRepository.GetRegistros9900();
        }

        public Registro9990 GetRegistro9990()
        {
            return DadosArquivoFiscalRepository.GetRegistro9990();
        }

        public Registro9999 GetRegistro9999()
        {
            return DadosArquivoFiscalRepository.GetRegistro9999();
        }

        public void OpenRegistros()
        {
            DadosArquivoFiscalRepository.OpenRegistros();
        }

        public bool ReadRegistro()
        {
            return DadosArquivoFiscalRepository.ReadRegistro();
        }

        public string GetConteudoRegistro()
        {
            return DadosArquivoFiscalRepository.GetConteudoRegistro();
        }

        public void CloseRegistros()
        {
            DadosArquivoFiscalRepository.CloseRegistros();
        }
        
        public void RegistrarExcecao(Exception ex)
        {
            DadosArquivoFiscalRepository.RegistrarExcecao(ex);
        }

        public void Finalizar()
        {
            DadosArquivoFiscalRepository.Finalizar();
        }
    }
}
