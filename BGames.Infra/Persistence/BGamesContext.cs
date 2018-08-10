using BGames.Entiteis;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BGames.Infra
{
    public class BGamesContext : DbContext
    {
        public BGamesContext() : base("BGamesConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Jogador> Jogadores { get; set; }
        public IDbSet<Plataforma> Plataformas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Seta o Shema default
            //modelBuider.HasDefaultSchema("Apoio");

            //remover a pluralização dos nomes das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //remover exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar para usar varchar ou invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //caso eu esqueça de infomar o tamanho do campo ele irá colocar varchar de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //mapeia as entidades
            //modelBuilder.Configurations.Add(new JogadorMap());
            //modelBuilder.Configurations.Add(new JogadorMap());


            #region Adicionar entidades mapeadas - Automaticamente via Assembly
            modelBuilder.Configurations.AddFromAssembly(typeof(BGamesContext).Assembly);
            #endregion

            base.OnModelCreating(modelBuilder);
        }

    }
}
