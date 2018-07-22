using BGames.Entiteis;
using System;
using System.Collections.Generic;

namespace BGames.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);
        Jogador AdicionarJogador(Jogador request);
        IEnumerable<Jogador> ListarJogador();
        Jogador ObterJogadorPorId(Guid id);
        Jogador AlterarJogador(Jogador jogador);
    }
}
