using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Exemplares;
using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Entity.Concretes.Funcionarios;
using System;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Relationship.FuncionariosExemplares
{
    public class FuncionarioExemplar
    {
        #region Atributos / Associações

        // FK...
        public string IdFuncionario { get; private set; }
        public string IdExemplar { get; private set; }
        public string CodigoFuncionario { get; private set; }
        public string CodigoExemplar { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraFim { get; private set; }
        public byte QuantidadeDiasEmprestimo { get; private set; }

        //_________________________________________

        // Navigate...
        public virtual Funcionario Funcionario { get; set; }
        public virtual Exemplar Exemplar { get; set; }

        #endregion

        #region Construtor

        public FuncionarioExemplar()
        {
            this.DataHoraInicio = DateTime.Now;
        }

        #endregion

        #region Comportamentos



        #endregion
    }
}