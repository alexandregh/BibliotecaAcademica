using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsLivros
{
    public class ConfigurationsLivro : EntityTypeConfiguration<Livro>
    {
        public ConfigurationsLivro()
        {
            #region Configurações Livro

            ToTable("TBLivro"); // Nome da Tabela...
            HasKey(livro => livro.IdLivro); // Primary Key da Tabela...

            Property(livro => livro.IdLivro).HasColumnName("IdLivro").HasMaxLength(16).IsRequired();
            Property(livro => livro.CodigoLivro).HasColumnName("CodigoLivro").HasMaxLength(6).IsRequired();
            Property(livro => livro.Nome).HasColumnName("Nome").HasMaxLength(80).IsRequired();
            Property(livro => livro.PalavraChave).HasColumnName("PalavraChave").HasMaxLength(50);

            // Área do Conhecimento...
            Property(livro => livro.AreaConhecimento.CodigoAreaConhecimento).HasColumnName("CodigoAreaConhecimento").HasMaxLength(4).IsRequired();
            Property(livro => livro.AreaConhecimento.Descricao).HasColumnName("DescricaoAreaConhecimento").HasMaxLength(250);

            #endregion

            #region Associações

            HasRequired(livro => livro.Editora) // Livros são lançados por uma Editora...
            .WithMany(editora => editora.Livros) // Editora lança * Livros...
            .HasForeignKey(livro => livro.IdEditora); // FK => IdEditora.

            #endregion
        }
    }
}