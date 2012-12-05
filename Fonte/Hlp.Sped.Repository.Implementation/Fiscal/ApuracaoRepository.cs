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
    public class ApuracaoRepository : IApuracaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<RegistroE110> regE110Accessor;
        private DataAccessor<RegistroE510> regE510Accessor;
        private DataAccessor<RegistroE520> regE520Accessor;
        private DataAccessor<RegistroE530> regE530Accessor;

        public IEnumerable<RegistroE500> GetRegistrosE500()
        {
            DataAccessor<RegistroE500> regE500Accessor =
                UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistrosE500(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                  MapBuilder<RegistroE500>.MapAllProperties().Build());
            return regE500Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroE510> GetRegistrosE510(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            if (regE510Accessor == null)
            {
                regE510Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosE510(),
                    new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroE510>.MapAllProperties().Build());
            }

            return regE510Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dtPeriodoInicial,
                dtPeriodoFinal).ToList();
        }

        public RegistroE520 GetRegistroE520(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            if (regE520Accessor == null)
            {
                regE520Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistroE520(),
                    new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroE520>.MapAllProperties().Build());
            }

            return regE520Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dtPeriodoInicial,
                dtPeriodoFinal).FirstOrDefault();
        }

        public IEnumerable<RegistroE530> GetRegistrosE530(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            if (regE530Accessor == null)
            {
                regE530Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosE530(),
                    new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroE530>.MapAllProperties().Build());
            }

            return regE530Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dtPeriodoInicial,
                dtPeriodoFinal).ToList();
        }

        public IEnumerable<RegistroE100> GetRegistrosE100()
        {
            DataAccessor<RegistroE100> regE100Accessor =
               UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroE100(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                 MapBuilder<RegistroE100>.MapAllProperties().Build());
            return regE100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public RegistroE110 GetRegistroE110(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            if (regE110Accessor == null)
            {
                regE110Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistroE110(),
                    new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroE110>.MapAllProperties().Build());
            }
            return regE110Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dtPeriodoInicial,
                dtPeriodoFinal).FirstOrDefault();
        }

        public IEnumerable<RegistroE111> GetRegistrosE111(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            DataAccessor<RegistroE111> regE111Accessor =
               UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroE111(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                 MapBuilder<RegistroE111>.MapAllProperties().Build());
            return regE111Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }
        public IEnumerable<RegistroE116> GetRegistrosE116(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            DataAccessor<RegistroE116> regE111Accessor =
               UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroE116(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                 MapBuilder<RegistroE116>.MapAllProperties().Build());
            return regE111Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }
    }
}