using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation
{
    public class UnitOfWork : UnitOfWorkBase
    {
        private Database _DBOrigemDadosContmatic;

        public override Database DBOrigemDadosContmatic
        {
            get { return _DBOrigemDadosContmatic; }
        }

        private Database _DBOrigemDadosFiscal;

        public override Database DBOrigemDadosFiscal
        {
            get { return _DBOrigemDadosFiscal; }
        }

        private Database _DBOrigemDadosContabil;
        
        public override Database DBOrigemDadosContabil
        {
            get { return _DBOrigemDadosContabil; }
        }

        private Database _DBArquivoSpedFiscal;

        public override Database DBArquivoSpedFiscal
        {
            get { return _DBArquivoSpedFiscal; }
        }

        private Database _DBArquivoSpedContabil;

        public override Database DBArquivoSpedContabil
        {
            get { return _DBArquivoSpedContabil; }
        }

        public UnitOfWork()
        {
            this._DBOrigemDadosFiscal = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBOrigemDadosFiscal");
            this._DBOrigemDadosContabil = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBOrigemDadosContabil");
            this._DBArquivoSpedFiscal = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBArquivoSpedFiscal");
            this._DBArquivoSpedContabil = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBArquivoSpedContabil");
            this._DBOrigemDadosContmatic = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBArquivoSpedContmatic");
        }
    }
}
