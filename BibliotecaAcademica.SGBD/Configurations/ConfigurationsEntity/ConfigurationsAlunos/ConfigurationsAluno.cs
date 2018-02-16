using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsAlunos
{
    public class ConfigurationsAluno : EntityTypeConfiguration<Aluno>
    {        
        public ConfigurationsAluno()
        {
            #region Configurações Aluno

            ToTable("TBAluno"); // Nome da Tabela...
            HasKey(aluno => aluno.IdAluno); // Primary Key da Tabela...

            Property(aluno => aluno.IdAluno).HasColumnName("IdAluno").HasMaxLength(16).IsRequired();
            Property(aluno => aluno.CodigoUsuario).HasColumnName("CodigoUsuario").HasMaxLength(6).IsRequired();
            Property(aluno => aluno.Nome).HasColumnName("Nome").HasMaxLength(25).IsRequired();
            Property(aluno => aluno.Sobrenome).HasColumnName("Sobrenome").HasMaxLength(50).IsRequired();
            Property(aluno => aluno.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
            Property(aluno => aluno.TipoUsuario).HasColumnName("TipoUsuario").IsRequired();
            Property(aluno => aluno.Status).HasColumnName("StatusUsuario").IsRequired();

            // Telefone...
            Property(aluno => aluno.Telefone.DDD).HasColumnName("DDDTelefone").IsRequired();
            Property(aluno => aluno.Telefone.Numero).HasColumnName("NumeroTelefone").IsRequired();

            // Endereço...
            Property(aluno => aluno.Endereco.Logradouro).HasColumnName("Logradouro").IsRequired();
            Property(aluno => aluno.Endereco.Numero).HasColumnName("Numero");
            Property(aluno => aluno.Endereco.Complemento).HasColumnName("Complemento").HasMaxLength(250);
            Property(aluno => aluno.Endereco.CEP).HasColumnName("CEP").HasMaxLength(10).IsRequired();
            Property(aluno => aluno.Endereco.Zona).HasColumnName("Zona").IsRequired();

            #endregion

            #region Associações

            // N/A...

            #endregion
        }
    }
}