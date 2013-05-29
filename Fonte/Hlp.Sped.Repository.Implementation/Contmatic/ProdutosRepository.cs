using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Domain.Models.Contmatic;
using Hlp.Sped.Repository.Implementation.Contmatic.Mappers;

namespace Hlp.Sped.Repository.Implementation.Contmatic
{
    public class ProdutosRepository : IProdutosRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContmaticRepository SqlExpressionsContmaticRepository { get; set; }

        private DataAccessor<Registro0200> reg0200Accessor;

        private DataAccessor<Registro0220> reg0220Accessor;

        public Registro0200 GetRegistro0200(string codigoProduto)
        {
            if (this.reg0200Accessor == null)
            {
                this.reg0200Accessor =
                    UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                      SqlExpressionsContmaticRepository.GetSelectRegistro0200(),
                      new FilterByCdEmpresaCdProdParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                      MapBuilder<Registro0200>.MapAllProperties()
                      .Build());
            }
            return this.reg0200Accessor.Execute(
                UndTrabalho.CodigoEmpresa, codigoProduto).FirstOrDefault();
        }


        public IEnumerable<Registro0220> GetRegistros0220(string codigoProduto)
        {
            if (this.reg0220Accessor == null)
            {
                this.reg0220Accessor =
                    UndTrabalho.DBOrigemDadosContmatic.CreateSqlStringAccessor(
                      SqlExpressionsContmaticRepository.GetSelectRegistro0220(),
                      new FilterByCdEmpresaCdProdParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                      MapBuilder<Registro0220>.MapAllProperties()
                      .Build());
            }
            return this.reg0220Accessor.Execute(
                UndTrabalho.CodigoEmpresa, codigoProduto).ToList();
        }
    }
}