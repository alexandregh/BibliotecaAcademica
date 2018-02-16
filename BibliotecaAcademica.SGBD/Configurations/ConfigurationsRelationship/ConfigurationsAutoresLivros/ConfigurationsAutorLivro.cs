using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AutoresLivros;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsAutoresLivros
{
    public class ConfigurationsAutorLivro : EntityTypeConfiguration<AutorLivro>
    {
        public ConfigurationsAutorLivro()
        {
            #region Configurações AutorLivro

            ToTable("AutorLivro");

            // Chave composta (IdAutor e IdLivro) na tabela AutorLivro criada pelo modificador new...
            HasKey(autorlivro => new { autorlivro.IdAutor, autorlivro.IdLivro });

            Property(autorlivro => autorlivro.IdAutor).HasColumnName("IdAutor").IsRequired();
            Property(autorlivro => autorlivro.IdLivro).HasColumnName("IdLivro").IsRequired();

            Property(autorlivro => autorlivro.CodigoAutor).HasColumnName("CodigoUsuario").IsRequired();
            Property(autorlivro => autorlivro.CodigoLivro).HasColumnName("CodigoLivro").IsRequired();
            Property(autorlivro => autorlivro.NomeLivro).HasColumnName("NomeLivro").IsRequired();
            Property(autorlivro => autorlivro.NomeAutor).HasColumnName("NomeAutor").IsRequired();
            Property(autorlivro => autorlivro.SobrenomeAutor).HasColumnName("SobrenomeAutor").IsRequired();
            Property(autorlivro => autorlivro.NomeEditora).HasColumnName("NomeEditora").IsRequired();

            #endregion

            #region Associações

            HasRequired(autorlivro => autorlivro.Autor)
            .WithMany(autor => autor.AutorLivro)
            .HasForeignKey(autorlivro => autorlivro.IdAutor);

            //_______________________________________________________________________

            HasRequired(autorlivro => autorlivro.Livro)
            .WithMany(livro => livro.AutorLivro)
            .HasForeignKey(autorlivro => autorlivro.IdLivro);

            #endregion
        }
    }
}