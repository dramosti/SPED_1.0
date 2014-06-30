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
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistrosE500(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
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
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosE510(),
                    new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
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
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistroE520(),
                    new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
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
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosE530(),
                    new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
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
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroE100(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
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
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistroE110(),
                    new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
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
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroE111(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<RegistroE111>.MapAllProperties().Build());
            return regE111Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }
        public IEnumerable<RegistroE116> GetRegistrosE116(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            DataAccessor<RegistroE116> regE111Accessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroE116(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<RegistroE116>.MapAllProperties().Build());
            return regE111Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }


        public IEnumerable<RegistroE200> GetRegistrosE200()
        {
            try
            {


                DataAccessor<RegistroE200> regE111Accessor =
                   UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                     SqlExpressionsFiscalRepository.GetSelectRegistroE200(),
                     new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                     MapBuilder<RegistroE200>.MapAllProperties().Build());
                return regE111Accessor.Execute(
                   UndTrabalho.CodigoEmpresa,
                    UndTrabalho.DataInicial,
                    UndTrabalho.DataFinal).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RegistroE210 GetRegistroE210(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal, string sUF)
        {
            try
            {

                DataAccessor<RegistroE210> regE111Accessor =
                   UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                     SqlExpressionsFiscalRepository.GetSelectRegistroE210(),
                     new FilterByCdEmpresaDtEmi_UF_NfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                     MapBuilder<RegistroE210>.MapAllProperties().Build());
                return regE111Accessor.Execute(
                    UndTrabalho.CodigoEmpresa,
                    UndTrabalho.DataInicial,
                    UndTrabalho.DataFinal, sUF).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<RegistroE250> GetRegistrosE250(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal, string sUF)
        {
            try
            {

                DataAccessor<RegistroE250> regE250Accessor =
                   UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                     SqlExpressionsFiscalRepository.GetSelectRegistroE250(),
                     new FilterByCdEmpresaDtEmi_UF_NfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                     MapBuilder<RegistroE250>.MapAllProperties().Build());
                return regE250Accessor.Execute(
                    UndTrabalho.CodigoEmpresa,
                    UndTrabalho.DataInicial,
                    UndTrabalho.DataFinal, sUF).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}