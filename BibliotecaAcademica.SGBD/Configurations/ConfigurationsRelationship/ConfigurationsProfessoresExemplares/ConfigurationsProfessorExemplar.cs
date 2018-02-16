using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.ProfessoresExemplares;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsProfessoresExemplares
{
    public class ConfigurationsProfessorExemplar : EntityTypeConfiguration<ProfessorExemplar>
    {
        public ConfigurationsProfessorExemplar()
        {
            #region Configurações ProfessorExemplar

            ToTable("ProfessorExemplar");

            // Chave composta (IdProfessor e IdExemplar) na tabela ProfessorExemplar criada pelo modificador new...
            HasKey(professorexemplar => new { professorexemplar.IdProfessor, professorexemplar.IdExemplar });

            Property(professorexemplar => professorexemplar.IdProfessor).HasColumnName("IdProfessor").IsRequired();
            Property(professorexemplar => professorexemplar.IdExemplar).HasColumnName("IdExemplar").IsRequired();

            Property(professorexemplar => professorexemplar.CodigoProfessor).HasColumnName("CodigoUsuario").IsRequired();
            Property(professorexemplar => professorexemplar.CodigoExemplar).HasColumnName("CodigoExemplar").IsRequired();
            Property(professorexemplar => professorexemplar.DataHoraInicio).HasColumnName("DataHoraInicio").IsRequired();
            Property(professorexemplar => professorexemplar.DataHoraFim).HasColumnName("DataHoraFim").IsRequired();
            Property(professorexemplar => professorexemplar.QuantidadeDiasEmprestimo).HasColumnName("QuantidadeDiasEmprestimo").IsRequired();

            #endregion

            #region Associações

            HasRequired(professorexemplar => professorexemplar.Professor)
            .WithMany(professor => professor.ProfessorExemplar)
            .HasForeignKey(professorexemplar => professorexemplar.IdProfessor);

            //_______________________________________________________________________

            HasRequired(professorexemplar => professorexemplar.Exemplar)
            .WithMany(exemplar => exemplar.ProfessorExemplar)
            .HasForeignKey(professorexemplar => professorexemplar.IdExemplar);

            #endregion
        }
    }
}