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
    public class CuponsFiscaisRepository : ICuponsFiscaisRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<RegistroC405> regC405Accessor;
        private DataAccessor<RegistroC410> regC410Accessor;
        private DataAccessor<RegistroC420> regC420Accessor;
        private DataAccessor<RegistroC425> regC425Accessor;
        private DataAccessor<RegistroC460> regC460Accessor;
        private DataAccessor<RegistroC470> regC470Accessor;
        private DataAccessor<RegistroC490> regC490Accessor;

        public IEnumerable<RegistroC400> GetRegistrosC400()
        {
            DataAccessor<RegistroC400> regC400Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistrosC400(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroC400>.MapAllProperties().Build());
            return regC400Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC405> GetRegistrosC405(string codECF)
        {
            if (regC405Accessor == null)
            {
                regC405Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC405(),
                    new FilterByCdEmpresaPkEcfPeriodoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC405>.MapAllProperties().Build());
            }

            return regC405Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codECF,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public RegistroC410 GetRegistroC410(string codECF, DateTime dtEmissao)
        {
            if (regC410Accessor == null)
            {
                regC410Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistroC410(),
                    new FilterByCdEmpresaPkEcfDiaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC410>.MapAllProperties().Build());
            }

            return regC410Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codECF,
                dtEmissao).FirstOrDefault();
        }

        public IEnumerable<RegistroC420> GetRegistrosC420(string codECF, DateTime dtEmissao)
        {
            if (regC420Accessor == null)
            {
                regC420Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC420(),
                    new FilterByCdEmpresaPkEcfDiaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC420>.MapAllProperties().Build());
            }

            return regC420Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codECF,
                dtEmissao).ToList();
        }

        public IEnumerable<RegistroC425> GetRegistrosC425(
            string codECF, DateTime dtEmissao, string codTotalizador)
        {
            if (regC425Accessor == null)
            {
                regC425Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC425(),
                    new FilterByCdEmpresaPkEcfDiaTotalizadorParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC425>.MapAllProperties().Build());
            }

            return regC425Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codECF,
                dtEmissao,
                codTotalizador).ToList();
        }

        public IEnumerable<RegistroC460> GetRegistrosC460(string codECF, DateTime dtEmissao)
        {
            if (regC460Accessor == null)
            {
                regC460Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC460(),
                    new FilterByCdEmpresaPkEcfDiaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC460>.MapAllProperties().Build());
            }

            return regC460Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codECF,
                dtEmissao).ToList();
        }
        
        public IEnumerable<RegistroC470> GetRegistrosC470(string pkCupomFis)
        {
            if (regC470Accessor == null)
            {
                regC470Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC470(),
                    new FilterByCdEmpresaPkCupomFisParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC470>.MapAllProperties().Build());
            }

            return regC470Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                pkCupomFis).ToList();
        }

        public IEnumerable<RegistroC490> GetRegistrosC490(string codECF, DateTime dtEmissao)
        {
            if (regC490Accessor == null)
            {
                regC490Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosC490(),
                    new FilterByCdEmpresaPkEcfDiaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroC490>.MapAllProperties().Build());
            }

            return regC490Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codECF,
                dtEmissao).ToList();
        }
    }
}