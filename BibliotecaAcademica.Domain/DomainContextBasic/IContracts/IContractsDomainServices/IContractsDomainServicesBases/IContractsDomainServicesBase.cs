using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesBases
{
    public interface IContractsDomainServicesBase<TEntity> where TEntity : class
    {
        #region Declaração dos Métodos Base

        void DomainServiceInserir(TEntity entity);
        void DomainServiceAtualizar(TEntity entity);
        void DomainServiceExcluir(TEntity entity);
        TEntity DomainServicePesquisarPorCodigo(string codigoUsuario);
        void DomainServiceRealizarLogin(TEntity entity);

        #endregion
    }
}