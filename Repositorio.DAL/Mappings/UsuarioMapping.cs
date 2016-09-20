using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entidades;

namespace Repositorio.DAL.Mappings
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            this.HasKey(t => t.UsuarioId);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            this.Property(t => t.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_LoginNameUser", 1) { IsUnique = true }));


            this.Property(t => t.Senha)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(1024);

            this.Property(t => t.Sexo)
                  .IsOptional()
                  .HasColumnType("varchar")
                  .HasMaxLength(20);

            this.Property(t => t.SenhaKey)
                  .IsOptional()
                  .HasColumnType("varchar")
                  .HasMaxLength(100);

            this.Property(t => t.DataCadastro)
                  .IsOptional()
                  .HasColumnType("datetime");

            this.Property(t => t.Sexo)
                  .IsOptional()
                  .HasColumnType("varchar");

            this.Property(t => t.Foto)
                  .IsOptional()
                  .HasColumnType("tinyint");

            this.Property(t => t.DatadeNascimento)
                  .IsOptional()
                  .HasColumnType("datetime");

            this.Property(t => t.Idade)
                              .IsOptional()
                              .HasColumnType("int");

            this.Property(t => t.Ativo)
                .IsOptional()
                .HasColumnType("bit");

        
            ToTable("Usuario","dbo");
        }

    }
}
