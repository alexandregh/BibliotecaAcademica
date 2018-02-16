using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum._Status;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDProfessores;
using BibliotecaAcademica.SGBD.Repository.RepositoryBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAcademica.SGBD.Repository.RepositoryEntity.RepositoryProfessores
{
    public class RepositoryProfessor : RepositoryBase<Professor>, IContractsSGBDProfessor
    {
        #region Implementação dos Métodos do Professor

        public Professor DomainServicePesquisarProfessorPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Aluno PersistencePesquisarAlunoPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Aluno PersistencePesquisarAlunoPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Aluno PersistencePesquisarAlunoPorNomeSobrenome(string nome, string sobrenome)
        {
            throw new NotImplementedException();
        }

        public Aluno PersistencePesquisarAlunoPorSobrenome(string sobrenome)
        {
            throw new NotImplementedException();
        }

        public ICollection<Aluno> PersistencePesquisarAlunosPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public ICollection<Aluno> PersistencePesquisarAlunosPorNomeSobrenome(string nome, string sobrenome)
        {
            throw new NotImplementedException();
        }

        public ICollection<Aluno> PersistencePesquisarAlunosPorSobrenome(string sobrenome)
        {
            throw new NotImplementedException();
        }

        public ICollection<Aluno> PersistencePesquisarAlunosPorStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public Professor PersistencePesquisarProfessorPorNome(string nome, string email)
        {
            throw new NotImplementedException();
        }

        public Professor PersistencePesquisarProfessorPorSobrenome(string sobrenome, string email)
        {
            throw new NotImplementedException();
        }

        #endregion        
    }
}