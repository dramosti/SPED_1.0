using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Infrastructure.Controllers
{
    public interface IObserverAsynchronousExecution
    {
        void ConfigureBeforeAsynchronousExecution();
        void UpdateStatusAsynchronousExecution(string message);
        void AsynchronousExecutionFinished();
        void AsynchronousExecutionAborted(Exception ex);
    }
}
