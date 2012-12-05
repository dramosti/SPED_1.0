using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Repository.Implementation.Fiscal.Mappers;

namespace Hlp.Sped.Repository.Implementation.Fiscal.Lorenzon
{
    public class ParticipantesLorenzonRepository : IParticipantesLorenzonRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        public IEnumerable<Registro0150> GetRegistros0150()
        {
            DataAccessor<Registro0150> reg0150Accessor =
                UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  "SELECT * FROM SP_SPEDFIS_LORENZON_REG0150(?, ?, ?)",
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                  MapBuilder<Registro0150>.MapAllProperties()
                  .Map(p => p.END).ToColumn("ENDERECO")
                  .Build());

            return reg0150Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }
    }
}