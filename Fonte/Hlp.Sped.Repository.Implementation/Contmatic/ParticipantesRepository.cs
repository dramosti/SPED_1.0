using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Infrastructure;
using Ninject;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Hlp.Sped.Domain.Models.Contmatic;
using Hlp.Sped.Repository.Implementation.Contmatic.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contmatic
{
    public class ParticipantesRepository : IParticipantesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContmaticRepository SqlExpressionsFiscalRepository { get; set; }

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
