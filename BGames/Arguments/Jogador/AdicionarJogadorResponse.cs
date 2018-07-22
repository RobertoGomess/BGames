using BGames.Entiteis;
using BGames.Interfaces.Arguments;
using BGames.Resorces;
using System;

namespace BGames.Interfaces.Services
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarJogadorResponse(Jogador v)
        {
            return new AdicionarJogadorResponse()
            {
                Id = v.Id,
                Message = BGames.Resorces.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
            
        }
    }
}