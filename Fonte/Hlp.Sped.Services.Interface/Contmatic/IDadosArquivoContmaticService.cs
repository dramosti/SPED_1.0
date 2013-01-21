using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;
using Hlp.Sped.Infrastructure.Registro;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface IDadosArquivoContmaticService
    {
        void Inicializar();
        void PersistirRegistro(RegistroBase registro);
        bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro);
        bool BlocoPossuiRegistros(string identificadorBloco);
        void OpenRegistros();
        bool ReadRegistro();
        string GetConteudoRegistro();
        void CloseRegistros();
        void RegistrarExcecao(Exception ex);
        void Finalizar();

        Registro0990 GetRegistro0990();
        RegistroA990 GetRegistroA990();
        RegistroC990 GetRegistroC990();
        RegistroD990 GetRegistroD990();
        Registro1990 GetRegistro1990();
    }
}
