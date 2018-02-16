using BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Livros;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue.Localizacao;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AlunosExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.ProfessoresExemplares;
using System;
using System.Collections.Generic;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares
{
    public class Exemplar : Livro
    {
        #region Variáveis

        Guid idExemplar, codigoExemplar;

        #endregion

        #region Propriedades

        public string IdExemplar { get; private set; }
        public string CodigoExemplar { get; private set; }
        public Localizacao Localizacao { get; private set; }

        //FK...
        public string IdLivros { get; set; }

        #endregion

        #region Construtor

        public Exemplar()
        {
            idExemplar = Guid.NewGuid();
            this.IdExemplar = idExemplar.ToString().Replace("-", "");
            this.IdExemplar = this.IdExemplar.Remove(24);
            idExemplar = Guid.Empty;
            this.SetIdExemplar(IdExemplar);

            codigoExemplar = Guid.NewGuid();
            this.CodigoExemplar = codigoExemplar.ToString().Replace("-", "");
            this.CodigoExemplar = this.CodigoExemplar.Remove(6);
            codigoExemplar = Guid.Empty;
            this.SetCodigoExemplar(CodigoExemplar);
        }

        #endregion

        #region Comportamentos

        private void SetIdExemplar(string IdExemplar)
        {
            this.IdExemplar = SecureValidationsExemplar.ValidationsIdExemplar(IdExemplar);
        }

        public string GetIdExemplar()
        {
            return this.IdExemplar;
        }

        //_____________________________________________

        private void SetCodigoExemplar(string CodigoExemplar)
        {
            this.CodigoExemplar = SecureValidationsExemplar.ValidationsCodigoExemplar(CodigoExemplar);
        }

        public string GetCodigoExemplar()
        {
            return this.CodigoExemplar;
        }

        //_____________________________________________

        public void SetLocalizacao(Localizacao localizacao)
        {
            try
            {
                if (SecureValidationsExemplar.ValidationsLocalizacao(Convert.ToInt16(localizacao.Andar), Convert.ToInt16(localizacao.Sala), Convert.ToInt16(localizacao.Estante)))
                {
                    this.Localizacao = localizacao;
                }
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

        public Localizacao GetLocalizacao()
        {
            return this.Localizacao;
        }

        #endregion

        #region Associações

        public virtual ICollection<AlunoExemplar> AlunoExemplar { get; set; } // Empréstimo de Exemplar(es) é)são solicitado(s) por Aluno(s).
        public virtual ICollection<ProfessorExemplar> ProfessorExemplar { get; set; } // Empréstimo de Exemplar(es) é)são solicitado(s) por Professor(s).
        public virtual ICollection<FuncionarioExemplar> FuncionarioExemplar { get; set; } // Empréstimo de Exemplar(es) é)são solicitado(s) por Funcionários(s).
        public virtual Livro Livro { get; set; } // Exemplares pertencem ao Livro.

        #endregion
    }
}