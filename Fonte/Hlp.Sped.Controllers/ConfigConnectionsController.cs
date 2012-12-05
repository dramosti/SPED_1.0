using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Controllers.IoC;
using Hlp.Sped.Services.Interfaces;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Controllers
{
    public class ConfigConnectionsController : BaseController
    {
        [Inject]
        public IConexoesService ConexoesService { get; set; }

        protected override NinjectModule GetInstanceDIControllersModule()
        {
            DIContollersModuleConfigConnections module = new DIContollersModuleConfigConnections();
            return module;
        }

        public Conexao ObterConexao(string nomeConexao)
        {
            return ConexoesService.Obter(nomeConexao);
        }

        public bool ValidarConexao(Conexao conexao)
        {
            return ConexoesService.Validar(conexao);
        }

        public void SalvarConexao(Conexao conexao)
        {
            ConexoesService.Salvar(conexao);
        }
    }
}
