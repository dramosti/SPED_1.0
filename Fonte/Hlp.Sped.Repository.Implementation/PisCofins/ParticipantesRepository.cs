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
    public class ParticipantesRepository : IParticipantesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        private DataAccessor<Registro0150> reg0150Accessor;

        public Registro0150 GetRegistro0150(string codigoParticipante)
        {
            if (this.reg0150Accessor == null)
            {
                this.reg0150Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                      SqlExpressionsPisCofinsRepository.GetSelectRegistro0150(),
                      new FilterByCdCliforParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                      MapBuilder<Registro0150>.MapAllProperties()
                      .Map(p => p.END).ToColumn("ENDERECO")
                      .Build());
            }
            return this.reg0150Accessor.Execute(codigoParticipante).FirstOrDefault();
        }
    }
}
