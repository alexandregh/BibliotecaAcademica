using BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsAlunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Abstracts.Usuarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum._Status;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue.Endereco;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AlunosExemplares;
using System;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos
{
    public class Aluno : Usuario
    {
        #region Variáveis

        Guid idAluno, codigoUsuario;

        #endregion

        #region Propriedades

        public string IdAluno { get; private set; }
        public Status Status { get; private set; }
        public Telefone Telefone { get; private set; }
        public Endereco Endereco { get; private set; }

        #endregion

        #region Construtor

        public Aluno()
        {
            idAluno = Guid.NewGuid();
            this.IdAluno = idAluno.ToString().Replace("-","");
            this.IdAluno = this.IdAluno.Remove(16);
            idAluno = Guid.Empty;
            this.SetIdAluno(IdAluno);

            codigoUsuario = Guid.NewGuid();
            this.CodigoUsuario = codigoUsuario.ToString().Replace("-", "");
            this.CodigoUsuario = this.CodigoUsuario.Remove(6);
            codigoUsuario = Guid.Empty;
            this.SetCodigoUsuario(CodigoUsuario);
        }

        #endregion

        #region Comportamentos

        private void SetIdAluno(string IdAluno)
        {
            this.IdAluno = SecureValidationsAluno.ValidationsIdAluno(IdAluno);
        }

        public string GetIdAluno()
        {
            return this.IdAluno;
        }

        //_____________________________________________

        private void SetCodigoUsuario(string CodigoUsuario)
        {
            this.CodigoUsuario = SecureValidationsAluno.ValidationsCodigoUsuario(CodigoUsuario);
        }

        public string GetCodigoUsuario()
        {
            return this.CodigoUsuario;
        }

        //_____________________________________________

        public void SetNovoCodigoUsuario(string CodigoUsuario)
        {
            this.CodigoUsuario = SecureValidationsAluno.ValidationsNovoCodigoUsuario(CodigoUsuario);
        }

        public string GetNovoCodigoUsuario()
        {
            return this.CodigoUsuario;
        }

        //_____________________________________________

        public void SetNome(string Nome)
        {
            this.Nome = SecureValidationsAluno.ValidationsNome(Nome);
        }

        public string GetNome()
        {
            return this.Nome;
        }

        //_____________________________________________

        public void SetSobrenome(string Sobrenome)
        {
            this.Sobrenome = SecureValidationsAluno.ValidationSobrenome(Sobrenome);
        }

        public string GetSobrenome()
        {
            return this.Sobrenome;
        }

        //_____________________________________________

        public void SetEmail(string Email)
        {
            this.Email = SecureValidationsAluno.ValidationsEmail(Email);
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
                this.TipoUsuario = (TipoUsuario)SecureValidationsAluno.ValidationsTipoUsuario(Convert.ToInt16(TipoUsuario));
            }
            catch(FormatException ex)
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

        public void SetTelefone(Telefone telefone)
        {
            this.Telefone = (Telefone)SecureValidationsAluno.ValidationsTelefone(telefone.DDD, telefone.Numero);
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
                this.Endereco = (Endereco)SecureValidationsAluno.ValidationsEndereco(Convert.ToInt16(endereco.Logradouro), endereco.Numero, endereco.Complemento, endereco.CEP, Convert.ToInt16(endereco.Zona));
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

        //_____________________________________________

        public void SetStatus(Status status)
        {
            try
            {
                this.Status = (Status)SecureValidationsAluno.ValidationStatus(Convert.ToInt16(status));
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

        public Status GetStatus()
        {
            return this.Status;
        }

        #endregion

        #region Associações

        public virtual ICollection<AlunoExemplar> AlunoExemplar { get; set; } // Aluno solicita empréstimo(s) de Exemplar(es).

        #endregion
    }
}