using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure.IoC;

namespace Hlp.Sped.Infrastructure.Controllers
{
    public abstract class BaseController
    {
        public event AsynchronousExecutionHandler AsynchronousExecution;
        public event AsynchronousExecutionAbortedHandler AsynchronousExecutionAborted;
        
        private IObserverAsynchronousExecution _observer;
        
        public void Initialize()
        {
            IKernel kernel = new StandardKernel(this.GetInstanceDIControllersModule());
            kernel.Settings.ActivationCacheDisabled = false;
            kernel.Inject(this);
        }

        public void ExecuteAsynchronous(IObserverAsynchronousExecution observer)
        {
            // O parâmetro observer representa a interface gráfica que executará este método
            // de forma assíncrona
            if (AsynchronousExecution != null)
            {
                try
                {
                    this._observer = observer;
                    observer.ConfigureBeforeAsynchronousExecution();
                    AsynchronousExecution();
                    observer.AsynchronousExecutionFinished();
                }
                catch (Exception ex)
                {
                    if (AsynchronousExecutionAborted != null)
                        AsynchronousExecutionAborted(ex);
                    observer.AsynchronousExecutionAborted(ex);
                }
            }
        }

        protected void UpdateStatusAsynchronousExecution(string message)
        {
            this._observer.UpdateStatusAsynchronousExecution(message + "...");
        }

        protected abstract NinjectModule GetInstanceDIControllersModule();
    }
}