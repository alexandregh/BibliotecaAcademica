using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsExemplares
{
    public class ConfigurationsExemplar : EntityTypeConfiguration<Exemplar>
    {       
        public ConfigurationsExemplar()
        {
            #region Configurações Exemplar

            ToTable("TBExemplar"); // Nome da Tabela...
            HasKey(livro => livro.IdExemplar); // Primary Key da Tabela...

            Property(exemplar => exemplar.IdExemplar).HasColumnName("IdExemplar").HasMaxLength(24).IsRequired();
            Property(exemplar => exemplar.CodigoExemplar).HasColumnName("CodigoExemplar").HasMaxLength(6).IsRequired();
            Property(exemplar => exemplar.Nome).HasColumnName("Nome").HasMaxLength(80).IsRequired();
            Property(exemplar => exemplar.PalavraChave).HasColumnName("PalavraChave").HasMaxLength(50);
            Property(exemplar => exemplar.AreaConhecimento.CodigoAreaConhecimento).HasColumnName("CodigoAreaConhecimento").IsRequired();
            Property(exemplar => exemplar.AreaConhecimento.Descricao).HasColumnName("DescricaoAreaConhecimento");

            // Localização...
            Property(exemplar => exemplar.Localizacao.Andar).HasColumnName("AndarLocalizacao").IsRequired();
            Property(exemplar => exemplar.Localizacao.Sala).HasColumnName("SalaLocalizacao").IsRequired();
            Property(exemplar => exemplar.Localizacao.Estante).HasColumnName("EstanteLocalizacao").IsRequired();

            #endregion

            #region Associações

            HasRequired(exemplares => exemplares.Livro) // Exemplar possue 1 Livro...
            .WithMany(livro => livro.Exemplares) // Livro possue * Exemplares...
            .HasForeignKey(exemplares => exemplares.IdLivros); // FK => IdLivro.

            #endregion
        }
    }
}