using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Autores;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsAutores
{
    public class ConfigurationsAutor : EntityTypeConfiguration<Autor>
    {       
        public ConfigurationsAutor()
        {
            #region Configurações Autor

            ToTable("TBAutor"); // Nome da Tabela...
            HasKey(autor => autor.IdAutor); // Primary Key da Tabela...

            Property(autor => autor.IdAutor).HasColumnName("IdAutor").HasMaxLength(16).IsRequired();
            Property(autor => autor.CodigoAutor).HasColumnName("CodigoAutor").HasMaxLength(6).IsRequired();            
            Property(professor => professor.Nome).HasColumnName("Nome").HasMaxLength(25).IsRequired();
            Property(professor => professor.Sobrenome).HasColumnName("Sobrenome").HasMaxLength(50).IsRequired();

            #endregion

            #region Associações

            // N/A...

            #endregion
        }
    }
}