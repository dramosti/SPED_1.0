using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Services.Interfaces
{
    public interface IConexoesService
    {
        Conexao Obter(string nomeConexao);
        bool Validar(Conexao conexao);
        void Salvar(Conexao conexao);
        ModelConexao GetConfigConexoes();
        void RemoveConexao(Conexao conexao);
        string GetConnectionString(Conexao conexao);
    }
}
