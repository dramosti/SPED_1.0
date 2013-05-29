using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contabil;
using Hlp.Sped.Domain.Models.Contabil;
using Hlp.Sped.Repository.Implementation.Contabil.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contabil
{
    public class PlanoContasRepository : IPlanoContasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContabilRepository SqlExpressionsContabilRepository { get; set; }

        private DataAccessor<RegistroI050> regI050Accessor;

        public IEnumerable<RegistroI050> GetRegistrosI050(string contaSuperior, int nivelContasFilhas)
        {
            if (regI050Accessor == null)
            {
                regI050Accessor =
                    UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                    SqlExpressionsContabilRepository.GetSelectRegistrosI050(),
                    new FilterByCdEmpresaContaSuperiorNivelParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                    MapBuilder<RegistroI050>.MapAllProperties()
                    .Build());
            }
            return regI050Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                contaSuperior,
                nivelContasFilhas);
        }
    }
}
