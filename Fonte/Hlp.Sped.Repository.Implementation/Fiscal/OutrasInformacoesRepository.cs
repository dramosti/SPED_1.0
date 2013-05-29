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
    public class OutrasInformacoesRepository : IOutrasInformacoesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<Registro1105> reg1105Accessor;
        private DataAccessor<Registro1110> reg1110Accessor;
        private DataAccessor<Registro1210> reg1210Accessor;
        private DataAccessor<Registro1710> reg1710Accessor;

        public Registro1010 GetRegistro1010()
        {
            DataAccessor<Registro1010> reg1010Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistro1010(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro1010>.MapAllProperties().Build());
            return reg1010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).FirstOrDefault();
        }

        public IEnumerable<Registro1100> GetRegistros1100()
        {
            DataAccessor<Registro1100> reg1100Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistros1100(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro1100>.MapAllProperties().Build());
            return reg1100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<Registro1105> GetRegistros1105(string numDeclaracaoExportacao)
        {
            if (reg1105Accessor == null)
            {
                reg1105Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistros1105(),
                    new FilterByCdEmpresaPeriodoDeclExportParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<Registro1105>.MapAllProperties().Build());
            }

            return reg1105Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal,
                numDeclaracaoExportacao);
        }

        public IEnumerable<Registro1110> GetRegistros1110(string codChaveNotaFiscal)
        {
            if (reg1110Accessor == null)
            {
                reg1110Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistros1110(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<Registro1110>.MapAllProperties()
                    .Build());
            }

            return reg1110Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal);
        }

        public IEnumerable<Registro1200> GetRegistros1200()
        {
            DataAccessor<Registro1200> reg1200Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistros1200(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro1200>.MapAllProperties().Build());
            return reg1200Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<Registro1210> GetRegistros1210(string codAjusteApuracao)
        {
            if (reg1210Accessor == null)
            {
                reg1210Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistros1210(),
                    new FilterByCdEmpresaPeriodoCodAjApurParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<Registro1210>.MapAllProperties().Build());
            }

            return reg1210Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal,
                codAjusteApuracao);
        }

        public IEnumerable<Registro1400> GetRegistros1400()
        {
            DataAccessor<Registro1400> reg1400Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistros1400(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro1400>.MapAllProperties().Build());
            return reg1400Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<Registro1600> GetRegistros1600()
        {
            DataAccessor<Registro1600> reg1600Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistros1600(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro1600>.MapAllProperties().Build());
            return reg1600Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<Registro1700> GetRegistros1700()
        {
            DataAccessor<Registro1700> reg1700Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistros1700(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro1700>.MapAllProperties().Build());
            return reg1700Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<Registro1710> GetRegistros1710(
            string codDispositivo, string codModelo, string serie, string subSerie)
        {
            if (reg1710Accessor == null)
            {
                reg1710Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistros1710(),
                    new FilterByCdEmpresaDocFiscaisUtilizadosParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<Registro1710>.MapAllProperties().Build());
            }

            return reg1710Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal,
                codDispositivo,
                codModelo,
                serie,
                subSerie);
        }
    }
}