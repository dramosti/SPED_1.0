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
    public class ConsolidacaoNotasFiscaisRepository : IConsolidacaoNotasFiscaisRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        private DataAccessor<RegistroC180> regC180Accessor;
        private DataAccessor<RegistroC181> regC181Accessor;
        private DataAccessor<RegistroC185> regC185Accessor;

        private DataAccessor<RegistroC190> regC190Accessor;
        private DataAccessor<RegistroC191> regC191Accessor;
        private DataAccessor<RegistroC195> regC195Accessor;
        private DataAccessor<RegistroC199> regC199Accessor;

        private DataAccessor<RegistroC380> regC380Accessor;
        private DataAccessor<RegistroC381> regC381Accessor;
        private DataAccessor<RegistroC385> regC385Accessor;

        public IEnumerable<RegistroC180> GetRegistrosC180(string codCNPJ)
        {
            if (regC180Accessor == null)
            {
                regC180Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC180(),
                    new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC180>.MapAllProperties().Build());
            }

            return regC180Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC181> GetRegistrosC181(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            if (regC181Accessor == null)
            {
                regC181Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC181(),
                    new FilterByCdEmpresaCdCNPJCdItemPeriodoParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC181>.MapAllProperties().Build());
            }

            return regC181Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codItem,
                dtInicial,
                dtFinal).ToList();
        }

        public IEnumerable<RegistroC185> GetRegistrosC185(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            if (regC185Accessor == null)
            {
                regC185Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC185(),
                    new FilterByCdEmpresaCdCNPJCdItemPeriodoParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC185>.MapAllProperties().Build());
            }

            return regC185Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codItem,
                dtInicial,
                dtFinal).ToList();
        }

        public IEnumerable<RegistroC190> GetRegistrosC190(string codCNPJ)
        {
            if (regC190Accessor == null)
            {
                regC190Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC190(),
                    new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC190>.MapAllProperties().Build());
            }

            return regC190Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC191> GetRegistrosC191(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            if (regC191Accessor == null)
            {
                regC191Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC191(),
                    new FilterByCdEmpresaCdCNPJCdItemPeriodoParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC191>.MapAllProperties().Build());
            }

            return regC191Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codItem,
                dtInicial,
                dtFinal).ToList();
        }

        public IEnumerable<RegistroC195> GetRegistrosC195(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            if (regC195Accessor == null)
            {
                regC195Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC195(),
                    new FilterByCdEmpresaCdCNPJCdItemPeriodoParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC195>.MapAllProperties().Build());
            }

            return regC195Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codItem,
                dtInicial,
                dtFinal).ToList();
        }

        public IEnumerable<RegistroC199> GetRegistrosC199(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            if (regC199Accessor == null)
            {
                regC199Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC199(),
                    new FilterByCdEmpresaCdCNPJCdItemPeriodoParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC199>.MapAllProperties().Build());
            }

            return regC199Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codItem,
                dtInicial,
                dtFinal).ToList();
        }

        public IEnumerable<RegistroC380> GetRegistrosC380(string codCNPJ)
        {
            if (regC380Accessor == null)
            {
                regC380Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC380(),
                    new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC380>.MapAllProperties().Build());
            }

            return regC380Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC381> GetRegistrosC381(
            string codCNPJ, string codModeloFiscal, DateTime dtInicial, DateTime dtFinal)
        {
            if (regC381Accessor == null)
            {
                regC381Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC381(),
                    new FilterByCdEmpresaCdCNPJCdModPeriodoParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC381>.MapAllProperties().Build());
            }

            return regC381Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codModeloFiscal,
                dtInicial,
                dtInicial).ToList();
        }

        public IEnumerable<RegistroC385> GetRegistrosC385(
            string codCNPJ, string codModeloFiscal, DateTime dtInicial, DateTime dtFinal)
        {
            if (regC385Accessor == null)
            {
                regC385Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC385(),
                    new FilterByCdEmpresaCdCNPJCdModPeriodoParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC385>.MapAllProperties().Build());
            }

            return regC385Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codModeloFiscal,
                dtInicial,
                dtInicial).ToList();
        }
    }
}