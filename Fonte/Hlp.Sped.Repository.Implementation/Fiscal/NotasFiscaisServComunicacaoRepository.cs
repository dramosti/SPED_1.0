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
    public class NotasFiscaisServComunicacaoRepository : INotasFiscaisServComunicacaoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<RegistroD590> regD590Accessor;

        public IEnumerable<RegistroD500> GetRegistrosD500()
        {
            DataAccessor<RegistroD500> regD500Accessor =
                UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistrosD500(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                  MapBuilder<RegistroD500>.MapAllProperties().Build());
            return regD500Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<RegistroD590> GetRegistrosD590(string codChaveNotaFiscal)
        {
            if (regD590Accessor == null)
            {
                regD590Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosD590(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroD590>.MapAllProperties().Build());
            }

            return regD590Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }
    }
}