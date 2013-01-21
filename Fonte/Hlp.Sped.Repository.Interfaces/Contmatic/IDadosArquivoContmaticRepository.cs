using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Repository.Interfaces.Contmatic
{
    public interface IDadosArquivoContmaticRepository
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
