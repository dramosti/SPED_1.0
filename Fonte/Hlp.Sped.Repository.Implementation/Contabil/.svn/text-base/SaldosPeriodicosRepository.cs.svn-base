using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contabil;
using Hlp.Sped.Domain.Models.Contabil;
using Hlp.Sped.Repository.Implementation.Contabil.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contabil
{
    public class SaldosPeriodicosRepository : ISaldosPeriodicosRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContabilRepository SqlExpressionsContabilRepository { get; set; }

        public RegistroI150 GetRegistroI150()
        {
            RegistroI150 regI150 = new RegistroI150();

            regI150.DT_INI = UndTrabalho.DataInicial;
            regI150.DT_FIN = UndTrabalho.DataFinal;

            return regI150;
        }

        public IEnumerable<RegistroI155> GetRegistrosI155()
        {
            DataAccessor<RegistroI155> regI155Accessor =
                UndTrabalho.DBOrigemDadosContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistrosI155(),
                  new FilterByCdEmpresaDtLctoParameterMapper(UndTrabalho.DBOrigemDadosContabil),
                  MapBuilder<RegistroI155>.MapAllProperties()
                  .Build());

            return regI155Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }
    }
}
