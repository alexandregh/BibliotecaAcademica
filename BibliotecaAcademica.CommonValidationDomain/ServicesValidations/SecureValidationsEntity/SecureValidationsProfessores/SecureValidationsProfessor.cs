using BibliotecaAcademica.CommonValidationDomain.MessageValidations.MessageEntity.MessageProfessores;
using System;
using System.Collections;

namespace BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsProfessores
{
    public static class SecureValidationsProfessor
    {
        #region Implementação das Validações do Professor

        public static string ValidationsIdProfessor(string idProfessor)
        {
            int qtdIdProfessor = 0;
            if (!String.IsNullOrEmpty(idProfessor))
            {
                qtdIdProfessor = idProfessor.Length;
            }
            if (qtdIdProfessor == 16)
            {
                return idProfessor;
            }
            else
            {
                throw new Exception(MessageProfessor.IdProfessorIsNullOrEmpty);
            }
        }

        //________________________________________________

        public static string ValidationsCodigoUsuario(string codigoUsuario)
        {
            int qtdCodigoUsuario = 0;
            if (!String.IsNullOrEmpty(codigoUsuario))
            {
                qtdCodigoUsuario = codigoUsuario.Length;
            }
            if (qtdCodigoUsuario == 6)
            {
                return codigoUsuario;
            }
            else
            {
                throw new Exception(MessageProfessor.CodigoUsuarioIsNullOrEmpty);
            }
        }

        //________________________________________________

        public static string ValidationsNovoCodigoUsuario(string codigoUsuario)
        {
            int qtdCodigoUsuario = 0;
            if (!String.IsNullOrEmpty(codigoUsuario))
            {
                qtdCodigoUsuario = codigoUsuario.Length;
            }
            if (qtdCodigoUsuario == 6)
            {
                return codigoUsuario;
            }
            else
            {
                throw new Exception(MessageProfessor.NovoCodigoUsuarioIsNullOrEmpty);
            }
        }

        //________________________________________________

        public static string ValidationsNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception(MessageProfessor.NomeIsNullOrEmpty);
            }
            if (nome.Length < 3 || nome.Length > 25)
            {
                throw new Exception(MessageProfessor.NomeLength);
            }
            else
            {
                return nome;
            }
        }

        //________________________________________________

        public static string ValidationsSobrenome(string sobrenome)
        {
            if (string.IsNullOrEmpty(sobrenome))
            {
                throw new Exception(MessageProfessor.SobrenomeIsNullOrEmpty);
            }
            if (sobrenome.Length < 3 || sobrenome.Length > 50)
            {
                throw new Exception(MessageProfessor.SobrenomeLength);
            }
            else
            {
                return sobrenome;
            }
        }

        //________________________________________________

        public static string ValidationsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception(MessageProfessor.EmailIsNullOrEmpty);
            }
            if (email.Length < 3 || email.Length > 50)
            {
                throw new Exception(MessageProfessor.EmailLength);
            }
            if (!email.Contains("@") && !email.Contains("."))
            {
                throw new Exception(MessageProfessor.EmailContains);
            }
            else
            {
                return email;
            }
        }

        //________________________________________________

        public static int ValidationsTipoUsuario(int tipoUsuario)
        {
            if (string.IsNullOrEmpty(tipoUsuario.ToString()))
            {
                throw new Exception(MessageProfessor.TipoUsuarioIsNullOrEmpty);
            }
            else
            {
                return tipoUsuario;
            }
        }

        //________________________________________________

        public static Object ValidationsTelefone(byte ddd, int numero)
        {
            int qtdDDD = Convert.ToString(ddd).Length;
            int qtdNumero = Convert.ToString(numero).Length;
            if (qtdDDD != 2)
            {
                throw new Exception(MessageProfessor.DDDTelefoneLength);
            }
            if (qtdNumero != 8 || qtdNumero != 9)
            {
                throw new Exception(MessageProfessor.NumeroTelefoneLength);
            }
            else
            {
                ArrayList telefone = new ArrayList();
                telefone.Add(ddd);
                telefone.Add(numero);
                return telefone;
            }
        }

        //________________________________________________

        public static Object ValidationsEndereco(int logradouro, int numero, string complemento, string cep, int zona)
        {
            if (string.IsNullOrEmpty(logradouro.ToString()))
            {
                throw new Exception(MessageProfessor.LogradouroEnderecoIsNullOrEmpty);
            }
            if (string.IsNullOrEmpty(numero.ToString()))
            {
                throw new Exception(MessageProfessor.NumeroEnderecoIsNullOrEmpt);
            }
            if (complemento.Length < 3 && complemento.Length > 250)
            {
                throw new Exception(MessageProfessor.ComplementoEnderecoLength);
            }
            if (string.IsNullOrEmpty(cep))
            {
                throw new Exception(MessageProfessor.CepEnderecoIsNullOrEmpty);
            }
            if (string.IsNullOrEmpty(zona.ToString()))
            {
                throw new Exception(MessageProfessor.ZonaEnderecoIsNullOrEmpty);
            }
            else
            {
                ArrayList endereco = new ArrayList();
                endereco.Add(logradouro);
                endereco.Add(numero);
                endereco.Add(complemento);
                endereco.Add(cep);
                endereco.Add(zona);
                return endereco;
            }
        }

        //________________________________________________

        public static int ValidationsStatus(int statusUsuario)
        {
            if (string.IsNullOrEmpty(statusUsuario.ToString()))
            {
                throw new Exception(MessageProfessor.StatusUsuarioIsNullOrEmpty);
            }
            else
            {
                return statusUsuario;
            }
        }

        #endregion
    }
}