using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces;
using Hlp.Sped.Repository.Interfaces;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Services.Implementation
{
    public class ConexoesService : IConexoesService
    {
        [Inject]
        public IConexoesRepository ConexoesRepository { get; set; }

        public Conexao Obter(string nomeConexao)
        {
            return ConexoesRepository.Obter(nomeConexao);
        }

        public bool Validar(Conexao conexao)
        {
            return ConexoesRepository.Validar(conexao);
        }

        public void Salvar(Conexao conexao)
        {
            ConexoesRepository.Salvar(conexao);
        }


        public ModelConexao GetConfigConexoes()
        {
            return ConexoesRepository.GetConfigConexoes();
        }


        public void RemoveConexao(Conexao conexao)
        {
            ConexoesRepository.RemoveConexao(conexao);
        }


        public string GetConnectionString(Conexao conexao)
        {
            return ConexoesRepository.GetConnectionString(conexao);
        }
    }
}
