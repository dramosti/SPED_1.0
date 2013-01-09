using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;
using Hlp.Sped.Domain.Models.Contmatic;
using Hlp.Sped.Repository.Implementation.Contmatic.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contmatic
{
    public class OutrasInformacoesRepository : IOutrasInformacoesRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContmaticRepository SqlExpressionsContmaticRepository { get; set; }


        public IEnumerable<Registro1010> GetRegistro1010()
        {
            DataAccessor<Registro1010> reg1010Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro1010(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro1010>.MapAllProperties().Build());

            return reg1010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<Registro1100> GetRegistro1100()
        {
            DataAccessor<Registro1100> reg1100Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro1100(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro1100>.MapAllProperties().Build());

            return reg1100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<Registro1200> GetRegistro1200()
        {
            DataAccessor<Registro1200> reg1200Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro1200(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro1200>.MapAllProperties().Build());

            return reg1200Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<Registro1600> GetRegistro1600()
        {
            DataAccessor<Registro1600> reg1600Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistro1600(),
                 new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<Registro1600>.MapAllProperties().Build());

            return reg1600Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }
    }
}
