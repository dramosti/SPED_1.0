using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Repository.Interfaces.Contabil
{
    public interface IDadosArquivoContabilRepository
    {
        void Inicializar();
        void PersistirRegistro(RegistroBase registro);
        bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro);
        Registro0990 GetRegistro0990();
        RegistroI990 GetRegistroI990();
        RegistroJ990 GetRegistroJ990();
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