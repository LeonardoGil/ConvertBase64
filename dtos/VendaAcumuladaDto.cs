namespace ConvertBase64.dtos
{
    //Select '+QuotedStr('* CHAVE*')+' as CODIGOVENDAACUMULADA, fv.NUMEROVENDA, '+
    //cast(substr(cast(v.DATAEMISSAOVENDA as character varying) ,1,10) as varchar(10)), cast(vi.codigovisitador as integer), '+
    //cast('+QuotedStr('CR')+'||TRIM(m.TIPOCRMEDICO)||TRIM(m.SIGLAESTADOCRMMEDICO)||TRIM(m.CRMMEDICO) as VARCHAR(20)) AS idSyncCliente, '+
    //cast(sum(FV.QUANTIDADEVEZESFORMULA) as integer) as QtdadeFormula, cast(round(SUM(fv.VALORLIQUIDOVENDAFORMULA),2) as varchar(40)) as ValorTotal '+
    //from formulavenda fv '+
    //join VISITADOR vi on vi.codigovisitador = fv.codigovisitador '+
    //join VENDA v on v.NUMEROVENDA=fv.NUMEROVENDA AND V.ORCAMENTOVENDA=0 '+
    //join MEDICO m on m.CODIGOMEDICO=fv.CODIGOMEDICO and((NOT TIPOCRMEDICO IS NULL) AND(NOT SIGLAESTADOCRMMEDICO IS NULL) AND(NOT CRMMEDICO IS NULL) AND(not m.codigovisitador is null))'+
    //where(not fv.codigomedico is null) '+
    //AND V.statusvenda = 1 '+
    //AND fv.statusformula = 1 '+
    //AND V.DATAEMISSAOVENDA >= current_timestamp - interval ''1 year'''+
    //GROUP BY 1,2,3,4,5 '+
    //union all '+
    //Select '+QuotedStr('*CHAVE*')+' as CODIGOVENDAACUMULADA, IV.NUMEROVENDA, '+
    //cast(substr(cast(V.DATAEMISSAOVENDA as character varying),1,10) as varchar(10)), cast(vi.codigovisitador as integer), '+
    //cast('+QuotedStr('CR')+'||TRIM(m.TIPOCRMEDICO)||TRIM(m.SIGLAESTADOCRMMEDICO)||TRIM(m.CRMMEDICO) as VARCHAR(20)) AS idSyncCliente, '+
    //cast(sum(IV.QUANTIDADEITEMVENDA) as integer) as QtdadeFormula, cast(round(SUM(IV.VALORLIQUIDOVENDAITEM),2) as varchar(40)) as ValorTotal '+
    //from ITEMVENDA IV '+
    //join VISITADOR vi on vi.codigovisitador = IV.codigovisitador '+
    //join VENDA V on V.NUMEROVENDA=IV.NUMEROVENDA AND V.ORCAMENTOVENDA=0 '+
    //join MEDICO m on m.CODIGOMEDICO=IV.CODIGOMEDICO and((NOT TIPOCRMEDICO IS NULL) AND(NOT SIGLAESTADOCRMMEDICO IS NULL) AND(NOT CRMMEDICO IS NULL) AND(not m.codigovisitador is null)) '+
    //where(not IV.codigomedico is null) '+
    //AND V.statusvenda = 1 '+
    //AND V.DATAEMISSAOVENDA >= current_timestamp - interval ''1 year'''+                  
    //GROUP BY 1,2,3,4,5 '

    public class VendaAcumuladaDto : BaseDto
    {

    }
}
