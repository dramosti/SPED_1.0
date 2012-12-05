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
    public class NotasFiscaisEnergiaAguaGasRepository : INotasFiscaisEnergiaAguaGasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        private DataAccessor<RegistroC500> regC500Accessor;
        private DataAccessor<RegistroC501> regC501Accessor;
        private DataAccessor<RegistroC505> regC505Accessor;

        public IEnumerable<RegistroC500> GetRegistrosC500(string codCNPJ)
        {
            if (regC500Accessor == null)
            {
                regC500Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                        SqlExpressionsPisCofinsRepository.GetSelectRegistrosC500(),
                        new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                        MapBuilder<RegistroC500>.MapAllProperties().Build());
            }

            return regC500Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC501> GetRegistrosC501(string codChaveNotaFiscal)
        {
            if (regC501Accessor == null)
            {
                regC501Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                        SqlExpressionsPisCofinsRepository.GetSelectRegistrosC501(),
                        new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                        MapBuilder<RegistroC501>.MapAllProperties().Build());
            }

            return regC501Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }
 
        public IEnumerable<RegistroC505> GetRegistrosC505(string codChaveNotaFiscal)
        {
            if (regC505Accessor == null)
            {
                regC505Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                        SqlExpressionsPisCofinsRepository.GetSelectRegistrosC505(),
                        new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                        MapBuilder<RegistroC505>.MapAllProperties().Build());
            }

            return regC505Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }
    }
}