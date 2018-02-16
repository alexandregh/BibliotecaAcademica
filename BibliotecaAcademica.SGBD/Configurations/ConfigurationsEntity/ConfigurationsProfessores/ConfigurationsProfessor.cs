using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsProfessores
{
    public class ConfigurationsProfessor : EntityTypeConfiguration<Professor>
    {        
        public ConfigurationsProfessor()
        {
            #region Configurações Professor

            ToTable("TBProfessor"); // Nome da Tabela...
            HasKey(professor => professor.IdProfessor); // Primary Key da Tabela...

            Property(professor => professor.IdProfessor).HasColumnName("IdProfessor").HasMaxLength(16).IsRequired();
            Property(professor => professor.CodigoUsuario).HasColumnName("CodigoUsuario").HasMaxLength(6).IsRequired();
            Property(professor => professor.Nome).HasColumnName("Nome").HasMaxLength(25).IsRequired();
            Property(professor => professor.Sobrenome).HasColumnName("Sobrenome").HasMaxLength(50).IsRequired();
            Property(professor => professor.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
            Property(professor => professor.TipoUsuario).HasColumnName("TipoUsuario").IsRequired();
            Property(professor => professor.Status).HasColumnName("StatusUsuario").IsRequired();

            // Telefone...
            Property(professor => professor.Telefone.DDD).HasColumnName("DDDTelefone").IsRequired();
            Property(professor => professor.Telefone.Numero).HasColumnName("NumeroTelefone").IsRequired();

            // Endereço...
            Property(professor => professor.Endereco.Logradouro).HasColumnName("Logradouro").IsRequired();
            Property(professor => professor.Endereco.Numero).HasColumnName("Numero");
            Property(professor => professor.Endereco.Complemento).HasColumnName("Complemento").HasMaxLength(250).IsRequired();
            Property(professor => professor.Endereco.CEP).HasColumnName("CEP").HasMaxLength(10).IsRequired();
            Property(professor => professor.Endereco.Zona).HasColumnName("Zona");

            #endregion

            #region Associações

            // N/A...

            #endregion
        }
    }
}