using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsAppServices.IContractsAppBases
{
    public interface IContractsAppBase<TEntity> where TEntity : class
    {
        #region Declaração dos Métodos Base

        void AppInserir(TEntity entity);
        void AppAtualizar(TEntity entity);
        void AppExcluir(TEntity entity);
        TEntity AppPesquisarPorCodigo(string codigoUsuario);
        void AppRealizarLogin(TEntity entity);

        #endregion
    }
}