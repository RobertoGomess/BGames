using System;

namespace BGames.Interfaces.Services
{
    public class AlterarJogadorRequest
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}