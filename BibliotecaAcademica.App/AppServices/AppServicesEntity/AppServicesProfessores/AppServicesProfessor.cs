using System.Collections.Generic;
using BibliotecaAcademica.App.AppServices.AppServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum._Status;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppProfessores;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesProfessores;

namespace BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesProfessores
{
    public class AppServicesProfessor : AppServicesBase<Professor>, IContractsAppProfessor
    {
        #region Atributo

        private IContractsDomainServicesProfessor appServicesProfessor;

        #endregion

        #region Construtor

        public AppServicesProfessor(IContractsDomainServicesProfessor appServicesProfessor)
            : base(appServicesProfessor)
        {
            this.appServicesProfessor = appServicesProfessor;
        }

        #endregion

        #region Implementação dos Métodos Professor

        // Aluno...
        public Aluno AppPesquisarAlunoPorEmail(string email)
        {
            return this.AppPesquisarAlunoPorEmail(email);
        }

        public Aluno AppPesquisarAlunoPorNome(string nome)
        {
            return this.AppPesquisarAlunoPorNome(nome);
        }

        public Aluno AppPesquisarAlunoPorNomeSobrenome(string nome, string sobrenome)
        {
            return this.AppPesquisarAlunoPorNomeSobrenome(nome, sobrenome);
        }

        public Aluno AppPesquisarAlunoPorSobrenome(string sobrenome)
        {
            return this.AppPesquisarAlunoPorSobrenome(sobrenome);
        }

        public ICollection<Aluno> AppPesquisarAlunosPorNome(string nome)
        {
            return this.AppPesquisarAlunosPorNome(nome);
        }

        public ICollection<Aluno> AppPesquisarAlunosPorNomeSobrenome(string nome, string sobrenome)
        {
            return this.AppPesquisarAlunosPorNomeSobrenome(nome, sobrenome);
        }

        public ICollection<Aluno> AppPesquisarAlunosPorSobrenome(string sobrenome)
        {
            return this.AppPesquisarAlunosPorSobrenome(sobrenome);
        }

        public ICollection<Aluno> AppPesquisarAlunosPorStatus(Status status)
        {
            return this.AppPesquisarAlunosPorStatus(status);
        }


        // Professor...
        public Professor AppPesquisarProfessorPorEmail(string email)
        {
            return this.AppPesquisarProfessorPorEmail(email);
        }

        public Professor AppPesquisarProfessorPorNome(string nome, string email)
        {
            return this.AppPesquisarProfessorPorNome(nome, email);
        }

        public Professor AppPesquisarProfessorPorSobrenome(string sobrenome, string email)
        {
            return this.AppPesquisarProfessorPorSobrenome(sobrenome, email);
        }

        #endregion
    }
}