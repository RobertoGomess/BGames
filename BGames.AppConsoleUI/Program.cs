using BGames.Entiteis;
using BGames.Infra;
using BGames.Infra.Persistence.Repositories;
using BGames.Interfaces.Repositories;
using BGames.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BGames.AppConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var BdContext = new BGamesContext();
            var repositoryJogador = new RepositoryJogador(BdContext);
            ServiceJogador serviceJogador = new ServiceJogador(repositoryJogador);

            var returno = serviceJogador.ListarJogador().ToList();
            if (returno.Count > 0)
            {
                foreach (var item in returno)
                {
                    Console.Write(item.NomeCompleto);
                }
            }
            else
            {
                Console.Write("Sem itens !");
            }
            
            
        }
    }
}
