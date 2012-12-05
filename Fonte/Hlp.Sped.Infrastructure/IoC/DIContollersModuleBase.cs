using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;

namespace Hlp.Sped.Infrastructure.IoC
{
    public abstract class DIContollersModuleBase<T> : NinjectModule where T: UnitOfWorkBase, new()
    {
        private T _UnitOfWork = new T();

        public T UnitOfWork
        {
            get { return _UnitOfWork; }
        }

        public override void Load()
        {
            Bind<UnitOfWorkBase>().ToConstant(this._UnitOfWork);

            this.ResolveRepositories();
            this.ResolveServices();
        }

        protected abstract void ResolveRepositories();
        protected abstract void ResolveServices();
    }
}
