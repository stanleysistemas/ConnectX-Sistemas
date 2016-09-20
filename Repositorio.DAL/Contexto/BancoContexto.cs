using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Repositorio.DAL.Mappings;
using Repositorio.Entidades;

namespace Repositorio.DAL.Contexto
{
    public class BancoContexto : DbContext
    {
        public BancoContexto() : base("Dbconnectx") { }

        public DbSet<Usuario> Usuarios { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            // modelBuilder.Properties<string>().Where(p => p.Name.Contains("Descricao")).Configure(p => p.HasMaxLength(400));
            //  modelBuilder.Properties<string>().Where(p => p.Name.Contains("UF")).Configure(p => p.HasMaxLength(2));

            modelBuilder.Configurations.Add(new UsuarioMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}