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
    public class DemonstracoesContabeisRepository : IDemonstracoesContabeisRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContabilRepository SqlExpressionsContabilRepository { get; set; }

        public RegistroJ001 GetRegistroJ001()
        {
            RegistroJ001 regJ001 = new RegistroJ001();
            regJ001.IND_DAD = 0;

            return regJ001;
        }

        public IEnumerable<RegistroJ930> GetRegistrosJ930()
        {
            DataAccessor<RegistroJ930> regJ930Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContabilRepository.GetSelectRegistrosJ930(),
                  new FilterByCdEmpresaParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<RegistroJ930>.MapAllProperties()
                  .Build());

            return regJ930Accessor.Execute(
                UndTrabalho.CodigoEmpresa);
        }
    }
}
