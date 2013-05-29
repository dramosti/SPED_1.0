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
    public class DocumentosFiscaisMercadoriasRepository : IDocumentosFiscaisMercadoriasRepository
    {
         [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        public IEnumerable<RegistroC010> GetRegistrosC010()
        {
            DataAccessor<RegistroC010> regC010Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistrosC010(),
                  new FilterByCdEmpresaDtEmiNfParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroC010>.MapAllProperties().Build());
            return regC010Accessor.Execute(
                UndTrabalho.CodigoEmpresa,
                UndTrabalho.DataInicial,
                UndTrabalho.DataFinal).ToList();
        }
   }
}