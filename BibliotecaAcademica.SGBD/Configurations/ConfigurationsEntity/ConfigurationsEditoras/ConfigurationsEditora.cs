using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Editoras;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsEditoras
{
    public class ConfigurationsEditora : EntityTypeConfiguration<Editora>
    {        
        public ConfigurationsEditora()
        {
            #region Configurações Editora

            ToTable("TBEditora"); // Nome da Tabela...
            HasKey(editora => editora.IdEditora); // Primary Key da Tabela...

            Property(editora => editora.IdEditora).HasColumnName("IdEditora").HasMaxLength(16).IsRequired();
            Property(editora => editora.CodigoEditora).HasColumnName("CodigoEditora").HasMaxLength(4).IsRequired();
            Property(professor => professor.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();

            // Telefone...
            Property(editora => editora.Telefone.DDD).HasColumnName("DDDTelefone").IsRequired();
            Property(editora => editora.Telefone.Numero).HasColumnName("NumeroTelefone").IsRequired();

            // Endereço...
            Property(editora => editora.Endereco.Logradouro).HasColumnName("Logradouro").IsRequired();
            Property(editora => editora.Endereco.Numero).HasColumnName("Numero");
            Property(editora => editora.Endereco.Complemento).HasColumnName("Complemento").HasMaxLength(250).IsRequired();
            Property(editora => editora.Endereco.CEP).HasColumnName("CEP").HasMaxLength(10).IsRequired();
            Property(editora => editora.Endereco.Zona).HasColumnName("Zona");

            #endregion

            #region Associações

            

            #endregion
        }
    }
}