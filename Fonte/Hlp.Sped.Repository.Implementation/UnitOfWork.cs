using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;

namespace Hlp.Sped.Repository.Implementation
{
    public class UnitOfWork : UnitOfWorkBase
    {
        private Database _DBOrigemDadosContmatic;

        public override Database DBOrigemDadosContmatic
        {
            get { return _DBOrigemDadosContmatic; }
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

        //private Database _DBArquivoSpedFiscal;

        //public override Database DBArquivoSpedFiscal
        //{
        //    get { return _DBArquivoSpedFiscal; }
        //}

        //private Database _DBArquivoSpedContabil;

        //public override Database DBArquivoSpedContabil
        //{
        //    get { return _DBArquivoSpedContabil; }
        //}

        public UnitOfWork()
        {
            //this._DBArquivoSpedFiscal = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBOrigemDadosFiscal");
            //this._DBArquivoSpedContabil = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBOrigemDadosContabil");
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.ConnectionStrings.ConnectionStrings["DBArquivoSpedFiscal"].ConnectionString != "")
                this._DBArquivoSpedFiscal = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBArquivoSpedFiscal");
            if (config.ConnectionStrings.ConnectionStrings["DBArquivoSpedContabil"].ConnectionString != "")
                this._DBArquivoSpedContabil = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBArquivoSpedContabil");
            if (config.ConnectionStrings.ConnectionStrings["DBArquivoSpedContmatic"].ConnectionString != "")
                this._DBOrigemDadosContmatic = EnterpriseLibraryContainer.Current.GetInstance<Database>("DBArquivoSpedContmatic");
        }
    }
}
