using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Funcionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using System;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosLivros
{
    public class FuncionarioLivro
    {
        #region Atributos / Associações

        public string IdFuncionario { get; private set; }
        public string IdLivro { get; private set; }
        public string CodigoFuncionario { get; private set; }
        public string CodigoLivro { get; private set; }
        public DateTime DataHoraGerenciamento { get; private set; }
        public string Gerenciamento { get; private set; }

        //_________________________________________

        // Navigate...
        public virtual Funcionario Funcionario { get; set; }
        public virtual Livro Livro { get; set; }

        #endregion

        #region Construtor

        public FuncionarioLivro()
        {
            
        }

        #endregion

        #region Comportamentos



        #endregion
    }
}