using System;
using BGames.Entiteis;

namespace BGames.Interfaces.Services
{
    public class JogadorResponse
    {
        public Guid Id { get; private set; }
        public string NomeCompleto { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public static explicit operator JogadorResponse(Jogador jogador)
        {
            return new JogadorResponse()
            {
                Email = jogador.Email.Endereco,
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                UltimoNome = jogador.Nome.UltimoNome,
                Id = jogador.Id,
                NomeCompleto = jogador.Nome.ToString(),
                Status = jogador.Status.ToString()
            };
        }
    }
}