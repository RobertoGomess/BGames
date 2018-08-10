using BGames.Api.Base;
using BGames.Arguments.Jogador;
using BGames.Infra.Transactions;
using BGames.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace BGames.Api.Controllers
{
    [RoutePrefix("api/jogador")]
    public class JogadorController : ControllerBase
    {

        private readonly IServiceJogador _serviceJogador;

        public JogadorController(UnitOfWork unitOfWork, IServiceJogador serviceJogador) : base (unitOfWork)
        {
            _serviceJogador = serviceJogador;
        }

        [Route("Adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AdicionarJogadorRequest request)
        {
            try
            {
                var response = _serviceJogador.AdicionarJogador(request);

                return await ResponseAsync(response, _serviceJogador);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _serviceJogador.ListarJogador();

                return await ResponseAsync(response, _serviceJogador);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        public override bool Equals(object obj)
        {
            var controller = obj as JogadorController;
            return controller != null &&
                   EqualityComparer<IServiceJogador>.Default.Equals(_serviceJogador, controller._serviceJogador);
        }
    }
}