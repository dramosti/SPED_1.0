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
    public class AberturaRepository : IAberturaRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContabilRepository SqlExpressionsContabilRepository { get; set; }

        public Registro0000 GetRegistro0000()
        {
            DataAccessor<Registro0000> reg0000Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistro0000(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<Registro0000>.MapAllProperties()
                  .DoNotMap(p => p.DT_INI)
                  .DoNotMap(p => p.DT_FIN)
                  .Build());

            Registro0000 reg0000 = reg0000Accessor.Execute(UndTrabalho.CodigoEmpresa).First();

            reg0000.DT_INI = UndTrabalho.DataInicial;
            reg0000.DT_FIN = UndTrabalho.DataFinal;

            return reg0000;
        }

        public Registro0001 GetRegistro0001()
        {
            Registro0001 reg0001 = new Registro0001();
            reg0001.IND_DAD = 0;

            return reg0001;
        }

        public IEnumerable<Registro0007> GetRegistros0007()
        {
            DataAccessor<Registro0007> reg0007Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistro0007(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<Registro0007>.MapAllProperties()
                  .Build());

            return reg0007Accessor.Execute(UndTrabalho.CodigoEmpresa);
        }

        public IEnumerable<Registro0020> GetRegistros0020()
        {
            DataAccessor<Registro0020> reg0020Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistro0020(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<Registro0020>.MapAllProperties()
                  .Build());

            return reg0020Accessor.Execute(UndTrabalho.CodigoEmpresa);
        }

        public IEnumerable<Registro0150> GetRegistros0150()
        {
            DataAccessor<Registro0150> reg0150Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistro0150(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<Registro0150>.MapAllProperties()
                  .Build());

            return reg0150Accessor.Execute(UndTrabalho.CodigoEmpresa);
        }

        private DataAccessor<Registro0180> reg0180Accessor;

        public Registro0180 GetRegistro0180(string COD_PART)
        {
            if (this.reg0180Accessor == null)
            {
                this.reg0180Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistro0180(),
                  new FilterByCdParticipanteParameterMapper(UndTrabalho.DBArquivoSpedContabil), 
                  MapBuilder<Registro0180>.MapAllProperties()
                  .Build());
            }

            return this.reg0180Accessor.Execute(COD_PART).First();
        }
    }
}
