using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppBases;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppAlunos
{
    public interface IContractsAppAluno : IContractsAppBase<Aluno>
    {
        #region Declaração dos Métodos do Aluno

        // Métodos de Pesquisa...
        Aluno AppPesquisarPorEmailCodigo(string email, string codigo);
        Aluno AppPesquisarPorNome(string nome, string email);
        Aluno AppPesquisarPorSobrenome(string sobrenome, string email);
        Aluno AppPesquisarPorEmail(string email);

        #endregion
    }
}