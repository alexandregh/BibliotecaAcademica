using BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsProfessores;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Abstracts.Usuarios;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum._Status;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue.Endereco;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.ProfessoresExemplares;
using System;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores
{
    public class Professor : Usuario
    {
        #region Variáveis

        Guid idProfessor, codigoUsuario;

        #endregion

        #region Propriedades

        public string IdProfessor { get; private set; }
        public Status Status { get; private set; }
        public Telefone Telefone { get; private set; }
        public Endereco Endereco { get; private set; }        

        #endregion

        #region Construtor

        public Professor()
        {
            idProfessor = Guid.NewGuid();
            this.IdProfessor = idProfessor.ToString().Replace("-", "");
            this.IdProfessor = this.IdProfessor.Remove(16);
            idProfessor = Guid.Empty;
            this.SetIdProfessor(IdProfessor);

            codigoUsuario = Guid.NewGuid();
            this.CodigoUsuario = codigoUsuario.ToString().Replace("-", "");
            this.CodigoUsuario = this.CodigoUsuario.Remove(6);
            codigoUsuario = Guid.Empty;
            this.SetCodigoUsuario(CodigoUsuario);
        }

        #endregion

        #region Comportamentos

        private void SetIdProfessor(string IdProfessor)
        {           
            this.IdProfessor = SecureValidationsProfessor.ValidationsIdProfessor(IdProfessor);
        }

        public string GetIdProfessor()
        {
            return this.IdProfessor;
        }

        //_____________________________________________

        private void SetCodigoUsuario(string CodigoUsuario)
        {
            this.CodigoUsuario = SecureValidationsProfessor.ValidationsCodigoUsuario(CodigoUsuario);
        }

        public string GetCodigoUsuario()
        {
            return this.CodigoUsuario;
        }

        //_____________________________________________        

        public void SetNovoCodigoUsuario(string CodigoUsuario)
        {
            this.CodigoUsuario = SecureValidationsProfessor.ValidationsNovoCodigoUsuario(CodigoUsuario);
        }

        public string GetNovoCodigoUsuario()
        {
            return this.CodigoUsuario;
        }

        //_____________________________________________

        public void SetNome(string Nome)
        {
            this.Nome = SecureValidationsProfessor.ValidationsNome(Nome);
        }

        public string GetNome()
        {
            return this.Nome;
        }

        //_____________________________________________

        public void SetSobrenome(string Sobrenome)
        {
            this.Sobrenome = SecureValidationsProfessor.ValidationsSobrenome(Sobrenome);
        }

        public string GetSobrenome()
        {
            return this.Sobrenome;
        }

        //_____________________________________________

        public void SetEmail(string Email)
        {
            this.Email = SecureValidationsProfessor.ValidationsEmail(Email);
        }

        public string GetEmail()
        {
            return this.Email;
        }

        //_____________________________________________

        public void SetTipoUsuario(TipoUsuario TipoUsuario)
        {
            this.TipoUsuario = (TipoUsuario)SecureValidationsProfessor.ValidationsTipoUsuario(Convert.ToInt32(TipoUsuario));
        }

        public TipoUsuario GetTipoUsuario()
        {
            return this.TipoUsuario;
        }

        //_____________________________________________

        public void SetTelefone(Telefone telefone)
        {
            this.Telefone = (Telefone)SecureValidationsProfessor.ValidationsTelefone(telefone.DDD, telefone.Numero);
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
                this.Endereco = (Endereco)SecureValidationsProfessor.ValidationsEndereco(Convert.ToInt16(endereco.Logradouro), endereco.Numero, endereco.Complemento, endereco.CEP, Convert.ToInt16(endereco.Zona));
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
                this.Status = (Status)SecureValidationsProfessor.ValidationsStatus(Convert.ToInt32(status));
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

        public virtual ICollection<ProfessorExemplar> ProfessorExemplar { get; set; } // Professor solicita empréstimo(s) de Exemplar(es).

        #endregion
    }
}