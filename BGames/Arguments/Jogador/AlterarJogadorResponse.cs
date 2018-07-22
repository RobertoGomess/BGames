using System;
using BGames.Entiteis;

namespace BGames.Interfaces.Services
{
    public class AlterarJogadorResponse
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Message { get; private set; }

        public static explicit operator AlterarJogadorResponse(Jogador jogador)
        {
            return new AlterarJogadorResponse()
            {
                Email = jogador.Email.Endereco,
                Id = jogador.Id,
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                Message = Resorces.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}