using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Autores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AutoresLivros
{
    public class AutorLivro
    {
        #region Atributos / Associações

        // FK...
        public string IdLivro { get; private set; }
        public string IdAutor { get; private set; }
        public string CodigoLivro { get; private set; }
        public string CodigoAutor { get; private set; }
        public string NomeAutor { get; private set; }
        public string SobrenomeAutor { get; private set; }        
        public string NomeLivro { get; private set; }
        public string NomeEditora { get; private set; }

        // Navigate...
        public virtual Autor Autor { get; set; }
        public virtual Livro Livro { get; set; }

        #endregion

        #region Construtor

        public AutorLivro()
        {

        }

        #endregion

        #region Comportamentos



        #endregion
    }
}