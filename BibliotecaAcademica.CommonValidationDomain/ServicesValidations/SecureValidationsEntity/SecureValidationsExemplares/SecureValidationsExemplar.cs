using System;

namespace BibliotecaAcademica.CommonValidationDomain.ServicesValidations.SecureValidationsEntity.SecureValidationsExemplares
{
    public static class SecureValidationsExemplar
    {
        #region Implementação das Validações do Exemplar

        public static string ValidationsIdExemplar(string idExemplar)
        {
            int qtdIdExemplar = 0;
            if (!String.IsNullOrEmpty(idExemplar))
            {
                qtdIdExemplar = idExemplar.Length;
            }
            if (qtdIdExemplar == 24)
            {
                return idExemplar;
            }
            else
            {
                throw new Exception("Ocorreu um erro ao gerar o campo Id do Exemplar do Livro. Tente outra vez.");
            }
        }

        //________________________________________________

        public static string ValidationsCodigoExemplar(string codigoExemplar)
        {
            int qtdCodigoExemplar = 0;
            if (!String.IsNullOrEmpty(codigoExemplar))
            {
                qtdCodigoExemplar = codigoExemplar.Length;
            }
            if (qtdCodigoExemplar == 6)
            {
                return codigoExemplar;
            }
            else
            {
                throw new Exception("Ocorreu um erro ao gerar o campo Código do Exemplar do Livro. Tente outra vez.");
            }
        }

        //________________________________________________

        public static bool ValidationsLocalizacao(int andar, int sala, int estante)
        {
            int qtdAndar = andar.ToString().Length;
            int qtdSala = sala.ToString().Length;
            int qtdEstante = estante.ToString().Length;

            if (string.IsNullOrEmpty(andar.ToString()))
            {
                throw new Exception("Campo Localização do Andar obrigatório.");
            }
            if (string.IsNullOrEmpty(sala.ToString()))
            {
                throw new Exception("Campo Localização da Sala obrigatório.");
            }
            if (string.IsNullOrEmpty(estante.ToString()))
            {
                throw new Exception("Campo Localização da Estante obrigatório.");
            }
            if (qtdAndar != 1)
            {
                throw new Exception("Campo Localização do Andar deverá conter apenas 1 caracter.");
            }
            if (qtdSala != 3)
            {
                throw new Exception("Campo Localização da Sala deverá conter apenas 3 caracteres.");
            }
            if (qtdEstante != 3)
            {
                throw new Exception("Campo Localização da Estante deverá conter apenas 3 caracteres.");
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}