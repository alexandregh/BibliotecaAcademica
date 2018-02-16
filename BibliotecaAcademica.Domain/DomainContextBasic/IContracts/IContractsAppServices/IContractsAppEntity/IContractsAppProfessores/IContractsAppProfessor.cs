using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum._Status;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppBases;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppProfessores
{
    public interface IContractsAppProfessor : IContractsAppBase<Professor>
    {
        #region Declaração dos Métodos do Professor

        // Métodos de Pesquisa do Professor...
        Professor AppPesquisarProfessorPorNome(string nome, string email);
        Professor AppPesquisarProfessorPorSobrenome(string sobrenome, string email);
        Professor AppPesquisarProfessorPorEmail(string email);

        // Métodos de Pesquisa do Aluno...
        Aluno AppPesquisarAlunoPorEmail(string email);
        Aluno AppPesquisarAlunoPorNome(string nome);
        Aluno AppPesquisarAlunoPorSobrenome(string sobrenome);
        Aluno AppPesquisarAlunoPorNomeSobrenome(string nome, string sobrenome);

        //__________________________________________

        ICollection<Aluno> AppPesquisarAlunosPorNome(string nome);
        ICollection<Aluno> AppPesquisarAlunosPorSobrenome(string sobrenome);
        ICollection<Aluno> AppPesquisarAlunosPorNomeSobrenome(string nome, string sobrenome);
        ICollection<Aluno> AppPesquisarAlunosPorStatus(Status status);

        #endregion
    }
}