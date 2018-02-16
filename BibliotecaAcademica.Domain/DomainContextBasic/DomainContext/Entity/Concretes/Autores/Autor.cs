using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AutoresLivros;
using System;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Autores
{
    public class Autor
    {
        #region Variáveis

        Guid idAutor, codigoAutor;

        #endregion

        #region Propriedades

        public string IdAutor { get; private set; }
        public string CodigoAutor { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Telefone Telefone { get; private set; }

        #endregion

        #region Construtor

        public Autor()
        {
            idAutor = Guid.NewGuid();
            this.IdAutor = idAutor.ToString().Replace("-", "");
            this.IdAutor = this.IdAutor.Remove(16);
            idAutor = Guid.Empty;
            this.SetIdAutor(IdAutor);

            codigoAutor = Guid.NewGuid();
            this.CodigoAutor = codigoAutor.ToString().Replace("-", "");
            this.CodigoAutor = this.CodigoAutor.Remove(6);
            codigoAutor = Guid.Empty;
            this.SetCodigoAutor(CodigoAutor);
        }

        #endregion

        #region Comportamentos

        private void SetIdAutor(string IdAutor)
        {
            try
            {
                int qtdIdAutor = 0;
                if (!String.IsNullOrEmpty(IdAutor))
                {
                    qtdIdAutor = IdAutor.Length;
                }
                if (qtdIdAutor == 16)
                {
                    this.GetIdAutor();
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao gerar o campo Id do Autor. Tente outra vez.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetIdAutor()
        {
            return this.IdAutor;
        }

        //_____________________________________________

        public void SetCodigoAutor(string CodigoAutor)
        {
            try
            {
                int qtdCodigoAutor = 0;
                if (!String.IsNullOrEmpty(CodigoAutor))
                {
                    qtdCodigoAutor = CodigoAutor.Length;
                }
                if (qtdCodigoAutor == 6)
                {
                    this.GetCodigoAutor();
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao gerar o campo Código de Autor. Tente outra vez.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetCodigoAutor()
        {
            return this.CodigoAutor;
        }

        //_____________________________________________

        public void SetNome(string Nome)
        {
            try
            {
                if (string.IsNullOrEmpty(Nome))
                {
                    throw new Exception("Campo Nome do Autor obrigatório.");
                }
                if (Nome.Length < 3 || Nome.Length > 25)
                {
                    throw new Exception("Campo Nome do Autor fora do interválo válido de 3 até 25 caracteres.");
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

        public void SetSobrenome(string Sobrenome)
        {
            try
            {
                if (string.IsNullOrEmpty(Sobrenome))
                {
                    throw new Exception("Campo Sobrenome do Autor obrigatório.");
                }
                if (Sobrenome.Length < 3 || Sobrenome.Length > 50)
                {
                    throw new Exception("Campo Sobrenome do Autor fora do intervalo válido de 3 até 50 caracteres.");
                }
                else
                {
                    this.Sobrenome = Sobrenome;
                    this.GetSobrenome();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetSobrenome()
        {
            return this.Sobrenome;
        }

        #endregion

        #region Associações

        public virtual ICollection<AutorLivro> AutorLivro { get; set; } // Autores publicam Livros.

        #endregion
    }
}