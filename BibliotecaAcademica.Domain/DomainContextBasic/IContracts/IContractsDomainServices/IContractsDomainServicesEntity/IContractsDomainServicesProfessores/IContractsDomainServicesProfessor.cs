using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum._Status;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesProfessores
{
    public interface IContractsDomainServicesProfessor : IContractsDomainServicesBase<Professor>
    {        
        #region Métodos de Pesquisas do Professor

        // Métodos de Pesquisa do Professor...
        Professor DomainServicePesquisarProfessorPorNome(string nome, string email);
        Professor DomainServicePesquisarProfessorPorSobrenome(string sobrenome, string email);
        Professor DomainServicePesquisarProfessorPorEmail(string email);

        // Métodos de Pesquisa do Aluno...
        Aluno DomainServicePesquisarAlunoPorEmail(string email);
        Aluno DomainServicePesquisarAlunoPorNome(string nome);
        Aluno DomainServicePesquisarAlunoPorSobrenome(string sobrenome);
        Aluno DomainServicePesquisarAlunoPorNomeSobrenome(string nome, string sobrenome);

        //__________________________________________

        ICollection<Aluno> DomainServicePesquisarAlunosPorNome(string nome);
        ICollection<Aluno> DomainServicePesquisarAlunosPorSobrenome(string sobrenome);
        ICollection<Aluno> DomainServicePesquisarAlunosPorNomeSobrenome(string nome, string sobrenome);
        ICollection<Aluno> DomainServicePesquisarAlunosPorStatus(Status status);

        #endregion
    }
}