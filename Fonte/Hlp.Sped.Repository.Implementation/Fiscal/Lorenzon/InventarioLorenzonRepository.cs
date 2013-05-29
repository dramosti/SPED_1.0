using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal.Lorenzon;
using Hlp.Sped.Repository.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Repository.Implementation.Fiscal.Mappers;

namespace Hlp.Sped.Repository.Implementation.Fiscal.Lorenzon
{
    public class InventarioLorenzonRepository : IInventarioLorenzonRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        private DataAccessor<RegistroH010> regH010Accessor;

        public IEnumerable<RegistroH005Lorenzon> GetRegistrosH005()
        {
            DateTime dataInicialInventario = UndTrabalho.DataInicial;
            DateTime dataFinalInventario = UndTrabalho.DataFinal;

            DataAccessor<RegistroH005Lorenzon> regH005Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  "SELECT * FROM SP_SPEDFIS_LORENZON_REGH005(?, ?, ?)",
                  new FilterByCdEmpresaPeriodoInveParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroH005Lorenzon>
                      .MapAllProperties()
                      .Build());
            return regH005Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dataInicialInventario,
                dataFinalInventario);
        }

        public IEnumerable<RegistroH010> GetRegistrosH010(DateTime dataInventario)
        {
            if (regH010Accessor == null)
            {
                regH010Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                    "SELECT * FROM SP_SPEDFIS_LORENZON_REGH010(?, ?)",
                    new FilterByCdEmpresaDtInveParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroH010>.MapAllProperties().Build());
            }

            return regH010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dataInventario).ToList();
        }

        public IEnumerable<Registro0200> GetRegistros0200()
        {
            DateTime dataInicialInventario = UndTrabalho.DataInicial;
            DateTime dataFinalInventario = UndTrabalho.DataFinal;

            DataAccessor<Registro0200> reg0200Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  "SELECT * FROM SP_SPEDFIS_LORENZON_REG0200(?, ?, ?)",
                  new FilterByCdEmpresaPeriodoInveParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro0200>
                      .MapAllProperties()
                      .Build());
            return reg0200Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dataInicialInventario,
                dataFinalInventario);
        }
    }
}