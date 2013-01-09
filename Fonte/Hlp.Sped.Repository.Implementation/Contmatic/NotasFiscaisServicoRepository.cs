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
    public class NotasFiscaisServicoRepository : INotasFiscaisServicoRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContmaticRepository SqlExpressionsContmaticRepository { get; set; }


        public IEnumerable<RegistroA100> GetRegistroA100(string codCNPJ)
        {
            DataAccessor<RegistroA100> regA100Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroA100(),
                 new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroA100>.MapAllProperties().Build());

            return regA100Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codCNPJ,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }

        public IEnumerable<RegistroA170> GetRegistroA170(string codChaveNotaFiscal)
        {
            DataAccessor<RegistroA170> regA170Accessor =
               UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                 SqlExpressionsContmaticRepository.GetSelectRegistroA170(),
                 new FilterByCdEmpresaCdCNPJDtEmiNfParameterMapper(UndTrabalho.DBOrigemDadosContmatic),
                 MapBuilder<RegistroA170>.MapAllProperties()
                 .DoNotMap(p => p.NUM_ITEM)
                 .Build());

            List<RegistroA170> resultado = regA170Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                codChaveNotaFiscal).ToList();
            int numeroItem = 0;
            foreach (RegistroA170 regA170 in resultado)
                regA170.NUM_ITEM = ++numeroItem;
            return resultado;
        }
    }
}
