using BibliotecaAcademica.CommonValidationPersistence.MessageValidations.MessageValidationsBases;
using System;

namespace BibliotecaAcademica.CommonValidationPersistence.MessageValidations.SecureValidationsBases
{
    public static class SecureValidationsBase<TEntity> where TEntity : class
    {
        #region Implementação das Validações Base

        public static TEntity ValidationsTEntity(TEntity entity)
        {
            if (entity == null)
            {
                throw new Exception(MessageBase.MessageValidationEntityIsNullOrEmpty);
            }
            else
            {
                return entity;
            }
        }

        //_____________________________________________

        public static string ValidationsPesquisarPorCodigo(string codigoUsuario)
        {
            if (string.IsNullOrEmpty(codigoUsuario))
            {
                throw new Exception(MessageBase.MessageValidationCodigoUsuarioIsNullOrEmpty);
            }
            else
            {
                return codigoUsuario;
            }
        }

        //_____________________________________________

        public static TEntity ValidationsLogin(TEntity entity)
        {
            // LOGICA.............

            return entity;
        }

        #endregion
    }
}