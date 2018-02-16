using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Funcionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesFuncionarios
{
    public interface IContractsDomainServicesFuncionario : IContractsDomainServicesBase<Funcionario>
    {
        #region Métodos de Serviços do Funcionário

        //void ExluirAlunoDomainService(Aluno entity);
        //void ExluirLivroDomainService(Livro entity);
        //void ExluirAlunoDomainService(Professor entity);

        #endregion

        #region Métodos de Pesquisas do Funcionário



        #endregion
    }
}