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
    public class NotasFiscaisMercadoriasRepository : INotasFiscaisMercadoriasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        private DataAccessor<RegistroC100> regC100Accessor;
        private DataAccessor<RegistroC120> regC120Accessor;
        private DataAccessor<RegistroC170> regC170Accessor;

        public IEnumerable<RegistroC100> GetRegistrosC100(string codCNPJ)
        {
            if (regC100Accessor == null)
            {
                regC100Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                        SqlExpressionsPisCofinsRepository.GetSelectRegistrosC100(),
                        new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                        MapBuilder<RegistroC100>.MapAllProperties().Build());
            }

            return regC100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC120> GetRegistrosC120(string codChaveNotaFiscal)
        {
            if (regC120Accessor == null)
            {
                regC120Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                        SqlExpressionsPisCofinsRepository.GetSelectRegistrosC120(),
                        new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                        MapBuilder<RegistroC120>.MapAllProperties().Build());
            }

            return regC120Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }

        public IEnumerable<RegistroC170> GetRegistrosC170(string codChaveNotaFiscal)
        {
            if (regC170Accessor == null)
            {
                regC170Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                        SqlExpressionsPisCofinsRepository.GetSelectRegistrosC170(),
                        new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
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
    }
}