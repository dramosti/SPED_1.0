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
    public class ParticipantesRepository : IParticipantesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<Registro0150> reg0150Accessor;

        public Registro0150 GetRegistro0150(string codigoParticipante)
        {
            if (this.reg0150Accessor == null)
            {
                this.reg0150Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                      SqlExpressionsFiscalRepository.GetSelectRegistro0150(),
                      new FilterByCdCliforParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                      MapBuilder<Registro0150>.MapAllProperties()
                      .Map(p => p.END).ToColumn("ENDERECO")
                      .Build());
            }
            return this.reg0150Accessor.Execute(codigoParticipante).FirstOrDefault();
        }
    }
}