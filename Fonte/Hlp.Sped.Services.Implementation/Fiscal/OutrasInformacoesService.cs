using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Implementation.Fiscal
{
    public class OutrasInformacoesService : IOutrasInformacoesService
    {
        [Inject]
        public IOutrasInformacoesRepository OutrasInformacoesRepository { get; set; }

        public Registro1010 GetRegistro1010()
        {
            return OutrasInformacoesRepository.GetRegistro1010();
        }

        public IEnumerable<Registro1100> GetRegistros1100()
        {
            return OutrasInformacoesRepository.GetRegistros1100();
        }

        public IEnumerable<Registro1105> GetRegistros1105(string numDeclaracaoExportacao)
        {
            return OutrasInformacoesRepository.GetRegistros1105(numDeclaracaoExportacao);
        }

        public IEnumerable<Registro1110> GetRegistros1110(string codChaveNotaFiscal)
        {
            return OutrasInformacoesRepository.GetRegistros1110(codChaveNotaFiscal);
        }

        public IEnumerable<Registro1200> GetRegistros1200()
        {
            return OutrasInformacoesRepository.GetRegistros1200();
        }

        public IEnumerable<Registro1210> GetRegistros1210(string codAjusteApuracao)
        {
            return OutrasInformacoesRepository.GetRegistros1210(codAjusteApuracao);
        }

        public IEnumerable<Registro1400> GetRegistros1400()
        {
            return OutrasInformacoesRepository.GetRegistros1400();
        }

        public IEnumerable<Registro1600> GetRegistros1600()
        {
            return OutrasInformacoesRepository.GetRegistros1600();
        }

        public IEnumerable<Registro1700> GetRegistros1700()
        {
            return OutrasInformacoesRepository.GetRegistros1700();
        }

        public IEnumerable<Registro1710> GetRegistros1710(
            string codDispositivo, string codModelo, string serie, string subSerie)
        {
            return OutrasInformacoesRepository.GetRegistros1710(
                codDispositivo, codModelo, serie, subSerie);
        }
    }
}