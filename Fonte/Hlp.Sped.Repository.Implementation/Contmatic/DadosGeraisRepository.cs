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


        public Domain.Models.Contmatic.Registro0000 GetRegistro0000()
        {
            DataAccessor<Registro0000> reg0000Accessor =
                UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  SqlExpressionsContmaticRepository.GetSelectRegistro0000(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBOrigemDadosFiscal),
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
    }
}
