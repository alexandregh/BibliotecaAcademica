using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AlunosExemplares;
using System.Data.Entity.ModelConfiguration;

namespace BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsAlunosExemplares
{
    public class ConfigurationsAlunoExemplar : EntityTypeConfiguration<AlunoExemplar>
    {
        public ConfigurationsAlunoExemplar()
        {
            #region Configurações AlunoExemplar

            ToTable("AlunoExemplar");

            // Chave composta (IdAluno e IdExemplar) na tabela AlunoExemplar criada pelo modificador new...
            HasKey(alunoexemplar => new { alunoexemplar.IdAluno, alunoexemplar.IdExemplar });

            Property(alunoexemplar => alunoexemplar.IdAluno).HasColumnName("IdAluno").IsRequired();
            Property(alunoexemplar => alunoexemplar.IdExemplar).HasColumnName("IdExemplar").IsRequired();

            Property(alunoexemplar => alunoexemplar.CodigoAluno).HasColumnName("CodigoUsuario").IsRequired();
            Property(alunoexemplar => alunoexemplar.CodigoExemplar).HasColumnName("CodigoExemplar").IsRequired();
            Property(alunoexemplar => alunoexemplar.DataHoraInicio).HasColumnName("DataHoraInicio").IsRequired();
            Property(alunoexemplar => alunoexemplar.DataHoraFim).HasColumnName("DataHoraFim").IsRequired();
            Property(alunoexemplar => alunoexemplar.QuantidadeDiasEmprestimo).HasColumnName("QuantidadeDiasEmprestimo").IsRequired();

            #endregion

            #region Associações

            HasRequired(alunoexemplar => alunoexemplar.Aluno)
            .WithMany(aluno => aluno.AlunoExemplar)
            .HasForeignKey(alunoexemplar => alunoexemplar.IdAluno);

            //_______________________________________________________________________

            HasRequired(alunoexemplar => alunoexemplar.Exemplar)
            .WithMany(exemplar => exemplar.AlunoExemplar)
            .HasForeignKey(alunoexemplar => alunoexemplar.IdExemplar);

            #endregion
        }
    }
}