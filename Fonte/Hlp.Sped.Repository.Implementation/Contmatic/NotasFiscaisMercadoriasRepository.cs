using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;
using Hlp.Sped.Domain.Models.Contmatic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Hlp.Sped.Repository.Implementation.Contmatic.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contmatic
{
    public class NotasFiscaisMercadoriasRepository : INotasFiscaisMercadoriasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContmaticRepository SqlExpressionsContmaticRepository { get; set; }


        public IEnumerable<RegistroC100> GetRegistroC100()
        {
            DataAccessor<RegistroC100> regC100Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroC100(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroC100>.MapAllProperties().Build());

            return regC100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC170> GetRegistroC170(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroC170> regC170Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroC170(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroC170>.MapAllProperties()
                    .DoNotMap(p => p.NUM_ITEM)
                    .Build());

            List<RegistroC170> resultado = regC170Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroC170 regC170 in resultado)
                regC170.NUM_ITEM = ++numeroItem;
            return resultado;

        }

        public IEnumerable<RegistroC400> GetRegistroC400()
        {
            DataAccessor<RegistroC400> regC400Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroC400(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroC400>.MapAllProperties().Build());

            return regC400Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC405> GetRegistroC405(string codECF)
        {
            DataAccessor<RegistroC405> regC405Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroC405(),
                 new FilterByCdEmpresaPkEcfPeriodoParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroC405>.MapAllProperties().Build());

            return regC405Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codECF,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC460> GetRegistroC460(string codECF, DateTime dtEmissao)
        {
            DataAccessor<RegistroC460> regC460Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroC460(),
                 new FilterByCdEmpresaPkEcfDiaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroC460>.MapAllProperties().Build());

            return regC460Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codECF,
                dtEmissao).ToList();
        }

        public IEnumerable<RegistroC470> GetRegistroC470(string pkCupomFis)
        {
            DataAccessor<RegistroC470> regC470Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroC470(),
                 new FilterByCdEmpresaPkCupomFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroC470>.MapAllProperties().Build());

            return regC470Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                pkCupomFis).ToList();
        }

        public IEnumerable<RegistroC500> GetRegistroC500()
        {
            DataAccessor<RegistroC500> regC500Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroC500(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroC500>.MapAllProperties().Build());

            return regC500Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC510> GetRegistroC510(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroC510> regC510Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroC510(),
                 new FilterByCdEmpresaPkNotaFisParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroC510>.MapAllProperties()
                    .DoNotMap(p => p.NUM_ITEM)
                    .Build());

            List<RegistroC510> resultado = regC510Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroC510 regC510 in resultado)
                regC510.NUM_ITEM = ++numeroItem;
            return resultado;
        }
    }
}
