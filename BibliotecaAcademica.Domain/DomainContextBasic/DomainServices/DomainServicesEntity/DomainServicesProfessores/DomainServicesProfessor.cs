using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum._Status;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesProfessores;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDProfessores;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesProfessores
{
    public class DomainServicesProfessor : DomainServicesBase<Professor>, IContractsDomainServicesProfessor
    {
        #region Atributo

        private IContractsSGBDProfessor serviceProfessor;

        #endregion

        #region Construtor

        public DomainServicesProfessor(IContractsSGBDProfessor serviceProfessor)
            : base(serviceProfessor)
        {
            this.serviceProfessor = serviceProfessor;
        }

        #endregion

        #region Implementação dos Métodos do Professor

        // Aluno...
        public Aluno DomainServicePesquisarAlunoPorEmail(string email)
        {
            return this.DomainServicePesquisarAlunoPorEmail(email);
        }

        public Aluno DomainServicePesquisarAlunoPorNome(string nome)
        {
            return this.DomainServicePesquisarAlunoPorNome(nome);
        }

        public Aluno DomainServicePesquisarAlunoPorNomeSobrenome(string nome, string sobrenome)
        {
            return this.DomainServicePesquisarAlunoPorNomeSobrenome(nome, sobrenome);
        }

        public Aluno DomainServicePesquisarAlunoPorSobrenome(string sobrenome)
        {
            return this.DomainServicePesquisarAlunoPorSobrenome(sobrenome);
        }

        public ICollection<Aluno> DomainServicePesquisarAlunosPorNome(string nome)
        {
            return this.DomainServicePesquisarAlunosPorNome(nome);
        }

        public ICollection<Aluno> DomainServicePesquisarAlunosPorNomeSobrenome(string nome, string sobrenome)
        {
            return this.DomainServicePesquisarAlunosPorNomeSobrenome(nome, sobrenome);
        }

        public ICollection<Aluno> DomainServicePesquisarAlunosPorSobrenome(string sobrenome)
        {
            return this.DomainServicePesquisarAlunosPorSobrenome(sobrenome);
        }

        public ICollection<Aluno> DomainServicePesquisarAlunosPorStatus(Status status)
        {
            return this.DomainServicePesquisarAlunosPorStatus(status);
        }

        // Professor...
        public Professor DomainServicePesquisarProfessorPorEmail(string email)
        {
            return this.DomainServicePesquisarProfessorPorEmail(email);
        }

        public Professor DomainServicePesquisarProfessorPorNome(string nome, string email)
        {
            return this.DomainServicePesquisarProfessorPorNome(nome, email);
        }

        public Professor DomainServicePesquisarProfessorPorSobrenome(string sobrenome, string email)
        {
            return this.DomainServicePesquisarProfessorPorSobrenome(sobrenome, email);
        }

        #endregion
    }
}