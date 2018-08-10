using System;
using System.Collections.Generic;
using System.Linq;
using BGames.Entiteis;
using BGames.Infra.Persistence.Repositories.Base;
using BGames.Interfaces.Repositories;

namespace BGames.Infra.Persistence.Repositories
{
    public class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly BGamesContext _context;

        public RepositoryJogador(BGamesContext bGamesContext) : base (bGamesContext)
        {
            _context = bGamesContext;
        }

        public Jogador AdicionarJogador(Jogador request)
        {
            _context.Jogadores.Add(request);
            _context.SaveChanges();

            return request;
        }

        public Jogador AlterarJogador(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public Jogador AutenticarJogador(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogador> ListarJogador()
        {
            return _context.Jogadores.ToList();
        }

        public Jogador ObterJogadorPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
