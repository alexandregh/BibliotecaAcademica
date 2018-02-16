using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsDomainServices.IContractsDomainServicesBases;

namespace BibliotecaAcademica.App.AppServices.AppServicesBases
{
    public abstract class AppServicesBase<TEntity> : IContractsAppBase<TEntity> where TEntity : class
    {
        #region Atributo

        private IContractsDomainServicesBase<TEntity> appServicesBase;

        #endregion

        #region Construtor

        public AppServicesBase(IContractsDomainServicesBase<TEntity> appServicesBase)
        {
            this.appServicesBase = appServicesBase;
        }

        #endregion

        #region Implementação dos Métodos Base

        public void AppAtualizar(TEntity entity)
        {
            this.AppAtualizar(entity);
        }

        //_________________________________________

        public void AppExcluir(TEntity entity)
        {
            this.AppExcluir(entity);
        }

        //_________________________________________

        public void AppInserir(TEntity entity)
        {
            this.AppInserir(entity);
        }

        //_________________________________________

        public TEntity AppPesquisarPorCodigo(string codigoUsuario)
        {
            return this.AppPesquisarPorCodigo(codigoUsuario);
        }

        //_________________________________________

        public void AppRealizarLogin(TEntity entity)
        {
            this.AppRealizarLogin(entity);
        }

        #endregion
    }
}