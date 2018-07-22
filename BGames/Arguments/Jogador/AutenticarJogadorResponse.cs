using BGames.Entiteis;

namespace BGames.Interfaces.Services
{
    public class AutenticarJogadorResponse
    {
        public string PrimeiroNome { get; set; }
        public string Email{ get; set; }

        public int Status { get; set; }

        public static explicit operator AutenticarJogadorResponse(Jogador jogador)
        {
            AutenticarJogadorResponse response = new AutenticarJogadorResponse() {
                Email = jogador.Email.Endereco,
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                Status = (int)jogador.Status
        };
            

            return response;
        }
    }
}