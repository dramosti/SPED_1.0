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
    public class NotasFiscaisEnergiaAguaGasRepository : INotasFiscaisEnergiaAguaGasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<RegistroC510> regC510Accessor;
        private DataAccessor<RegistroC590> regC590Accessor;

        public IEnumerable<RegistroC500> GetRegistrosC500()
        {
            DataAccessor<RegistroC500> regC500Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistrosC500(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroC500>.MapAllProperties().Build());
            return regC500Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<RegistroC510> GetRegistrosC510(string codChaveNotaFiscal)
        {
            if (regC510Accessor == null)
            {
                regC510Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC510(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC510>.MapAllProperties()
                    .DoNotMap(p => p.NUM_ITEM)
                    .Build());
            }

            List<RegistroC510> resultado = regC510Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroC510 regC510 in resultado)
                regC510.NUM_ITEM = ++numeroItem;

            return resultado;
        }

        public IEnumerable<RegistroC590> GetRegistrosC590(string codChaveNotaFiscal)
        {
            if (regC590Accessor == null)
            {
                regC590Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC590(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC590>.MapAllProperties().Build());
            }

            return regC590Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }
    }
}