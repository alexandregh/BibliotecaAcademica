using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Professores;
using System;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.ProfessoresExemplares
{
    public class ProfessorExemplar
    {
        #region Atributos / Associações

        // FK...
        public string IdProfessor { get; private set; }
        public string IdExemplar { get; private set; }
        public string CodigoProfessor { get; private set; }
        public string CodigoExemplar { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraFim { get; private set; }
        public byte QuantidadeDiasEmprestimo { get; private set; }

        //_________________________________________

        // Navigate...
        public virtual Professor Professor { get; set; }
        public virtual Exemplar Exemplar { get; set; }

        #endregion

        #region Construtor

        public ProfessorExemplar()
        {
            this.DataHoraInicio = DateTime.Now;
            this.DataHoraFim = DateTime.Now;
        }

        #endregion

        #region Comportamentos



        #endregion
    }
}