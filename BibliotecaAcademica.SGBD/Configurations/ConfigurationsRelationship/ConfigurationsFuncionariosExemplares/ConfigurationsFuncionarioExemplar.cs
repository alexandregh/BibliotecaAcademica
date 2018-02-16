using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosExemplares;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsFuncionariosExemplares
{
    public class ConfigurationsFuncionarioExemplar : EntityTypeConfiguration<FuncionarioExemplar>
    {
        public ConfigurationsFuncionarioExemplar()
        {
            #region Configurações FuncionarioExemplar

            ToTable("FuncionarioExemplar");

            // Chave composta (IdFuncionário e IdExemplar) na tabela FuncionárioExemplar criada pelo modificador new...
            HasKey(funcionarioexemplar => new { funcionarioexemplar.IdFuncionario, funcionarioexemplar.IdExemplar });

            Property(funcionarioexemplar => funcionarioexemplar.IdFuncionario).HasColumnName("IdFuncionario").IsRequired();
            Property(funcionarioexemplar => funcionarioexemplar.IdExemplar).HasColumnName("IdExemplar").IsRequired();

            Property(funcionarioexemplar => funcionarioexemplar.CodigoFuncionario).HasColumnName("CodigoUsuario").IsRequired();
            Property(funcionarioexemplar => funcionarioexemplar.CodigoExemplar).HasColumnName("CodigoExemplar").IsRequired();
            Property(funcionarioexemplar => funcionarioexemplar.DataHoraInicio).HasColumnName("DataHoraInicio").IsRequired();
            Property(funcionarioexemplar => funcionarioexemplar.DataHoraFim).HasColumnName("DataHoraFim").IsRequired();
            Property(funcionarioexemplar => funcionarioexemplar.QuantidadeDiasEmprestimo).HasColumnName("QuantidadeDiasEmprestimo").IsRequired();

            #endregion

            #region Associações

            HasRequired(funcionarioexemplar => funcionarioexemplar.Funcionario)
            .WithMany(funcionario => funcionario.FuncionarioExemplar)
            .HasForeignKey(funcionarioexemplar => funcionarioexemplar.IdFuncionario);

            //_______________________________________________________________________

            HasRequired(funcionarioexemplar => funcionarioexemplar.Exemplar)
            .WithMany(exemplar => exemplar.FuncionarioExemplar)
            .HasForeignKey(funcionarioexemplar => funcionarioexemplar.IdExemplar);

            #endregion
        }
    }
}