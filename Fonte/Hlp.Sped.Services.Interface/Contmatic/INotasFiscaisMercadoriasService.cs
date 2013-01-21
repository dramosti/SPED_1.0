using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface INotasFiscaisMercadoriasService
    {
        IEnumerable<RegistroC100> GetRegistrosC100();
        IEnumerable<RegistroC170> GetRegistrosC170(string codChaveNotaFiscal); //Vários por registro C100
        /// <summary>
        /// Cupom Fiscal
        /// </summary>
        /// <returns></returns>
        IEnumerable<RegistroC400> GetRegistrosC400();
        /// <summary>
        /// Cupom Fiscal
        /// </summary>
        /// <returns></returns>
        IEnumerable<RegistroC405> GetRegistrosC405(string codECF); //Vários por registro C400
        /// <summary>
        /// Cupom Fiscal
        /// </summary>
        /// <returns></returns>
        IEnumerable<RegistroC460> GetRegistrosC460(string codECF, DateTime dtEmissao); //Vários por registro C405
        /// <summary>
        /// Cupom Fiscal
        /// </summary>
        /// <returns></returns>
        IEnumerable<RegistroC470> GetRegistrosC470(string pkCupomFis); //Vários por registro C460
        /// <summary>
        /// Cupom Fiscal
        /// </summary>
        /// <returns></returns>
        IEnumerable<RegistroC500> GetRegistrosC500();
        /// <summary>
        /// Cupom Fiscal
        /// </summary>
        /// <returns></returns>
        IEnumerable<RegistroC510> GetRegistrosC510(string codChaveNotaFiscal);// Vários por registro C500
    }
}
