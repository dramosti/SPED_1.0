using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Repository.Implementation.Fiscal.Mappers;

namespace Hlp.Sped.Repository.Implementation.Fiscal
{
    public class UnidadesRepository : IUnidadesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<Registro0190> reg0190Accessor;

        public Registro0190 GetRegistro0190(string codigoUnidade)
        {
            if (this.reg0190Accessor == null)
            {
                this.reg0190Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                      SqlExpressionsFiscalRepository.GetSelectRegistro0190(),
                      new FilterByCdTpUnidParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                      MapBuilder<Registro0190>.MapNoProperties()
                      .Map(p => p.UNID).ToColumn("UNID")
                      .Map(p => p.DESCR).ToColumn("DESCR")
                      .Build());
            }
            return this.reg0190Accessor.Execute(codigoUnidade).FirstOrDefault();
        }
    }
}