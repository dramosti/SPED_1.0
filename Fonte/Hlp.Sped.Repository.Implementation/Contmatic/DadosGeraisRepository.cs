using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Ninject;
using Hlp.Sped.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Hlp.Sped.Domain.Models.Contmatic;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;
using Hlp.Sped.Repository.Implementation.Contmatic.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contmatic
{
    public class DadosGeraisRepository : IDadosGeraisRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContmaticRepository SqlExpressionsContmaticRepository { get; set; }


        public Registro0000 GetRegistro0000()
        {
            DataAccessor<Registro0000> reg0000Accessor =
                UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                  SqlExpressionsContmaticRepository.GetSelectRegistro0000(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                  MapBuilder<Registro0000>.MapAllProperties()
                  .DoNotMap(p => p.COD_FIN)
                  .DoNotMap(p => p.DT_INI)
                  .DoNotMap(p => p.DT_FIN)
                  .Build());

            Registro0000 reg0000 = reg0000Accessor.Execute(UndTrabalho.CodigoEmpresa).First();

            reg0000.COD_FIN = ((int)UndTrabalho.TipoRemessa).ToString();
            reg0000.DT_INI = UndTrabalho.DataInicial;
            reg0000.DT_FIN = UndTrabalho.DataFinal;

            return reg0000;
        }

        public Registro0100 GetRegistro0100()
        {
            DataAccessor<Registro0100> reg0100Accessor =
                UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                  SqlExpressionsContmaticRepository.GetSelectRegistro0100(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                  MapBuilder<Registro0100>.MapAllProperties()
                  .Map(p => p.END).ToColumn("ENDERECO")
                  .Build());

            Registro0100 reg0100 = reg0100Accessor.Execute(UndTrabalho.CodigoEmpresa).First();
            return reg0100;
        }

        public IEnumerable<Registro0150> GetRegistro0150(string codigoParticipante)
        {
            DataAccessor<Registro0150> reg0150Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro0150(),
                 new FilterByCdCliforParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro0150>.MapAllProperties().Build());

            return reg0150Accessor.Execute(codigoParticipante).ToList();
        }

        public IEnumerable<Registro0190> GetRegistro0190(string codigoUnidade)
        {
            DataAccessor<Registro0190> reg0190Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro0190(),
                 new FilterByCdTpUnidParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro0190>.MapNoProperties()
                      .Map(p => p.UNID).ToColumn("UNID")
                      .Map(p => p.DESCR).ToColumn("DESCR")
                      .Build());

            return reg0190Accessor.Execute(codigoUnidade).ToList();
        }

        public IEnumerable<Registro0200> GetRegistro0200(string codigoProduto)
        {
            DataAccessor<Registro0200> reg0200Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro0200(),
                 new FilterByCdEmpresaCdProdParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro0200>.MapAllProperties().Build());

            return reg0200Accessor.Execute(UndTrabalho.CodigoEmpresa, codigoProduto).ToList();
        }

       

        public IEnumerable<Registro0220> GetRegistro0220(string codigoProduto)
        {
            DataAccessor<Registro0220> reg0220Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro0220(),
                 new FilterByCdEmpresaCdProdParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro0220>.MapAllProperties().Build());

            return reg0220Accessor.Execute(UndTrabalho.CodigoEmpresa, codigoProduto).ToList();
        }

        public IEnumerable<Registro0400> GetRegistro0400()
        {
            DataAccessor<Registro0400> reg0400Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro0400(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro0400>.MapAllProperties().Build());

            return reg0400Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();

            
            
        }

        public IEnumerable<Registro0600> GetRegistro0600()
        {
            DataAccessor<Registro0600> reg0600Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro0600(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro0600>.MapAllProperties().Build());

            return reg0600Accessor.Execute(UndTrabalho.CodigoEmpresa).ToList();
        }

        public Registro0001 GetRegistro0001()
        {
            Registro0001 reg0001 = new Registro0001();
            reg0001.IND_MOV = "0";  // Sempre haverá um conjunto de informações no bloco 0

            return reg0001;
        }
    }
}
