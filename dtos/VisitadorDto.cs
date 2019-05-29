namespace ConvertBase64.dtos
{

    // SELECT CODIGOVISITADOR, NOMEVISITADOR, COMISSAOVISITADOR, ENDERECOVISITADOR, NUMEROENDERECO, COMPLEMENTOVISITADOR, CEPVISITADOR, 
    // DDDVISITADOR, TELEFONEVISITADOR, CELULARVISITADOR, CODIGOCIDADE, CODIGOBAIRRO, SIGLAESTADO FROM VISITADOR;

    public class VisitadorDto : BaseDto
    {
        public string NomeVisitador { get; set; }
        public long ComissaoVisitador { get; set; }
        public string EnderecoVisitador { get; set; }
        public int NumeroEndereco { get; set; }
        public string ComplementoVisitador { get; set; }
        public string CepVisitador { get; set; }
        public int DDDVisitador { get; set; }
        public string TelefoneVisitador { get; set; }
        public string CelularVisitador { get; set; }
        public int CodigoCidade { get; set; }
        public int CodigoBairro { get; set; }
        public string SiglaEstado { get; set; }
    }
}

