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
    public class NotasFiscaisMercadoriasRepository : INotasFiscaisMercadoriasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<RegistroC170> regC170Accessor;
        private DataAccessor<RegistroC190> regC190Accessor;

        public IEnumerable<RegistroC100> GetRegistrosC100()
        {
            DataAccessor<RegistroC100> regC100Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistrosC100(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroC100>.MapAllProperties().Build());
            return regC100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal);
        }

        public IEnumerable<RegistroC170> GetRegistrosC170(string codChaveNotaFiscal)
        {
            if (regC170Accessor == null)
            {
                regC170Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC170(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC170>.MapAllProperties()
                    .DoNotMap(p => p.NUM_ITEM)
                    .Build());
            }

            List<RegistroC170> resultado = regC170Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroC170 regC170 in resultado)
                regC170.NUM_ITEM = ++numeroItem;
            return resultado;
        }

        public IEnumerable<RegistroC190> GetRegistrosC190(string codChaveNotaFiscal)
        {
            if (regC190Accessor == null)
            {
                regC190Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC190(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC190>.MapAllProperties().Build());
            }

            return regC190Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }
    }
}