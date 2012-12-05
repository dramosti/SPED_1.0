using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Repository.Interfaces.Fiscal
{
    public interface IDadosArquivoFiscalRepository
    {
        void Inicializar();
        void PersistirRegistro(RegistroBase registro);
        bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro);
        bool BlocoPossuiRegistros(string identificadorBloco);
        Registro0990 GetRegistro0990();
        RegistroC990 GetRegistroC990();
        RegistroD990 GetRegistroD990();
        RegistroE990 GetRegistroE990();
        RegistroG990 GetRegistroG990();
        RegistroH990 GetRegistroH990();
        Registro1990 GetRegistro1990();
        Registro9001 GetRegistro9001();
        IEnumerable<Registro9900> GetRegistros9900();
        Registro9990 GetRegistro9990();
        Registro9999 GetRegistro9999();
        void OpenRegistros();
        bool ReadRegistro();
        string GetConteudoRegistro();
        void CloseRegistros();
        void RegistrarExcecao(Exception ex);
        void Finalizar();
    }
}