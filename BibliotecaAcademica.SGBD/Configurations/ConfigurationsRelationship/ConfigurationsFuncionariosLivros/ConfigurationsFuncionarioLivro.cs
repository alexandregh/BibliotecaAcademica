using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosLivros;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsFuncionariosLivros
{
    public class ConfigurationsFuncionarioLivro : EntityTypeConfiguration<FuncionarioLivro>
    {
        public ConfigurationsFuncionarioLivro()
        {
            #region Configurações FuncionarioLivro

            ToTable("FuncionarioLivro");

            // Chave composta (IdFuncionário e IdLivro) na tabela FuncionarioLivro criada pelo modificador new...
            HasKey(funcionariolivro => new { funcionariolivro.IdFuncionario, funcionariolivro.IdLivro });

            Property(funcionariolivro => funcionariolivro.IdFuncionario).HasColumnName("IdFuncionario").IsRequired();
            Property(funcionariolivro => funcionariolivro.IdLivro).HasColumnName("IdLivro").IsRequired();

            Property(funcionariolivro => funcionariolivro.CodigoFuncionario).HasColumnName("CodigoUsuario").IsRequired();
            Property(funcionariolivro => funcionariolivro.CodigoLivro).HasColumnName("CodigoLivro").IsRequired();
            Property(funcionariolivro => funcionariolivro.DataHoraGerenciamento).HasColumnName("DataHoraGerenciamento").IsRequired();
            Property(funcionariolivro => funcionariolivro.Gerenciamento).HasColumnName("Gerenciamento").IsRequired();

            #endregion

            #region Associações

            HasRequired(funcionariolivro => funcionariolivro.Funcionario)
            .WithMany(funcionario => funcionario.FuncionarioLivro)
            .HasForeignKey(funcionariolivro => funcionariolivro.IdFuncionario);

            //_______________________________________________________________________

            HasRequired(funcionariolivro => funcionariolivro.Livro)
            .WithMany(livro => livro.FuncionarioLivro)
            .HasForeignKey(funcionariolivro => funcionariolivro.IdLivro);

            #endregion
        }
    }
}