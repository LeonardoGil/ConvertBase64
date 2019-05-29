using System;

namespace ConvertBase64.dtos
{
    // SELECT cast(cast(convenio.codigoconvenio as integer) as varchar(20)) AS idSyncCliente, 
    // convenio.nomeconvenio as  NomeMedico,
    // convenio.enderecoconvenio as EnderecoMedico,
    // convenio.numeroenderecoconvenio as  NumeroEnderecoMedico,
    // convenio.complementoconvenio as ComplementoMedico,
    // Cast(null as varchar(20)) as ProximidadeMedico,
    // convenio.cepconvenio as CepMedico,                      
    // convenio.dddconvenio as DddTelefoneMedico,              
    // convenio.telefoneconvenio as TelefoneMedico,          
    // convenio.dddconvenio as DddCelularMedico,                
    // convenio.telefoneconvenio as CelularMedico,                
    // convenio.codigocidade as CodigoCidade,                     
    // convenio.codigobairro as CodigoBairro,                     
    // convenio.siglaestado,                                      
    // cast(null as varchar(20)) as EnderecoResidencialMedico,    
    // cast(null as varchar(7)) as NumeroEnderecoResidencial,     
    // cast(null as varchar(10)) as CepResidencialMedico,         
    // cast(null as varchar(3)) as DddResidencialMedico,          
    // cast(null as varchar(10)) as TelefoneResidencialMedico,    
    // cast(null as varchar(20))  as  EmailMedico,                
    // cast(null as varchar(10)) as DataAniversarioMedico,        
    // cast(null as varchar(20)) as SecretariaMedico,             
    // cast(convenio.codigovisitador as integer),                 
    // cast(null as varchar(30)) as NOMEROTULOMEDICO              
    // FROM CONVENIO

    public class ClienteDto : BaseDto
    {
        public string NomeMedico { get; set; }
        public string EnderecoMedico { get; set; }
        public int NumeroEnderecoMedico { get; set; }
        public string ComplementoMedico { get; set; }
        public string ProximidadeMedico { get; set; }
        public string CepMedico { get; set; }
        public int DddTelefoneMedico { get; set; }
        public string TelefoneMedico { get; set; }
        public int DddCelularMedico { get; set; }
        public string CelularMedico { get; set; }
        public int CodigoCidade { get; set; }
        public int CodigoBairro { get; set; }
        public string SiglaEstado { get; set; }
        public string EnderecoResidencialMedico { get; set; }
        public int NumeroEnderecoResidencial { get; set; }
        public string CepResidencialMedico { get; set; }
        public int DddResidencialMedico { get; set; }
        public string TelefoneResidencialMedico { get; set; }
        public string EmailMedico { get; set; }
        public DateTime DataAniversarioMedico { get; set; }
        public string SecretariaMedico { get; set; }
        public int CodigoVisitador { get; set; }
        public string NomeRotuloMedico { get; set; }
    }
}
