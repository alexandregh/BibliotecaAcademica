using BibliotecaAcademica.CommonValidationPersistence.MessageValidations.MessageValidationsBases;
using BibliotecaAcademica.CommonValidationPersistence.MessageValidations.SecureValidationsBases;
using BibliotecaAcademica.Domain.DomainContextBasic.IContracts.IContractsInfraEstructure.IContractsSGBDServices.IContractsSGBDBases;
using BibliotecaAcademica.SGBD.Context;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Transactions;

namespace BibliotecaAcademica.SGBD.Repository.RepositoryBases
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IContractsSGBDBase<TEntity> where TEntity : class
    {
        #region Atributo

        protected DataContext dataContext;
        protected DbContextTransaction transacaoBD;

        #endregion

        #region Construtor

        public RepositoryBase()
        {
            dataContext = new DataContext();
        }

        #endregion

        #region Implementação dos Métodos Base

        public void PersistenceAtualizar(TEntity entity)
        {
            entity = SecureValidationsBase<TEntity>.ValidationsTEntity(entity);
            if (entity != null)
            {
                try
                {
                    using (TransactionScope transacao = new TransactionScope())
                    {
                        dataContext.Entry(entity).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        transacao.Complete();
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new DbUpdateConcurrencyException(nameof(ex.Message));
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null)
                    {
                        throw new Exception("Ocorreu o erro: " + String.Concat(ex.InnerException.StackTrace, ex.InnerException.Message + ". Aguarde alguns instantes e tente novamente."));
                    }
                    throw new DbUpdateException(nameof(ex.Message));
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                catch (NotSupportedException ex)
                {
                    throw new NotSupportedException(nameof(ex.Message));
                }
                catch (ObjectDisposedException ex)
                {
                    throw new ObjectDisposedException(nameof(ex.Message));
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageBase.MessageValidationAtualizar);
            }            
        }

        //_________________________________________________

        public void PersistenceExcluir(TEntity entity)
        {
            entity = SecureValidationsBase<TEntity>.ValidationsTEntity(entity);
            if (entity != null)
            {
                try
                {
                    using (TransactionScope transacao = new TransactionScope())
                    {
                        dataContext.Entry(entity).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        transacao.Complete();
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new DbUpdateConcurrencyException(nameof(ex.Message));
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null)
                    {
                        throw new Exception("Ocorreu o erro: " + String.Concat(ex.InnerException.StackTrace, ex.InnerException.Message + ". Aguarde alguns instantes e tente novamente."));
                    }
                    throw new DbUpdateException(nameof(ex.Message));
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                catch (NotSupportedException ex)
                {
                    throw new NotSupportedException(nameof(ex.Message));
                }
                catch (ObjectDisposedException ex)
                {
                    throw new ObjectDisposedException(nameof(ex.Message));
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageBase.MessageValidationExcluir);
            }
        }

        //_________________________________________________

        public void PersistenceInserir(TEntity entity)
        {
            entity = SecureValidationsBase<TEntity>.ValidationsTEntity(entity);
            if (entity != null)
            {
                try
                {
                    using (TransactionScope transacao = new TransactionScope())
                    {
                        dataContext.Entry(entity).State = EntityState.Added;
                        dataContext.SaveChanges();
                        transacao.Complete();
                    }
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw new DbUpdateConcurrencyException(nameof(ex.Message));
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null)
                    {
                        throw new Exception(nameof(ex.Message));
                    }
                    throw new Exception(nameof(ex.Message));
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                catch (NotSupportedException ex)
                {
                    throw new NotSupportedException(nameof(ex.Message));
                }
                catch (ObjectDisposedException ex)
                {
                    throw new ObjectDisposedException(nameof(ex.Message));
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageBase.MessageValidationInserir);
            }
        }

        //_________________________________________________

        public TEntity PersistencePesquisarPorCodigo(string codigoUsuario)
        {
            codigoUsuario = SecureValidationsBase<TEntity>.ValidationsPesquisarPorCodigo(codigoUsuario);
            if (codigoUsuario != null)
            {
                try
                {
                    TEntity entidade = dataContext.Set<TEntity>().Find(codigoUsuario);
                    return entidade;
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageBase.MessageValidationCodigoUsuario);
            }
        }

        //_________________________________________________        

        public void PersistenceRealizarLogin(TEntity entity)
        {
            entity = SecureValidationsBase<TEntity>.ValidationsLogin(entity);
            if(entity != null)
            {
                // REALIZAR LOGIN.............
            }
            else
            {
                this.Dispose(true);
                throw new Exception(MessageBase.MessageValidationLogin);
            }
        }

        #endregion

        #region Implementação do Método Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources

            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }     

        #endregion
    }
}