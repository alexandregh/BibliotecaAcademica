using BibliotecaAcademica.App.AppServices.AppServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppEntity.IContractsAppAlunos;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAlunos;

namespace BibliotecaAcademica.App.AppServices.AppServicesEntity.AppServicesAlunos
{
    public class AppServicesAluno : AppServicesBase<Aluno>, IContractsAppAluno
    {
        #region Atributo

        private IContractsDomainServicesAluno appServicesAluno;

        #endregion

        #region Construtor

        public AppServicesAluno(IContractsDomainServicesAluno appServicesAluno)
            :base(appServicesAluno)
        {
            this.appServicesAluno = appServicesAluno;
        }

        #endregion

        #region Implementação dos Métodos Aluno

        public Aluno AppPesquisarPorEmail(string email)
        {
            return this.AppPesquisarPorEmail(email);
        }

        public Aluno AppPesquisarPorEmailCodigo(string email, string codigo)
        {
            return this.AppPesquisarPorEmailCodigo(email, codigo);
        }

        public Aluno AppPesquisarPorNome(string nome, string email)
        {
            return this.AppPesquisarPorNome(nome, email);
        }

        public Aluno AppPesquisarPorSobrenome(string sobrenome, string email)
        {
            return this.AppPesquisarPorSobrenome(sobrenome, email);
        }

        #endregion
    }
}