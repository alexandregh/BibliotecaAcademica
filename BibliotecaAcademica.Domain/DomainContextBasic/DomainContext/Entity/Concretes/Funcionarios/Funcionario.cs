using BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsFuncionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Abstracts.Usuarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum.TiposFuncionarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue.Endereco;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosLivros;
using System;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Funcionarios
{
    public class Funcionario : Usuario
    {
        #region Variáveis

        Guid idFuncionario, codigoUsuario;

        #endregion

        #region Propriedades

        public string IdFuncionario { get; private set; }
        public Telefone Telefone { get; private set; }
        public Endereco Endereco { get; private set; }
        public TipoFuncionario TipoFuncionario { get; private set; }

        #endregion

        #region Construtor

        public Funcionario()
        {
            idFuncionario = Guid.NewGuid();
            this.IdFuncionario = idFuncionario.ToString().Replace("-", "");
            this.IdFuncionario = this.IdFuncionario.Remove(16);
            idFuncionario = Guid.Empty;
            this.SetIdFuncionario(IdFuncionario);

            codigoUsuario = Guid.NewGuid();
            this.CodigoUsuario = codigoUsuario.ToString().Replace("-", "");
            this.CodigoUsuario = this.CodigoUsuario.Remove(6);
            codigoUsuario = Guid.Empty;
            this.SetCodigoUsuario(CodigoUsuario);
        }

        #endregion

        #region Comportamentos

        private void SetIdFuncionario(string IdFuncionario)
        {
            this.IdFuncionario = SecureValidationsFuncionario.ValidationsIdFuncionario(IdFuncionario);
        }

        public string GetIdProfessor()
        {
            return this.IdFuncionario;
        }

        //_____________________________________________

        private void SetCodigoUsuario(string CodigoUsuario)
        {
            this.CodigoUsuario = SecureValidationsFuncionario.ValidationsCodigoUsuario(CodigoUsuario);
        }

        public string GetCodigoUsuario()
        {
            return this.CodigoUsuario;
        }

        //_____________________________________________

        public void SetNovoCodigoUsuario(string CodigoUsuario)
        {
            this.CodigoUsuario = SecureValidationsFuncionario.ValidationsNovoCodigoUsuario(CodigoUsuario);
        }

        public string GetNovoCodigoUsuario()
        {
            return this.CodigoUsuario;
        }

        //_____________________________________________

        public void SetNome(string Nome)
        {
            this.Nome = SecureValidationsFuncionario.ValidationsNome(Nome);
        }

        public string GetNome()
        {
            return this.Nome;
        }

        //_____________________________________________

        public void SetSobrenome(string Sobrenome)
        {
            this.Sobrenome = SecureValidationsFuncionario.ValidationsSobrenome(Sobrenome);
        }

        public string GetSobrenome()
        {
            return this.Sobrenome;
        }

        //_____________________________________________

        public void SetEmail(string Email)
        {
            this.Email = SecureValidationsFuncionario.ValidationsEmail(Email);
        }

        public string GetEmail()
        {
            return this.Email;
        }

        //_____________________________________________

        public void SetTipoUsuario(TipoUsuario TipoUsuario)
        {
            try
            {
                this.TipoUsuario = (TipoUsuario)SecureValidationsFuncionario.ValidationsTipoUsuario(Convert.ToInt32(TipoUsuario));
            }
            catch (FormatException ex)
            {
                throw new FormatException(nameof(ex.Message));
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidCastException(nameof(ex.Message));
            }
            catch (OverflowException ex)
            {
                throw new OverflowException(nameof(ex.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public TipoUsuario GetTipoUsuario()
        {
            return this.TipoUsuario;
        }

        //_____________________________________________

        public void SetTipoFuncionario(TipoFuncionario TipoFuncionario)
        {
            try
            {
                this.TipoFuncionario = (TipoFuncionario)SecureValidationsFuncionario.ValidationsTipoFuncionario(Convert.ToInt32(TipoFuncionario));   
            }
            catch (FormatException ex)
            {
                throw new FormatException(nameof(ex.Message));
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidCastException(nameof(ex.Message));
            }
            catch (OverflowException ex)
            {
                throw new OverflowException(nameof(ex.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public TipoFuncionario GetTipoFuncionario()
        {
            return this.TipoFuncionario;
        }

        //_____________________________________________

        public void SetTelefone(Telefone telefone)
        {
            this.Telefone = (Telefone)SecureValidationsFuncionario.ValidationsTelefone(telefone.DDD, telefone.Numero);
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
                this.Endereco = (Endereco)SecureValidationsFuncionario.ValidationsEndereco(Convert.ToInt16(endereco.Logradouro), endereco.Numero, endereco.Complemento, endereco.CEP, Convert.ToInt16(endereco.Zona));
            }
            catch (FormatException ex)
            {
                throw new FormatException(nameof(ex.Message));
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidCastException(nameof(ex.Message));
            }
            catch (OverflowException ex)
            {
                throw new OverflowException(nameof(ex.Message));
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

        public virtual ICollection<FuncionarioExemplar> FuncionarioExemplar { get; set; } // Funcionário solicita empréstimo(s) de Exemplar(es).
        public virtual ICollection<FuncionarioLivro> FuncionarioLivro { get; set; } // Funcionários gerenciam Livros.

        #endregion
    }
}