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
    public class HistoricosContabeisRepository : IHistoricosContabeisRepository 
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContabilRepository SqlExpressionsContabilRepository { get; set; }

        private DataAccessor<RegistroI075> regI075Accessor;

        public RegistroI075 GetRegistroI075(string codigoHistorico)
        {
            if (this.regI075Accessor == null)
            {
                this.regI075Accessor =
                    UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                      SqlExpressionsContabilRepository.GetSelectRegistroI075(),
                      new FilterByCdHistParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                      MapBuilder<RegistroI075>.MapAllProperties().Build());
            }
            return this.regI075Accessor.Execute(codigoHistorico).FirstOrDefault();
        }
    }
}
