using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAlunos;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDAlunos;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesAlunos
{
    public class DomainServicesAluno : DomainServicesBase<Aluno>, IContractsDomainServicesAluno
    {
        #region Atributo

        private IContractsSGBDAluno serviceAluno;

        #endregion

        #region Construtor

        public DomainServicesAluno(IContractsSGBDAluno serviceAluno)
            : base(serviceAluno)
        {
            this.serviceAluno = serviceAluno;
        }

        #endregion

        #region Implementação dos Métodos do Aluno

        public Aluno DomainServicePesquisarPorEmail(string email)
        {
            return this.DomainServicePesquisarPorEmail(email);
        }

        public Aluno DomainServicePesquisarPorEmailCodigo(string email, string codigo)
        {
            return this.DomainServicePesquisarPorEmailCodigo(email, codigo);
        }

        public Aluno DomainServicePesquisarPorNome(string nome, string email)
        {
            return this.DomainServicePesquisarPorNome(nome, email);
        }

        public Aluno DomainServicePesquisarPorSobrenome(string sobrenome, string email)
        {
            return this.DomainServicePesquisarPorSobrenome(sobrenome, email);
        }

        #endregion
    }
}