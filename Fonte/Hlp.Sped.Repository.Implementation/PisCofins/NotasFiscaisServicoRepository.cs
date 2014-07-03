using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;
using Hlp.Sped.Repository.Implementation.PisCofins.Mappers;

namespace Hlp.Sped.Repository.Implementation.PisCofins
{
    public class NotasFiscaisServicoRepository : INotasFiscaisServicoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        private DataAccessor<RegistroA100> regA100Accessor;
        private DataAccessor<RegistroA170> regA170Accessor;

        public IEnumerable<RegistroA010> GetRegistrosA010(string codEmp)
        {
            DataAccessor<RegistroA010> regA010Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistrosA010(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroA010>.MapAllProperties().Build());
            return regA010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroA100> GetRegistrosA100(string codCNPJ, string codEmp)
        {
            if (regA100Accessor == null)
            {
                regA100Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosA100(),
                    new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroA100>.MapAllProperties().Build());
            }

            return regA100Accessor.Execute(
                codEmp,
                codCNPJ,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroA170> GetRegistrosA170(string codChaveNotaFiscal, string codEmp)
        {
            if (regA170Accessor == null)
            {
                regA170Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosA170(),
                    new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroA170>.MapAllProperties()
                    .DoNotMap(p => p.NUM_ITEM)
                    .Build());
            }

            List<RegistroA170> resultado = regA170Accessor.Execute(
                codEmp,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroA170 regA170 in resultado)
                regA170.NUM_ITEM = ++numeroItem;
            return resultado;
        }
    }
}