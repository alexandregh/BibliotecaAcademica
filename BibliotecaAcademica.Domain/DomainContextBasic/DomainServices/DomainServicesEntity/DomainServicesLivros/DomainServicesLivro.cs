using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesLivros;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDEntity.IContractsSGBDLivros;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesEntity.DomainServicesLivros
{
    public class DomainServicesLivro : DomainServicesBase<Livro>, IContractsDomainServicesLivro
    {
        #region Atributo

        private IContractsSGBDLivro serviceLivro;

        #endregion

        #region Construtor

        public DomainServicesLivro(IContractsSGBDLivro serviceLivro)
            : base(serviceLivro)
        {
            this.serviceLivro = serviceLivro;
        }

        #endregion

        #region Implementação dos Métodos do Livro



        #endregion
    }
}