using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue.AreaConhecimento;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Autores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Editoras;
using System;
using System.Collections.Generic;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosLivros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AutoresLivros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros
{
    public class Livro
    {
        #region Variáveis

        Guid idLivro, codigoLivro;

        #endregion

        #region Propriedades

        public string IdLivro { get; private set; }
        public string CodigoLivro { get; private set; }
        public string Nome { get; private set; }
        public string PalavraChave { get; private set; }
        public AreaConhecimento AreaConhecimento { get; private set; }

        // FK...
        public string IdEditora { get; set; }
        public string IdAutor { get; set; }

        #endregion

        #region Construtor

        public Livro()
        {
            idLivro = Guid.NewGuid();
            this.IdLivro = idLivro.ToString().Replace("-", "");
            this.IdLivro = this.IdLivro.Remove(16);
            idLivro = Guid.Empty;
            this.SetIdLivro(IdLivro);

            codigoLivro = Guid.NewGuid();
            this.CodigoLivro = codigoLivro.ToString().Replace("-", "");
            this.CodigoLivro = this.CodigoLivro.Remove(6);
            codigoLivro = Guid.Empty;
            this.SetCodigoLivro(CodigoLivro);
        }

        #endregion

        #region Comportamentos

        private void SetIdLivro(string IdLivro)
        {
            try
            {
                int qtdIdLivro = 0;
                if (!String.IsNullOrEmpty(IdLivro))
                {
                    qtdIdLivro = IdLivro.Length;
                }
                if (qtdIdLivro == 16)
                {
                    this.GetIdAluno();
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao gerar o campo Id do Livro. Tente outra vez.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetIdAluno()
        {
            return this.IdLivro;
        }

        //_____________________________________________

        private void SetCodigoLivro(string CodigoLivro)
        {
            try
            {
                int qtdCodigoUsuario = 0;
                if (!String.IsNullOrEmpty(CodigoLivro))
                {
                    qtdCodigoUsuario = CodigoLivro.Length;
                }
                if (qtdCodigoUsuario == 6)
                {
                    this.GetCodigoUsuario();
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao gerar o campo Código do Livro. Tente outra vez.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetCodigoUsuario()
        {
            return this.CodigoLivro;
        }

        //_____________________________________________

        public void SetNome(string Nome)
        {
            try
            {
                if (string.IsNullOrEmpty(Nome))
                {
                    throw new Exception("Campo Nome do Livro obrigatório.");
                }
                if (Nome.Length < 3 || Nome.Length > 80)
                {
                    throw new Exception("Campo Nome do Livro fora do interválo válido de 3 até 80 caracteres.");
                }
                else
                {
                    this.Nome = Nome;
                    this.GetNome();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetNome()
        {
            return this.Nome;
        }

        //_____________________________________________

        public void SetPalavraChave(string PalavraChave)
        {
            try
            {
                if (PalavraChave.Length < 3)
                {
                    throw new Exception("Campo Palavra-Chave do Livro menor que 3 caracteres.");
                }
                else
                {
                    this.PalavraChave = PalavraChave;
                    this.GetPalavraChave();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetPalavraChave()
        {
            return this.PalavraChave;
        }

        //_____________________________________________

        public void SetAutores(Autor Autor)
        {
            try
            {
                if (Autor == null)
                {
                    throw new Exception("Autor do Livro obrigatório.");
                }
                else
                {
                    this.Autor = Autor;
                    this.GetAutor();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public Autor GetAutor()
        {
            return this.Autor;
        }

        //_____________________________________________

        public void SetEditora(Editora Editora)
        {
            try
            {
                if (Editora == null)
                {
                    throw new Exception("Campo Editora do Livro obrigatório.");
                }
                else
                {
                    this.Editora = Editora;
                    this.GetEditora();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public Editora GetEditora()
        {
            return this.Editora;
        }

        //_____________________________________________

        public void SetAreaConhecimento(AreaConhecimento AreaConhecimento)
        {
            try
            {                
                this.AreaConhecimento = AreaConhecimento;
                this.GetAreaConhecimento();
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public AreaConhecimento GetAreaConhecimento()
        {
            return this.AreaConhecimento;
        }

        #endregion

        #region Associações

        public virtual ICollection<FuncionarioLivro> FuncionarioLivro { get; set; } // Livros são gerenciados pelos Funcionários.
        public virtual ICollection<AutorLivro> AutorLivro { get; set; } // Livros são publicados pelos Autores.
        public virtual ICollection<Exemplar> Exemplares { get; set; } // Livros possuem Exemplares.
        public virtual Editora Editora { get; set; } // Livros são publicados pela Editora.
        public virtual Autor Autor { get; set; } // Livro possue Autor.

        #endregion
    }
}