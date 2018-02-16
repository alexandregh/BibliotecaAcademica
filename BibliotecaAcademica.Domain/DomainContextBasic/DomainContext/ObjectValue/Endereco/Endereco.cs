using BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.Enum;

namespace BibliotecaAcademica.Domain.DomainContextBasic.DomainContext.ObjectValue.Endereco
{
    public class Endereco
    {
        public Logradouro Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public Zonas Zona { get; set; }        
    }
}