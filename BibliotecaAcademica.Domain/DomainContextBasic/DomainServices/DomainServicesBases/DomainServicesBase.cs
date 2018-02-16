using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDBases;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainServices.DomainServicesBases
{
    public abstract class DomainServicesBase<TEntity> : IContractsDomainServicesBase<TEntity> where TEntity : class
    {
        #region Atributo

        private IContractsSGBDBase<TEntity> domainServiceSBase;

        #endregion

        #region Construtor

        public DomainServicesBase(IContractsSGBDBase<TEntity> domainServiceSBase)
        {
            this.domainServiceSBase = domainServiceSBase;
        }

        #endregion

        #region Implementação dos Métodos Base

        public void DomainServiceAtualizar(TEntity entity)
        {
            this.DomainServiceAtualizar(entity);
        }

        public void DomainServiceExcluir(TEntity entity)
        {
            this.DomainServiceExcluir(entity);
        }

        public void DomainServiceInserir(TEntity entity)
        {
            this.DomainServiceInserir(entity);
        }

        public TEntity DomainServicePesquisarPorCodigo(string codigoUsuario)
        {
            return this.DomainServicePesquisarPorCodigo(codigoUsuario);
        }

        public void DomainServiceRealizarLogin(TEntity entity)
        {
            this.DomainServiceRealizarLogin(entity);
        }

        #endregion
    }
}