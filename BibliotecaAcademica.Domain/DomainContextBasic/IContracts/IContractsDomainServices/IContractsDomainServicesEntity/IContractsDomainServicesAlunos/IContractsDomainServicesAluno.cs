using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesBases;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAlunos
{
    public interface IContractsDomainServicesAluno : IContractsDomainServicesBase<Aluno>
    {
        #region Declaração dos Métodos do Aluno

        // Métodos de Pesquisa...
        Aluno DomainServicePesquisarPorEmailCodigo(string email, string codigo);
        Aluno DomainServicePesquisarPorNome(string nome, string email);
        Aluno DomainServicePesquisarPorSobrenome(string sobrenome, string email);
        Aluno DomainServicePesquisarPorEmail(string email);

        #endregion
    }
}