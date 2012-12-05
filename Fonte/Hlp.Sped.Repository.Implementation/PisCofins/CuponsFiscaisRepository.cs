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
    public class CuponsFiscaisRepository : ICuponsFiscaisRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        private DataAccessor<RegistroC400> regC400Accessor;
        private DataAccessor<RegistroC405> regC405Accessor;
        private DataAccessor<RegistroC481> regC481Accessor;
        private DataAccessor<RegistroC485> regC485Accessor;

        public IEnumerable<RegistroC400> GetRegistrosC400(string codCNPJ)
        {
            if (regC400Accessor == null)
            {
                regC400Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                        SqlExpressionsPisCofinsRepository.GetSelectRegistrosC400(),
                        new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                        MapBuilder<RegistroC400>.MapAllProperties().Build());
            }

            return regC400Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC405> GetRegistrosC405(string codCNPJ, string codECF)
        {
            if (regC405Accessor == null)
            {
                regC405Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC405(),
                    new FilterByCdEmpresaCdCNPJPkEcfPeriodoParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC405>.MapAllProperties().Build());
            }

            return regC405Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codECF,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroC481> GetRegistrosC481(
            string codCNPJ, string codECF, DateTime dtEmissao)
        {
            if (regC481Accessor == null)
            {
                regC481Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC481(),
                    new FilterByCdEmpresaCdCNPJPkEcfDiaParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC481>.MapAllProperties().Build());
            }

            return regC481Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codECF,
                dtEmissao).ToList();
        }

        public IEnumerable<RegistroC485> GetRegistrosC485(
            string codCNPJ, string codECF, DateTime dtEmissao)
        {
            if (regC485Accessor == null)
            {
                regC485Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistrosC485(),
                    new FilterByCdEmpresaCdCNPJPkEcfDiaParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroC485>.MapAllProperties().Build());
            }

            return regC485Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                codECF,
                dtEmissao).ToList();
        }
    }
}