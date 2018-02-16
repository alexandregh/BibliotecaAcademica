using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Autores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Editoras;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Funcionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AlunosExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AutoresLivros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosLivros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.ProfessoresExemplares;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsAlunos;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsAutores;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsEditoras;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsExemplares;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsFuncionarios;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsLivros;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsEntity.ConfigurationsProfessores;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsAlunosExemplares;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsAutoresLivros;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsFuncionariosExemplares;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsFuncionariosLivros;
using BibliotecaAcademica.SGBD.Configurations.ConfigurationsRelationship.ConfigurationsProfessoresExemplares;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BibliotecaAcademica.SGBD.Context
{
    public class DataContext : DbContext
    {
        #region Construtor

        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["dbBibliotecaAcademica"].ConnectionString)
        {
            
        }

        #endregion

        #region DbSetEntity

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Editora> Editora { get; set; }
        public DbSet<Exemplar> Exemplar { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        //public DbSet<Livro> Livro { get; set; }
        public DbSet<Professor> Professor { get; set; }

        #endregion

        #region DbSetRelationship

        public DbSet<AlunoExemplar> AlunoExemplar { get; set; }
        public DbSet<AutorLivro> AutorLivro { get; set; }
        public DbSet<FuncionarioExemplar> FuncionarioExemplar { get; set; }
        public DbSet<FuncionarioLivro> FuncionarioLivro { get; set; }
        public DbSet<ProfessorExemplar> ProfessorExemplar { get; set; }

        #endregion

        #region OnModelCreating

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            // Configurations
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //__________________________________________

            // Configurations Data Type
            //modelBuilder.Properties<string>().Configure(entity => entity.HasColumnType("varchar"));
            //modelBuilder.Properties<DateTime>().Configure(entity => entity.HasColumnType("smalldatetime"));

            //__________________________________________

            // Configurations Entity
            modelBuilder.Configurations.Add(new ConfigurationsAluno());
            modelBuilder.Configurations.Add(new ConfigurationsAutor());
            modelBuilder.Configurations.Add(new ConfigurationsEditora());
            modelBuilder.Configurations.Add(new ConfigurationsExemplar());
            modelBuilder.Configurations.Add(new ConfigurationsFuncionario());
            modelBuilder.Configurations.Add(new ConfigurationsLivro());
            modelBuilder.Configurations.Add(new ConfigurationsProfessor());

            //__________________________________________

            // Configurations Relationship
            modelBuilder.Configurations.Add(new ConfigurationsAlunoExemplar());
            modelBuilder.Configurations.Add(new ConfigurationsAutorLivro());
            modelBuilder.Configurations.Add(new ConfigurationsFuncionarioExemplar());
            modelBuilder.Configurations.Add(new ConfigurationsFuncionarioLivro());
            modelBuilder.Configurations.Add(new ConfigurationsProfessorExemplar());
        }

        #endregion        
    }
}