using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Implementation.PisCofins.Mappers;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins;
using Hlp.Sped.Repository.Interfaces.PisCofins;

namespace Hlp.Sped.Repository.Implementation.PisCofins
{
    public class DemaisDocumentosOperacoesRepository : IDemaisDocumentosOperacoesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository sqlExpressionsPisCofinsRepository { get; set; }

        public List<RegistroF010> GetRegistroF010()
        {
            DataAccessor<RegistroF010> regF010Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  sqlExpressionsPisCofinsRepository.GetSelectRegistroF010(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper (UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroF010>.MapAllProperties().Build());

            return regF010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }


        public List<RegistroF600> GetRegistroF600(string codEmp)
        {
            DataAccessor<RegistroF600> regF600Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  sqlExpressionsPisCofinsRepository.GetSelectRegistroF600(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroF600>.MapAllProperties().Build());

            return regF600Accessor.Execute(
                codEmp,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }


        public List<RegistroF200> GetRegistroF200(string codEmp)
        {
            DataAccessor<RegistroF200> regF200Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  sqlExpressionsPisCofinsRepository.GetSelectRegistroF200(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroF200>.MapAllProperties().Build());

            return regF200Accessor.Execute(
                codEmp,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }



    }
}
