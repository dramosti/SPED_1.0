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
    public class InventarioRepository : IInventarioRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsFiscalRepository SqlExpressionsFiscalRepository { get; set; }

        private DataAccessor<RegistroH010> regH010Accessor;

        public IEnumerable<RegistroH005> GetRegistrosH005()
        {
           // DateTime dataInicialInventario = UndTrabalho.DataInicial.AddMonths(-2);
            //DateTime dataFinalInventario = dataInicialInventario.AddMonths(1).AddDays(-1);

            DataAccessor<RegistroH005> regH005Accessor =
                UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  SqlExpressionsFiscalRepository.GetSelectRegistrosH005(),
                  new FilterByCdEmpresaPeriodoInveParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                  MapBuilder<RegistroH005>.MapAllProperties().Build());
            return regH005Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,  // dataInicialInventario,
                UndTrabalho.DataFinal);//dataFinalInventario);
        }

        public IEnumerable<RegistroH010> GetRegistrosH010(DateTime dataInventario)
        {
            if (regH010Accessor == null)
            {
                regH010Accessor =
                    UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                    SqlExpressionsFiscalRepository.GetSelectRegistrosH010(),
                    new FilterByCdEmpresaDtInveParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
                    MapBuilder<RegistroH010>.MapAllProperties().Build());
            }

            return regH010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                dataInventario).ToList();
        }
    }
}
