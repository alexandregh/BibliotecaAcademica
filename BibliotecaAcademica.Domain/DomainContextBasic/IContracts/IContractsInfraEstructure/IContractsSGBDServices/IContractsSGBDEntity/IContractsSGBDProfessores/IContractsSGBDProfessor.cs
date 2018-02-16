using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum._Status;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDBases;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDProfessores
{
    public interface IContractsSGBDProfessor : IContractsSGBDBase<Professor>
    {
        #region Métodos de Pesquisas do Professor

        // Métodos de Pesquisa do Professor...
        Professor PersistencePesquisarProfessorPorNome(string nome, string email);
        Professor PersistencePesquisarProfessorPorSobrenome(string sobrenome, string email);
        Professor DomainServicePesquisarProfessorPorEmail(string email);

        // Métodos de Pesquisa do Aluno...
        Aluno PersistencePesquisarAlunoPorEmail(string email);
        Aluno PersistencePesquisarAlunoPorNome(string nome);
        Aluno PersistencePesquisarAlunoPorSobrenome(string sobrenome);
        Aluno PersistencePesquisarAlunoPorNomeSobrenome(string nome, string sobrenome);

        //__________________________________________

        ICollection<Aluno> PersistencePesquisarAlunosPorNome(string nome);
        ICollection<Aluno> PersistencePesquisarAlunosPorSobrenome(string sobrenome);
        ICollection<Aluno> PersistencePesquisarAlunosPorNomeSobrenome(string nome, string sobrenome);
        ICollection<Aluno> PersistencePesquisarAlunosPorStatus(Status status);

        #endregion
    }
}