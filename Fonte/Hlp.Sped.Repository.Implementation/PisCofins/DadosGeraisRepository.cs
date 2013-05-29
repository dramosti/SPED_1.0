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
    public class DadosGeraisRepository : IDadosGeraisRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        DataAccessor<Registro0140> reg0140Accessor;

        public Registro0000 GetRegistro0000()
        {
            DataAccessor<Registro0000> reg0000Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistro0000(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro0000>.MapAllProperties()
                  .DoNotMap(p => p.TIPO_ESCRIT)
                  .DoNotMap(p => p.NUM_REC_ANTERIOR)
                  .DoNotMap(p => p.DT_INI)
                  .DoNotMap(p => p.DT_FIN)
                  .Build());

            Registro0000 reg0000 = reg0000Accessor.Execute(UndTrabalho.CodigoEmpresa).First();

            reg0000.TIPO_ESCRIT = ((int)UndTrabalho.TipoRemessa).ToString();
            reg0000.NUM_REC_ANTERIOR = UndTrabalho.NumeroReciboAnterior;
            reg0000.DT_INI = UndTrabalho.DataInicial;
            reg0000.DT_FIN = UndTrabalho.DataFinal;

            return reg0000;
        }

        public Registro0001 GetRegistro0001()
        {
            Registro0001 reg0001 = new Registro0001();
            reg0001.IND_MOV = "0";  // Sempre haverá um conjunto de informações no bloco 0

            return reg0001;
        }
        
        public Registro0100 GetRegistro0100()
        {
            DataAccessor<Registro0100> reg0100Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistro0100(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro0100>.MapAllProperties()
                  .Map(p => p.END).ToColumn("ENDERECO")
                  .Build());

            Registro0100 reg0100 = reg0100Accessor.Execute(UndTrabalho.CodigoEmpresa).FirstOrDefault();
            return reg0100;
        }

        public Registro0110 GetRegistro0110()
        {
            DataAccessor<Registro0110> reg0110Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistro0110(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro0110>.MapAllProperties().Build());
            return reg0110Accessor.Execute(
                UndTrabalho.CodigoEmpresa).FirstOrDefault();
        }

        public IEnumerable<Registro0140> GetRegistro0140()
        {
            if (reg0140Accessor == null)
            {
                reg0140Accessor =
                   UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                     SqlExpressionsPisCofinsRepository.GetSelectRegistro0140(),
                     new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                     MapBuilder<Registro0140>.MapAllProperties().Build());
            }
            return reg0140Accessor.Execute(
                UndTrabalho.CodigoEmpresa).ToList();
        }

        public IEnumerable<Registro0400> GetRegistro0400(string codEmp)
        {
            DataAccessor<Registro0400> reg0400Accessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsPisCofinsRepository.GetSelectRegistro0400(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<Registro0400>.MapAllProperties().Build());

            return reg0400Accessor.Execute(
                codEmp,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<Registro0500> GetRegistro0500(string codEmp)
        {
            DataAccessor<Registro0500> reg0500Accessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsPisCofinsRepository.GetSelectRegistro0500(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<Registro0500>.MapAllProperties().Build());

            return reg0500Accessor.Execute(
                codEmp).ToList();
        }
    }
}