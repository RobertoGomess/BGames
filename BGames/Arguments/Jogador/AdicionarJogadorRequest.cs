using BGames.Interfaces.Arguments;
using BGames.ValuesObjets;

namespace BGames.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
