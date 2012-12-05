using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Implementation.PisCofins
{
    public class DadosArquivoPisCofinsService : IDadosArquivoPisCofinsService
    {
        [Inject]
        public IDadosArquivoPisCofinsRepository DadosArquivoPisCofinsRepository { get; set; }

        public void Inicializar()
        {
            DadosArquivoPisCofinsRepository.Inicializar();
        }

        public void PersistirRegistro(RegistroBase registro)
        {
            DadosArquivoPisCofinsRepository.PersistirRegistro(registro);
        }

        public bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro)
        {
            return DadosArquivoPisCofinsRepository.RegistroJaExistente(tipoRegistro, valorChaveRegistro);
        }

        public bool BlocoPossuiRegistros(string identificadorBloco)
        {
            return DadosArquivoPisCofinsRepository.BlocoPossuiRegistros(identificadorBloco);
        }

        public Registro0990 GetRegistro0990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistro0990();
        }

        public RegistroA990 GetRegistroA990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistroA990();
        }

        public RegistroC990 GetRegistroC990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistroC990();
        }

        public RegistroD990 GetRegistroD990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistroD990();
        }

        public RegistroF990 GetRegistroF990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistroF990();
        }

        public RegistroM990 GetRegistroM990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistroM990();
        }

        public RegistroP990 GetRegistroP990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistroP990();
        }

        public Registro1990 GetRegistro1990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistro1990();
        }

        public Registro9001 GetRegistro9001()
        {
            return DadosArquivoPisCofinsRepository.GetRegistro9001();
        }

        public IEnumerable<Registro9900> GetRegistros9900()
        {
            return DadosArquivoPisCofinsRepository.GetRegistros9900();
        }

        public Registro9990 GetRegistro9990()
        {
            return DadosArquivoPisCofinsRepository.GetRegistro9990();
        }

        public Registro9999 GetRegistro9999()
        {
            return DadosArquivoPisCofinsRepository.GetRegistro9999();
        }

        public void OpenRegistros()
        {
            DadosArquivoPisCofinsRepository.OpenRegistros();
        }

        public bool ReadRegistro()
        {
            return DadosArquivoPisCofinsRepository.ReadRegistro();
        }

        public string GetConteudoRegistro()
        {
            return DadosArquivoPisCofinsRepository.GetConteudoRegistro();
        }

        public void CloseRegistros()
        {
            DadosArquivoPisCofinsRepository.CloseRegistros();
        }

        public void RegistrarExcecao(Exception ex)
        {
            DadosArquivoPisCofinsRepository.RegistrarExcecao(ex);
        }

        public void Finalizar()
        {
            DadosArquivoPisCofinsRepository.Finalizar();
        }
    }
}
