using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Implementation.Fiscal.Mappers;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Fiscal;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Repository.Implementation.Fiscal
{


    public class ProducaoRepository : IProducaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }


        public RegistroK100 GetRegistroK100()
        {
            DataAccessor<RegistroK100> regQueryAccessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistroK100(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroK100>.MapAllProperties()
                  .Build());

            return regQueryAccessor.Execute(UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).FirstOrDefault();
        }

        public IEnumerable<RegistroK200> GetRegistrosK200()
        {
            DataAccessor<RegistroK200> regQueryAccessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroK200(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<RegistroK200>.MapAllProperties()
                 .Build());

            return regQueryAccessor.Execute(UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();

        }

        public IEnumerable<RegistroK220> GetRegistrosK220()
        {
            DataAccessor<RegistroK220> regQueryAccessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroK220(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<RegistroK220>.MapAllProperties()
                 .Build());

            return regQueryAccessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();

        }

        public IEnumerable<RegistroK230> GetRegistrosK230()
        {
            DataAccessor<RegistroK230> regQueryAccessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroK230(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<RegistroK230>.MapAllProperties()
                 .Build());

            return regQueryAccessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();

        }

        public IEnumerable<RegistroK235> GetRegistrosK235(RegistroK230 regK230)
        {
            DataAccessor<RegistroK235> regQueryAccessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroK235(),
                 new FilterByCdEmpresaCd_OS_ParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<RegistroK235>.MapAllProperties()
                 .Build());

            return regQueryAccessor.Execute(
                UndTrabalho.CodigoEmpresa,
                regK230.COD_DOC_OP).ToList();
        }

        public IEnumerable<RegistroK250> GetRegistrosK250()
        {
            DataAccessor<RegistroK250> regQueryAccessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroK250(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<RegistroK250>.MapAllProperties()
                 .Build());

            return regQueryAccessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroK255> GetRegistrosK255(RegistroK250 regK250)
        {
            DataAccessor<RegistroK255> regQueryAccessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistroK255(),
                 new FilterByCdEmpresaCd_ProdPrin_ParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<RegistroK255>.MapAllProperties()
                 .Build());

            return regQueryAccessor.Execute(
                UndTrabalho.CodigoEmpresa,
                regK250.COD_ITEM).ToList();
        }


        public Registro0210 GetRegistro0210(string COD_PROD)
        {
            DataAccessor<Registro0210> regQueryAccessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistro0210(),
                 new FilterByCdEmpresaCdProdParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<Registro0210>.MapAllProperties()
                 .Build());

            return regQueryAccessor.Execute(
                UndTrabalho.CodigoEmpresa,
                COD_PROD).FirstOrDefault();
        }






    }
}
