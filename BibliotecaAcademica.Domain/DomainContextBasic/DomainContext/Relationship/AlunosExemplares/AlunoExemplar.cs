using BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsAlunos;
using BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsExemplares;
using BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsRelationship.SecureValidationsAlunosExemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Alunos;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares;
using System;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.AlunosExemplares
{
    public class AlunoExemplar
    {
        #region Atributos / Associações

        // FK...
        public string IdAluno { get; private set; }
        public string IdExemplar { get; private set; }
        public string CodigoAluno { get; private set; }
        public string CodigoExemplar { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraFim { get; private set; }
        public byte QuantidadeDiasEmprestimo { get; private set; }

        //_________________________________________

        // Navigate...
        public virtual Aluno Aluno { get; set; }
        public virtual Exemplar Exemplar { get; set; }

        #endregion

        #region Construtor

        public AlunoExemplar()
        {
            this.DataHoraInicio = DateTime.Now;
            this.DataHoraFim = DateTime.Now;
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

        //_________________________________________

        private void SetIdExemplar(string IdExemplar)
        {
            this.IdExemplar = SecureValidationsExemplar.ValidationsIdExemplar(IdExemplar);
        }

        public string GetIdExemplar()
        {
            return this.IdExemplar;
        }

        //_________________________________________

        private void SetCodigoUsuario(string CodigoUsuario)
        {
            this.CodigoAluno = SecureValidationsAluno.ValidationsCodigoUsuario(CodigoUsuario);
        }

        public string GetCodigoUsuario()
        {
            return this.CodigoAluno;
        }

        //_________________________________________

        private void SetCodigoExemplar(string CodigoExemplar)
        {
            this.CodigoExemplar = SecureValidationsExemplar.ValidationsCodigoExemplar(CodigoExemplar);
        }

        public string GetCodigoExemplar()
        {
            return this.CodigoExemplar;
        }

        //_________________________________________

        public void SetDataHoraInicio(DateTime dataHoraInicio)
        {
            this.DataHoraInicio = SecureValidationsAlunoExemplar.ValidationsDataHoraInicio(dataHoraInicio);
        }

        public DateTime GetDataHoraInicio()
        {
            return this.DataHoraInicio;
        }

        //_________________________________________

        public void SetDataHoraFim(DateTime dataHoraFim)
        {
            this.DataHoraFim = SecureValidationsAlunoExemplar.ValidationsDataHoraFim(dataHoraFim);
        }

        public DateTime GetDataHoraFim()
        {
            return this.DataHoraFim;
        }

        //_________________________________________

        public void SetQuantidadeDiasEmprestimo(byte qtdDiasEmprestimo)
        {
            this.QuantidadeDiasEmprestimo = SecureValidationsAlunoExemplar.ValidationsQuantidadeDiasEmprestimo(qtdDiasEmprestimo);
        }

        public byte GetQuantidadeDiasEmprestimo()
        {
            return this.QuantidadeDiasEmprestimo;
        }

        #endregion
    }
}