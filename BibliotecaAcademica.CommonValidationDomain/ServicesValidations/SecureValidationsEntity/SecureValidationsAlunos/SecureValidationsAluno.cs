using BibliotecaAcademica.CommonValidationDomain.MessageValidations.MessageEntity.MessageAlunos;
using System;
using System.Collections;

namespace BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsAlunos
{
    public static class SecureValidationsAluno
    {
        #region Implementação das Validações do Aluno

        public static string ValidationsIdAluno(string idAluno)
        {
            int qtdIdAluno = 0;
            if (!String.IsNullOrEmpty(idAluno))
            {
                qtdIdAluno = idAluno.Length;
            }
            if (qtdIdAluno == 16)
            {
                return idAluno;
            }
            else
            {
                throw new Exception(MessageAluno.IdAlunoIsNullOrEmpty);
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
                throw new Exception(MessageAluno.CodigoUsuarioIsNullOrEmpty);
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
                throw new Exception(MessageAluno.NovoCodigoUsuarioIsNullOrEmpty);
            }
        }

        //________________________________________________

        public static string ValidationsNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception(MessageAluno.NomeIsNullOrEmpty);
            }
            if (nome.Length < 3 || nome.Length > 25)
            {
                throw new Exception(MessageAluno.NomeLength);
            }
            else
            {
                return nome;
            }
        }

        //________________________________________________

        public static string ValidationSobrenome(string sobrenome)
        {
            if (string.IsNullOrEmpty(sobrenome))
            {
                throw new Exception(MessageAluno.SobrenomeIsNullOrEmpty);
            }
            if (sobrenome.Length < 3 || sobrenome.Length > 50)
            {
                throw new Exception(MessageAluno.SobrenomeLength);
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
                throw new Exception(MessageAluno.EmailIsNullOrEmpty);
            }
            if (email.Length < 3 || email.Length > 50)
            {
                throw new Exception(MessageAluno.EmailLength);
            }
            if (!email.Contains("@") && !email.Contains("."))
            {
                throw new Exception(MessageAluno.EmailContains);
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
                throw new Exception(MessageAluno.TipoUsuarioIsNullOrEmpty);
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
                throw new Exception(MessageAluno.DDDTelefoneLength);
            }
            if (qtdNumero != 8 || qtdNumero != 9)
            {
                throw new Exception(MessageAluno.NumeroTelefoneLength);
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
                throw new Exception(MessageAluno.LogradouroEnderecoIsNullOrEmpty);
            }            
            if (complemento.Length < 3 && complemento.Length > 250)
            {
                throw new Exception(MessageAluno.ComplementoEnderecoLength);
            }
            if (string.IsNullOrEmpty(cep))
            {
                throw new Exception(MessageAluno.CepEnderecoIsNullOrEmpty);
            }
            if (cep.Length != 10)
            {
                throw new Exception(MessageAluno.CepEnderecoLength);
            }
            if (string.IsNullOrEmpty(zona.ToString()))
            {
                throw new Exception(MessageAluno.ZonaEnderecoIsNullOrEmpty);
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

        public static int ValidationStatus(int status)
        {
            if (string.IsNullOrEmpty(status.ToString()))
            {
                throw new Exception(MessageAluno.StatusIsNullOrEmpty);
            }
            else
            {
                return status;
            }
        }

        #endregion
    }
}