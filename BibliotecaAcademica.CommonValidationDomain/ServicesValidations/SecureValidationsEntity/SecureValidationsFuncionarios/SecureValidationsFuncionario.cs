using BibliotecaAcademica.CommonValidationDomain.MessageValidations.MessageEntity.MessageFuncionarios;
using System;
using System.Collections;

namespace BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsFuncionarios
{
    public static class SecureValidationsFuncionario
    {
        #region Implementação das Validações do Funcionário

        public static string ValidationsIdFuncionario(string idFuncionario)
        {
            int qtdIdFuncionario = 0;
            if (!String.IsNullOrEmpty(idFuncionario))
            {
                qtdIdFuncionario = idFuncionario.Length;
            }
            if (qtdIdFuncionario == 16)
            {
                return idFuncionario;
            }
            else
            {
                throw new Exception(MessageFuncionario.IdFuncionarioLength);
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
                throw new Exception(MessageFuncionario.CodigoUsuarioLength);
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
                throw new Exception(MessageFuncionario.NovoCodigoUsuarioIsNullOrEmptyIsNullOrEmpty);
            }
        }

        //________________________________________________

        public static string ValidationsNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception(MessageFuncionario.NomeIsNullOrEmpty);
            }
            if (nome.Length < 3 || nome.Length > 25)
            {
                throw new Exception(MessageFuncionario.NomeLength);
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
                throw new Exception(MessageFuncionario.SobrenomeIsNullOrEmpty);
            }
            if (sobrenome.Length < 3 || sobrenome.Length > 50)
            {
                throw new Exception(MessageFuncionario.SobrenomeLength);
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
                throw new Exception(MessageFuncionario.EmailIsNullOrEmpty);
            }
            if (email.Length < 3 || email.Length > 50)
            {
                throw new Exception(MessageFuncionario.EmailLength);
            }
            if (!email.Contains("@") && !email.Contains("."))
            {
                throw new Exception(MessageFuncionario.EmailContains);
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
                throw new Exception(MessageFuncionario.TipoUsuarioIsNullOrEmpty);
            }
            else
            {
                return tipoUsuario;
            }
        }

        //________________________________________________

        public static int ValidationsTipoFuncionario(int tipoFuncionario)
        {
            if (string.IsNullOrEmpty(tipoFuncionario.ToString()))
            {
                throw new Exception(MessageFuncionario.TipoFuncionarioIsNullOrEmpty);
            }
            else
            {
                return tipoFuncionario;
            }
        }

        //________________________________________________

        public static Object ValidationsTelefone(byte ddd, int numero)
        {
            int qtdDDD = Convert.ToString(ddd).Length;
            int qtdNumero = Convert.ToString(numero).Length;
            if (qtdDDD != 2)
            {
                throw new Exception(MessageFuncionario.DDDTelefoneLength);
            }
            if (qtdNumero != 8 || qtdNumero != 9)
            {
                throw new Exception(MessageFuncionario.NumeroTelefoneLength);
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
                throw new Exception(MessageFuncionario.LogradouroEnderecoIsNullOrEmpty);
            }
            if (string.IsNullOrEmpty(numero.ToString()))
            {
                throw new Exception(MessageFuncionario.NumeroEnderecoIsNullOrEmpt);
            }
            if (complemento.Length < 3 && complemento.Length > 250)
            {
                throw new Exception(MessageFuncionario.ComplementoEnderecoLength);
            }
            if (string.IsNullOrEmpty(cep))
            {
                throw new Exception(MessageFuncionario.CepEnderecoIsNullOrEmpty);
            }
            if (string.IsNullOrEmpty(zona.ToString()))
            {
                throw new Exception(MessageFuncionario.ZonaEnderecoIsNullOrEmpty);
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

        #endregion
    }
}