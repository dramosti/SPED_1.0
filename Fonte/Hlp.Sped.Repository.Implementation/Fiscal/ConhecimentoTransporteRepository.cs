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
    public class ConhecimentoTransporteRepository : IConhecimentoTransporteRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<RegistroD110> regD110Accessor;
        private DataAccessor<RegistroD120> regD120Accessor;
        private DataAccessor<RegistroD130> regD130Accessor;
        private DataAccessor<RegistroD190> regD190Accessor;

        public IEnumerable<RegistroD100> GetRegistrosD100()
        {
            DataAccessor<RegistroD100> regD100Accessor =
                UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistrosD100(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                  MapBuilder<RegistroD100>.MapAllProperties().Build());
            return regD100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<RegistroD110> GetRegistrosD110(string codChaveNotaFiscal)
        {
            if (regD110Accessor == null)
            {
                regD110Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosD110(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroD110>.MapAllProperties()
                    .DoNotMap(p => p.NUM_ITEM)
                    .Build());
            }

            List<RegistroD110> resultado = regD110Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroD110 regD110 in resultado)
                regD110.NUM_ITEM = ++numeroItem;
            return resultado;
        }

        public IEnumerable<RegistroD120> GetRegistrosD120(string codChaveNotaFiscal)
        {
            if (regD120Accessor == null)
            {
                regD120Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosD120(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroD120>.MapAllProperties()
                    .Build());
            }

            return regD120Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }

        public IEnumerable<RegistroD130> GetRegistrosD130(string codChaveNotaFiscal)
        {
            if (regD130Accessor == null)
            {
                regD130Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosD130(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroD130>.MapAllProperties()
                    .Build());
            }

            return regD130Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }

        public IEnumerable<RegistroD190> GetRegistrosD190(string codChaveNotaFiscal)
        {
            if (regD190Accessor == null)
            {
                regD190Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosD190(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroD190>.MapAllProperties()
                    .Build());
            }

            return regD190Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }
    }
}