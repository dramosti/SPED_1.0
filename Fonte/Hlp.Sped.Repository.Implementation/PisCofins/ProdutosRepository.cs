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
    public class ProdutosRepository : IProdutosRepository   
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

        private DataAccessor<Registro0200> reg0200Accessor;

        public Registro0200 GetRegistro0200(string codigoProduto, string codEmp)
        {
            if (this.reg0200Accessor == null)
            {
                this.reg0200Accessor =
                    UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                      SqlExpressionsPisCofinsRepository.GetSelectRegistro0200(),
                      new FilterByCdEmpresaCdProdParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                      MapBuilder<Registro0200>.MapAllProperties()
                      .Build());
            }
            return this.reg0200Accessor.Execute(
                codEmp, codigoProduto).FirstOrDefault();
        }
    }
}