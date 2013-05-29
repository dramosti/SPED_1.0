using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;
using Hlp.Sped.Repository.Implementation.PisCofins.Mappers;

namespace Hlp.Sped.Repository.Implementation.PisCofins
{
    public class UnidadesRepository : IUnidadesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        private DataAccessor<Registro0190> reg0190Accessor;

        public Registro0190 GetRegistro0190(string codigoUnidade)
        {
            if (this.reg0190Accessor == null)
            {
                this.reg0190Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                      SqlExpressionsPisCofinsRepository.GetSelectRegistro0190(),
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