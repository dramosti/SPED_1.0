using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contabil;
using Hlp.Sped.Domain.Models.Contabil;
using Hlp.Sped.Repository.Implementation.Contabil.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contabil
{
    public class LancamentosRepository : ILancamentosRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContabilRepository SqlExpressionsContabilRepository { get; set; }

        private DataAccessor<RegistroI250> regI250Accessor;

        public bool EfetuarProcessamentoLancamentosContabeis()
        {
            return (UndTrabalho.TipoArquivo == TipoArquivo.ContabilDiarioCompleto ||
                    UndTrabalho.TipoArquivo == TipoArquivo.ContabilDiarioEscrituracaoResumida ||
                    UndTrabalho.TipoArquivo == TipoArquivo.ContabilDiarioAuxiliar);
        }

        public RegistroI001 GetRegistroI001()
        {
            RegistroI001 regI001 = new RegistroI001();
            regI001.IND_DAD = "0";  // Sempre haverá um conjunto de informações no bloco I

            return regI001;
        }

        public RegistroI010 GetRegistroI010()
        {
            DataAccessor<RegistroI010> regI010Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistroI010(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<RegistroI010>.MapAllProperties()
                  .DoNotMap(p => p.IND_ESC)
                  .Build());

            RegistroI010 regI010 = regI010Accessor.Execute(UndTrabalho.CodigoEmpresa).First();
            switch (UndTrabalho.TipoArquivo)
            {
                case TipoArquivo.ContabilDiarioCompleto:
                    regI010.IND_ESC = "G";
                    break;
                case TipoArquivo.ContabilDiarioEscrituracaoResumida:
                    regI010.IND_ESC = "R";
                    break;
                case TipoArquivo.ContabilDiarioAuxiliar:
                    regI010.IND_ESC = "A";
                    break;
                case TipoArquivo.ContabilLivroBalancetes:
                    regI010.IND_ESC = "B";
                    break;
                case TipoArquivo.ContabilRazaoAuxiliar:
                    regI010.IND_ESC = "Z";
                    break;
            }

            return regI010;
        }

        public IEnumerable<RegistroI200> GetRegistrosI200()
        {
            DataAccessor<RegistroI200> regI200Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistrosI200(),
                  new FilterByCdEmpresaDtLctoParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<RegistroI200>.MapAllProperties()
                  .Build());

            return regI200Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<RegistroI250> GetRegistrosI250(string numeroLancamento)
        {
            if (regI250Accessor == null)
            {
                regI250Accessor =
                    UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                      SqlExpressionsContabilRepository.GetSelectRegistrosI250(),
                      new FilterByCdEmpresaNumLctoParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                      MapBuilder<RegistroI250>.MapAllProperties()
                      .Build());
            }

            return regI250Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                numeroLancamento);
        }
    }
}
