using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Repository.Interfaces.PisCofins
{
    public interface IDemaisDocumentosOperacoesRepository
    {

        List<RegistroF010> GetRegistroF010();

        List<RegistroF600> GetRegistroF600(string codEmp);

        List<RegistroF200> GetRegistroF200(string codEmp);


    }
}
