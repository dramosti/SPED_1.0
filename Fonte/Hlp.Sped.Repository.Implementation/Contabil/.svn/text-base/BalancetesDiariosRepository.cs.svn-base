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
    public class BalancetesDiariosRepository : IBalancetesDiariosRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContabilRepository SqlExpressionsContabilRepository { get; set; }

        private DataAccessor<RegistroI310> regI310Accessor;

        public bool EfetuarProcessamentoBalancetesDiarios()
        {
            return (UndTrabalho.TipoArquivo == TipoArquivo.ContabilLivroBalancetes);
        }

        public IEnumerable<RegistroI300> GetRegistrosI300()
        {
            DataAccessor<RegistroI300> regI300Accessor =
                UndTrabalho.DBOrigemDadosContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistrosI300(),
                  new FilterByCdEmpresaDtLctoParameterMapper(UndTrabalho.DBOrigemDadosContabil),
                  MapBuilder<RegistroI300>.MapAllProperties()
                  .Build());

            return regI300Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<RegistroI310> GetRegistrosI310(DateTime dataBalancete)
        {
            if (regI310Accessor == null)
            {
                regI310Accessor =
                    UndTrabalho.DBOrigemDadosContabil.CreateSqlStringAccessor(
                      SqlExpressionsContabilRepository.GetSelectRegistrosI310(),
                      new FilterByCdEmpresaDtBcteParameterMapper(UndTrabalho.DBOrigemDadosContabil),
                      MapBuilder<RegistroI310>.MapAllProperties()
                      .Build());
            }

            return regI310Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dataBalancete);
        }
    }
}
