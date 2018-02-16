using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDBases;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDAlunos
{
    public interface IContractsSGBDAluno : IContractsSGBDBase<Aluno>
    {
        #region Declaração dos Métodos do Aluno

        // Métodos de Pesquisa...
        Aluno PersistencePesquisarPorEmailCodigo(string email, string codigo);
        Aluno PersistencePesquisarPorNome(string nome, string email);
        Aluno PersistencePesquisarPorSobrenome(string sobrenome, string email);
        Aluno PersistencePesquisarPorEmail(string email);

        #endregion
    }
}