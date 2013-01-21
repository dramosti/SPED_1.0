using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Implementation.SQLExpressions.PisCofins;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins;
using Hlp.Sped.Repository.Implementation.PisCofins.Mappers;
using Hlp.Sped.Repository.Interfaces.PisCofins;

namespace Hlp.Sped.Repository.Implementation.PisCofins
{
    public class NotasFiscaisServComunicacaoRepository : INotasFiscaisServComunicacaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        DataAccessor<RegistroD500> regD500Accessor;
        DataAccessor<RegistroD501> regD501Accessor;
        DataAccessor<RegistroD505> regD505Accessor;

        public IEnumerable<RegistroD010> GetRegistrosD010()
        {
            DataAccessor<RegistroD010> regA010Accessor =
                UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistrosD010(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                  MapBuilder<RegistroD010>.MapAllProperties().Build());
            return regA010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroD500> GetRegistrosD500(string CD_CNPJ)
        {
            IEnumerable<RegistroD500> objRet;
            if (regD500Accessor == null)
                regD500Accessor =
                UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistroD500(),
                  new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                  MapBuilder<RegistroD500>.MapAllProperties().Build());

            try
            {
                objRet = regD500Accessor.Execute(
               UndTrabalho.CodigoEmpresa,
               CD_CNPJ,
               UndTrabalho.DataInicial,
               UndTrabalho.DataFinal);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objRet;
        }

        public IEnumerable<RegistroD501> GetRegistrosD501(string codChaveNotaFiscal)
        {
            if (regD501Accessor == null)
                regD501Accessor =
                   UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                     SqlExpressionsPisCofinsRepository.GetSelectRegistroD501(),
                     new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                     MapBuilder<RegistroD501>.MapAllProperties().Build());

            return regD501Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal);
        }

        public IEnumerable<RegistroD505> GetRegistrosD505(string codChaveNotaFiscal)
        {
            if (regD505Accessor == null)
                regD505Accessor =
                   UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                     SqlExpressionsPisCofinsRepository.GetSelectRegistroD505(),
                     new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                     MapBuilder<RegistroD505>.MapAllProperties().Build());

            return regD505Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal);
        }


    }
}
