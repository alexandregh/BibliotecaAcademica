using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue.Endereco;
using System;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Editoras
{
    public class Editora
    {
        #region Variáveis

        Guid idEditora, codigoEditora;

        #endregion

        #region Propriedades

        public string IdEditora { get; private set; }
        public string CodigoEditora { get; private set; }
        public string Nome { get; private set; }
        public Telefone Telefone { get; private set; }
        public Endereco Endereco { get; private set; }        

        #endregion

        #region Construtor

        public Editora()
        {
            idEditora = Guid.NewGuid();
            this.IdEditora = idEditora.ToString().Replace("-", "");
            this.IdEditora = this.IdEditora.Remove(16);
            idEditora = Guid.Empty;
            this.SetIdEditora(IdEditora);

            codigoEditora = Guid.NewGuid();
            this.CodigoEditora = codigoEditora.ToString().Replace("-", "");
            this.CodigoEditora = this.CodigoEditora.Remove(6);
            codigoEditora = Guid.Empty;
            this.SetCodigoUsuario(CodigoEditora);
        }

        #endregion

        #region Comportamentos

        public void SetIdEditora(string IdEditora)
        {
            try
            {
                int qtdIdEditora = 0;
                if (!String.IsNullOrEmpty(IdEditora))
                {
                    qtdIdEditora = IdEditora.Length;
                }
                if (qtdIdEditora == 16)
                {
                    this.GetIdEditora();
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao gerar o campo Id da Editora. Tente outra vez.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetIdEditora()
        {
            return this.IdEditora;
        }

        //_____________________________________________

        public void SetCodigoUsuario(string CodigoEditora)
        {
            try
            {
                int qtdCodigoEditora = 0;
                if (!String.IsNullOrEmpty(CodigoEditora))
                {
                    qtdCodigoEditora = CodigoEditora.Length;
                }
                if (qtdCodigoEditora == 6)
                {
                    this.GetCodigoEditora();
                }
                else
                {
                    throw new Exception("Ocorreu um erro ao gerar o campo Código da Editora. Tente outra vez.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public string GetCodigoEditora()
        {
            return this.CodigoEditora;
        }

        //_____________________________________________

        public void SetNome(string Nome)
        {
            try
            {
                if (string.IsNullOrEmpty(Nome))
                {
                    throw new Exception("Campo Nome da Editora obrigatório.");
                }
                if (Nome.Length < 3 || Nome.Length > 50)
                {
                    throw new Exception("Campo Nome do Aluno fora do interválo válido de 3 até 50 caracteres.");
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

        public void SetTelefone(Telefone telefone)
        {
            try
            {
                int qtdDDD = Convert.ToString(telefone.DDD).Length;
                int qtdNumero = Convert.ToString(telefone.Numero).Length;
                if (qtdDDD != 2)
                {
                    throw new Exception("Campo DDD do Telefone inválido.");
                }
                if (qtdNumero != 8 || qtdNumero != 9)
                {
                    throw new Exception("Campo Número do Telefone inválido.");
                }
                else
                {
                    this.Telefone = telefone;
                    this.GetTelefone();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public Telefone GetTelefone()
        {
            return this.Telefone;
        }

        //_____________________________________________

        public void SetEndereco(Endereco endereco)
        {
            try
            {
                if (string.IsNullOrEmpty(endereco.Logradouro.ToString()))
                {
                    throw new Exception("Campo Logradouro do Endereço da Editora obrigatório.");
                }
                if (string.IsNullOrEmpty(endereco.Numero.ToString()))
                {
                    throw new Exception("Campo Número do Endereço da Editora obrigatório.");
                }
                if (endereco.Complemento.Length < 3 && endereco.Complemento.Length > 250)
                {
                    throw new Exception("Campo Complemento do Endereço da Editora fora do intervalo válido de 3 até 150 caracteres.");
                }
                if (string.IsNullOrEmpty(endereco.CEP))
                {
                    throw new Exception("Campo CEP do Endereço da Editora obrigatório.");
                }
                if (string.IsNullOrEmpty(endereco.Zona.ToString()))
                {
                    throw new Exception("Campo Zona do Endereço da Editora obrigatório.");
                }
                else
                {
                    this.Endereco = endereco;
                    this.GetEndereco();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public Endereco GetEndereco()
        {
            return this.Endereco;
        }

        #endregion

        #region Associações

        public virtual ICollection<Livro> Livros { get; set; } // Editora publica Livros.

        #endregion
    }
}