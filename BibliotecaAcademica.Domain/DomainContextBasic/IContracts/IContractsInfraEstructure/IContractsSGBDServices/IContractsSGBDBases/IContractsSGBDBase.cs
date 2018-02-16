using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;

namespace BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDBases
{
    public interface IContractsSGBDBase<TEntity> where TEntity : class
    {
        #region Declaração dos Métodos Base

        void PersistenceInserir(TEntity entity);
        void PersistenceAtualizar(TEntity entity);
        void PersistenceExcluir(TEntity entity);
        TEntity PersistencePesquisarPorCodigo(string codigoUsuario);
        void PersistenceRealizarLogin(TEntity entity);

        #endregion
    }
}