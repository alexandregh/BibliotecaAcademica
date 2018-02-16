using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Abstracts.Usuarios
{
    public abstract class Usuario
    {
        #region Propriedades

        public string CodigoUsuario { get; protected set; }
        public string Nome { get; protected set; }
        public string Sobrenome { get; protected set; }
        public string Email { get; protected set; }
        public TipoUsuario TipoUsuario { get; protected set; }

        #endregion
    }
}