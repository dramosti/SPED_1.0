using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Domain.Models.Contmatic;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Hlp.Sped.Repository.Implementation.Contmatic.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contmatic
{
    public class ConhecimentoTransporteRepository : IConhecimentoTransporteRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContmaticRepository SqlExpressionsContmaticRepository { get; set; }



        public IEnumerable<RegistroD100> GetRegistroD100()
        {
            DataAccessor<RegistroD100> regD100Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD100(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD100>.MapAllProperties().Build());

            return regD100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroD101> GetRegistroD101()
        {
            DataAccessor<RegistroD101> regD101Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD101(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD101>.MapAllProperties().Build());

            return regD101Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroD110> GetRegistroD110(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroD110> regD110Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD110(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD110>.MapAllProperties()
                    .DoNotMap(p => p.NUM_ITEM)
                    .Build());

            List<RegistroD110> resultado = regD110Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroD110 regD110 in resultado)
                regD110.NUM_ITEM = ++numeroItem;
            return resultado;
        }

        public IEnumerable<RegistroD120> GetRegistroD120(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroD120> regD120Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD120(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD120>.MapAllProperties()
                    .Build());

            return regD120Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }

        public IEnumerable<RegistroD130> GetRegistroD130(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroD130> regD130Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD130(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD130>.MapAllProperties()
                    .Build());

            return regD130Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }

        public IEnumerable<RegistroD190> GetRegistroD190(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroD190> regD190Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD190(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD190>.MapAllProperties()
                    .Build());

            return regD190Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }

        public IEnumerable<RegistroD500> GetRegistroD500()
        {
            DataAccessor<RegistroD500> regD500Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD500(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD500>.MapAllProperties().Build());

            return regD500Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroD510> GetRegistroD510(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroD510> regD510Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD510(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD510>.MapAllProperties()
                    .DoNotMap(p => p.NUM_ITEM)
                    .Build());

            List<RegistroD510> resultado = regD510Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroD510 regD510 in resultado)
                regD510.NUM_ITEM = ++numeroItem;
            return resultado;
        }

        public IEnumerable<RegistroD590> GetRegistroD590(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroD590> regD590Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroD590(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroD590>.MapAllProperties()
                    .Build());

            return regD590Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
        }


    }
}
