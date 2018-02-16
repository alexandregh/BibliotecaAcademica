using BibliotecaAcademica.CommonValidationDomain.MessageValidations.MessageRelationship.MessageAlunosExemplares;
using System;

namespace BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsRelationship.SecureValidationsAlunosExemplares
{
    public static class SecureValidationsAlunoExemplar
    {
        #region Implementação das Validações do AlunoExemplar
        
        public static DateTime ValidationsDataHoraInicio(DateTime dataHoraInicio)
        {
            if(dataHoraInicio != null)
            {
                return dataHoraInicio;
            }
            else
            {
                throw new Exception(MessageAlunoExemplar.DataHoraInicioIsNullOrEmpty);
            }
        }

        //________________________________________________

        public static DateTime ValidationsDataHoraFim(DateTime dataHoraFim)
        {
            if (dataHoraFim != null)
            {                
                if(dataHoraFim.DayOfWeek != DayOfWeek.Saturday && dataHoraFim.DayOfWeek != DayOfWeek.Sunday)
                {
                    dataHoraFim = dataHoraFim.AddDays(5);
                }
                return dataHoraFim;
            }
            else
            {
                throw new Exception(MessageAlunoExemplar.DataHoraFimIsNullOrEmpty);
            }
        }

        //________________________________________________

        public static byte ValidationsQuantidadeDiasEmprestimo(byte qtdDiasEmprestimo)
        {
            if(qtdDiasEmprestimo != 5)
            {
                throw new Exception(MessageAlunoExemplar.QuantidadeDiasEmprestimo5DiasUteis);
                
            }
            if(string.IsNullOrEmpty(Convert.ToString(qtdDiasEmprestimo)))
            {
                throw new Exception(MessageAlunoExemplar.QuantidadeDiasEmprestimoIsNullOrEmpty);
            }
            else
            {
                return qtdDiasEmprestimo;
            }
        }

        #endregion
    }
}