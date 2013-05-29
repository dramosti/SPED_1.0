using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Repository.Implementation.Fiscal.Mappers;

namespace Hlp.Sped.Repository.Implementation.Fiscal
{
    public class DadosGeraisRepository : IDadosGeraisRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        public Registro0000 GetRegistro0000()
        {
            DataAccessor<Registro0000> reg0000Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistro0000(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
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

        public Registro0001 GetRegistro0001()
        {
            Registro0001 reg0001 = new Registro0001();
            reg0001.IND_MOV = "0";  // Sempre haverá um conjunto de informações no bloco 0

            return reg0001;
        }

        public Registro0005 GetRegistro0005()
        {
            DataAccessor<Registro0005> reg0005Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistro0005(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro0005>.MapAllProperties()
                  .Map(p => p.END).ToColumn("ENDERECO")
                  .Build());

            return reg0005Accessor.Execute(UndTrabalho.CodigoEmpresa).First();
        }

        public Registro0100 GetRegistro0100()
        {
            DataAccessor<Registro0100> reg0100Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistro0100(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro0100>.MapAllProperties()
                  .Map(p => p.END).ToColumn("ENDERECO")
                  .Build());

            Registro0100 reg0100 = reg0100Accessor.Execute(UndTrabalho.CodigoEmpresa).First();
            return reg0100;
        }

        public IEnumerable<Registro0400> GetRegistro0400()
        {
            DataAccessor<Registro0400> reg0400Accessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistro0400(),
                 new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<Registro0400>.MapAllProperties().Build());

            return reg0400Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<Registro0500> GetRegistro0500()
        {
            DataAccessor<Registro0500> reg0500Accessor =
               UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                 SqlExpressionsFiscalRepository.GetSelectRegistro0500(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                 MapBuilder<Registro0500>.MapAllProperties().Build());
            
            return reg0500Accessor.Execute(
                UndTrabalho.CodigoEmpresa).ToList();
        }
    }
}
