using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Funcionarios;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsFuncionarios
{
    public class ConfigurationsFuncionario : EntityTypeConfiguration<Funcionario>
    {        
        public ConfigurationsFuncionario()
        {
            #region Configurações Funcionário

            ToTable("TBFuncionario"); // Nome da Tabela...
            HasKey(Funcionario => Funcionario.IdFuncionario); // Primary Key da Tabela...

            Property(funcionario => funcionario.IdFuncionario).HasColumnName("IdFuncionario").HasMaxLength(16).IsRequired();
            Property(funcionario => funcionario.CodigoUsuario).HasColumnName("CodigoUsuario").HasMaxLength(6).IsRequired();
            Property(funcionario => funcionario.Nome).HasColumnName("Nome").HasMaxLength(25).IsRequired();
            Property(funcionario => funcionario.Sobrenome).HasColumnName("Sobrenome").HasMaxLength(50).IsRequired();
            Property(funcionario => funcionario.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
            Property(funcionario => funcionario.TipoUsuario).HasColumnName("TipoUsuario").IsRequired();
            Property(funcionario => funcionario.TipoFuncionario).HasColumnName("TipoFuncionario").IsRequired();

            // Telefone...
            Property(funcionario => funcionario.Telefone.DDD).HasColumnName("DDDTelefone").IsRequired();
            Property(funcionario => funcionario.Telefone.Numero).HasColumnName("NumeroTelefone").IsRequired();

            // Endereço...
            Property(funcionario => funcionario.Endereco.Logradouro).HasColumnName("Logradouro").IsRequired();
            Property(funcionario => funcionario.Endereco.Numero).HasColumnName("Numero");
            Property(funcionario => funcionario.Endereco.Complemento).HasColumnName("Complemento").HasMaxLength(250).IsRequired();
            Property(funcionario => funcionario.Endereco.CEP).HasColumnName("CEP").HasMaxLength(10).IsRequired();
            Property(funcionario => funcionario.Endereco.Zona).HasColumnName("Zona");

            #endregion

            #region Associações

            // N/A...

            #endregion
        }
    }
}